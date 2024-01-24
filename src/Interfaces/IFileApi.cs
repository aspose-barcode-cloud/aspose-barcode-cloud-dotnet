using System.IO;
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
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="CopyFileAsync" /> instead.
        ///     Copy file
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>

        [System.Obsolete]
        void CopyFile(CopyFileRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="DeleteFileAsync" /> instead.
        ///     Delete file
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>

        [System.Obsolete]
        void DeleteFile(DeleteFileRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="DownloadFileAsync" /> instead.
        ///     Download file
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns>
        ///     <see cref="System.IO.Stream" />
        /// </returns>
        [System.Obsolete]
        Stream DownloadFile(DownloadFileRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="MoveFileAsync" /> instead.
        ///     Move file
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>

        [System.Obsolete]
        void MoveFile(MoveFileRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="UploadFileAsync" /> instead.
        ///     Upload file
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns>
        ///     <see cref="FilesUploadResult" />
        /// </returns>
        [System.Obsolete]
        FilesUploadResult UploadFile(UploadFileRequest request);

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
        ///     A task representing the asynchronous operation. The result is a <see cref="Stream" />.
        /// </returns>
        Task<Stream> DownloadFileAsync(DownloadFileRequest request);

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
