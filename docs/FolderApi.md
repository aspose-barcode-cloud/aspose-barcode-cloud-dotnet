# Aspose.BarCode.Cloud.Sdk.Api.FolderApi

All URIs are relative to *<https://api.aspose.cloud/v3.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**CopyFolder**](FolderApi.md#copyfolder) | **PUT** /barcode/storage/folder/copy/{srcPath} | Copy folder
[**CreateFolder**](FolderApi.md#createfolder) | **PUT** /barcode/storage/folder/{path} | Create the folder
[**DeleteFolder**](FolderApi.md#deletefolder) | **DELETE** /barcode/storage/folder/{path} | Delete folder
[**GetFilesList**](FolderApi.md#getfileslist) | **GET** /barcode/storage/folder/{path} | Get all files and folders within a folder
[**MoveFolder**](FolderApi.md#movefolder) | **PUT** /barcode/storage/folder/move/{srcPath} | Move folder


## **CopyFolder**

```csharp
void CopyFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)
```

Copy folder

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; |
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; |
 **srcStorageName** | **string**| Source storage name | [optional]
 **destStorageName** | **string**| Destination storage name | [optional]

### Return type

void (empty response body)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **CreateFolder**

```csharp
void CreateFolder (string path, string storageName = null)
```

Create the folder

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; |
 **storageName** | **string**| Storage name | [optional]

### Return type

void (empty response body)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **DeleteFolder**

```csharp
void DeleteFolder (string path, string storageName = null, bool? recursive = null)
```

Delete folder

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| Folder path e.g. &#39;/folder&#39; |
 **storageName** | **string**| Storage name | [optional]
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

### Return type

void (empty response body)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **GetFilesList**

```csharp
FilesList GetFilesList (string path, string storageName = null)
```

Get all files and folders within a folder

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **path** | **string**| Folder path e.g. &#39;/folder&#39; |
 **storageName** | **string**| Storage name | [optional]

### Return type

[**FilesList**](FilesList.md)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **MoveFolder**

```csharp
void MoveFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)
```

Move folder

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; |
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; |
 **srcStorageName** | **string**| Source storage name | [optional]
 **destStorageName** | **string**| Destination storage name | [optional]

### Return type

void (empty response body)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json

