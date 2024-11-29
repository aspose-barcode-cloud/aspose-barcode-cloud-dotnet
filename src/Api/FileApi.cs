// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FileApi.cs">
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
    ///     FileApi
    /// </summary>
    public class FileApi : IFileApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="FileApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public FileApi(Configuration configuration)
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
        ///     Initializes a new instance of the <see cref="FileApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public FileApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }

        /// <summary>
        ///     Copy file
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        public async Task CopyFileAsync(CopyFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFile");
            }
            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFile");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/file/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
#pragma warning restore CS0618 // Type or member is obsolete

            await _apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Delete file
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        public async Task DeleteFileAsync(DeleteFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFile");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
#pragma warning restore CS0618 // Type or member is obsolete

            await _apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Download file
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="System.IO.Stream" />
        /// </returns>
        public async Task<System.IO.Stream> DownloadFileAsync(DownloadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DownloadFile");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
#pragma warning restore CS0618 // Type or member is obsolete

            return await _apiInvoker.InvokeBinaryApiAsync(
                resourcePath,
                "GET",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Move file
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        public async Task MoveFileAsync(MoveFileRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFile");
            }
            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFile");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/file/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
#pragma warning restore CS0618 // Type or member is obsolete

            await _apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Upload file
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="FilesUploadResult" />
        /// </returns>
        public async Task<FilesUploadResult> UploadFileAsync(UploadFileRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling UploadFile");
            }
            // verify the required parameter '_file' is set
            if (request.File == null)
            {
                throw new ApiException(400, "Missing required parameter '_file' when calling UploadFile");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/file/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            var formParams = new MultipartFormDataContent();
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
#pragma warning restore CS0618 // Type or member is obsolete

            if (request.File != null)
            {
                formParams.Add(new StreamContent(request.File), "File", "_file.png");
            }
            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "PUT",
                           null,
                           null,
                           formParams);

            return response == null ? null : (FilesUploadResult)SerializationHelper.Deserialize(response, typeof(FilesUploadResult));


        }
    }
}
