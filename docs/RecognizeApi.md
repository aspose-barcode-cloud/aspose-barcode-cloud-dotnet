# Aspose.BarCode.Cloud.Sdk.Api.RecognizeApi

All URIs are relative to *<https://api.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**Recognize**](RecognizeApi.md#recognize) | **GET** /barcode/recognize | Recognize barcode from file on server in the Internet using GET requests with parameter in query string. For recognizing files from your hard drive use &#x60;recognize-body&#x60; or &#x60;recognize-multipart&#x60; endpoints instead.
[**RecognizeBase64**](RecognizeApi.md#recognizebase64) | **POST** /barcode/recognize-body | Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
[**RecognizeMultipart**](RecognizeApi.md#recognizemultipart) | **POST** /barcode/recognize-multipart | Recognize barcode from file in request body using POST requests with parameters in multipart form.


## **Recognize**

```csharp
BarcodeResponseList Recognize (DecodeBarcodeType barcodeType, string fileUrl, RecognitionMode? recognitionMode = null, RecognitionImageKind? recognitionImageKind = null)
```

Recognize barcode from file on server in the Internet using GET requests with parameter in query string. For recognizing files from your hard drive use `recognize-body` or `recognize-multipart` endpoints instead.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **DecodeBarcodeType**| Type of barcode to recognize |
 **fileUrl** | **string**| Url to barcode image |
 **recognitionMode** | **RecognitionMode?**| Recognition mode | [optional]
 **recognitionImageKind** | **RecognitionImageKind?**| Image kind for recognition | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


## **RecognizeBase64**

```csharp
BarcodeResponseList RecognizeBase64 (RecognizeBase64Request recognizeBase64Request)
```

Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **recognizeBase64Request** | [**RecognizeBase64Request**](RecognizeBase64Request.md)| Barcode recognition request |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json, application/xml


## **RecognizeMultipart**

```csharp
BarcodeResponseList RecognizeMultipart (DecodeBarcodeType barcodeType, System.IO.Stream file, RecognitionMode? recognitionMode = null, RecognitionImageKind? recognitionImageKind = null)
```

Recognize barcode from file in request body using POST requests with parameters in multipart form.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **DecodeBarcodeType**|  |
 **file** | **System.IO.Stream****System.IO.Stream**| Barcode image file |
 **recognitionMode** | **RecognitionMode?**|  | [optional]
 **recognitionImageKind** | **RecognitionImageKind?**|  | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json, application/xml

