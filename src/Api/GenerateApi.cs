// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GenerateApi.cs">
//   Copyright (c) 2026 Aspose.BarCode for Cloud
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
        /// Generate barcode using GET request with parameters in route and query string.
        /// </summary>
        /// <param name="barcodeType">Type of barcode to generate.</param>
        /// <param name="data">String represents data to encode</param>
        /// <param name="dataType">Type of data to encode. Default value: StringData. (optional)</param>
        /// <param name="imageFormat">Barcode output image format. Default value: png (optional)</param>
        /// <param name="textLocation">Specify the displaying Text Location, set to CodeLocation.None to hide CodeText. Default value: Depends on BarcodeType. CodeLocation.Below for 1D Barcodes. CodeLocation.None for 2D Barcodes. (optional)</param>
        /// <param name="foregroundColor">Specify the displaying bars and content Color. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: Black. (optional, default to &quot;Black&quot;)</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: White. (optional, default to &quot;White&quot;)</param>
        /// <param name="units">Common Units for all measuring in query. Default units: pixel. (optional)</param>
        /// <param name="resolution">Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is dot. (optional)</param>
        /// <param name="imageHeight">Height of the barcode image in given units. Default units: pixel. Decimal separator is dot. (optional)</param>
        /// <param name="imageWidth">Width of the barcode image in given units. Default units: pixel. Decimal separator is dot. (optional)</param>
        /// <param name="rotationAngle">BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'data' is set
            if (data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling Generate");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate/{barcodeType}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "barcodeType", barcodeType);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dataType", dataType);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "data", data);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageFormat", imageFormat);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textLocation", textLocation);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "foregroundColor", foregroundColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backgroundColor", backgroundColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "units", units);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolution", resolution);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageHeight", imageHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageWidth", imageWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", rotationAngle);
#pragma warning restore CS0618 // Type or member is obsolete


            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }
        /// <summary>
        /// Generate barcode using POST request with parameters in body in json or xml format.
        /// </summary>
        /// <param name="generateParams">Parameters of generation</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateBodyAsync(GenerateParams generateParams, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'generateParams' is set
            if (generateParams == null)
            {
                throw new ApiException(400, "Missing required parameter 'generateParams' when calling GenerateBody");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate-body";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            string postBody = SerializationHelper.Serialize(generateParams); // http body (model) parameter

            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }
        /// <summary>
        /// Generate barcode using POST request with parameters in multipart form.
        /// </summary>
        /// <param name="barcodeType"></param>
        /// <param name="data">String represents data to encode</param>
        /// <param name="dataType"> (optional)</param>
        /// <param name="imageFormat"> (optional)</param>
        /// <param name="textLocation"> (optional)</param>
        /// <param name="foregroundColor">Specify the displaying bars and content Color. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: Black. (optional, default to &quot;Black&quot;)</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: White. (optional, default to &quot;White&quot;)</param>
        /// <param name="units"> (optional)</param>
        /// <param name="resolution">Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is dot. (optional)</param>
        /// <param name="imageHeight">Height of the barcode image in given units. Default units: pixel. Decimal separator is dot. (optional)</param>
        /// <param name="imageWidth">Width of the barcode image in given units. Default units: pixel. Decimal separator is dot. (optional)</param>
        /// <param name="rotationAngle">BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. (optional)</param>
        /// <param name="cancellationToken"></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GenerateMultipartAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, System.Threading.CancellationToken cancellationToken = default)
        {
            // verify the required parameter 'data' is set
            if (data == null)
            {
                throw new ApiException(400, "Missing required parameter 'data' when calling GenerateMultipart");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate-multipart";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            MultipartFormDataContent multipartContent = new MultipartFormDataContent();

            multipartContent.Add(new StringContent($"{barcodeType}"), "barcodeType");


            if (dataType != null)
            {
                multipartContent.Add(new StringContent($"{dataType}"), "dataType");
            }

            if (data != null)
            {
                multipartContent.Add(new StringContent($"{data}"), "data");
            }

            if (imageFormat != null)
            {
                multipartContent.Add(new StringContent($"{imageFormat}"), "imageFormat");
            }

            if (textLocation != null)
            {
                multipartContent.Add(new StringContent($"{textLocation}"), "textLocation");
            }

            if (foregroundColor != null)
            {
                multipartContent.Add(new StringContent($"{foregroundColor}"), "foregroundColor");
            }

            if (backgroundColor != null)
            {
                multipartContent.Add(new StringContent($"{backgroundColor}"), "backgroundColor");
            }

            if (units != null)
            {
                multipartContent.Add(new StringContent($"{units}"), "units");
            }

            if (resolution != null)
            {
                multipartContent.Add(new StringContent($"{resolution}"), "resolution");
            }

            if (imageHeight != null)
            {
                multipartContent.Add(new StringContent($"{imageHeight}"), "imageHeight");
            }

            if (imageWidth != null)
            {
                multipartContent.Add(new StringContent($"{imageWidth}"), "imageWidth");
            }

            if (rotationAngle != null)
            {
                multipartContent.Add(new StringContent($"{rotationAngle}"), "rotationAngle");
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
