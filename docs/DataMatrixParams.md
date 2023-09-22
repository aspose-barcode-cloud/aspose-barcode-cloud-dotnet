# Aspose.BarCode.Cloud.Sdk.Model.DataMatrixParams

DataMatrix parameters.

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**AspectRatio** | **double?** | Height/Width ratio of 2D BarCode module | [optional]
**TextEncoding** | **string** | DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext. | [optional]
**Columns** | **int?** | DEPRECATED: Will be replaced with &#39;DataMatrix.Version&#39; in the next release  Columns count. | [optional]
**DataMatrixEcc** | **DataMatrixEccType** | Datamatrix ECC type. Default value: DataMatrixEccType.Ecc200. | [optional]
**DataMatrixEncodeMode** | **DataMatrixEncodeMode** | Encode mode of Datamatrix barcode. Default value: DataMatrixEncodeMode.Auto. | [optional]
**Rows** | **int?** | DEPRECATED: Will be replaced with &#39;DataMatrix.Version&#39; in the next release  Rows count. | [optional]
**MacroCharacters** | **MacroCharacter** | Macro Characters 05 and 06 values are used to obtain more compact encoding in special modes. Can be used only with DataMatrixEccType.Ecc200 or DataMatrixEccType.EccAuto. Cannot be used with EncodeTypes.GS1DataMatrix Default value: MacroCharacters.None. | [optional]
**Version** | **DataMatrixVersion** | Sets a Datamatrix symbol size. Default value: DataMatrixVersion.Auto. | [optional]
