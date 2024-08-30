// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ScanApi.cs">
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
    ///     ScanApi
    /// </summary>
    public class ScanApi : IScanApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="ScanApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public ScanApi(Configuration configuration)
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
        ///     Initializes a new instance of the <see cref="ScanApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public ScanApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }

        /// <summary>
        ///     Scan barcode from file in request body using POST requests with parameter in body in json or xml format.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeScanBodyPostRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> BarcodeScanBodyPostAsync(BarcodeScanBodyPostRequest request)
        {
            // verify the required parameter 'scanBase64Request' is set
            if (request.ScanBase64Request == null)
            {
                throw new ApiException(400, "Missing required parameter 'scanBase64Request' when calling BarcodeScanBodyPost");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/scan-body";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            string postBody = SerializationHelper.Serialize(request.ScanBase64Request); // http body (model) parameter

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
        ///     Scan barcode from file in request body using POST requests with parameter in multipart form.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeScanFormPostRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> BarcodeScanFormPostAsync(BarcodeScanFormPostRequest request)
        {
            // verify the required parameter 'file' is set
            if (request.File == null)
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling BarcodeScanFormPost");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/scan-form";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new MultipartFormDataContent();
            if (request.File != null)
            {
                formParams.Add(new StreamContent(request.File), "File", "file.png");
            }


            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "POST",
                           null,
                           null,
                           formParams);

            if (response != null)
            {
                return (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));
            }

            return null;

        }

        /// <summary>
        ///     Scan barcode from file on server using GET requests with parameter in query string.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeScanGetRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> BarcodeScanGetAsync(BarcodeScanGetRequest request)
        {
            // verify the required parameter 'url' is set
            if (request.Url == null)
            {
                throw new ApiException(400, "Missing required parameter 'url' when calling BarcodeScanGet");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/scan";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.Url);
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
    }
}
