using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     StorageApi interface
    /// </summary>
    public interface IStorageApi
    {

        /// <summary>
        ///     Get disc usage
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="DiscUsage" />.
        /// </returns>
        Task<DiscUsage> GetDiscUsageAsync(GetDiscUsageRequest request);

        /// <summary>
        ///     Get file versions
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="FileVersions" />.
        /// </returns>
        Task<FileVersions> GetFileVersionsAsync(GetFileVersionsRequest request);

        /// <summary>
        ///     Check if file or folder exists
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="ObjectExist" />.
        /// </returns>
        Task<ObjectExist> ObjectExistsAsync(ObjectExistsRequest request);

        /// <summary>
        ///     Check if storage exists
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="StorageExist" />.
        /// </returns>
        Task<StorageExist> StorageExistsAsync(StorageExistsRequest request);
    }
}
