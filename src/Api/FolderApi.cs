// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="FolderApi.cs">
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
    ///     FolderApi
    /// </summary>
    public class FolderApi : IFolderApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="FolderApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public FolderApi(Configuration configuration)
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
        ///     Initializes a new instance of the <see cref="FolderApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public FolderApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }

        /// <summary>
        ///     Copy folder
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        public async Task CopyFolderAsync(CopyFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling CopyFolder");
            }
            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling CopyFolder");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/folder/copy/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
#pragma warning restore CS0618 // Type or member is obsolete

            await _apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Create the folder
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        public async Task CreateFolderAsync(CreateFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling CreateFolder");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
#pragma warning restore CS0618 // Type or member is obsolete

            await _apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Delete folder
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        public async Task DeleteFolderAsync(DeleteFolderRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling DeleteFolder");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "recursive", request.recursive);
#pragma warning restore CS0618 // Type or member is obsolete

            await _apiInvoker.InvokeApiAsync(
                resourcePath,
                "DELETE",
                null,
                null,
                null);
        }

        /// <summary>
        ///     Get all files and folders within a folder
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="FilesList" />
        /// </returns>
        public async Task<FilesList> GetFilesListAsync(GetFilesListRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFilesList");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/folder/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
#pragma warning restore CS0618 // Type or member is obsolete

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "GET",
                           null,
                           null,
                           null);

            return response == null ? null : (FilesList)SerializationHelper.Deserialize(response, typeof(FilesList));


        }

        /// <summary>
        ///     Move folder
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation.
        /// </returns>
        public async Task MoveFolderAsync(MoveFolderRequest request)
        {
            // verify the required parameter 'srcPath' is set
            if (request.srcPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'srcPath' when calling MoveFolder");
            }
            // verify the required parameter 'destPath' is set
            if (request.destPath == null)
            {
                throw new ApiException(400, "Missing required parameter 'destPath' when calling MoveFolder");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/folder/move/{srcPath}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "srcPath", request.srcPath);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destPath", request.destPath);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "srcStorageName", request.srcStorageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "destStorageName", request.destStorageName);
#pragma warning restore CS0618 // Type or member is obsolete

            await _apiInvoker.InvokeApiAsync(
                resourcePath,
                "PUT",
                null,
                null,
                null);
        }
    }
}
