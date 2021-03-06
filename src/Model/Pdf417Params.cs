// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Pdf417Params.cs">
//   Copyright (c) 2021 Aspose.BarCode for Cloud
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

//
// This source code was auto-generated by AsposeBarcodeCloudCodegen.
//

using System;
using System.Collections.Generic;
using System.Text;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     PDF417 parameters.
    /// </summary>
    public class Pdf417Params
    {
        /// <summary>
        ///     Pdf417 symbology type of BarCode&#39;s compaction mode. Default value: Pdf417CompactionMode.Auto.
        /// </summary>
        public Pdf417CompactionMode? CompactionMode { get; set; }

        /// <summary>
        ///     Pdf417 symbology type of BarCode&#39;s error correction level ranging from level0 to level8, level0 means no error correction info, level8 means best error correction which means a larger picture.
        /// </summary>
        public Pdf417ErrorLevel? ErrorLevel { get; set; }

        /// <summary>
        ///     Extended Channel Interpretation Identifiers. It is used to tell the barcode reader details about the used references for encoding the data in the symbol. Current implementation consists all well known charset encodings.
        /// </summary>
        public ECIEncodings? Pdf417ECIEncoding { get; set; }

        /// <summary>
        ///     Extended Channel Interpretation Identifiers. Applies for Macro PDF417 text fields.
        /// </summary>
        public ECIEncodings? MacroECIEncoding { get; set; }

        /// <summary>
        ///     Function codeword for Code 128 emulation. Applied for MicroPDF417 only. Ignored for PDF417 and MacroPDF417 barcodes.
        /// </summary>
        public Code128Emulation? Code128Emulation { get; set; }

        /// <summary>
        ///     Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     Encoding of codetext.
        /// </summary>
        public string TextEncoding { get; set; }

        /// <summary>
        ///     Columns count.
        /// </summary>
        public int? Columns { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode's file ID. Used for MacroPdf417.
        /// </summary>
        public int? MacroFileID { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode's segment ID, which starts from 0, to MacroSegmentsCount - 1.
        /// </summary>
        public int? MacroSegmentID { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode segments count.
        /// </summary>
        public int? MacroSegmentsCount { get; set; }

        /// <summary>
        ///     Rows count.
        /// </summary>
        public int? Rows { get; set; }

        /// <summary>
        ///     Whether Pdf417 symbology type of BarCode is truncated (to reduce space).
        /// </summary>
        public bool? Truncate { get; set; }

        /// <summary>
        ///     Used to instruct the reader to interpret the data contained within the symbol as programming for reader initialization
        /// </summary>
        public bool? IsReaderInitialization { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode time stamp
        /// </summary>
        public DateTime? MacroTimeStamp { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode sender name
        /// </summary>
        public string MacroSender { get; set; }

        /// <summary>
        ///     Macro Pdf417 file size. The file size field contains the size in bytes of the entire source file
        /// </summary>
        public int? MacroFileSize { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode checksum. The checksum field contains the value of the 16-bit (2 bytes) CRC checksum using the CCITT-16 polynomial
        /// </summary>
        public int? MacroChecksum { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode file name
        /// </summary>
        public string MacroFileName { get; set; }

        /// <summary>
        ///     Macro Pdf417 barcode addressee name
        /// </summary>
        public string MacroAddressee { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Pdf417Params {\n");
            sb.Append("  AspectRatio: ").Append(AspectRatio).Append("\n");
            sb.Append("  TextEncoding: ").Append(TextEncoding).Append("\n");
            sb.Append("  Columns: ").Append(Columns).Append("\n");
            sb.Append("  CompactionMode: ").Append(CompactionMode).Append("\n");
            sb.Append("  ErrorLevel: ").Append(ErrorLevel).Append("\n");
            sb.Append("  MacroFileID: ").Append(MacroFileID).Append("\n");
            sb.Append("  MacroSegmentID: ").Append(MacroSegmentID).Append("\n");
            sb.Append("  MacroSegmentsCount: ").Append(MacroSegmentsCount).Append("\n");
            sb.Append("  Rows: ").Append(Rows).Append("\n");
            sb.Append("  Truncate: ").Append(Truncate).Append("\n");
            sb.Append("  Pdf417ECIEncoding: ").Append(Pdf417ECIEncoding).Append("\n");
            sb.Append("  IsReaderInitialization: ").Append(IsReaderInitialization).Append("\n");
            sb.Append("  MacroTimeStamp: ").Append(MacroTimeStamp).Append("\n");
            sb.Append("  MacroSender: ").Append(MacroSender).Append("\n");
            sb.Append("  MacroFileSize: ").Append(MacroFileSize).Append("\n");
            sb.Append("  MacroChecksum: ").Append(MacroChecksum).Append("\n");
            sb.Append("  MacroFileName: ").Append(MacroFileName).Append("\n");
            sb.Append("  MacroAddressee: ").Append(MacroAddressee).Append("\n");
            sb.Append("  MacroECIEncoding: ").Append(MacroECIEncoding).Append("\n");
            sb.Append("  Code128Emulation: ").Append(Code128Emulation).Append("\n");
            sb.Append("}\n");

            return sb.ToString();
        }
    }
}
