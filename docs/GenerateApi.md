# Aspose.BarCode.Cloud.Sdk.Api.GenerateApi

All URIs are relative to *<https://barcode.qa.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**BarcodeGenerateBarcodeTypeGet**](GenerateApi.md#barcodegeneratebarcodetypeget) | **GET** /barcode/generate/{barcodeType} | Generate barcode using GET request with parameters in route and query string.
[**BarcodeGenerateBodyPost**](GenerateApi.md#barcodegeneratebodypost) | **POST** /barcode/generate-body | Generate barcode using POST request with parameters in body in json or xml format.
[**BarcodeGenerateFormPost**](GenerateApi.md#barcodegenerateformpost) | **POST** /barcode/generate-form | Generate barcode using POST request with parameters in url ecncoded form.


## **BarcodeGenerateBarcodeTypeGet**

```csharp
System.IO.Stream BarcodeGenerateBarcodeTypeGet (EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = null, AvailableBarCodeImageFormat? imageFormat = null, string twoDDisplayText = null, CodeLocation? textLocation = null, TextAlignment? textAlignment = null, string foregroundColor = null, string backgroundColor = null, AvailableGraphicsUnit? units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null)
```

Generate barcode using GET request with parameters in route and query string.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **EncodeBarcodeType**| Type of barcode to generate. |
 **data** | **string**| String represents data to encode |
 **dataType** | **EncodeDataType?**| Type of data to encode.  Default value:  EncodeDataType.StringData. | [optional]
 **imageFormat** | **AvailableBarCodeImageFormat?**| Barcode output image format.  Default value: png | [optional]
 **twoDDisplayText** | **string**| Text that will be displayed instead of codetext in 2D barcodes.  Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode | [optional]
 **textLocation** | **CodeLocation?**| Specify the displaying Text Location, set to CodeLocation.None to hide CodeText.  Default value: CodeLocation.Below. | [optional]
 **textAlignment** | **TextAlignment?**| Text alignment.  Default value: TextAligment.Left | [optional]
 **foregroundColor** | **string**| Specify the displaying bars and content Color.   Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.Black. | [optional]
 **backgroundColor** | **string**| Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.White. | [optional]
 **units** | **AvailableGraphicsUnit?**| Common Units for all measuring in query. Default units: pixel. | [optional]
 **resolution** | **float?**| Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi. | [optional]
 **imageHeight** | **float?**| Height of the barcode image in given units. Default units: pixel. | [optional]
 **imageWidth** | **float?**| Width of the barcode image in given units. Default units: pixel. | [optional]
 **rotationAngle** | **int?**| BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0. | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml


## **BarcodeGenerateBodyPost**

```csharp
System.IO.Stream BarcodeGenerateBodyPost (GenerateParams generateParams)
```

Generate barcode using POST request with parameters in body in json or xml format.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **generateParams** | [**GenerateParams**](GenerateParams.md)| Parameters of generation |

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml


## **BarcodeGenerateFormPost**

```csharp
System.IO.Stream BarcodeGenerateFormPost (EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = null, AvailableBarCodeImageFormat? imageFormat = null, string twoDDisplayText = null, CodeLocation? textLocation = null, TextAlignment? textAlignment = null, string foregroundColor = null, string backgroundColor = null, AvailableGraphicsUnit? units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null)
```

Generate barcode using POST request with parameters in url ecncoded form.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **EncodeBarcodeType**|  |
 **data** | **string**| String represents data to encode |
 **dataType** | **EncodeDataType?**|  | [optional]
 **imageFormat** | **AvailableBarCodeImageFormat?**|  | [optional]
 **twoDDisplayText** | **string**| Text that will be displayed instead of codetext in 2D barcodes.  Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode | [optional]
 **textLocation** | **CodeLocation?**|  | [optional]
 **textAlignment** | **TextAlignment?**|  | [optional]
 **foregroundColor** | **string**| Specify the displaying bars and content Color.   Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.Black. | [optional]
 **backgroundColor** | **string**| Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.White. | [optional]
 **units** | **AvailableGraphicsUnit?**|  | [optional]
 **resolution** | **float?**| Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi. | [optional]
 **imageHeight** | **float?**| Height of the barcode image in given units. Default units: pixel. | [optional]
 **imageWidth** | **float?**| Width of the barcode image in given units. Default units: pixel. | [optional]
 **rotationAngle** | **int?**| BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0. | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml

