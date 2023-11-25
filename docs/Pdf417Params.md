# Aspose.BarCode.Cloud.Sdk.Model.Pdf417Params

PDF417 parameters.

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**AspectRatio** | **double?** | Height/Width ratio of 2D BarCode module. | [optional]
**TextEncoding** | **string** | DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext. | [optional]
**Columns** | **int?** | Columns count. | [optional]
**CompactionMode** | **Pdf417CompactionMode** | Pdf417 symbology type of BarCode&#39;s compaction mode. Default value: Pdf417CompactionMode.Auto. | [optional]
**ErrorLevel** | **Pdf417ErrorLevel** | Pdf417 symbology type of BarCode&#39;s error correction level ranging from level0 to level8, level0 means no error correction info, level8 means best error correction which means a larger picture. | [optional]
**MacroFileID** | **int?** | Macro Pdf417 barcode&#39;s file ID. Used for MacroPdf417. | [optional]
**MacroSegmentID** | **int?** | Macro Pdf417 barcode&#39;s segment ID, which starts from 0, to MacroSegmentsCount - 1. | [optional]
**MacroSegmentsCount** | **int?** | Macro Pdf417 barcode segments count. | [optional]
**Rows** | **int?** | Rows count. | [optional]
**Truncate** | **bool?** | Whether Pdf417 symbology type of BarCode is truncated (to reduce space). | [optional]
**Pdf417ECIEncoding** | **ECIEncodings** | Extended Channel Interpretation Identifiers. It is used to tell the barcode reader details about the used references for encoding the data in the symbol. Current implementation consists all well known charset encodings. | [optional]
**IsReaderInitialization** | **bool?** | Used to instruct the reader to interpret the data contained within the symbol as programming for reader initialization | [optional]
**MacroTimeStamp** | **DateTime?** | Macro Pdf417 barcode time stamp | [optional]
**MacroSender** | **string** | Macro Pdf417 barcode sender name | [optional]
**MacroFileSize** | **int?** | Macro Pdf417 file size. The file size field contains the size in bytes of the entire source file | [optional]
**MacroChecksum** | **int?** | Macro Pdf417 barcode checksum. The checksum field contains the value of the 16-bit (2 bytes) CRC checksum using the CCITT-16 polynomial | [optional]
**MacroFileName** | **string** | Macro Pdf417 barcode file name | [optional]
**MacroAddressee** | **string** | Macro Pdf417 barcode addressee name | [optional]
**MacroECIEncoding** | **ECIEncodings** | Extended Channel Interpretation Identifiers. Applies for Macro PDF417 text fields. | [optional]
**Code128Emulation** | **Code128Emulation** | DEPRECATED: This property is obsolete and will be removed in future releases. See samples of using new parameters on https://releases.aspose.com/barcode/net/release-notes/2023/aspose-barcode-for-net-23-10-release-notes/ Function codeword for Code 128 emulation. Applied for MicroPDF417 only. Ignored for PDF417 and MacroPDF417 barcodes. | [optional]
**IsCode128Emulation** | **bool?** | Can be used only with MicroPdf417 and encodes Code 128 emulation modes. Can encode FNC1 in second position modes 908 and 909, also can encode 910 and 911 which just indicate that recognized MicroPdf417 can be interpret as Code 128. | [optional]
**Pdf417MacroTerminator** | **Pdf417MacroTerminator** | Used to tell the encoder whether to add Macro PDF417 Terminator (codeword 922) to the segment. Applied only for Macro PDF417. | [optional]
**IsLinked** | **bool?** | Defines linked modes with GS1MicroPdf417, MicroPdf417 and Pdf417 barcodes. With GS1MicroPdf417 symbology encodes 906, 907, 912, 913, 914, 915 “Linked” UCC/EAN-128 modes. With MicroPdf417 and Pdf417 symbologies encodes 918 linkage flag to associated linear component other than an EAN.UCC. | [optional]
**MacroCharacters** | **MacroCharacter** | Macro Characters 05 and 06 values are used to obtain more compact encoding in special modes. Can be used only with MicroPdf417 and encodes 916 and 917 MicroPdf417 modes. Default value: MacroCharacters.None. | [optional]
