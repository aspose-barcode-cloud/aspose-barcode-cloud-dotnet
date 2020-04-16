// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodeApi.cs">
//   Copyright (c) 2019 Aspose.BarCode for Cloud
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

namespace Aspose.BarCode.Cloud.Sdk
{
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Aspose.BarCode.Cloud.Sdk.Model;
    using Aspose.BarCode.Cloud.Sdk.Model.Requests;
    using Aspose.BarCode.Cloud.Sdk.RequestHandlers;
    
    /// <summary>
    /// Aspose.BarCode for Cloud API.
    /// </summary>
    public class BarCodeApi
    {        
        private readonly ApiInvoker apiInvoker;
        private readonly Configuration configuration;     

        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodeApi"/> class.
        /// </summary>
        /// <param name="apiKey">
        /// The api Key.
        /// </param>
        /// <param name="appSid">
        /// The app Sid.
        /// </param>
        public BarCodeApi(string apiKey, string appSid)
            : this(new Configuration { AppKey = apiKey, AppSid = appSid })
        {
        }

        public BarCodeApi(string jwtToken)
            : this(new Configuration { JwtToken = jwtToken, ApiVersion = ApiVersion.V3, AuthType = AuthType.ExternalAuth })
        {
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodeApi"/> class.
        /// </summary>    
        /// <param name="configuration">Configuration settings</param>
        public BarCodeApi(Configuration configuration)
        {
            this.configuration = configuration;
            
            var requestHandlers = new List<IRequestHandler>();
            switch (this.configuration.AuthType)
            {
                case AuthType.RequestSignature: requestHandlers.Add(new AuthWithSignatureRequestHandler(this.configuration));
                    break;
                case AuthType.OAuth2: requestHandlers.Add(new OAuthRequestHandler(this.configuration));
                    break;
                case AuthType.ExternalAuth: requestHandlers.Add(new ExternalAuthorizationRequestHandler(this.configuration));
                    break;
            }

            requestHandlers.Add(new DebugLogRequestHandler(this.configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            this.apiInvoker = new ApiInvoker(configuration, requestHandlers);
        }                            

        /// <summary>
        /// Generate barcode. 
        /// </summary>
        /// <param name="request">Request. <see cref="BarCodeGetBarCodeGenerateRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream BarCodeGetBarCodeGenerate(BarCodeGetBarCodeGenerateRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/barcode/generate";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", request.text);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionX", request.resolutionX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionY", request.resolutionY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dimensionX", request.dimensionX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dimensionY", request.dimensionY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableChecksum", request.enableChecksum);
            
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "GET", 
                        null, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Recognize barcode from a file on server. 
        /// </summary>
        /// <param name="request">Request. <see cref="BarCodeGetBarCodeRecognizeRequest" /></param> 
        /// <returns><see cref="BarCodeResponseList"/></returns>            
        public BarCodeResponseList BarCodeGetBarCodeRecognize(BarCodeGetBarCodeRecognizeRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling BarCodeGetBarCodeRecognize");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/barcode/{name}/recognize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "checksumValidation", request.checksumValidation);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "stripFnc", request.stripFnc);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", request.rotationAngle);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barcodesCount", request.barcodesCount);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectX", request.rectX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectY", request.rectY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectWidth", request.rectWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rectHeight", request.rectHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "GET", 
                    null, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BarCodeResponseList)SerializationHelper.Deserialize(response, typeof(BarCodeResponseList));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image or encoded with base64. 
        /// </summary>
        /// <param name="request">Request. <see cref="BarCodePostBarCodeRecognizeFromUrlorContentRequest" /></param> 
        /// <returns><see cref="BarCodeResponseList"/></returns>            
        public BarCodeResponseList BarCodePostBarCodeRecognizeFromUrlorContent(BarCodePostBarCodeRecognizeFromUrlorContentRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/barcode/recognize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "checksumValidation", request.checksumValidation);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "stripFnc", request.stripFnc);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotationAngle", request.rotationAngle);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "url", request.url);
            
            if (request.imageData != null) 
            {
                formParams.Add("imageData", this.apiInvoker.ToFileInfo(request.imageData, "imageData"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "POST", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (BarCodeResponseList)SerializationHelper.Deserialize(response, typeof(BarCodeResponseList));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Generate multiple barcodes and return in response stream 
        /// </summary>
        /// <param name="request">Request. <see cref="BarCodePostGenerateMultipleRequest" /></param> 
        /// <returns><see cref="System.IO.Stream"/></returns>            
        public System.IO.Stream BarCodePostGenerateMultiple(BarCodePostGenerateMultipleRequest request)
        {
            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/barcode/generateMultiple";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            var postBody = SerializationHelper.Serialize(request.dto); // http body (model) parameter
            try 
            {                               
                    return this.apiInvoker.InvokeBinaryApi(
                        resourcePath, 
                        "POST", 
                        postBody, 
                        null, 
                        null);
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Generate barcode and save on server. 
        /// </summary>
        /// <param name="request">Request. <see cref="BarCodePutBarCodeGenerateFileRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse BarCodePutBarCodeGenerateFile(BarCodePutBarCodeGenerateFileRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling BarCodePutBarCodeGenerateFile");
            }

            // verify the required parameter 'file' is set
            if (request.File == null) 
            {
                throw new ApiException(400, "Missing required parameter 'file' when calling BarCodePutBarCodeGenerateFile");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/barcode/{name}/generate";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            var formParams = new Dictionary<string, object>();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "text", request.text);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionX", request.resolutionX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "resolutionY", request.resolutionY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dimensionX", request.dimensionX);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "dimensionY", request.dimensionY);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "codeLocation", request.codeLocation);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "grUnit", request.grUnit);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "autoSize", request.autoSize);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "barHeight", request.barHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageHeight", request.imageHeight);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageWidth", request.imageWidth);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "imageQuality", request.imageQuality);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rotAngle", request.rotAngle);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "topMargin", request.topMargin);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "bottomMargin", request.bottomMargin);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "leftMargin", request.leftMargin);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "rightMargin", request.rightMargin);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "enableChecksum", request.enableChecksum);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storage", request.storage);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            
            if (request.File != null) 
            {
                formParams.Add("file", this.apiInvoker.ToFileInfo(request.File, "File"));
            }
            
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    null, 
                    null, 
                    formParams);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Recognition of a barcode from file on server with parameters in body. 
        /// </summary>
        /// <param name="request">Request. <see cref="BarCodePutBarCodeRecognizeFromBodyRequest" /></param> 
        /// <returns><see cref="BarCodeResponseList"/></returns>            
        public BarCodeResponseList BarCodePutBarCodeRecognizeFromBody(BarCodePutBarCodeRecognizeFromBodyRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling BarCodePutBarCodeRecognizeFromBody");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/barcode/{name}/recognize";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "type", request.type);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var postBody = SerializationHelper.Serialize(request.barcodeReader); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (BarCodeResponseList)SerializationHelper.Deserialize(response, typeof(BarCodeResponseList));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }

        /// <summary>
        /// Generate image with multiple barcodes and put new file on server 
        /// </summary>
        /// <param name="request">Request. <see cref="BarCodePutGenerateMultipleRequest" /></param> 
        /// <returns><see cref="AsposeResponse"/></returns>            
        public AsposeResponse BarCodePutGenerateMultiple(BarCodePutGenerateMultipleRequest request)
        {
            // verify the required parameter 'name' is set
            if (request.name == null) 
            {
                throw new ApiException(400, "Missing required parameter 'name' when calling BarCodePutGenerateMultiple");
            }

            // create path and map variables
            var resourcePath = this.configuration.GetApiRootUrl() + "/barcode/{name}/generateMultiple";
            resourcePath = Regex
                        .Replace(resourcePath, "\\*", string.Empty)
                        .Replace("&amp;", "&")
                        .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "name", request.name);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "format", request.format);
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "folder", request.folder);
            var postBody = SerializationHelper.Serialize(request.dto); // http body (model) parameter
            try 
            {                               
                var response = this.apiInvoker.InvokeApi(
                    resourcePath, 
                    "PUT", 
                    postBody, 
                    null, 
                    null);
                if (response != null)
                {
                    return (AsposeResponse)SerializationHelper.Deserialize(response, typeof(AsposeResponse));
                }
                    
                return null;
            } 
            catch (ApiException ex) 
            {
                if (ex.ErrorCode == 404) 
                {
                    return null;
                }
                
                throw;                
            }
        }
    }
}
