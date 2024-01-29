using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;

namespace Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers
{
    internal class ExternalAuthorizationRequestHandler : IRequestHandler
    {
        private readonly Configuration _configuration;

        public ExternalAuthorizationRequestHandler(Configuration configuration)
        {
            _configuration = configuration;
        }

        public void Preparing()
        {

        }

        public Task PreparingAsync()
        {
            return Task.CompletedTask;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            if (_configuration.AuthType == AuthType.ExternalAuth && string.IsNullOrEmpty(_configuration.JwtToken))
            {
                throw new ApiException(401, "Authorization header value required");
            }

            request.Headers.Add("Authorization", "Bearer " + _configuration.JwtToken);
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
        }

        public Task BeforeSendAsync(HttpRequestMessage request)
        {
            if (_configuration.AuthType == AuthType.ExternalAuth && string.IsNullOrEmpty(_configuration.JwtToken))
            {
                throw new ApiException(401, "Authorization header value required");
            }

            request.Headers.Add("Authorization", "Bearer " + _configuration.JwtToken);

            return Task.CompletedTask;
        }

        public Task ProcessResponseAsync(HttpResponseMessage response)
        {
            return Task.CompletedTask;
        }
    }
}
