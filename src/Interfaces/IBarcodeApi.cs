using System.IO;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     BarcodeApi interface
    /// </summary>
    public interface IBarcodeApi
    {
        /// <summary>
        ///     Generate barcode asynchronously.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeGenerateRequest" /></param>
        /// <returns>
        ///     <see cref="System.IO.Stream" />
        /// </returns>
        Task<Stream> GetBarcodeGenerateAsync(GetBarcodeGenerateRequest request);

        /// <summary>
        ///     Recognize barcode from a file on server asynchronously.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeRecognizeRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        Task<BarcodeResponseList> GetBarcodeRecognizeAsync(GetBarcodeRecognizeRequest request);

        /// <summary>
        ///     Recognize barcode from an URL or from request body asynchronously. Request body can contain raw data bytes of the image or encoded with base64.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBarcodeRecognizeFromUrlOrContentRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        Task<BarcodeResponseList> PostBarcodeRecognizeFromUrlOrContentAsync(PostBarcodeRecognizeFromUrlOrContentRequest request);

        /// <summary>
        ///     Generate multiple barcodes and return in response stream asynchronously.
        /// </summary>
        /// <param name="request">Request. <see cref="PostGenerateMultipleRequest" /></param>
        /// <returns>
        ///     <see cref="System.IO.Stream" />
        /// </returns>
        Task<Stream> PostGenerateMultipleAsync(PostGenerateMultipleRequest request);

        /// <summary>
        ///     Generate barcode and save on server (from query params or from file with JSON or XML content) asynchronously.
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeGenerateFileRequest" /></param>
        /// <returns>
        ///     <see cref="ResultImageInfo" />
        /// </returns>
        Task<ResultImageInfo> PutBarcodeGenerateFileAsync(PutBarcodeGenerateFileRequest request);

        /// <summary>
        ///     Recognition of a barcode from a file on the server with parameters in the body asynchronously.
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeRecognizeFromBodyRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        Task<BarcodeResponseList> PutBarcodeRecognizeFromBodyAsync(PutBarcodeRecognizeFromBodyRequest request);

        /// <summary>
        ///     Generate image with multiple barcodes and put a new file on the server asynchronously.
        /// </summary>
        /// <param name="request">Request. <see cref="PutGenerateMultipleRequest" /></param>
        /// <returns>
        ///     <see cref="ResultImageInfo" />
        /// </returns>
        Task<ResultImageInfo> PutGenerateMultipleAsync(PutGenerateMultipleRequest request);
    }
}

