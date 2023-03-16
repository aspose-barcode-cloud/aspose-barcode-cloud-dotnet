using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    /// FolderApi interface
    /// </summary>
    public interface IFolderApi
    {
        /// <summary>
        ///     Copy folder
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        void CopyFolder(CopyFolderRequest request);

        /// <summary>
        ///     Create the folder
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        void CreateFolder(CreateFolderRequest request);

        /// <summary>
        ///     Delete folder
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        void DeleteFolder(DeleteFolderRequest request);

        /// <summary>
        ///     Get all files and folders within a folder
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns>
        ///     <see cref="FilesList" />
        /// </returns>
        FilesList GetFilesList(GetFilesListRequest request);

        /// <summary>
        ///     Move folder
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        void MoveFolder(MoveFolderRequest request);
    }
}
