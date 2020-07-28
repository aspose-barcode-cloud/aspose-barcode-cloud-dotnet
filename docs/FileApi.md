# Aspose.BarCode.Cloud.Sdk.Api.FileApi

All URIs are relative to *https://api.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CopyFile**](FileApi.md#copyfile) | **PUT** /barcode/storage/file/copy/{srcPath} | Copy file
[**DeleteFile**](FileApi.md#deletefile) | **DELETE** /barcode/storage/file/{path} | Delete file
[**DownloadFile**](FileApi.md#downloadfile) | **GET** /barcode/storage/file/{path} | Download file
[**MoveFile**](FileApi.md#movefile) | **PUT** /barcode/storage/file/move/{srcPath} | Move file
[**UploadFile**](FileApi.md#uploadfile) | **PUT** /barcode/storage/file/{path} | Upload file


<a name="copyfile"></a>
# **CopyFile**
> void CopyFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)

Copy file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class CopyFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FileApi();
            var srcPath = srcPath_example;  // string | Source file path e.g. '/folder/file.ext'
            var destPath = destPath_example;  // string | Destination file path
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to copy (optional) 

            try
            {
                // Copy file
                apiInstance.CopyFile(srcPath, destPath, srcStorageName, destStorageName, versionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileApi.CopyFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/folder/file.ext&#39; | 
 **destPath** | **string**| Destination file path | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to copy | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefile"></a>
# **DeleteFile**
> void DeleteFile (string path, string storageName = null, string versionId = null)

Delete file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FileApi();
            var path = path_example;  // string | File path e.g. '/folder/file.ext'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to delete (optional) 

            try
            {
                // Delete file
                apiInstance.DeleteFile(path, storageName, versionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileApi.DeleteFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to delete | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="downloadfile"></a>
# **DownloadFile**
> System.IO.Stream DownloadFile (string path, string storageName = null, string versionId = null)

Download file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class DownloadFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FileApi();
            var path = path_example;  // string | File path e.g. '/folder/file.ext'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to download (optional) 

            try
            {
                // Download file
                System.IO.Stream result = apiInstance.DownloadFile(path, storageName, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileApi.DownloadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/folder/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID to download | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: multipart/form-data

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movefile"></a>
# **MoveFile**
> void MoveFile (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null, string versionId = null)

Move file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class MoveFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FileApi();
            var srcPath = srcPath_example;  // string | Source file path e.g. '/src.ext'
            var destPath = destPath_example;  // string | Destination file path e.g. '/dest.ext'
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 
            var versionId = versionId_example;  // string | File version ID to move (optional) 

            try
            {
                // Move file
                apiInstance.MoveFile(srcPath, destPath, srcStorageName, destStorageName, versionId);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileApi.MoveFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source file path e.g. &#39;/src.ext&#39; | 
 **destPath** | **string**| Destination file path e.g. &#39;/dest.ext&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 
 **versionId** | **string**| File version ID to move | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="uploadfile"></a>
# **UploadFile**
> FilesUploadResult UploadFile (string path, System.IO.Stream _file, string storageName = null)

Upload file

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class UploadFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FileApi();
            var path = path_example;  // string | Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header. 
            var _file = new System.IO.Stream(); // System.IO.Stream | File to upload
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Upload file
                FilesUploadResult result = apiInstance.UploadFile(path, _file, storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FileApi.UploadFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Path where to upload including filename and extension e.g. /file.ext or /Folder 1/file.ext             If the content is multipart and path does not contains the file name it tries to get them from filename parameter             from Content-Disposition header.  | 
 **_file** | **System.IO.Stream**| File to upload | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesUploadResult**](FilesUploadResult.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

