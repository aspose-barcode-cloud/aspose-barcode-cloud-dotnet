# Aspose.BarCode.Cloud.Sdk.Api.RecognizeApi

All URIs are relative to *<https://barcode.qa.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**BarcodeRecognizeBarcodeTypeGet**](RecognizeApi.md#barcoderecognizebarcodetypeget) | **GET** /barcode/recognize/{barcodeType} | Recognize barcode from file on server using GET requests with parameters in route and query string.
[**BarcodeRecognizeBodyPost**](RecognizeApi.md#barcoderecognizebodypost) | **POST** /barcode/recognize-body | Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
[**BarcodeRecognizeFormPost**](RecognizeApi.md#barcoderecognizeformpost) | **POST** /barcode/recognize-form | Recognize barcode from file in request body using POST requests with parameters in multipart form.


## **BarcodeRecognizeBarcodeTypeGet**

```csharp
BarcodeResponseList BarcodeRecognizeBarcodeTypeGet (DecodeBarcodeType barcodeType, string fileUrl, RecognitionMode? recognitionMode = null, RecognitionImageKind? imageKind = null)
```

Recognize barcode from file on server using GET requests with parameters in route and query string.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **DecodeBarcodeType**| Type of barcode to recognize |
 **fileUrl** | **string**| Url to barcode image |
 **recognitionMode** | **RecognitionMode?**| Recognition mode | [optional]
 **imageKind** | **RecognitionImageKind?**| Image kind | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml


## **BarcodeRecognizeBodyPost**

```csharp
BarcodeResponseList BarcodeRecognizeBodyPost (RecognizeBase64Request recognizeBase64Request)
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


## **BarcodeRecognizeFormPost**

```csharp
BarcodeResponseList BarcodeRecognizeFormPost (DecodeBarcodeType barcodeType, System.IO.Stream file, RecognitionMode? recognitionMode = null, RecognitionImageKind? imageKind = null)
```

Recognize barcode from file in request body using POST requests with parameters in multipart form.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **barcodeType** | **DecodeBarcodeType**|  |
 **file** | **System.IO.Stream****System.IO.Stream**|  |
 **recognitionMode** | **RecognitionMode?**|  | [optional]
 **imageKind** | **RecognitionImageKind?**|  | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json, application/xml

