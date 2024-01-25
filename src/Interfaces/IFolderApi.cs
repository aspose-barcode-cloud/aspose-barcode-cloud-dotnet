using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using System.Threading.Tasks;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    /// FolderApi interface
    /// </summary>
    public interface IFolderApi
    {
        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="CopyFolderAsync" /> instead.
        ///     Copy folder
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>

        [System.Obsolete("This method is obsolete and will be removed in next releases. Use new async method \"CopyFolderAsync\" instead.")]
        void CopyFolder(CopyFolderRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="CreateFolderAsync" /> instead.
        ///     Create the folder
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>

        [System.Obsolete("This method is obsolete and will be removed in next releases. Use new async method \"CreateFolderAsync\" instead.")]
        void CreateFolder(CreateFolderRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="DeleteFolderAsync" /> instead.
        ///     Delete folder
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>

        [System.Obsolete("This method is obsolete and will be removed in next releases. Use new async method \"DeleteFolderAsync\" instead.")]
        void DeleteFolder(DeleteFolderRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="GetFilesListAsync" /> instead.
        ///     Get all files and folders within a folder
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns>
        ///     <see cref="FilesList" />
        /// </returns>
        [System.Obsolete("This method is obsolete and will be removed in next releases. Use new async method \"GetFilesListAsync\" instead.")]
        FilesList GetFilesList(GetFilesListRequest request);

        /// <summary>
        /// This method is obsolete and will be removed in next releases. Use new async method <see cref="MoveFolderAsync" /> instead.
        ///     Move folder
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>

        [System.Obsolete("This method is obsolete and will be removed in next releases. Use new async method \"MoveFolderAsync\" instead.")]
        void MoveFolder(MoveFolderRequest request);

        /// <summary>
        ///     Copy folder
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        Task CopyFolderAsync(CopyFolderRequest request);

        /// <summary>
        ///     Create the folder
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        Task CreateFolderAsync(CreateFolderRequest request);

        /// <summary>
        ///     Delete folder
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        Task DeleteFolderAsync(DeleteFolderRequest request);

        /// <summary>
        ///     Get all files and folders within a folder
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns>
        ///     <see cref="FilesList" />
        /// </returns>
        Task<FilesList> GetFilesListAsync(GetFilesListRequest request);

        /// <summary>
        ///     Move folder
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        Task MoveFolderAsync(MoveFolderRequest request);
    }
}
