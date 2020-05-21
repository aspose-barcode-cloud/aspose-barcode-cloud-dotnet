// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="JWTRequestHandler.cs">
//   Copyright (c) 2020 Aspose.BarCode for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

using System.Collections.Generic;
using System.IO;
using System.Net;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Newtonsoft.Json;

namespace Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers
{
    internal class JwtRequestHandler : IRequestHandler
    {
        private readonly Configuration _configuration;
        private readonly ApiInvoker _apiInvoker;

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
            var requestUrl = _configuration.ApiBaseUrl + "/connect/token";

            var postData = "grant_type=client_credentials";
            postData += "&client_id=" + _configuration.AppSid;
            postData += "&client_secret=" + _configuration.AppKey;

            var responseString = _apiInvoker.InvokeApi(
                requestUrl,
                "POST",
                postData,
                contentType: "application/x-www-form-urlencoded");

            var result =
                (GetAccessTokenResult)SerializationHelper.Deserialize(responseString, typeof(GetAccessTokenResult));

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
