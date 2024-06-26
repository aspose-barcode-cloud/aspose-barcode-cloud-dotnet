
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     PDF417 parameters.
    /// </summary>
    public class Pdf417Params : IToString
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
        ///     DEPRECATED: This property is obsolete and will be removed in future releases. See samples of using new parameters on https://releases.aspose.com/barcode/net/release-notes/2023/aspose-barcode-for-net-23-10-release-notes/ Function codeword for Code 128 emulation. Applied for MicroPDF417 only. Ignored for PDF417 and MacroPDF417 barcodes.
        /// </summary>
        [System.Obsolete("This property is obsolete and will be removed in future releases. See samples of using new parameters on https://releases.aspose.com/barcode/net/release-notes/2023/aspose-barcode-for-net-23-10-release-notes/ Function codeword for Code 128 emulation. Applied for MicroPDF417 only. Ignored for PDF417 and MacroPDF417 barcodes.", false)]
        public Code128Emulation? Code128Emulation { get; set; }

        /// <summary>
        ///     Used to tell the encoder whether to add Macro PDF417 Terminator (codeword 922) to the segment. Applied only for Macro PDF417.
        /// </summary>
        public Pdf417MacroTerminator? Pdf417MacroTerminator { get; set; }

        /// <summary>
        ///     Macro Characters 05 and 06 values are used to obtain more compact encoding in special modes. Can be used only with MicroPdf417 and encodes 916 and 917 MicroPdf417 modes. Default value: MacroCharacters.None.
        /// </summary>
        public MacroCharacter? MacroCharacters { get; set; }

        /// <summary>
        ///     Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.
        /// </summary>
        [System.Obsolete("This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.", false)]
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
        ///     Can be used only with MicroPdf417 and encodes Code 128 emulation modes. Can encode FNC1 in second position modes 908 and 909, also can encode 910 and 911 which just indicate that recognized MicroPdf417 can be interpret as Code 128.
        /// </summary>
        public bool? IsCode128Emulation { get; set; }

        /// <summary>
        ///     Defines linked modes with GS1MicroPdf417, MicroPdf417 and Pdf417 barcodes. With GS1MicroPdf417 symbology encodes 906, 907, 912, 913, 914, 915 “Linked” UCC/EAN-128 modes. With MicroPdf417 and Pdf417 symbologies encodes 918 linkage flag to associated linear component other than an EAN.UCC.
        /// </summary>
        public bool? IsLinked { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return _srcString ?? SerializationHelper.Serialize(this);
        }

        private string _srcString;
        /// <summary>
        ///   Set the string presentation of the object
        /// </summary>
        public void SetSrcString(string value)
        {
            _srcString = value;
        }
    }
}
