// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PostBarcodeRecognizeFromUrlOrContentRequest.cs">
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

namespace Aspose.BarCode.Cloud.Sdk.Model.Requests
{
    /// <summary>
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarcodeApi.PostBarcodeRecognizeFromUrlOrContentAsync" /> operation.
    /// </summary>
    public class PostBarcodeRecognizeFromUrlOrContentRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PostBarcodeRecognizeFromUrlOrContentRequest"/> class.
        /// </summary>
        public PostBarcodeRecognizeFromUrlOrContentRequest(System.IO.Stream image = null)
        {
            this.image = image;
        }

        /// <summary>
        ///     The type of barcode to read.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///     Multiple barcode types to read.
        /// </summary>
        public List<DecodeBarcodeType> Types { get; set; }

        /// <summary>
        ///     Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies
        /// </summary>
        public string ChecksumValidation { get; set; }

        /// <summary>
        ///     A flag which force engine to detect codetext encoding for Unicode.
        /// </summary>
        public bool? DetectEncoding { get; set; }

        /// <summary>
        ///     Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality.
        /// </summary>
        public string Preset { get; set; }

        /// <summary>
        ///     Set X of top left corner of area for recognition.
        /// </summary>
        public int? RectX { get; set; }

        /// <summary>
        ///     Set Y of top left corner of area for recognition.
        /// </summary>
        public int? RectY { get; set; }

        /// <summary>
        ///     Set Width of area for recognition.
        /// </summary>
        public int? RectWidth { get; set; }

        /// <summary>
        ///     Set Height of area for recognition.
        /// </summary>
        public int? RectHeight { get; set; }

        /// <summary>
        ///     Value indicating whether FNC symbol strip must be done.
        /// </summary>
        public bool? StripFNC { get; set; }

        /// <summary>
        ///     Timeout of recognition process in milliseconds. Default value is 15_000 (15 seconds). Maximum value is 30_000 (1/2 minute). In case of a timeout RequestTimeout (408) status will be returned. Try reducing the image size to avoid timeout.
        /// </summary>
        public int? Timeout { get; set; }

        /// <summary>
        ///     Window size for median smoothing. Typical values are 3 or 4. Default value is 3. AllowMedianSmoothing must be set.
        /// </summary>
        public int? MedianSmoothingWindowSize { get; set; }

        /// <summary>
        ///     Allows engine to enable median smoothing as additional scan. Mode helps to recognize noised barcodes.
        /// </summary>
        public bool? AllowMedianSmoothing { get; set; }

        /// <summary>
        ///     Allows engine to recognize color barcodes on color background as additional scan. Extremely slow mode.
        /// </summary>
        public bool? AllowComplexBackground { get; set; }

        /// <summary>
        ///     Allows engine for Datamatrix to recognize dashed industrial Datamatrix barcodes. Slow mode which helps only for dashed barcodes which consist from spots.
        /// </summary>
        public bool? AllowDatamatrixIndustrialBarcodes { get; set; }

        /// <summary>
        ///     Allows engine to recognize decreased image as additional scan. Size for decreasing is selected by internal engine algorithms. Mode helps to recognize barcodes which are noised and blurred but captured with high resolution.
        /// </summary>
        public bool? AllowDecreasedImage { get; set; }

        /// <summary>
        ///     Allows engine to use gap between scans to increase recognition speed. Mode can make recognition problems with low height barcodes.
        /// </summary>
        public bool? AllowDetectScanGap { get; set; }

        /// <summary>
        ///     Allows engine to recognize barcodes which has incorrect checksum or incorrect values. Mode can be used to recognize damaged barcodes with incorrect text.
        /// </summary>
        public bool? AllowIncorrectBarcodes { get; set; }

        /// <summary>
        ///     Allows engine to recognize inverse color image as additional scan. Mode can be used when barcode is white on black background.
        /// </summary>
        public bool? AllowInvertImage { get; set; }

        /// <summary>
        ///     Allows engine for Postal barcodes to recognize slightly noised images. Mode helps to recognize slightly damaged Postal barcodes.
        /// </summary>
        public bool? AllowMicroWhiteSpotsRemoving { get; set; }

        /// <summary>
        ///     Allows engine for 1D barcodes to quickly recognize high quality barcodes which fill almost whole image. Mode helps to quickly recognize generated barcodes from Internet.
        /// </summary>
        public bool? AllowOneDFastBarcodesDetector { get; set; }

        /// <summary>
        ///     Allows engine for 1D barcodes to recognize barcodes with single wiped/glued bars in pattern.
        /// </summary>
        public bool? AllowOneDWipedBarsRestoration { get; set; }

        /// <summary>
        ///     Allows engine for QR/MicroQR to recognize damaged MicroQR barcodes.
        /// </summary>
        public bool? AllowQRMicroQrRestoration { get; set; }

        /// <summary>
        ///     Allows engine to recognize regular image without any restorations as main scan. Mode to recognize image as is.
        /// </summary>
        public bool? AllowRegularImage { get; set; }

        /// <summary>
        ///     Allows engine to recognize barcodes with salt and pepper noise type. Mode can remove small noise with white and black dots.
        /// </summary>
        public bool? AllowSaltAndPepperFiltering { get; set; }

        /// <summary>
        ///     Allows engine to recognize image without small white spots as additional scan. Mode helps to recognize noised image as well as median smoothing filtering.
        /// </summary>
        public bool? AllowWhiteSpotsRemoving { get; set; }

        /// <summary>
        ///     Allows engine to recognize 1D barcodes with checksum by checking more recognition variants. Default value: False.
        /// </summary>
        public bool? CheckMore1DVariants { get; set; }

        /// <summary>
        ///     Allows engine for 1D barcodes to quickly recognize middle slice of an image and return result without using any time-consuming algorithms. Default value: False.
        /// </summary>
        public bool? FastScanOnly { get; set; }

        /// <summary>
        ///     Allows engine using additional image restorations to recognize corrupted barcodes. At this time, it is used only in MicroPdf417 barcode type. Default value: False.
        /// </summary>
        public bool? AllowAdditionalRestorations { get; set; }

        /// <summary>
        ///     Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time.
        /// </summary>
        public double? RegionLikelihoodThresholdPercent { get; set; }

        /// <summary>
        ///     Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality.
        /// </summary>
        public List<int?> ScanWindowSizes { get; set; }

        /// <summary>
        ///     Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9]
        /// </summary>
        public double? Similarity { get; set; }

        /// <summary>
        ///     Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time.
        /// </summary>
        public bool? SkipDiagonalSearch { get; set; }

        /// <summary>
        ///     Allows engine to recognize tiny barcodes on large images. Ignored if AllowIncorrectBarcodes is set to True. Default value: False.
        /// </summary>
        public bool? ReadTinyBarcodes { get; set; }

        /// <summary>
        ///     Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other.
        /// </summary>
        public string AustralianPostEncodingTable { get; set; }

        /// <summary>
        ///     The flag which force AustraliaPost decoder to ignore last filling patterns in Customer Information Field during decoding as CTable method. CTable encoding method does not have any gaps in encoding table and sequence \"333\" of filling patterns is decoded as letter \"z\".
        /// </summary>
        public bool? IgnoreEndingFillingPatternsForCTable { get; set; }

        /// <summary>
        ///     The image file url.
        /// </summary>
        public string url { get; set; }

        /// <summary>
        ///     Image data
        /// </summary>
        public System.IO.Stream image { get; set; }
    }
}
