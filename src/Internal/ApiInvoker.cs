using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using System.Linq;

namespace Aspose.BarCode.Cloud.Sdk.Internal
{
    internal class ApiInvoker
    {
        private const string ASPOSE_CLIENT_HEADER_NAME = "x-aspose-client";
        private const string ASPOSE_CLIENT_VERSION_HEADER_NAME = "x-aspose-client-version";
        private readonly Dictionary<string, string> _defaultHeaderMap = new Dictionary<string, string>();
        private readonly List<IRequestHandler> _requestHandlers;

        public ApiInvoker(Configuration configuration, List<IRequestHandler> requestHandlers)
        {
            Dictionary<string, string> headers = configuration.DefaultHeaders;
            if (headers != null)
            {
                foreach (KeyValuePair<string, string> header in headers)
                {
                    AddDefaultHeader(header.Key, header.Value);
                }
            }

            Version sdkVersion = GetType().Assembly.GetName().Version;
            AddDefaultHeader(ASPOSE_CLIENT_HEADER_NAME, ".net sdk");
            AddDefaultHeader(ASPOSE_CLIENT_VERSION_HEADER_NAME, $"{sdkVersion.Major}.{sdkVersion.Minor}");
            _requestHandlers = requestHandlers;
        }

        public string InvokeApi(
            string path,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams,
            string contentType = "application/json")
        {
            return InvokeInternal(path, method, false, body, headerParams, formParams, contentType) as string;
        }

        private static byte[] GetMultipartFormData(Dictionary<string, object> postParameters, string boundary)
        {
            // TODO: stream is not disposed
            MemoryStream formDataStream = new MemoryStream();
            var needsCrlf = false;

            if (postParameters.Count > 0)
            {
                foreach (KeyValuePair<string, object> param in postParameters)
                {
                    // Thanks to feedback from commenters, add a CRLF to allow multiple parameters to be added.
                    // Skip it on the first parameter, add it to subsequent parameters.
                    if (needsCrlf)
                    {
                        formDataStream.Write(Encoding.UTF8.GetBytes("\r\n"), 0, Encoding.UTF8.GetByteCount("\r\n"));
                    }

                    needsCrlf = true;

                    if (param.Value is FileInfo fileInfo)
                    {
                        string postData =
                            $"--{boundary}\r\n" +
                            $"Content-Disposition: form-data;" +
                            $" name=\"{param.Key}\";" +
                            $" filename=\"{fileInfo.Name}\"\r\n" +
                            $"Content-Type: {fileInfo.MimeType}\r\n\r\n";
                        formDataStream.Write(Encoding.UTF8.GetBytes(postData), 0, Encoding.UTF8.GetByteCount(postData));

                        // Write the file data directly to the Stream, rather than serializing it to a string.
                        formDataStream.Write(fileInfo.FileContent, 0, fileInfo.FileContent.Length);
                    }
                    else
                    {
                        throw new ApiException(500, $"Unsupported type of parameter '{param.Key}'");
                    }
                }

                // Add the end of the request.  Start with a newline
                string footer = $"\r\n--{boundary}--\r\n";
                formDataStream.Write(Encoding.UTF8.GetBytes(footer), 0, Encoding.UTF8.GetByteCount(footer));
            }

            // Dump the Stream into a byte[]
            formDataStream.Position = 0;
            var formData = new byte[formDataStream.Length];
            int _ = formDataStream.Read(formData, 0, formData.Length);
            formDataStream.Close();

            return formData;
        }

        private void AddDefaultHeader(string key, string value)
        {
            if (!_defaultHeaderMap.ContainsKey(key))
            {
                _defaultHeaderMap.Add(key, value);
            }
        }

        private object InvokeInternal(
            string path,
            string method,
            bool binaryResponse,
            string body,
            Dictionary<string, string> headerParams,
            Dictionary<string, object> formParams,
            string contentType)
        {
            if (formParams == null)
            {
                formParams = new Dictionary<string, object>();
            }

            if (headerParams == null)
            {
                headerParams = new Dictionary<string, string>();
            }

            _requestHandlers.ForEach(p => p.Preparing());

            WebRequest request;
            try
            {
                request = PrepareRequest(path, method, formParams, headerParams, body, contentType);
                return ReadResponse(request, binaryResponse);
            }
            catch (NeedRepeatRequestException)
            {
                request = PrepareRequest(path, method, formParams, headerParams, body, contentType);
                return ReadResponse(request, binaryResponse);
            }
        }

        private WebRequest PrepareRequest(string path, string method, Dictionary<string, object> formParams,
            Dictionary<string, string> headerParams, string body, string contentType)
        {
            var request = WebRequest.Create(path);
            request.Method = method;

            byte[] formData = null;
            if (formParams.Count > 0)
            {

                var formDataBoundary = Guid.NewGuid().ToString();
                request.ContentType = "multipart/form-data; boundary=" + formDataBoundary;
                formData = GetMultipartFormData(formParams, formDataBoundary);

                request.ContentLength = formData.Length;
            }
            else
            {
                request.ContentType = contentType;
            }

            foreach (KeyValuePair<string, string> headerParamsItem in headerParams)
            {
                request.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
            }

            foreach (KeyValuePair<string, string> defaultHeaderMapItem in _defaultHeaderMap)
            {
                if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                {
                    request.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);
                }
            }

            MemoryStream streamToSend = null;
            try
            {
                switch (method)
                {
                    case "GET":
                        break;
                    case "POST":
                    case "PUT":
                    case "DELETE":
                        streamToSend = new MemoryStream();

                        if (formData != null)
                        {
                            streamToSend.Write(formData, 0, formData.Length);
                        }

                        if (body != null)
                        {
                            var requestWriter = new StreamWriter(streamToSend);
                            requestWriter.Write(body);
                            requestWriter.Flush();
                        }

                        break;
                    default:
                        throw new ApiException(500, "unknown method type " + method);
                }

                _requestHandlers.ForEach(p => p.BeforeSend(request, streamToSend));

                if (streamToSend != null)
                {
                    using (Stream requestStream = request.GetRequestStream())
                    {
                        StreamHelper.CopyTo(streamToSend, requestStream);
                    }
                }
            }
            finally
            {
                streamToSend?.Dispose();
            }

            return request;
        }

        private object ReadResponse(WebRequest client, bool binaryResponse)
        {
            var webResponse = (HttpWebResponse)GetResponse(client);
            var resultStream = new MemoryStream();

            StreamHelper.CopyTo(webResponse.GetResponseStream(), resultStream);
            try
            {
                _requestHandlers.ForEach(p => p.ProcessResponse(webResponse, resultStream));

                resultStream.Position = 0;
                if (binaryResponse)
                {
                    return resultStream;
                }

                using (var responseReader = new StreamReader(resultStream))
                {
                    string responseData = responseReader.ReadToEnd();
                    resultStream.Dispose();
                    return responseData;
                }
            }
            catch (Exception)
            {
                resultStream.Dispose();
                throw;
            }
        }

        private static WebResponse GetResponse(WebRequest request)
        {
            try
            {
                return request.GetResponse();
            }
            catch (WebException wex)
            {
                if (wex.Response != null)
                {
                    return wex.Response;
                }

                throw;
            }
        }

        public async Task<Stream> InvokeBinaryApiAsync(string path,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            MultipartFormDataContent formParams,
            string contentType = "application/json")
        {
            var responseStream = await InvokeInternalAsync(path, method, true, body, headerParams, formParams, contentType)
                    as Stream;
            return responseStream;
        }

        public async Task<string> InvokeApiAsync(string path,
            string method,
            string body,
            Dictionary<string, string> headerParams,
            MultipartFormDataContent formParams,
            string contentType = "application/json")
        {
            var response = await InvokeInternalAsync(path, method, false, body, headerParams, formParams, contentType) as string;
            return response;
        }

        private async Task<object> InvokeInternalAsync(string path,
            string method,
            bool binaryResponse,
            string body,
            Dictionary<string, string> headerParams,
            MultipartFormDataContent formParams,
            string contentType)
        {
            if (headerParams == null)
            {
                headerParams = new Dictionary<string, string>();
            }
            await Task.WhenAll(_requestHandlers.Select(p => p.PreparingAsync()).ToArray());

            using (var client = new HttpClient())
            {
                using (var request = new HttpRequestMessage(new HttpMethod(method), path))
                {
                    if (!(formParams is null))
                    {
                        request.Content = formParams;
                    }
                    else if (body != null)
                    {
                        request.Content = new StringContent(body, Encoding.UTF8, contentType);
                    }

                    foreach (KeyValuePair<string, string> headerParamsItem in headerParams)
                    {
                        request.Headers.Add(headerParamsItem.Key, headerParamsItem.Value);
                    }

                    foreach (KeyValuePair<string, string> defaultHeaderMapItem in _defaultHeaderMap)
                    {
                        if (!headerParams.ContainsKey(defaultHeaderMapItem.Key))
                        {
                            request.Headers.Add(defaultHeaderMapItem.Key, defaultHeaderMapItem.Value);
                        }
                    }

                    await Task.WhenAll(_requestHandlers.Select(p => p.BeforeSendAsync(request)).ToArray());

                    using (HttpResponseMessage response = await client.SendAsync(request))
                    {
                        await Task.WhenAll(_requestHandlers.Select(p => p.ProcessResponseAsync(response)).ToArray());

                        if (response.Content != null)
                        {
                            if (binaryResponse)
                            {
                                MemoryStream resultStream = new MemoryStream();
                                await response.Content.CopyToAsync(resultStream);
                                resultStream.Position = 0;
                                return resultStream;
                            }
                            else
                            {
                                return await response.Content.ReadAsStringAsync();
                            }
                        }
                    }
                }
            }

            return null;
        }


    }
}
