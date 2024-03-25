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
