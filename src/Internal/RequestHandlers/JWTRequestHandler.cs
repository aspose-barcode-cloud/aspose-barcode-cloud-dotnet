using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Newtonsoft.Json;

namespace Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers
{
    internal class JwtRequestHandler : IRequestHandler
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;

        private string _accessToken;

        public JwtRequestHandler(Configuration configuration)
        {
            _configuration = configuration;

            var requestHandlers = new List<IRequestHandler>
            {
                new DebugLogRequestHandler(_configuration),
                new ApiExceptionRequestHandler()
            };
            _apiInvoker = new ApiInvoker(configuration, requestHandlers);
        }

        public string ProcessUrl(string url)
        {
            if (_configuration.AuthType != AuthType.JWT)
            {
                return url;
            }

            if (string.IsNullOrEmpty(_accessToken))
            {
                RequestToken();
            }

            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            if (_configuration.AuthType != AuthType.JWT)
            {
                return;
            }

            request.Headers.Add("Authorization", "Bearer " + _accessToken);
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (_configuration.AuthType != AuthType.JWT)
            {
                return;
            }

            if (response.StatusCode == HttpStatusCode.Unauthorized)
            {
                RefreshToken();

                throw new NeedRepeatRequestException();
            }
        }

        private void RequestToken()
        {
            var postData = "grant_type=client_credentials";

            if (string.IsNullOrEmpty(_configuration.ClientId))
            {
                throw new ApiException(403,
                    "Missing required parameter 'ClientId'");
            }
            postData += "&client_id=" + _configuration.ClientId;

            if (string.IsNullOrEmpty(_configuration.ClientSecret))
            {
                throw new ApiException(403,
                    "Missing required parameter 'ClientSecret'");
            }
            postData += "&client_secret=" + _configuration.ClientSecret;

            string responseString = _apiInvoker.InvokeApi(
                _configuration.TokenUrl,
                "POST",
                "application/x-www-form-urlencoded",
                postData);

            var result = (GetAccessTokenResult)
                SerializationHelper.Deserialize(responseString, typeof(GetAccessTokenResult));

            _accessToken = result.AccessToken;
        }

        private void RefreshToken()
        {
            // Request new token instead of refresh for JWT
            RequestToken();
        }

        private class GetAccessTokenResult
        {
            [JsonProperty(PropertyName = "access_token")]
            public string AccessToken { get; set; }

            [JsonProperty(PropertyName = "expires_in")]
            public long ExpiresIn { get; set; }

            [JsonProperty(PropertyName = "token_type")]
            public string TokenType { get; set; }
        }
    }
}
