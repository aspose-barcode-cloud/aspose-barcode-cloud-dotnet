// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="DebugLogRequestHandler.cs">
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

using System.Collections.Specialized;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
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

        public string ProcessUrl(string url)
        {
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
            if (_configuration.DebugMode) LogRequest(request, streamToSend);
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
            var header = $"\r\nResponse {(int) response.StatusCode}: {response.StatusCode}";
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

        private static void Log(string header, StringBuilder sb)
        {
            Trace.WriteLine(header);
            Trace.WriteLine(sb.ToString());
        }
    }
}
