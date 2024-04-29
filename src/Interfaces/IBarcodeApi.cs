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
        ///     Generate barcode.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeGenerateRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="System.IO.Stream" />.
        /// </returns>
        Task<System.IO.Stream> GetBarcodeGenerateAsync(GetBarcodeGenerateRequest request);

        /// <summary>
        ///     Recognize barcode from a file on server.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeRecognizeRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> GetBarcodeRecognizeAsync(GetBarcodeRecognizeRequest request);

        /// <summary>
        ///     Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image with content-type \&quot;application/octet-stream\&quot;. An image can also be passed as a form field.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBarcodeRecognizeFromUrlOrContentRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> PostBarcodeRecognizeFromUrlOrContentAsync(PostBarcodeRecognizeFromUrlOrContentRequest request);

        /// <summary>
        ///     Generate multiple barcodes and return in response stream
        /// </summary>
        /// <param name="request">Request. <see cref="PostGenerateMultipleRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="System.IO.Stream" />.
        /// </returns>
        Task<System.IO.Stream> PostGenerateMultipleAsync(PostGenerateMultipleRequest request);

        /// <summary>
        ///     Generate barcode and save on server (from query params or from file with json or xml content)
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeGenerateFileRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="ResultImageInfo" />.
        /// </returns>
        Task<ResultImageInfo> PutBarcodeGenerateFileAsync(PutBarcodeGenerateFileRequest request);

        /// <summary>
        ///     Recognition of a barcode from file on server with parameters in body.
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeRecognizeFromBodyRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> PutBarcodeRecognizeFromBodyAsync(PutBarcodeRecognizeFromBodyRequest request);

        /// <summary>
        ///     Generate image with multiple barcodes and put new file on server
        /// </summary>
        /// <param name="request">Request. <see cref="PutGenerateMultipleRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="ResultImageInfo" />.
        /// </returns>
        Task<ResultImageInfo> PutGenerateMultipleAsync(PutGenerateMultipleRequest request);

        /// <summary>
        ///     Quickly scan a barcode from an image.
        /// </summary>
        /// <param name="request">Request. <see cref="ScanBarcodeRequest" /></param>
        /// <returns>
        ///     A task representing the asynchronous operation. The result is a <see cref="BarcodeResponseList" />.
        /// </returns>
        Task<BarcodeResponseList> ScanBarcodeAsync(ScanBarcodeRequest request);
    }
}
