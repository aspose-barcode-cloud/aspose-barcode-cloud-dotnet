# Aspose.BarCode.Cloud.Sdk.Model.BarcodeImageParams

Barcode image optional parameters

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**ImageFormat** | **AvailableBarCodeImageFormat** |  | [optional]
**TwoDDisplayText** | **string** | Text that will be displayed instead of codetext in 2D barcodes.  Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode | [optional]
**TextLocation** | **CodeLocation** |  | [optional]
**TextAlignment** | **TextAlignment** |  | [optional]
**ForegroundColor** | **string** | Specify the displaying bars and content Color.   Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.Black. | [optional]
**BackgroundColor** | **string** | Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.White. | [optional]
**Units** | **AvailableGraphicsUnit** |  | [optional]
**Resolution** | **float?** | Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi. | [optional]
**ImageHeight** | **float?** | Height of the barcode image in given units. Default units: pixel. | [optional]
**ImageWidth** | **float?** | Width of the barcode image in given units. Default units: pixel. | [optional]
**RotationAngle** | **int?** | BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0. | [optional]
