using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     ScanApi interface
    /// </summary>
    public interface IScanApi
    {

        /// <summary>
        ///     Scan barcode from file in request body using POST requests with parameter in body in json or xml format.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeScanBodyPostRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> BarcodeScanBodyPostAsync(BarcodeScanBodyPostRequest request);

        /// <summary>
        ///     Scan barcode from file on server using GET requests with parameter in query string.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeScanGetRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> BarcodeScanGetAsync(BarcodeScanGetRequest request);

        /// <summary>
        ///     Scan barcode from file in request body using POST requests with parameter in multipart form.
        /// </summary>
        /// <param name="request">Request. <see cref="BarcodeScanMultipartPostRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> BarcodeScanMultipartPostAsync(BarcodeScanMultipartPostRequest request);
    }
}
