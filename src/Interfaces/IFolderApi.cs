using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    public interface IFolderApi
    {
        /// <summary>
        ///     Copy folder
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        /// <returns>
        ///     <see cref="" />
        /// </returns>
        void CopyFolder(CopyFolderRequest request);

        /// <summary>
        ///     Create the folder
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        /// <returns>
        ///     <see cref="" />
        /// </returns>
        void CreateFolder(CreateFolderRequest request);

        /// <summary>
        ///     Delete folder
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        /// <returns>
        ///     <see cref="" />
        /// </returns>
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
        /// <returns>
        ///     <see cref="" />
        /// </returns>
        void MoveFolder(MoveFolderRequest request);
    }
}
