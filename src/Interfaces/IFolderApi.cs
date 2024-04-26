using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     FolderApi interface
    /// </summary>
    public interface IFolderApi
    {

        /// <summary>
        ///     Copy folder
        /// </summary>
        /// <param name="request">Request. <see cref="CopyFolderRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation.
        /// </returns>
        Task CopyFolderAsync(CopyFolderRequest request);

        /// <summary>
        ///     Create the folder
        /// </summary>
        /// <param name="request">Request. <see cref="CreateFolderRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation.
        /// </returns>
        Task CreateFolderAsync(CreateFolderRequest request);

        /// <summary>
        ///     Delete folder
        /// </summary>
        /// <param name="request">Request. <see cref="DeleteFolderRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation.
        /// </returns>
        Task DeleteFolderAsync(DeleteFolderRequest request);

        /// <summary>
        ///     Get all files and folders within a folder
        /// </summary>
        /// <param name="request">Request. <see cref="GetFilesListRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="FilesList" />.
        /// </returns>
        Task<FilesList> GetFilesListAsync(GetFilesListRequest request);

        /// <summary>
        ///     Move folder
        /// </summary>
        /// <param name="request">Request. <see cref="MoveFolderRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation.
        /// </returns>
        Task MoveFolderAsync(MoveFolderRequest request);
    }
}
