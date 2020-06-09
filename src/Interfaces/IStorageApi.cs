using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    public interface IStorageApi
    {
        /// <summary>
        ///     Get disc usage
        /// </summary>
        /// <param name="request">Request. <see cref="GetDiscUsageRequest" /></param>
        /// <returns>
        ///     <see cref="DiscUsage" />
        /// </returns>
        DiscUsage GetDiscUsage(GetDiscUsageRequest request);

        /// <summary>
        ///     Get file versions
        /// </summary>
        /// <param name="request">Request. <see cref="GetFileVersionsRequest" /></param>
        /// <returns>
        ///     <see cref="FileVersions" />
        /// </returns>
        FileVersions GetFileVersions(GetFileVersionsRequest request);

        /// <summary>
        ///     Check if file or folder exists
        /// </summary>
        /// <param name="request">Request. <see cref="ObjectExistsRequest" /></param>
        /// <returns>
        ///     <see cref="ObjectExist" />
        /// </returns>
        ObjectExist ObjectExists(ObjectExistsRequest request);

        /// <summary>
        ///     Check if storage exists
        /// </summary>
        /// <param name="request">Request. <see cref="StorageExistsRequest" /></param>
        /// <returns>
        ///     <see cref="StorageExist" />
        /// </returns>
        StorageExist StorageExists(StorageExistsRequest request);
    }
}
