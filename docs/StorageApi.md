# Aspose.BarCode.Cloud.Sdk.Api.StorageApi

All URIs are relative to *<https://api.aspose.cloud/v3.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**GetDiscUsage**](StorageApi.md#getdiscusage) | **GET** /barcode/storage/disc | Get disc usage
[**GetFileVersions**](StorageApi.md#getfileversions) | **GET** /barcode/storage/version/{path} | Get file versions
[**ObjectExists**](StorageApi.md#objectexists) | **GET** /barcode/storage/exist/{path} | Check if file or folder exists
[**StorageExists**](StorageApi.md#storageexists) | **GET** /barcode/storage/{storageName}/exist | Check if storage exists


## **GetDiscUsage**

```csharp
DiscUsage GetDiscUsage (string storageName = null)
```

Get disc usage

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **storageName** | **string**| Storage name | [optional]

### Return type

[**DiscUsage**](DiscUsage.md)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **GetFileVersions**

```csharp
FileVersions GetFileVersions (string path, string storageName = null)
```

Get file versions

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| File path e.g. &#39;/file.ext&#39; |
 **storageName** | **string**| Storage name | [optional]

### Return type

[**FileVersions**](FileVersions.md)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **ObjectExists**

```csharp
ObjectExist ObjectExists (string path, string storageName = null, string versionId = null)
```

Check if file or folder exists

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; |
 **storageName** | **string**| Storage name | [optional]
 **versionId** | **string**| File version ID | [optional]

### Return type

[**ObjectExist**](ObjectExist.md)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **StorageExists**

```csharp
StorageExist StorageExists (string storageName)
```

Check if storage exists

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **storageName** | **string**| Storage name |

### Return type

[**StorageExist**](StorageExist.md)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

