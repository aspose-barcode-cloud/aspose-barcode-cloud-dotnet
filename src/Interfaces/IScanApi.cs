using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;


namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     ScanApi interface
    /// </summary>
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IScanApi
    {
        /// <summary>
        /// Scan barcode from file on server in the Internet using GET requests with parameter in query string. For scaning files from your hard drive use &#x60;scan-body&#x60; or &#x60;scan-multipart&#x60; endpoints instead.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fileUrl">Url to barcode image</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> ScanAsync(string fileUrl, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scan barcode from file in request body using POST requests with parameter in body in json or xml format.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scanBase64Request">Barcode scan request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> ScanBase64Async(ScanBase64Request scanBase64Request, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Scan barcode from file in request body using POST requests with parameter in multipart form.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="file">Barcode image file</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> ScanMultipartAsync(System.IO.Stream file, System.Threading.CancellationToken cancellationToken = default);
    }
}
