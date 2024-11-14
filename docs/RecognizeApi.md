# Aspose.BarCode.Cloud.Sdk.Api.RecognizeApi

All URIs are relative to *<https://barcode.qa.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**BarcodeRecognizeBodyPost**](RecognizeApi.md#barcoderecognizebodypost) | **POST** /barcode/recognize-body | Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
[**BarcodeRecognizeGet**](RecognizeApi.md#barcoderecognizeget) | **GET** /barcode/recognize | Recognize barcode from file on server using GET requests with parameters in route and query string.
[**BarcodeRecognizeMultipartPost**](RecognizeApi.md#barcoderecognizemultipartpost) | **POST** /barcode/recognize-multipart | Recognize barcode from file in request body using POST requests with parameters in multipart form.


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


## **BarcodeRecognizeGet**

```csharp
BarcodeResponseList BarcodeRecognizeGet (DecodeBarcodeType barcodeType, string fileUrl, RecognitionMode? recognitionMode = null, RecognitionImageKind? recognitionImageKind = null)
```

Recognize barcode from file on server using GET requests with parameters in route and query string.

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


## **BarcodeRecognizeMultipartPost**

```csharp
BarcodeResponseList BarcodeRecognizeMultipartPost (DecodeBarcodeType barcodeType, System.IO.Stream file, RecognitionMode? recognitionMode = null, RecognitionImageKind? recognitionImageKind = null)
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

