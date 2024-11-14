// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="RecognizeApi.cs">
//   Copyright (c) 2024 Aspose.BarCode for Cloud
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
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

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

            var requestHandlers = new List<IRequestHandler>();
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
        ///     Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeRecognizeBodyPostRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> BarcodeRecognizeBodyPostAsync(BarcodeRecognizeBodyPostRequest request)
        {
            // verify the required parameter 'recognizeBase64Request' is set
            if (request.RecognizeBase64Request == null)
            {
                throw new ApiException(400, "Missing required parameter 'recognizeBase64Request' when calling BarcodeRecognizeBodyPost");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/recognize-body";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            string postBody = SerializationHelper.Serialize(request.RecognizeBase64Request); // http body (model) parameter

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "POST",
                           postBody,
                           null,
                           null);

            if (response != null)
            {
                return (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));
            }

            return null;

        }

        /// <summary>
        ///     Recognize barcode from file on server using GET requests with parameters in route and query string.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeRecognizeGetRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> BarcodeRecognizeGetAsync(BarcodeRecognizeGetRequest request)
        {
            // verify the required parameter 'fileUrl' is set
            if (request.FileUrl == null)
            {
                throw new ApiException(400, "Missing required parameter 'fileUrl' when calling BarcodeRecognizeGet");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/recognize";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barcodeType", request.BarcodeType);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fileUrl", request.FileUrl);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recognitionMode", request.RecognitionMode);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recognitionImageKind", request.RecognitionImageKind);
#pragma warning restore CS0618 // Type or member is obsolete


            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "GET",
                           null,
                           null,
                           null);

            if (response != null)
            {
                return (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));
            }

            return null;

        }

        /// <summary>
        ///     Recognize barcode from file in request body using POST requests with parameters in multipart form.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeRecognizeMultipartPostRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> BarcodeRecognizeMultipartPostAsync(BarcodeRecognizeMultipartPostRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling BarcodeRecognizeMultipartPost");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/recognize-multipart";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new StringContent($"{request.BarcodeType}"), "BarcodeType");


            if (request.File != null)
            {

                multipartContent.Add(new StreamContent(request.File), "File", "file.png");

            }

            if (request.RecognitionMode != null)
            {
                multipartContent.Add(new StringContent($"{request.RecognitionMode}"), "RecognitionMode");
            }

            if (request.RecognitionImageKind != null)
            {
                multipartContent.Add(new StringContent($"{request.RecognitionImageKind}"), "RecognitionImageKind");
            }


            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "POST",
                           null,
                           null,
                           multipartContent);

            if (response != null)
            {
                return (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));
            }

            return null;

        }
    }
}
