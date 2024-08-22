# Aspose.BarCode.Cloud.Sdk.Api.GenerateApi

All URIs are relative to *<https://api.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**Generate**](GenerateApi.md#generate) | **GET** /barcode/generate/{barcodeType} | Generate barcode using GET request with parameters in route and query string.
[**GenerateBody**](GenerateApi.md#generatebody) | **POST** /barcode/generate-body | Generate barcode using POST request with parameters in body in json or xml format.
[**GenerateMultipart**](GenerateApi.md#generatemultipart) | **POST** /barcode/generate-multipart | Generate barcode using POST request with parameters in multipart form.


## **Generate**

```csharp
System.IO.Stream Generate (EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = null, BarcodeImageFormat? imageFormat = null, CodeLocation? textLocation = null, string foregroundColor = null, string backgroundColor = null, GraphicsUnit? units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null)
```

Generate barcode using GET request with parameters in route and query string.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **EncodeBarcodeType**| Type of barcode to generate. |
 **data** | **string**| String represents data to encode |
 **dataType** | **EncodeDataType?**| Type of data to encode.  Default value: StringData. | [optional]
 **imageFormat** | **BarcodeImageFormat?**| Barcode output image format.  Default value: png | [optional]
 **textLocation** | **CodeLocation?**| Specify the displaying Text Location, set to CodeLocation.None to hide CodeText.  Default value: CodeLocation.Below. | [optional]
 **foregroundColor** | **string**| Specify the displaying bars and content Color.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.  For example: AliceBlue or #FF000000  Default value: Black. | [optional] [default to &quot;Black&quot;]
 **backgroundColor** | **string**| Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.  For example: AliceBlue or #FF000000  Default value: White. | [optional] [default to &quot;White&quot;]
 **units** | **GraphicsUnit?**| Common Units for all measuring in query. Default units: pixel. | [optional]
 **resolution** | **float?**| Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi.  Decimal separator is dot. | [optional]
 **imageHeight** | **float?**| Height of the barcode image in given units. Default units: pixel.  Decimal separator is dot. | [optional]
 **imageWidth** | **float?**| Width of the barcode image in given units. Default units: pixel.  Decimal separator is dot. | [optional]
 **rotationAngle** | **int?**| BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0. | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml


## **GenerateBody**

```csharp
System.IO.Stream GenerateBody (GenerateParams generateParams)
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


## **GenerateMultipart**

```csharp
System.IO.Stream GenerateMultipart (EncodeBarcodeType barcodeType, string data, EncodeDataType? dataType = null, BarcodeImageFormat? imageFormat = null, CodeLocation? textLocation = null, string foregroundColor = null, string backgroundColor = null, GraphicsUnit? units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null)
```

Generate barcode using POST request with parameters in multipart form.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **EncodeBarcodeType**|  |
 **data** | **string**| String represents data to encode |
 **dataType** | **EncodeDataType?**|  | [optional]
 **imageFormat** | **BarcodeImageFormat?**|  | [optional]
 **textLocation** | **CodeLocation?**|  | [optional]
 **foregroundColor** | **string**| Specify the displaying bars and content Color.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.  For example: AliceBlue or #FF000000  Default value: Black. | [optional] [default to &quot;Black&quot;]
 **backgroundColor** | **string**| Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.  For example: AliceBlue or #FF000000  Default value: White. | [optional] [default to &quot;White&quot;]
 **units** | **GraphicsUnit?**|  | [optional]
 **resolution** | **float?**| Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi.  Decimal separator is dot. | [optional]
 **imageHeight** | **float?**| Height of the barcode image in given units. Default units: pixel.  Decimal separator is dot. | [optional]
 **imageWidth** | **float?**| Width of the barcode image in given units. Default units: pixel.  Decimal separator is dot. | [optional]
 **rotationAngle** | **int?**| BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0. | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml

