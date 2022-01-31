# Aspose.BarCode.Cloud.Sdk.Api.FileApi

All URIs are relative to *<https://api.aspose.cloud/v3.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**CopyFile**](FileApi.md#copyfile) | **PUT** /barcode/storage/file/copy/{srcPath} | Copy file
[**DeleteFile**](FileApi.md#deletefile) | **DELETE** /barcode/storage/file/{path} | Delete file
[**DownloadFile**](FileApi.md#downloadfile) | **GET** /barcode/storage/file/{path} | Download file
[**MoveFile**](FileApi.md#movefile) | **PUT** /barcode/storage/file/move/{srcPath} | Move file
[**UploadFile**](FileApi.md#uploadfile) | **PUT** /barcode/storage/file/{path} | Upload file


## **CopyFile**

```csharp
void CopyFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)
```

Copy file

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; |
 **destPath** | **string**| Destination file path |
 **srcStorageName** | **string**| Source storage name | [optional]
 **destStorageName** | **string**| Destination storage name | [optional]
 **versionId** | **string**| File version ID to copy | [optional]

### Return type

void (empty response body)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **DeleteFile**

```csharp
void DeleteFile (string path, string storageName = null, string versionId = null)
```

Delete file

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; |
 **storageName** | **string**| Storage name | [optional]
 **versionId** | **string**| File version ID to delete | [optional]

### Return type

void (empty response body)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **DownloadFile**

```csharp
System.IO.Stream DownloadFile (string path, string storageName = null, string versionId = null)
```

Download file

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; |
 **storageName** | **string**| Storage name | [optional]
 **versionId** | **string**| File version ID to download | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: multipart/form-data


## **MoveFile**

```csharp
void MoveFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)
```

Move file

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; |
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; |
 **srcStorageName** | **string**| Source storage name | [optional]
 **destStorageName** | **string**| Destination storage name | [optional]
 **versionId** | **string**| File version ID to move | [optional]

### Return type

void (empty response body)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **UploadFile**

```csharp
FilesUploadResult UploadFile (string path, System.IO.Stream _file, string storageName = null)
```

Upload file

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext  If the content is multipart and path does not contains the file name it tries to get them from filename parameter  from Content-Disposition header. |
 **_file** | **System.IO.Stream**| File to upload |
 **storageName** | **string**| Storage name | [optional]

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

### HTTP request headers

- **Content-Type**: multipart/form-data
- **Accept**: application/json

