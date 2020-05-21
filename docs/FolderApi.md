# Aspose.BarCode.Cloud.Sdk.Api.FolderApi

All URIs are relative to *https://api.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CopyFolder**](FolderApi.md#copyfolder) | **PUT** /barcode/storage/folder/copy/{srcPath} | Copy folder
[**CreateFolder**](FolderApi.md#createfolder) | **PUT** /barcode/storage/folder/{path} | Create the folder
[**DeleteFolder**](FolderApi.md#deletefolder) | **DELETE** /barcode/storage/folder/{path} | Delete folder
[**GetFilesList**](FolderApi.md#getfileslist) | **GET** /barcode/storage/folder/{path} | Get all files and folders within a folder
[**MoveFolder**](FolderApi.md#movefolder) | **PUT** /barcode/storage/folder/move/{srcPath} | Move folder


<a name="copyfolder"></a>
# **CopyFolder**
> void CopyFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)

Copy folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class CopyFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FolderApi();
            var srcPath = srcPath_example;  // string | Source folder path e.g. '/src'
            var destPath = destPath_example;  // string | Destination folder path e.g. '/dst'
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 

            try
            {
                // Copy folder
                apiInstance.CopyFolder(srcPath, destPath, srcStorageName, destStorageName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderApi.CopyFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Source folder path e.g. &#39;/src&#39; | 
 **destPath** | **string**| Destination folder path e.g. &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createfolder"></a>
# **CreateFolder**
> void CreateFolder (string path, string storageName = null)

Create the folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class CreateFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FolderApi();
            var path = path_example;  // string | Folder path to create e.g. 'folder_1/folder_2/'
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Create the folder
                apiInstance.CreateFolder(path, storageName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderApi.CreateFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path to create e.g. &#39;folder_1/folder_2/&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletefolder"></a>
# **DeleteFolder**
> void DeleteFolder (string path, string storageName = null, bool? recursive = null)

Delete folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class DeleteFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FolderApi();
            var path = path_example;  // string | Folder path e.g. '/folder'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var recursive = true;  // bool? | Enable to delete folders, subfolders and files (optional)  (default to false)

            try
            {
                // Delete folder
                apiInstance.DeleteFolder(path, storageName, recursive);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderApi.DeleteFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **recursive** | **bool?**| Enable to delete folders, subfolders and files | [optional] [default to false]

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileslist"></a>
# **GetFilesList**
> FilesList GetFilesList (string path, string storageName = null)

Get all files and folders within a folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class GetFilesListExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FolderApi();
            var path = path_example;  // string | Folder path e.g. '/folder'
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Get all files and folders within a folder
                FilesList result = apiInstance.GetFilesList(path, storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderApi.GetFilesList: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| Folder path e.g. &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FilesList**](FilesList.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="movefolder"></a>
# **MoveFolder**
> void MoveFolder (string srcPath, string destPath, string srcStorageName = null, string destStorageName = null)

Move folder

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class MoveFolderExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FolderApi();
            var srcPath = srcPath_example;  // string | Folder path to move e.g. '/folder'
            var destPath = destPath_example;  // string | Destination folder path to move to e.g '/dst'
            var srcStorageName = srcStorageName_example;  // string | Source storage name (optional) 
            var destStorageName = destStorageName_example;  // string | Destination storage name (optional) 

            try
            {
                // Move folder
                apiInstance.MoveFolder(srcPath, destPath, srcStorageName, destStorageName);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling FolderApi.MoveFolder: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **srcPath** | **string**| Folder path to move e.g. &#39;/folder&#39; | 
 **destPath** | **string**| Destination folder path to move to e.g &#39;/dst&#39; | 
 **srcStorageName** | **string**| Source storage name | [optional] 
 **destStorageName** | **string**| Destination storage name | [optional] 

### Return type

void (empty response body)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

