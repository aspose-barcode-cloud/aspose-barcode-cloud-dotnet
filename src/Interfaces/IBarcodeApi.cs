using System.IO;
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
        ///     <see cref="System.IO.Stream" />
        /// </returns>
        Stream GetBarcodeGenerate(GetBarcodeGenerateRequest request);

        /// <summary>
        ///     Recognize barcode from a file on server.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeRecognizeRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        BarcodeResponseList GetBarcodeRecognize(GetBarcodeRecognizeRequest request);

        /// <summary>
        ///     Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image or encoded
        ///     with base64.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBarcodeRecognizeFromUrlOrContentRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        BarcodeResponseList PostBarcodeRecognizeFromUrlOrContent(PostBarcodeRecognizeFromUrlOrContentRequest request);

        /// <summary>
        ///     Generate multiple barcodes and return in response stream
        /// </summary>
        /// <param name="request">Request. <see cref="PostGenerateMultipleRequest" /></param>
        /// <returns>
        ///     <see cref="System.IO.Stream" />
        /// </returns>
        Stream PostGenerateMultiple(PostGenerateMultipleRequest request);

        /// <summary>
        ///     Generate barcode and save on server (from query params or from file with json or xml content)
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeGenerateFileRequest" /></param>
        /// <returns>
        ///     <see cref="ResultImageInfo" />
        /// </returns>
        ResultImageInfo PutBarcodeGenerateFile(PutBarcodeGenerateFileRequest request);

        /// <summary>
        ///     Recognition of a barcode from file on server with parameters in body.
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeRecognizeFromBodyRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        BarcodeResponseList PutBarcodeRecognizeFromBody(PutBarcodeRecognizeFromBodyRequest request);

        /// <summary>
        ///     Generate image with multiple barcodes and put new file on server
        /// </summary>
        /// <param name="request">Request. <see cref="PutGenerateMultipleRequest" /></param>
        /// <returns>
        ///     <see cref="ResultImageInfo" />
        /// </returns>
        ResultImageInfo PutGenerateMultiple(PutGenerateMultipleRequest request);
    }
}
