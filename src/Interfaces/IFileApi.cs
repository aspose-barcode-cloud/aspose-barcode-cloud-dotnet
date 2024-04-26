using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     FileApi interface
    /// </summary>
    public interface IFileApi
    {

        /// <summary>
        ///     Copy file
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation.
        /// </returns>
        Task CopyFileAsync(CopyFileRequest request);

        /// <summary>
        ///     Delete file
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation.
        /// </returns>
        Task DeleteFileAsync(DeleteFileRequest request);

        /// <summary>
        ///     Download file
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="System.IO.Stream" />.
        /// </returns>
        Task<System.IO.Stream> DownloadFileAsync(DownloadFileRequest request);

        /// <summary>
        ///     Move file
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation.
        /// </returns>
        Task MoveFileAsync(MoveFileRequest request);

        /// <summary>
        ///     Upload file
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="FilesUploadResult" />.
        /// </returns>
        Task<FilesUploadResult> UploadFileAsync(UploadFileRequest request);
    }
}
