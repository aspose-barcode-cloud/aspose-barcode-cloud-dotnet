// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarcodeGenerateBarcodeTypeGetRequest.cs">
//   Copyright (c) 2024 Aspose.BarCode for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Aspose.BarCode.Cloud.Sdk.Model.Requests
{
    /// <summary>
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.GenerateApi.BarcodeGenerateBarcodeTypeGetAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class BarcodeGenerateBarcodeTypeGetRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BarcodeGenerateBarcodeTypeGetRequest"/> class.
        /// </summary>
        /// <param name="barcodeType">Type of barcode to generate.</param>
        /// <param name="dataType">Type of data to encode.</param>
        /// <param name="data">String represents data to encode</param>
        public BarcodeGenerateBarcodeTypeGetRequest(EncodeBarcodeType barcodeType, EncodeDataType dataType, string data)
        {
            this.BarcodeType = barcodeType;
            this.DataType = dataType;
            this.Data = data;
        }

        /// <summary>
        ///     Type of barcode to generate.
        /// </summary>
        public EncodeBarcodeType BarcodeType { get; set; }

        /// <summary>
        ///     Type of data to encode.
        /// </summary>
        public EncodeDataType DataType { get; set; }

        /// <summary>
        ///     String represents data to encode
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        ///     Barcode output image format.  Default value: png
        /// </summary>
        public AvailableBarCodeImageFormat? ImageFormat { get; set; }

        /// <summary>
        ///     Text that will be displayed instead of codetext in 2D barcodes.  Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode
        /// </summary>
        public string TwoDDisplayText { get; set; }

        /// <summary>
        ///     Specify the displaying Text Location, set to CodeLocation.None to hide CodeText.  Default value: CodeLocation.Below.
        /// </summary>
        public CodeLocation? TextLocation { get; set; }

        /// <summary>
        ///     Text alignment.  Default value: TextAligment.Left
        /// </summary>
        public TextAlignment? TextAlignment { get; set; }

        /// <summary>
        ///     Specify the displaying bars and content Color.   Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.Black.
        /// </summary>
        public string ForegroundColor { get; set; }

        /// <summary>
        ///     Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.White.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     Common Units for all measuring in query. Default units: pixel.
        /// </summary>
        public AvailableGraphicsUnit? Units { get; set; }

        /// <summary>
        ///     Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi.
        /// </summary>
        public float? Resolution { get; set; }

        /// <summary>
        ///     Height of the barcode image in given units. Default units: pixel.
        /// </summary>
        public float? ImageHeight { get; set; }

        /// <summary>
        ///     Width of the barcode image in given units. Default units: pixel.
        /// </summary>
        public float? ImageWidth { get; set; }

        /// <summary>
        ///     BarCode image rotation angle, measured in degree, e.g. RotationAngle = 0 or RotationAngle = 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0.
        /// </summary>
        public int? RotationAngle { get; set; }
    }
}
