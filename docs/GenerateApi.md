# Aspose.BarCode.Cloud.Sdk.Api.GenerateApi

All URIs are relative to *<https://barcode.qa.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**BarcodeGenerateBarcodeTypeGet**](GenerateApi.md#barcodegeneratebarcodetypeget) | **GET** /barcode/generate/{barcodeType} | Generate barcode using GET request with parameters in route and query string.
[**BarcodeGenerateBodyPost**](GenerateApi.md#barcodegeneratebodypost) | **POST** /barcode/generate-body | Generate barcode using POST request with parameters in body in json or xml format.
[**BarcodeGenerateFormPost**](GenerateApi.md#barcodegenerateformpost) | **POST** /barcode/generate-form | Generate barcode using POST request with parameters in url ecncoded form.

## **BarcodeGenerateBarcodeTypeGet**

```csharp
byte[] BarcodeGenerateBarcodeTypeGet (EncodeBarcodeType barcodeType, EncodeDataType dataType, string data, AvailableBarCodeImageFormat imageFormat = null, string twoDDisplayText = null, CodeLocation textLocation = null, TextAlignment textAlignment = null, string foregroundColor = null, string backgroundColor = null, AvailableGraphicsUnit units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null)
```

Generate barcode using GET request with parameters in route and query string.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | [**EncodeBarcodeType**](EncodeBarcodeType.md)| Type of barcode to generate. |
 **dataType** | [**EncodeDataType**](EncodeDataType.md)| Type of data to encode. |
 **data** | **string**| String represents data to encode |
 **imageFormat** | [**AvailableBarCodeImageFormat**](AvailableBarCodeImageFormat.md)| Barcode output image format.  Default value: png | [optional]
 **twoDDisplayText** | **string**| Text that will be displayed instead of codetext in 2D barcodes.  Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode | [optional]
 **textLocation** | [**CodeLocation**](CodeLocation.md)| Specify the displaying Text Location, set to CodeLocation.None to hide CodeText.  Default value: CodeLocation.Below. | [optional]
 **textAlignment** | [**TextAlignment**](TextAlignment.md)| Text alignment.  Default value: TextAligment.Left | [optional]
 **foregroundColor** | **string**| Specify the displaying bars and content Color.   Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.Black. | [optional]
 **backgroundColor** | **string**| Background color of the barcode image.  Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #.   For example: Color.AliceBlue or #FF000000  Default value: Color.White. | [optional]
 **units** | [**AvailableGraphicsUnit**](AvailableGraphicsUnit.md)| Common Units for all measuring in query. Default units: pixel. | [optional]
 **resolution** | **float?**| Resolution of the BarCode image.  One value for both dimensions.  Default value: 96 dpi. | [optional]
 **imageHeight** | **float?**| Height of the barcode image in given units. Default units: pixel. | [optional]
 **imageWidth** | **float?**| Width of the barcode image in given units. Default units: pixel. | [optional]
 **rotationAngle** | **int?**| BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation.  If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image.  Default value: 0. | [optional]

### Return type

byte[]

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml


## **BarcodeGenerateBodyPost**

```csharp
byte[] BarcodeGenerateBodyPost (GenerateParams body = null)
```

Generate barcode using POST request with parameters in body in json or xml format.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **body** | [**GenerateParams**](GenerateParams.md)| Parameters of generation | [optional]

### Return type

byte[]

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml


## **BarcodeGenerateFormPost**

```csharp
byte[] BarcodeGenerateFormPost (EncodeBarcodeType barcodeType = null, EncodeDataType dataType = null, string data = null, AvailableBarCodeImageFormat imageFormat = null, string twoDDisplayText = null, CodeLocation textLocation = null, TextAlignment textAlignment = null, string foregroundColor = null, string backgroundColor = null, AvailableGraphicsUnit units = null, float? resolution = null, float? imageHeight = null, float? imageWidth = null, int? rotationAngle = null)
```

Generate barcode using POST request with parameters in url ecncoded form.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | [**EncodeBarcodeType**](EncodeBarcodeType.md)|  | [optional]
 **dataType** | [**EncodeDataType**](EncodeDataType.md)|  | [optional]
 **data** | **string**|  | [optional]
 **imageFormat** | [**AvailableBarCodeImageFormat**](AvailableBarCodeImageFormat.md)|  | [optional]
 **twoDDisplayText** | **string**|  | [optional]
 **textLocation** | [**CodeLocation**](CodeLocation.md)|  | [optional]
 **textAlignment** | [**TextAlignment**](TextAlignment.md)|  | [optional]
 **foregroundColor** | **string**|  | [optional]
 **backgroundColor** | **string**|  | [optional]
 **units** | [**AvailableGraphicsUnit**](AvailableGraphicsUnit.md)|  | [optional]
 **resolution** | **float?**|  | [optional]
 **imageHeight** | **float?**|  | [optional]
 **imageWidth** | **float?**|  | [optional]
 **rotationAngle** | **int?**|  | [optional]

### Return type

byte[]

### HTTP request headers

- **Content-Type**: application/x-www-form-urlencoded
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff, application/json, application/xml

