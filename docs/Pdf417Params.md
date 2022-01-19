# Aspose.BarCode.Cloud.Sdk.Model.Pdf417Params

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**AspectRatio** | **double?** | Height/Width ratio of 2D BarCode module. | [optional]
**TextEncoding** | **string** | Encoding of codetext. | [optional]
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
**Code128Emulation** | **Code128Emulation** | Function codeword for Code 128 emulation. Applied for MicroPDF417 only. Ignored for PDF417 and MacroPDF417 barcodes. | [optional]

