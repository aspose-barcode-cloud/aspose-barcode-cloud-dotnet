using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;

namespace Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers
{
    internal class DebugLogRequestHandler : IRequestHandler
    {
        private readonly Configuration _configuration;

        public DebugLogRequestHandler(Configuration configuration)
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
            if (_configuration.DebugMode)
            {
                LogRequest(request, streamToSend);
            }
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (_configuration.DebugMode)
            {
                resultStream.Position = 0;
                LogResponse(response, resultStream);
            }
        }

        private void LogRequest(WebRequest request, Stream streamToSend)
        {
            var header = $"{request.Method}: {request.RequestUri}";
            var sb = new StringBuilder();

            FormatHeaders(sb, request.Headers);
            if (streamToSend != null)
            {
                streamToSend.Position = 0;
                StreamHelper.CopyStreamToStringBuilder(sb, streamToSend);
                streamToSend.Position = 0;
            }

            Log(header, sb);
        }

        private static void LogResponse(HttpWebResponse response, Stream resultStream)
        {
            var header = $"\r\nResponse {(int)response.StatusCode}: {response.StatusCode}";
            var sb = new StringBuilder();

            FormatHeaders(sb, response.Headers);
            StreamHelper.CopyStreamToStringBuilder(sb, resultStream);
            Log(header, sb);
        }

        private static void FormatHeaders(StringBuilder sb, NameValueCollection headerDictionary)
        {
            foreach (var key in headerDictionary.AllKeys)
            {
                sb.Append(key);
                sb.Append(": ");
                sb.AppendLine(headerDictionary[key]);
            }
        }

        private static void FormatHeaders(StringBuilder sb, HttpHeaders headers)
        {
            foreach (var header in headers)
            {
                sb.Append(header.Key);
                sb.Append(": ");
                sb.AppendLine(string.Join(" ", header.Value));
            }
        }

        private static void Log(string header, StringBuilder sb)
        {
            Trace.WriteLine(header);
            Trace.WriteLine(sb.ToString());
        }

        public async Task BeforeSendAsync(HttpRequestMessage request)
        {
            if (_configuration.DebugMode)
            {
                await LogRequestAsync(request);
            }
        }

        public async Task ProcessResponseAsync(HttpResponseMessage response)
        {
            if (_configuration.DebugMode)
            {
                await LogResponseAsync(response);
            }
        }

        private async Task LogRequestAsync(HttpRequestMessage request)
        {
            var header = $"{request.Method}: {request.RequestUri}";
            var sb = new StringBuilder();

            FormatHeaders(sb, request.Headers);
            string content = await request.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(content))
            {
                sb.AppendLine("Body:");
                sb.AppendLine(content);
            }

            Log(header, sb);
        }

        private async Task LogResponseAsync(HttpResponseMessage response)
        {
            var header = $"\r\nResponse {(int)response.StatusCode}: {response.StatusCode}";
            var sb = new StringBuilder();

            FormatHeaders(sb, response.Headers);
            string content = await response.Content.ReadAsStringAsync();
            if (!string.IsNullOrEmpty(content))
            {
                sb.AppendLine("Body:");
                sb.AppendLine(content);
            }
            Log(header, sb);
        }
    }
}
