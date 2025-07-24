// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RecognizeApi.cs">
//   Copyright (c) 2025 Aspose.BarCode for Cloud
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
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers;
using Aspose.BarCode.Cloud.Sdk.Model;


namespace Aspose.BarCode.Cloud.Sdk.Api
{
    /// <summary>
    ///     RecognizeApi
    /// </summary>
    public class RecognizeApi : IRecognizeApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="RecognizeApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public RecognizeApi(Configuration configuration)
        {
            _configuration = configuration;

            List<IRequestHandler> requestHandlers = new List<IRequestHandler>();
            switch (_configuration.AuthType)
            {
                case AuthType.JWT:
                    requestHandlers.Add(new JwtRequestHandler(_configuration));
                    break;
                case AuthType.ExternalAuth:
                    requestHandlers.Add(new ExternalAuthorizationRequestHandler(_configuration));
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException($"Unknown AuthType={_configuration.AuthType}.");
            }

            requestHandlers.Add(new DebugLogRequestHandler(_configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            _apiInvoker = new ApiInvoker(configuration, requestHandlers);
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="RecognizeApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public RecognizeApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }
        /// <summary>
        /// Recognize barcode from file on server in the Internet using GET requests with parameter in query string. For recognizing files from your hard drive use &#x60;recognize-body&#x60; or &#x60;recognize-multipart&#x60; endpoints instead.
        /// </summary>
        /// <param name="barcodeType">Type of barcode to recognize</param>
        /// <param name="fileUrl">Url to barcode image</param>
        /// <param name="recognitionMode">Recognition mode (optional)</param>
        /// <param name="recognitionImageKind">Image kind for recognition (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> RecognizeAsync(DecodeBarcodeType barcodeType, string fileUrl, RecognitionMode? recognitionMode = default, RecognitionImageKind? recognitionImageKind = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'fileUrl' is set
            if (fileUrl == null)
            {
                throw new ApiException(400, "Missing required parameter 'fileUrl' when calling Recognize");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/recognize";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barcodeType", barcodeType);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileUrl", fileUrl);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recognitionMode", recognitionMode);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recognitionImageKind", recognitionImageKind);
#pragma warning restore CS0618 // Type or member is obsolete


            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "GET",
                           null,
                           null,
                           null);

            return response != null ? (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList)) : null;


        }
        /// <summary>
        /// Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
        /// </summary>
        /// <param name="recognizeBase64Request">Barcode recognition request</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> RecognizeBase64Async(RecognizeBase64Request recognizeBase64Request, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'recognizeBase64Request' is set
            if (recognizeBase64Request == null)
            {
                throw new ApiException(400, "Missing required parameter 'recognizeBase64Request' when calling RecognizeBase64");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/recognize-body";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            string postBody = SerializationHelper.Serialize(recognizeBase64Request); // http body (model) parameter

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "POST",
                           postBody,
                           null,
                           null);

            return response != null ? (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList)) : null;


        }
        /// <summary>
        /// Recognize barcode from file in request body using POST requests with parameters in multipart form.
        /// </summary>
        /// <param name="barcodeType"></param>
        /// <param name="file">Barcode image file</param>
        /// <param name="recognitionMode"> (optional)</param>
        /// <param name="recognitionImageKind"> (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> RecognizeMultipartAsync(DecodeBarcodeType barcodeType, System.IO.Stream file, RecognitionMode? recognitionMode = default, RecognitionImageKind? recognitionImageKind = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'file' is set
            if (file == null)
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling RecognizeMultipart");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/recognize-multipart";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            MultipartFormDataContent multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new StringContent($"{barcodeType}"), "barcodeType");


            if (file != null)
            {

                multipartContent.Add(new StreamContent(file), "file", "file.png");

            }

            if (recognitionMode != null)
            {
                multipartContent.Add(new StringContent($"{recognitionMode}"), "recognitionMode");
            }

            if (recognitionImageKind != null)
            {
                multipartContent.Add(new StringContent($"{recognitionImageKind}"), "recognitionImageKind");
            }


            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "POST",
                           null,
                           null,
                           multipartContent);

            return response != null ? (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList)) : null;


        }
    }
}
