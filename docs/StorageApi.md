# Aspose.BarCode.Cloud.Sdk.Api.StorageApi

All URIs are relative to *https://api.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDiscUsage**](StorageApi.md#getdiscusage) | **GET** /barcode/storage/disc | Get disc usage
[**GetFileVersions**](StorageApi.md#getfileversions) | **GET** /barcode/storage/version/{path} | Get file versions
[**ObjectExists**](StorageApi.md#objectexists) | **GET** /barcode/storage/exist/{path} | Check if file or folder exists
[**StorageExists**](StorageApi.md#storageexists) | **GET** /barcode/storage/{storageName}/exist | Check if storage exists


<a name="getdiscusage"></a>
# **GetDiscUsage**
> DiscUsage GetDiscUsage (string storageName = null)

Get disc usage

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class GetDiscUsageExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Get disc usage
                DiscUsage result = apiInstance.GetDiscUsage(storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetDiscUsage: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**DiscUsage**](DiscUsage.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getfileversions"></a>
# **GetFileVersions**
> FileVersions GetFileVersions (string path, string storageName = null)

Get file versions

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class GetFileVersionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | File path e.g. '/file.ext'
            var storageName = storageName_example;  // string | Storage name (optional) 

            try
            {
                // Get file versions
                FileVersions result = apiInstance.GetFileVersions(path, storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.GetFileVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File path e.g. &#39;/file.ext&#39; | 
 **storageName** | **string**| Storage name | [optional] 

### Return type

[**FileVersions**](FileVersions.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="objectexists"></a>
# **ObjectExists**
> ObjectExist ObjectExists (string path, string storageName = null, string versionId = null)

Check if file or folder exists

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class ObjectExistsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var path = path_example;  // string | File or folder path e.g. '/file.ext' or '/folder'
            var storageName = storageName_example;  // string | Storage name (optional) 
            var versionId = versionId_example;  // string | File version ID (optional) 

            try
            {
                // Check if file or folder exists
                ObjectExist result = apiInstance.ObjectExists(path, storageName, versionId);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.ObjectExists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **path** | **string**| File or folder path e.g. &#39;/file.ext&#39; or &#39;/folder&#39; | 
 **storageName** | **string**| Storage name | [optional] 
 **versionId** | **string**| File version ID | [optional] 

### Return type

[**ObjectExist**](ObjectExist.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="storageexists"></a>
# **StorageExists**
> StorageExist StorageExists (string storageName)

Check if storage exists

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class StorageExistsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StorageApi();
            var storageName = storageName_example;  // string | Storage name

            try
            {
                // Check if storage exists
                StorageExist result = apiInstance.StorageExists(storageName);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling StorageApi.StorageExists: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **storageName** | **string**| Storage name | 

### Return type

[**StorageExist**](StorageExist.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

