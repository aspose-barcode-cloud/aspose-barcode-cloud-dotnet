// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GenerateApi.cs">
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
    ///     GenerateApi
    /// </summary>
    public class GenerateApi : IGenerateApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="GenerateApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public GenerateApi(Configuration configuration)
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
        ///     Initializes a new instance of the <see cref="GenerateApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public GenerateApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }

        /// <summary>
        ///     Generate barcode using GET request with parameters in route and query string.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeGenerateBarcodeTypeGetRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> BarcodeGenerateBarcodeTypeGetAsync(BarcodeGenerateBarcodeTypeGetRequest request)
        {
            // verify the required parameter 'data' is set
            if (request.Data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling BarcodeGenerateBarcodeTypeGet");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate/{barcodeType}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "barcodeType", request.BarcodeType);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dataType", request.DataType);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "data", request.Data);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageFormat", request.ImageFormat);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textLocation", request.TextLocation);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "foregroundColor", request.ForegroundColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColor", request.BackgroundColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "units", request.Units);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolution", request.Resolution);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageHeight", request.ImageHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageWidth", request.ImageWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", request.RotationAngle);
#pragma warning restore CS0618 // Type or member is obsolete


            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Generate barcode using POST request with parameters in body in json or xml format.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeGenerateBodyPostRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> BarcodeGenerateBodyPostAsync(BarcodeGenerateBodyPostRequest request)
        {
            // verify the required parameter 'generateParams' is set
            if (request.GenerateParams == null)
            {
                throw new ApiException(400, "Missing required parameter 'generateParams' when calling BarcodeGenerateBodyPost");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate-body";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            string postBody = SerializationHelper.Serialize(request.GenerateParams); // http body (model) parameter

            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        /// <summary>
        ///     Generate barcode using POST request with parameters in multipart form.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeGenerateMultipartPostRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> BarcodeGenerateMultipartPostAsync(BarcodeGenerateMultipartPostRequest request)
        {
            // verify the required parameter 'data' is set
            if (request.Data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling BarcodeGenerateMultipartPost");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate-multipart";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new StringContent($"{request.BarcodeType}"), "BarcodeType");


            if (request.DataType != null)
            {
                multipartContent.Add(new StringContent($"{request.DataType}"), "DataType");
            }

            if (request.Data != null)
            {
                multipartContent.Add(new StringContent($"{request.Data}"), "Data");
            }

            if (request.ImageFormat != null)
            {
                multipartContent.Add(new StringContent($"{request.ImageFormat}"), "ImageFormat");
            }

            if (request.TextLocation != null)
            {
                multipartContent.Add(new StringContent($"{request.TextLocation}"), "TextLocation");
            }

            if (request.ForegroundColor != null)
            {
                multipartContent.Add(new StringContent($"{request.ForegroundColor}"), "ForegroundColor");
            }

            if (request.BackgroundColor != null)
            {
                multipartContent.Add(new StringContent($"{request.BackgroundColor}"), "BackgroundColor");
            }

            if (request.Units != null)
            {
                multipartContent.Add(new StringContent($"{request.Units}"), "Units");
            }

            if (request.Resolution != null)
            {
                multipartContent.Add(new StringContent($"{request.Resolution}"), "Resolution");
            }

            if (request.ImageHeight != null)
            {
                multipartContent.Add(new StringContent($"{request.ImageHeight}"), "ImageHeight");
            }

            if (request.ImageWidth != null)
            {
                multipartContent.Add(new StringContent($"{request.ImageWidth}"), "ImageWidth");
            }

            if (request.RotationAngle != null)
            {
                multipartContent.Add(new StringContent($"{request.RotationAngle}"), "RotationAngle");
            }


            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "POST",
                null,
                null,
                multipartContent);
        }
    }
}
