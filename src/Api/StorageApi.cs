// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="StorageApi.cs">
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
    ///     StorageApi
    /// </summary>
    public class StorageApi : IStorageApi
    {
        private readonly ApiInvoker _apiInvoker;
        private readonly Configuration _configuration;


        /// <summary>
        ///     Initializes a new instance of the <see cref="StorageApi" /> class.
        /// </summary>
        /// <param name="configuration">Configuration settings</param>
        public StorageApi(Configuration configuration)
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
        ///     Initializes a new instance of the <see cref="StorageApi" /> class.
        /// </summary>
        /// <param name="clientSecret">
        ///     The Client Secret.
        /// </param>
        /// <param name="clientId">
        ///     The Client Id.
        /// </param>
        public StorageApi(string clientSecret, string clientId)
            : this(new Configuration { ClientSecret = clientSecret, ClientId = clientId })
        {
        }

        /// <summary>
        ///     Get disc usage
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="DiscUsage" />
        /// </returns>
        public async Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request)
        {
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/disc";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);
#pragma warning restore CS0618 // Type or member is obsolete

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "GET",
                           null,
                           null,
                           null);

            if (response != null)
            {
                return (DiscUsage)SerializationHelper.Deserialize(response, typeof(DiscUsage));
            }

            return null;

        }

        /// <summary>
        ///     Get file versions
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="FileVersions" />
        /// </returns>
        public async Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling GetFileVersions");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/version/{path}";
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

            if (response != null)
            {
                return (FileVersions)SerializationHelper.Deserialize(response, typeof(FileVersions));
            }

            return null;

        }

        /// <summary>
        ///     Check if file or folder exists
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="ObjectExist" />
        /// </returns>
        public async Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request)
        {
            // verify the required parameter 'path' is set
            if (request.path == null)
            {
                throw new ApiException(400, "Missing required parameter 'path' when calling ObjectExists");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/exist/{path}";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "path", request.path);
#pragma warning disable CS0618 // Type or member is obsolete
            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "storageName", request.storageName);


            resourcePath = UrlHelper.AddQueryParameterToUrl(resourcePath, "versionId", request.versionId);
#pragma warning restore CS0618 // Type or member is obsolete

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "GET",
                           null,
                           null,
                           null);

            if (response != null)
            {
                return (ObjectExist)SerializationHelper.Deserialize(response, typeof(ObjectExist));
            }

            return null;

        }

        /// <summary>
        ///     Check if storage exists
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns>
        /// A task that represents the asynchronous operation. Task result type is  <see cref="StorageExist" />
        /// </returns>
        public async Task<StorageExist> StorageExistsAsync(StorageExistsRequest request)
        {
            // verify the required parameter 'storageName' is set
            if (request.storageName == null)
            {
                throw new ApiException(400, "Missing required parameter 'storageName' when calling StorageExists");
            }
            // create path and map variables
            string resourcePath = _configuration.GetApiRootUrl() + "/barcode/storage/{storageName}/exist";
            resourcePath = Regex
                .Replace(resourcePath, "\\*", string.Empty)
                .Replace("&amp;", "&")
                .Replace("/?", "?");
            resourcePath = UrlHelper.AddPathParameter(resourcePath, "storageName", request.storageName);

            string response = await _apiInvoker.InvokeApiAsync(
                           resourcePath,
                           "GET",
                           null,
                           null,
                           null);

            if (response != null)
            {
                return (StorageExist)SerializationHelper.Deserialize(response, typeof(StorageExist));
            }

            return null;

        }
    }
}
