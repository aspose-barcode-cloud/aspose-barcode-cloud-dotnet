// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarcodeGenerateMultipartPostRequest.cs">
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
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.GenerateApi.BarcodeGenerateMultipartPostAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class BarcodeGenerateMultipartPostRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BarcodeGenerateMultipartPostRequest"/> class.
        /// </summary>
        /// <param name="barcodeType"></param>
        /// <param name="data">String represents data to encode</param>
        public BarcodeGenerateMultipartPostRequest(EncodeBarcodeType barcodeType, string data)
        {
            this.BarcodeType = barcodeType;
            this.Data = data;
        }

        /// <summary>
        ///     Gets or sets BarcodeType
        /// </summary>
        public EncodeBarcodeType BarcodeType { get; set; }

        /// <summary>
        ///     String represents data to encode
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        ///     Gets or sets DataType
        /// </summary>
        public EncodeDataType? DataType { get; set; }

        /// <summary>
        ///     Gets or sets ImageFormat
        /// </summary>
        public BarcodeImageFormat? ImageFormat { get; set; }

        /// <summary>
        ///     Gets or sets TextLocation
        /// </summary>
        public CodeLocation? TextLocation { get; set; }

        /// <summary>
        ///     Specify the displaying bars and content Color.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.  For example: AliceBlue or #FF000000  Default value: Black.
        /// </summary>
        public string ForegroundColor { get; set; }

        /// <summary>
        ///     Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.  For example: AliceBlue or #FF000000  Default value: White.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     Gets or sets Units
        /// </summary>
        public GraphicsUnit? Units { get; set; }

        /// <summary>
        ///     Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi.  Decimal separator is dot.
        /// </summary>
        public float? Resolution { get; set; }

        /// <summary>
        ///     Height of the barcode image in given units. Default units: pixel.  Decimal separator is dot.
        /// </summary>
        public float? ImageHeight { get; set; }

        /// <summary>
        ///     Width of the barcode image in given units. Default units: pixel.  Decimal separator is dot.
        /// </summary>
        public float? ImageWidth { get; set; }

        /// <summary>
        ///     BarCode image rotation angle, measured in degree, e.g. RotationAngle = 0 or RotationAngle = 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0.
        /// </summary>
        public int? RotationAngle { get; set; }
    }
}

