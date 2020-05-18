using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    public interface IFileApi
    {
        /// <summary>
        /// Copy file
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFileRequest" /></param>
        /// <returns><see cref=""/></returns>
        void CopyFile(CopyFileRequest request);

        /// <summary>
        /// Delete file
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFileRequest" /></param>
        /// <returns><see cref=""/></returns>
        void DeleteFile(DeleteFileRequest request);

        /// <summary>
        /// Download file
        /// </summary>
        /// <param name="request">Request. <see cref="DownloadFileRequest" /></param>
        /// <returns><see cref="System.IO.Stream"/></returns>
        System.IO.Stream DownloadFile(DownloadFileRequest request);

        /// <summary>
        /// Move file
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFileRequest" /></param>
        /// <returns><see cref=""/></returns>
        void MoveFile(MoveFileRequest request);

        /// <summary>
        /// Upload file
        /// </summary>
        /// <param name="request">Request. <see cref="UploadFileRequest" /></param>
        /// <returns><see cref="FilesUploadResult"/></returns>
        FilesUploadResult UploadFile(UploadFileRequest request);
    }
}
