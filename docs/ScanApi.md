# Aspose.BarCode.Cloud.Sdk.Api.ScanApi

All URIs are relative to *<https://barcode.qa.aspose.cloud/v4.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**BarcodeScanBodyPost**](ScanApi.md#barcodescanbodypost) | **POST** /barcode/scan-body | Scan barcode from file in request body using POST requests with parameter in body in json or xml format.
[**BarcodeScanFormPost**](ScanApi.md#barcodescanformpost) | **POST** /barcode/scan-form | Scan barcode from file in request body using POST requests with parameter in multipart form.
[**BarcodeScanGet**](ScanApi.md#barcodescanget) | **GET** /barcode/scan | Scan barcode from file on server using GET requests with parameter in query string.


## **BarcodeScanBodyPost**

```csharp
BarcodeResponseList BarcodeScanBodyPost (ScanBase64Request scanBase64Request)
```

Scan barcode from file in request body using POST requests with parameter in body in json or xml format.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **scanBase64Request** | [**ScanBase64Request**](ScanBase64Request.md)| Barcode scan request |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json, application/xml


## **BarcodeScanFormPost**

```csharp
BarcodeResponseList BarcodeScanFormPost (System.IO.Stream file)
```

Scan barcode from file in request body using POST requests with parameter in multipart form.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **file** | **System.IO.Stream****System.IO.Stream**|  |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json, application/xml


## **BarcodeScanGet**

```csharp
BarcodeResponseList BarcodeScanGet (string fileUrl)
```

Scan barcode from file on server using GET requests with parameter in query string.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **fileUrl** | **string**| Url to barcode image |

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: application/json, application/xml

