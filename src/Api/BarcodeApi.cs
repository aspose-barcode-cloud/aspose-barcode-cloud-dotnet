// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarcodeApi.cs">
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
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Api
{
    /// <summary>
    ///     BarcodeApi
    /// </summary>
    public class BarcodeApi : IBarcodeApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="BarcodeApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public BarcodeApi(Configuration configuration)
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
        ///     Initializes a new instance of the <see cref="BarcodeApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public BarcodeApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }

        /// <summary>
        ///     Generate barcode.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeGenerateRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> GetBarcodeGenerateAsync(GetBarcodeGenerateRequest request)
        {
            // verify the required parameter 'type' is set
            if (request.Type == null)
            {
                throw new ApiException(400, "Missing required parameter 'type' when calling GetBarcodeGenerate");
            }
            // verify the required parameter 'text' is set
            if (request.Text == null)
            {
                throw new ApiException(400, "Missing required parameter 'text' when calling GetBarcodeGenerate");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generate";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", request.Text);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "twoDDisplayText", request.TwoDDisplayText);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textLocation", request.TextLocation);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textAlignment", request.TextAlignment);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textColor", request.TextColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "noWrap", request.NoWrap);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolution", request.Resolution);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionX", request.ResolutionX);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionY", request.ResolutionY);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dimensionX", request.DimensionX);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textSpace", request.TextSpace);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "units", request.Units);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sizeMode", request.SizeMode);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barHeight", request.BarHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageHeight", request.ImageHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageWidth", request.ImageWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", request.RotationAngle);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backColor", request.BackColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barColor", request.BarColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderColor", request.BorderColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderWidth", request.BorderWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderDashStyle", request.BorderDashStyle);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderVisible", request.BorderVisible);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableChecksum", request.EnableChecksum);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableEscape", request.EnableEscape);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filledBars", request.FilledBars);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "alwaysShowChecksum", request.AlwaysShowChecksum);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "wideNarrowRatio", request.WideNarrowRatio);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "validateText", request.ValidateText);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "supplementData", request.SupplementData);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "supplementSpace", request.SupplementSpace);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barWidthReduction", request.BarWidthReduction);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useAntiAlias", request.UseAntiAlias);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
#pragma warning restore CS0618 // Type or member is obsolete

            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Recognize barcode from a file on server.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeRecognizeRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> GetBarcodeRecognizeAsync(GetBarcodeRecognizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling GetBarcodeRecognize");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/{name}/recognize";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "types", request.Types);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "checksumValidation", request.ChecksumValidation);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "detectEncoding", request.DetectEncoding);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "preset", request.Preset);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectX", request.RectX);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectY", request.RectY);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.RectWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.RectHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "stripFNC", request.StripFNC);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "timeout", request.Timeout);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "medianSmoothingWindowSize", request.MedianSmoothingWindowSize);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowMedianSmoothing", request.AllowMedianSmoothing);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowComplexBackground", request.AllowComplexBackground);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowDatamatrixIndustrialBarcodes", request.AllowDatamatrixIndustrialBarcodes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowDecreasedImage", request.AllowDecreasedImage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowDetectScanGap", request.AllowDetectScanGap);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowIncorrectBarcodes", request.AllowIncorrectBarcodes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowInvertImage", request.AllowInvertImage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowMicroWhiteSpotsRemoving", request.AllowMicroWhiteSpotsRemoving);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowOneDFastBarcodesDetector", request.AllowOneDFastBarcodesDetector);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowOneDWipedBarsRestoration", request.AllowOneDWipedBarsRestoration);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowQRMicroQrRestoration", request.AllowQRMicroQrRestoration);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowRegularImage", request.AllowRegularImage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowSaltAndPepperFiltering", request.AllowSaltAndPepperFiltering);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowWhiteSpotsRemoving", request.AllowWhiteSpotsRemoving);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "checkMore1DVariants", request.CheckMore1DVariants);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fastScanOnly", request.FastScanOnly);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowAdditionalRestorations", request.AllowAdditionalRestorations);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "regionLikelihoodThresholdPercent", request.RegionLikelihoodThresholdPercent);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scanWindowSizes", request.ScanWindowSizes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarity", request.Similarity);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "skipDiagonalSearch", request.SkipDiagonalSearch);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "readTinyBarcodes", request.ReadTinyBarcodes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "australianPostEncodingTable", request.AustralianPostEncodingTable);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreEndingFillingPatternsForCTable", request.IgnoreEndingFillingPatternsForCTable);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
#pragma warning restore CS0618 // Type or member is obsolete

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "GET",
                           null,
                           null,
                           null);

            return response == null ? null : (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));


        }

        /// <summary>
        ///     Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image with content-type \&quot;application/octet-stream\&quot;. An image can also be passed as a form field.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBarcodeRecognizeFromUrlOrContentRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> PostBarcodeRecognizeFromUrlOrContentAsync(PostBarcodeRecognizeFromUrlOrContentRequest request)
        {
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/recognize";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            MultipartFormDataContent formParams = new MultipartFormDataContent();
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "types", request.Types);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "checksumValidation", request.ChecksumValidation);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "detectEncoding", request.DetectEncoding);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "preset", request.Preset);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectX", request.RectX);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectY", request.RectY);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.RectWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.RectHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "stripFNC", request.StripFNC);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "timeout", request.Timeout);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "medianSmoothingWindowSize", request.MedianSmoothingWindowSize);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowMedianSmoothing", request.AllowMedianSmoothing);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowComplexBackground", request.AllowComplexBackground);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowDatamatrixIndustrialBarcodes", request.AllowDatamatrixIndustrialBarcodes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowDecreasedImage", request.AllowDecreasedImage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowDetectScanGap", request.AllowDetectScanGap);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowIncorrectBarcodes", request.AllowIncorrectBarcodes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowInvertImage", request.AllowInvertImage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowMicroWhiteSpotsRemoving", request.AllowMicroWhiteSpotsRemoving);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowOneDFastBarcodesDetector", request.AllowOneDFastBarcodesDetector);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowOneDWipedBarsRestoration", request.AllowOneDWipedBarsRestoration);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowQRMicroQrRestoration", request.AllowQRMicroQrRestoration);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowRegularImage", request.AllowRegularImage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowSaltAndPepperFiltering", request.AllowSaltAndPepperFiltering);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowWhiteSpotsRemoving", request.AllowWhiteSpotsRemoving);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "checkMore1DVariants", request.CheckMore1DVariants);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "fastScanOnly", request.FastScanOnly);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "allowAdditionalRestorations", request.AllowAdditionalRestorations);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "regionLikelihoodThresholdPercent", request.RegionLikelihoodThresholdPercent);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "scanWindowSizes", request.ScanWindowSizes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "similarity", request.Similarity);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "skipDiagonalSearch", request.SkipDiagonalSearch);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "readTinyBarcodes", request.ReadTinyBarcodes);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "australianPostEncodingTable", request.AustralianPostEncodingTable);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "ignoreEndingFillingPatternsForCTable", request.IgnoreEndingFillingPatternsForCTable);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.url);
#pragma warning restore CS0618 // Type or member is obsolete

            if (request.image != null)
            {
                formParams.Add(new StreamContent(request.image), "image", "image.png");
            }
            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "POST",
                           null,
                           null,
                           formParams);

            return response == null ? null : (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));


        }

        /// <summary>
        ///     Generate multiple barcodes and return in response stream
        /// </summary>
        /// <param name="request">Request. <see cref="PostGenerateMultipleRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> PostGenerateMultipleAsync(PostGenerateMultipleRequest request)
        {
            // verify the required parameter 'generatorParamsList' is set
            if (request.generatorParamsList == null)
            {
                throw new ApiException(400, "Missing required parameter 'generatorParamsList' when calling PostGenerateMultiple");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/generateMultiple";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
#pragma warning restore CS0618 // Type or member is obsolete
            string postBody = SerializationHelper.Serialize(request.generatorParamsList); // http body (model) parameter
            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "POST",
                postBody,
                null,
                null);
        }

        /// <summary>
        ///     Generate barcode and save on server (from query params or from file with json or xml content)
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeGenerateFileRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="ResultImageInfo" />
        /// </returns>
        public async Task<ResultImageInfo> PutBarcodeGenerateFileAsync(PutBarcodeGenerateFileRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutBarcodeGenerateFile");
            }
            // verify the required parameter 'type' is set
            if (request.Type == null)
            {
                throw new ApiException(400, "Missing required parameter 'type' when calling PutBarcodeGenerateFile");
            }
            // verify the required parameter 'text' is set
            if (request.Text == null)
            {
                throw new ApiException(400, "Missing required parameter 'text' when calling PutBarcodeGenerateFile");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/{name}/generate";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.Type);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", request.Text);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "twoDDisplayText", request.TwoDDisplayText);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textLocation", request.TextLocation);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textAlignment", request.TextAlignment);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textColor", request.TextColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "noWrap", request.NoWrap);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolution", request.Resolution);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionX", request.ResolutionX);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionY", request.ResolutionY);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dimensionX", request.DimensionX);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "textSpace", request.TextSpace);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "units", request.Units);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "sizeMode", request.SizeMode);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barHeight", request.BarHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageHeight", request.ImageHeight);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageWidth", request.ImageWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", request.RotationAngle);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "backColor", request.BackColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barColor", request.BarColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderColor", request.BorderColor);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderWidth", request.BorderWidth);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderDashStyle", request.BorderDashStyle);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "borderVisible", request.BorderVisible);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableChecksum", request.EnableChecksum);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableEscape", request.EnableEscape);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "filledBars", request.FilledBars);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "alwaysShowChecksum", request.AlwaysShowChecksum);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "wideNarrowRatio", request.WideNarrowRatio);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "validateText", request.ValidateText);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "supplementData", request.SupplementData);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "supplementSpace", request.SupplementSpace);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barWidthReduction", request.BarWidthReduction);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "useAntiAlias", request.UseAntiAlias);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
#pragma warning restore CS0618 // Type or member is obsolete

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "PUT",
                           null,
                           null,
                           null);

            return response == null ? null : (ResultImageInfo)SerializationHelper.Deserialize(response, typeof(ResultImageInfo));


        }

        /// <summary>
        ///     Recognition of a barcode from file on server with parameters in body.
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeRecognizeFromBodyRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> PutBarcodeRecognizeFromBodyAsync(PutBarcodeRecognizeFromBodyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutBarcodeRecognizeFromBody");
            }
            // verify the required parameter 'readerParams' is set
            if (request.readerParams == null)
            {
                throw new ApiException(400, "Missing required parameter 'readerParams' when calling PutBarcodeRecognizeFromBody");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/{name}/recognize";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.type);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
#pragma warning restore CS0618 // Type or member is obsolete
            string postBody = SerializationHelper.Serialize(request.readerParams); // http body (model) parameter
            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "PUT",
                           postBody,
                           null,
                           null);

            return response == null ? null : (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));


        }

        /// <summary>
        ///     Generate image with multiple barcodes and put new file on server
        /// </summary>
        /// <param name="request">Request. <see cref="PutGenerateMultipleRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="ResultImageInfo" />
        /// </returns>
        public async Task<ResultImageInfo> PutGenerateMultipleAsync(PutGenerateMultipleRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null)
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling PutGenerateMultiple");
            }
            // verify the required parameter 'generatorParamsList' is set
            if (request.generatorParamsList == null)
            {
                throw new ApiException(400, "Missing required parameter 'generatorParamsList' when calling PutGenerateMultiple");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/{name}/generateMultiple";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
#pragma warning restore CS0618 // Type or member is obsolete
            string postBody = SerializationHelper.Serialize(request.generatorParamsList); // http body (model) parameter
            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "PUT",
                           postBody,
                           null,
                           null);

            return response == null ? null : (ResultImageInfo)SerializationHelper.Deserialize(response, typeof(ResultImageInfo));


        }

        /// <summary>
        ///     Quickly scan a barcode from an image.
        /// </summary>
        /// <param name="request">Request. <see cref="ScanBarcodeRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="BarcodeResponseList" />
        /// </returns>
        public async Task<BarcodeResponseList> ScanBarcodeAsync(ScanBarcodeRequest request)
        {
            // verify the required parameter 'imageFile' is set
            if (request.imageFile == null)
            {
                throw new ApiException(400, "Missing required parameter 'imageFile' when calling ScanBarcode");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/scan";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            MultipartFormDataContent formParams = new MultipartFormDataContent();




            if (request.imageFile != null)
            {
                formParams.Add(new StreamContent(request.imageFile), "imageFile", "imageFile.png");
            }
            if (request.decodeTypes != null)
            {
                foreach (DecodeBarcodeType oneParam in request.decodeTypes)
                {
                    formParams.Add(new StringContent(oneParam.ToString()), "decodeTypes");
                }
            }
            if (request.timeout != null)
            {
                formParams.Add(new StringContent($"{request.timeout}"), "timeout");
            }
            if (request.checksumValidation != null)
            {
                formParams.Add(new StringContent($"{request.checksumValidation}"), "checksumValidation");
            }
            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "POST",
                           null,
                           null,
                           formParams);

            return response == null ? null : (BarcodeResponseList)SerializationHelper.Deserialize(response, typeof(BarcodeResponseList));


        }
    }
}
