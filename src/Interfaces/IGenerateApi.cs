using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     GenerateApi interface
    /// </summary>
    public interface IGenerateApi
    {

        /// <summary>
        ///     Generate barcode using GET request with parameters in route and query string.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeGenerateBarcodeTypeGetRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="System.IO.Stream" />.
        /// </returns>
        Task<System.IO.Stream> BarcodeGenerateBarcodeTypeGetAsync(BarcodeGenerateBarcodeTypeGetRequest request);

        /// <summary>
        ///     Generate barcode using POST request with parameters in body in json or xml format.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeGenerateBodyPostRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="System.IO.Stream" />.
        /// </returns>
        Task<System.IO.Stream> BarcodeGenerateBodyPostAsync(BarcodeGenerateBodyPostRequest request);

        /// <summary>
        ///     Generate barcode using POST request with parameters in url ecncoded form.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeGenerateFormPostRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="System.IO.Stream" />.
        /// </returns>
        Task<System.IO.Stream> BarcodeGenerateFormPostAsync(BarcodeGenerateFormPostRequest request);
    }
}
