// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetBarcodeGenerateRequest.cs">
//   Copyright (c) 2025 Aspose.BarCode for Cloud
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
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarcodeApi.GetBarcodeGenerateAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class GetBarcodeGenerateRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetBarcodeGenerateRequest"/> class.
        /// </summary>
        /// <param name="type">Type of barcode to generate.</param>
        /// <param name="text">Text to encode.</param>
        public GetBarcodeGenerateRequest(string type, string text)
        {
            this.Type = type;
            this.Text = text;
        }

        /// <summary>
        ///     Type of barcode to generate.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///     Text to encode.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     Text that will be displayed instead of codetext in 2D barcodes. Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode
        /// </summary>
        public string TwoDDisplayText { get; set; }

        /// <summary>
        ///     Specify the displaying Text Location, set to CodeLocation.None to hide CodeText. Default value: CodeLocation.Below.
        /// </summary>
        public string TextLocation { get; set; }

        /// <summary>
        ///     Text alignment.
        /// </summary>
        public string TextAlignment { get; set; }

        /// <summary>
        ///     Specify the displaying CodeText's Color. Default value: black. Use named colors like: red, green, blue Or HTML colors like: #FF0000, #00FF00, #0000FF
        /// </summary>
        public string TextColor { get; set; }

        /// <summary>
        ///     Specify word wraps (line breaks) within text. Default value: false.
        /// </summary>
        public bool? NoWrap { get; set; }

        /// <summary>
        ///     Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi.
        /// </summary>
        public double? Resolution { get; set; }

        /// <summary>
        ///     DEPRECATED: Use 'Resolution' instead.
        /// </summary>
        [System.Obsolete("Use 'Resolution' instead.", false)]
        public double? ResolutionX { get; set; }

        /// <summary>
        ///     DEPRECATED: Use 'Resolution' instead.
        /// </summary>
        [System.Obsolete("Use 'Resolution' instead.", false)]
        public double? ResolutionY { get; set; }

        /// <summary>
        ///     The smallest width of the unit of BarCode bars or spaces. Increase this will increase the whole barcode image width. Ignored if AutoSizeMode property is set to AutoSizeMode.Nearest or AutoSizeMode.Interpolation.
        /// </summary>
        public double? DimensionX { get; set; }

        /// <summary>
        ///     Space between the CodeText and the BarCode in Unit value. Default value: 2pt. Ignored for EAN8, EAN13, UPCE, UPCA, ISBN, ISMN, ISSN, UpcaGs1DatabarCoupon.
        /// </summary>
        public double? TextSpace { get; set; }

        /// <summary>
        ///     Common Units for all measuring in query. Default units: pixel.
        /// </summary>
        public string Units { get; set; }

        /// <summary>
        ///     Specifies the different types of automatic sizing modes. Default value: AutoSizeMode.None.
        /// </summary>
        public string SizeMode { get; set; }

        /// <summary>
        ///     Height of the barcode in given units. Default units: pixel.
        /// </summary>
        public double? BarHeight { get; set; }

        /// <summary>
        ///     Height of the barcode image in given units. Default units: pixel.
        /// </summary>
        public double? ImageHeight { get; set; }

        /// <summary>
        ///     Width of the barcode image in given units. Default units: pixel.
        /// </summary>
        public double? ImageWidth { get; set; }

        /// <summary>
        ///     BarCode image rotation angle, measured in degree, e.g. RotationAngle = 0 or RotationAngle = 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0.
        /// </summary>
        public double? RotationAngle { get; set; }

        /// <summary>
        ///     Background color of the barcode image. Default value: white. Use named colors like: red, green, blue Or HTML colors like: #FF0000, #00FF00, #0000FF
        /// </summary>
        public string BackColor { get; set; }

        /// <summary>
        ///     Bars color. Default value: black. Use named colors like: red, green, blue Or HTML colors like: #FF0000, #00FF00, #0000FF
        /// </summary>
        public string BarColor { get; set; }

        /// <summary>
        ///     Border color. Default value: black. Use named colors like: red, green, blue Or HTML colors like: #FF0000, #00FF00, #0000FF
        /// </summary>
        public string BorderColor { get; set; }

        /// <summary>
        ///     Border width. Default value: 0. Ignored if Visible is set to false.
        /// </summary>
        public double? BorderWidth { get; set; }

        /// <summary>
        ///     Border dash style. Default value: BorderDashStyle.Solid.
        /// </summary>
        public string BorderDashStyle { get; set; }

        /// <summary>
        ///     Border visibility. If false than parameter Width is always ignored (0). Default value: false.
        /// </summary>
        public bool? BorderVisible { get; set; }

        /// <summary>
        ///     Enable checksum during generation 1D barcodes. Default is treated as Yes for symbology which must contain checksum, as No where checksum only possible. Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN, Codabar Checksum always used: Rest symbology
        /// </summary>
        public string EnableChecksum { get; set; }

        /// <summary>
        ///     Indicates whether explains the character \"\\\" as an escape character in CodeText property. Used for Pdf417, DataMatrix, Code128 only If the EnableEscape is true, \"\\\" will be explained as a special escape character. Otherwise, \"\\\" acts as normal characters. Aspose.BarCode supports input decimal ascii code and mnemonic for ASCII control-code characters. For example, \\013 and \\\\CR stands for CR.
        /// </summary>
        public bool? EnableEscape { get; set; }

        /// <summary>
        ///     Value indicating whether bars are filled. Only for 1D barcodes. Default value: true.
        /// </summary>
        public bool? FilledBars { get; set; }

        /// <summary>
        ///     Always display checksum digit in the human readable text for Code128 and GS1Code128 barcodes.
        /// </summary>
        public bool? AlwaysShowChecksum { get; set; }

        /// <summary>
        ///     Wide bars to Narrow bars ratio. Default value: 3, that is, wide bars are 3 times as wide as narrow bars. Used for ITF, PZN, PharmaCode, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, IATA2of5, VIN, DeutschePost, OPC, Code32, DataLogic2of5, PatchCode, Code39Extended, Code39Standard
        /// </summary>
        public double? WideNarrowRatio { get; set; }

        /// <summary>
        ///     Only for 1D barcodes. If codetext is incorrect and value set to true - exception will be thrown. Otherwise codetext will be corrected to match barcode's specification. Exception always will be thrown for: Databar symbology if codetext is incorrect. Exception always will not be thrown for: AustraliaPost, SingaporePost, Code39Extended, Code93Extended, Code16K, Code128 symbology if codetext is incorrect.
        /// </summary>
        public bool? ValidateText { get; set; }

        /// <summary>
        ///     Supplement parameters. Used for Interleaved2of5, Standard2of5, EAN13, EAN8, UPCA, UPCE, ISBN, ISSN, ISMN.
        /// </summary>
        public string SupplementData { get; set; }

        /// <summary>
        ///     Space between main the BarCode and supplement BarCode.
        /// </summary>
        public double? SupplementSpace { get; set; }

        /// <summary>
        ///     Bars reduction value that is used to compensate ink spread while printing.
        /// </summary>
        public double? BarWidthReduction { get; set; }

        /// <summary>
        ///     Indicates whether is used anti-aliasing mode to render image. Anti-aliasing mode is applied to barcode and text drawing.
        /// </summary>
        public bool? UseAntiAlias { get; set; }

        /// <summary>
        ///     Result image format.
        /// </summary>
        public string format { get; set; }
    }
}
