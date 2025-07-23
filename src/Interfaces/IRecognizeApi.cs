using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;


namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     RecognizeApi interface
    /// </summary>
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IRecognizeApi
    {
        /// <summary>
        /// Recognize barcode from file on server in the Internet using GET requests with parameter in query string. For recognizing files from your hard drive use &#x60;recognize-body&#x60; or &#x60;recognize-multipart&#x60; endpoints instead.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType">Type of barcode to recognize</param>
        /// <param name="fileUrl">Url to barcode image</param>
        /// <param name="recognitionMode">Recognition mode</param>
        /// <param name="recognitionImageKind">Image kind for recognition</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> RecognizeAsync(DecodeBarcodeType barcodeType, string fileUrl, RecognitionMode? recognitionMode = default, RecognitionImageKind? recognitionImageKind = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="recognizeBase64Request">Barcode recognition request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> RecognizeBase64Async(RecognizeBase64Request recognizeBase64Request, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Recognize barcode from file in request body using POST requests with parameters in multipart form.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType"></param>
        /// <param name="file">Barcode image file</param>
        /// <param name="recognitionMode"></param>
        /// <param name="recognitionImageKind"></param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of BarcodeResponseList</returns>
        Task<BarcodeResponseList> RecognizeMultipartAsync(DecodeBarcodeType barcodeType, System.IO.Stream file, RecognitionMode? recognitionMode = default, RecognitionImageKind? recognitionImageKind = default, System.Threading.CancellationToken cancellationToken = default);
    }
}
