# Aspose.BarCode.Cloud.Sdk.Model.AztecParams

Aztec parameters.

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**AspectRatio** | **double?** | Height/Width ratio of 2D BarCode module. | [optional]
**ErrorLevel** | **int?** | Level of error correction of Aztec types of barcode. Value should between 10 to 95. | [optional]
**SymbolMode** | **AztecSymbolMode** | Aztec Symbol mode. Default value: AztecSymbolMode.Auto. | [optional]
**TextEncoding** | **string** | DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext. | [optional]
**EncodeMode** | **AztecEncodeMode** | Encoding mode for Aztec barcodes. Default value: Auto | [optional]
**ECIEncoding** | **ECIEncodings** | Identifies ECI encoding. Used when AztecEncodeMode is Auto. Default value: ISO-8859-1. | [optional]
**IsReaderInitialization** | **bool?** | Used to instruct the reader to interpret the data contained within the symbol as programming for reader initialization. | [optional]
**LayersCount** | **int?** | Gets or sets layers count of Aztec symbol. Layers count should be in range from 1 to 3 for Compact mode and in range from 1 to 32 for Full Range mode. Default value: 0 (auto). | [optional]
