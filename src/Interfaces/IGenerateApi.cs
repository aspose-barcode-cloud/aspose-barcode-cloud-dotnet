using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Model;


namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    /// <summary>
    ///     GenerateApi interface
    /// </summary>
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IGenerateApi
    {
        /// <summary>
        /// Generate barcode using GET request with parameters in route and query string.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType">Type of barcode to generate.</param>
        /// <param name="data">String represents data to encode</param>
        /// <param name="dataType">Type of data to encode. Default value: StringData.</param>
        /// <param name="imageFormat">Barcode output image format. Default value: png</param>
        /// <param name="textLocation">Specify the displaying Text Location, set to CodeLocation.None to hide CodeText. Default value: Depends on BarcodeType. CodeLocation.Below for 1D Barcodes. CodeLocation.None for 2D Barcodes.</param>
        /// <param name="foregroundColor">Specify the displaying bars and content Color. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: Black.</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: White.</param>
        /// <param name="units">Common Units for all measuring in query. Default units: pixel.</param>
        /// <param name="resolution">Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is dot.</param>
        /// <param name="imageHeight">Height of the barcode image in given units. Default units: pixel. Decimal separator is dot.</param>
        /// <param name="imageWidth">Width of the barcode image in given units. Default units: pixel. Decimal separator is dot.</param>
        /// <param name="rotationAngle">BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate barcode using POST request with parameters in body in json or xml format.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="generateParams">Parameters of generation</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateBodyAsync(GenerateParams generateParams, System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Generate barcode using POST request with parameters in multipart form.
        /// </summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <exception cref="Aspose.BarCode.Cloud.Sdk.Api.ApiException">Thrown when fails to make API call</exception>
        /// <param name="barcodeType"></param>
        /// <param name="data">String represents data to encode</param>
        /// <param name="dataType"></param>
        /// <param name="imageFormat"></param>
        /// <param name="textLocation"></param>
        /// <param name="foregroundColor">Specify the displaying bars and content Color. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: Black.</param>
        /// <param name="backgroundColor">Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: White.</param>
        /// <param name="units"></param>
        /// <param name="resolution">Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is dot.</param>
        /// <param name="imageHeight">Height of the barcode image in given units. Default units: pixel. Decimal separator is dot.</param>
        /// <param name="imageWidth">Width of the barcode image in given units. Default units: pixel. Decimal separator is dot.</param>
        /// <param name="rotationAngle">BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0.</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of System.IO.Stream</returns>
        Task<System.IO.Stream> GenerateMultipartAsync(EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = default, BarcodeImageFormat? imageFormat = default, CodeLocation? textLocation = default, string foregroundColor = default, string backgroundColor = default, GraphicsUnit? units = default, float? resolution = default, float? imageHeight = default, float? imageWidth = default, int? rotationAngle = default, System.Threading.CancellationToken cancellationToken = default);
    }
}
