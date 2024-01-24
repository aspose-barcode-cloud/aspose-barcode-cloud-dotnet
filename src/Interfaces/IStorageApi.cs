using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using System.Threading.Tasks;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     StorageApi interface
    /// </summary>
    public interface IStorageApi
    {
        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="GetDiscUsageAsync" /> instead.
        ///     Get disc usage
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns>
        ///     <see cref="DiscUsage" />
        /// </returns>
        [System.Obsolete]
        DiscUsage GetDiscUsage(GetDiscUsageRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="GetFileVersionsAsync" /> instead.
        ///     Get file versions
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns>
        ///     <see cref="FileVersions" />
        /// </returns>
        [System.Obsolete]
        FileVersions GetFileVersions(GetFileVersionsRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="ObjectExistsAsync" /> instead.
        ///     Check if file or folder exists
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns>
        ///     <see cref="ObjectExist" />
        /// </returns>
        [System.Obsolete]
        ObjectExist ObjectExists(ObjectExistsRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="StorageExistsAsync" /> instead.
        ///     Check if storage exists
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns>
        ///     <see cref="StorageExist" />
        /// </returns>
        [System.Obsolete]
        StorageExist StorageExists(StorageExistsRequest request);

        /// <summary>
        /// Get disc usage
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns><see cref="DiscUsage" /></returns>
        Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request);

        /// <summary>
        /// Get file versions
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns><see cref="FileVersions" /></returns>
        Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request);

        /// <summary>
        /// Check if file or folder exists
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns><see cref="ObjectExist" /></returns>
        Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request);

        /// <summary>
        /// Check if storage exists
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns><see cref="StorageExist" /></returns>
        Task<StorageExist> StorageExistsAsync(StorageExistsRequest request);
    }
}
