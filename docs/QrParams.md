# Aspose.BarCode.Cloud.Sdk.Model.QrParams

QR parameters.

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**AspectRatio** | **double?** | Height/Width ratio of 2D BarCode module. | [optional]
**TextEncoding** | **string** | DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext. | [optional]
**EncodeType** | **QREncodeType** | QR / MicroQR selector mode. Select ForceQR for standard QR symbols, Auto for MicroQR. | [optional]
**ECIEncoding** | **ECIEncodings** | Extended Channel Interpretation Identifiers. It is used to tell the barcode reader details about the used references for encoding the data in the symbol. Current implementation consists all well known charset encodings. | [optional]
**EncodeMode** | **QREncodeMode** | QR symbology type of BarCode&#39;s encoding mode. Default value: QREncodeMode.Auto. | [optional]
**ErrorLevel** | **QRErrorLevel** | Level of Reed-Solomon error correction for QR barcode. From low to high: LevelL, LevelM, LevelQ, LevelH. see QRErrorLevel. | [optional]
**Version** | **QRVersion** | Version of QR Code. From Version1 to Version40 for QR code and from M1 to M4 for MicroQr. Default value is QRVersion.Auto. | [optional]
**StructuredAppend** | [**StructuredAppend**](StructuredAppend.md) | QR structured append parameters. | [optional]
