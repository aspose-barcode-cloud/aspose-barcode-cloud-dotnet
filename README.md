# Aspose.BarCode Cloud SDK for .NET

| WARNING: **Update SDK to version >= 21.9.0**: All SDK version < 21.9.0 will stop working soon! |
| ---------------------------------------------------------------------------------------------- |

[![License](https://img.shields.io/github/license/aspose-barcode-cloud/aspose-barcode-cloud-dotnet)](LICENSE)
[![.NET Core](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/dotnet-core.yml/badge.svg?branch=master)](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/dotnet-core.yml)
[![.NET Framework](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/net-framework.yml/badge.svg?branch=master)](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/net-framework.yml)
[![Nuget](https://img.shields.io/nuget/v/Aspose.BarCode-Cloud)](https://www.nuget.org/packages/Aspose.BarCode-Cloud/)

- API version: 3.0
- SDK version: 22.1.1

## Demo applications

[Generate Barcode](https://products.aspose.app/barcode/generate) | [Recognize Barcode](https://products.aspose.app/barcode/recognize) | [Embed Barcode](https://products.aspose.app/barcode/embed)
:---: | :---: | :---:
[![Generate](https://products.aspose.app/barcode/generate/img/aspose_generate-app-48.png)](https://products.aspose.app/barcode/generate) | [![Recognize](https://products.aspose.app/barcode/recognize/img/aspose_recognize-app-48.png)](https://products.aspose.app/barcode/recognize) | [![Embed](https://products.aspose.app/barcode/embed/img/aspose_embed-app-48.png)](https://products.aspose.app/barcode/embed)

[Aspose.BarCode for Cloud](https://products.aspose.cloud/barcode/) is a REST API for Linear, 2D and postal barcode generation and recognition in the cloud. API recognizes and generates barcode images in a variety of formats. Barcode REST API allows to specify barcode image attributes like image width, height, border style and output image format in order to customize the generation process. Developers can also specify the barcode type and text attributes such as text location and font styles in order to suit the application requirements.

This repository contains Aspose.BarCode Cloud SDK for .NET source code. This SDK allows you to work with Aspose.BarCode for Cloud REST APIs in your .NET Core or .NET Standard applications quickly and easily.

Aspose.BarCode Cloud SDK for .NET provides cross-platform bindings for:

- .NET Standard 2.0
- .NET Framework 2.0 and higher

To use these SDKs, you will need Client Id and Client Secret which can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/applications) (free registration in Aspose Cloud is required for this).

## How to use the SDK?

The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.BarCode-Cloud/) (recommended).

## Prerequisites

To use Aspose.BarCode Cloud SDK for .NET you need to register an account with [Aspose Cloud](https://www.aspose.cloud) and lookup/create Client Secret and Client Id at [Cloud Dashboard](https://dashboard.aspose.cloud/applications). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).

## Installation

### Install Aspose.BarCode-Cloud via NuGet

From the command line:

 nuget install Aspose.BarCode-Cloud

From Package Manager:

```ps
PM> Install-Package Aspose.BarCode-Cloud
```

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aspose.BarCode-Cloud".
5. Click on the Aspose.BarCode-Cloud package, select the appropriate version in the right-tab and click *Install*.

## Sample usage

The examples below show how you can generate Code128 barcode and save it into local file using Aspose.BarCode-Cloud library:

```csharp
const string clientId = "Client Id from https://dashboard.aspose.cloud/applications";
const string clientSecret = "Client Secret from https://dashboard.aspose.cloud/applications";

var api = new BarcodeApi(clientSecret, clientId);

using Stream response = api.GetBarcodeGenerate(
    new GetBarcodeGenerateRequest(
        EncodeBarcodeType.Code128.ToString(), "Sample text", format: "png")
    );
using FileStream stream = File.Create("out.png");
response.CopyTo(stream);
```

## Dependencies

- .NET Framework 2.0 or later, .NET Standard 2.0
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Licensing

All Aspose.BarCode for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

## Resources

- [**Website**](https://www.aspose.cloud)
- [**Product Home**](https://products.aspose.cloud/barcode/)
- [**Documentation**](https://docs.aspose.cloud/barcode/)
- [**Free Support Forum**](https://forum.aspose.cloud/c/barcode)
- [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)
- [**Blog**](https://blog.aspose.cloud/category/barcode/)

## Documentation for API Endpoints

All URIs are relative to *<https://api.aspose.cloud/v3.0>*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*BarcodeApi* | [**GetBarcodeGenerate**](docs/BarcodeApi.md#getbarcodegenerate) | **GET** /barcode/generate | Generate barcode.
*BarcodeApi* | [**GetBarcodeRecognize**](docs/BarcodeApi.md#getbarcoderecognize) | **GET** /barcode/{name}/recognize | Recognize barcode from a file on server.
*BarcodeApi* | [**PostBarcodeRecognizeFromUrlOrContent**](docs/BarcodeApi.md#postbarcoderecognizefromurlorcontent) | **POST** /barcode/recognize | Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image or encoded with base64.
*BarcodeApi* | [**PostGenerateMultiple**](docs/BarcodeApi.md#postgeneratemultiple) | **POST** /barcode/generateMultiple | Generate multiple barcodes and return in response stream
*BarcodeApi* | [**PutBarcodeGenerateFile**](docs/BarcodeApi.md#putbarcodegeneratefile) | **PUT** /barcode/{name}/generate | Generate barcode and save on server (from query params or from file with json or xml content)
*BarcodeApi* | [**PutBarcodeRecognizeFromBody**](docs/BarcodeApi.md#putbarcoderecognizefrombody) | **PUT** /barcode/{name}/recognize | Recognition of a barcode from file on server with parameters in body.
*BarcodeApi* | [**PutGenerateMultiple**](docs/BarcodeApi.md#putgeneratemultiple) | **PUT** /barcode/{name}/generateMultiple | Generate image with multiple barcodes and put new file on server
*FileApi* | [**CopyFile**](docs/FileApi.md#copyfile) | **PUT** /barcode/storage/file/copy/{srcPath} | Copy file
*FileApi* | [**DeleteFile**](docs/FileApi.md#deletefile) | **DELETE** /barcode/storage/file/{path} | Delete file
*FileApi* | [**DownloadFile**](docs/FileApi.md#downloadfile) | **GET** /barcode/storage/file/{path} | Download file
*FileApi* | [**MoveFile**](docs/FileApi.md#movefile) | **PUT** /barcode/storage/file/move/{srcPath} | Move file
*FileApi* | [**UploadFile**](docs/FileApi.md#uploadfile) | **PUT** /barcode/storage/file/{path} | Upload file
*FolderApi* | [**CopyFolder**](docs/FolderApi.md#copyfolder) | **PUT** /barcode/storage/folder/copy/{srcPath} | Copy folder
*FolderApi* | [**CreateFolder**](docs/FolderApi.md#createfolder) | **PUT** /barcode/storage/folder/{path} | Create the folder
*FolderApi* | [**DeleteFolder**](docs/FolderApi.md#deletefolder) | **DELETE** /barcode/storage/folder/{path} | Delete folder
*FolderApi* | [**GetFilesList**](docs/FolderApi.md#getfileslist) | **GET** /barcode/storage/folder/{path} | Get all files and folders within a folder
*FolderApi* | [**MoveFolder**](docs/FolderApi.md#movefolder) | **PUT** /barcode/storage/folder/move/{srcPath} | Move folder
*StorageApi* | [**GetDiscUsage**](docs/StorageApi.md#getdiscusage) | **GET** /barcode/storage/disc | Get disc usage
*StorageApi* | [**GetFileVersions**](docs/StorageApi.md#getfileversions) | **GET** /barcode/storage/version/{path} | Get file versions
*StorageApi* | [**ObjectExists**](docs/StorageApi.md#objectexists) | **GET** /barcode/storage/exist/{path} | Check if file or folder exists
*StorageApi* | [**StorageExists**](docs/StorageApi.md#storageexists) | **GET** /barcode/storage/{storageName}/exist | Check if storage exists

## Documentation for Models

- [Model.ApiError](docs/ApiError.md)
- [Model.ApiErrorResponse](docs/ApiErrorResponse.md)
- [Model.AustralianPostParams](docs/AustralianPostParams.md)
- [Model.AutoSizeMode](docs/AutoSizeMode.md)
- [Model.AvailableGraphicsUnit](docs/AvailableGraphicsUnit.md)
- [Model.AztecParams](docs/AztecParams.md)
- [Model.AztecSymbolMode](docs/AztecSymbolMode.md)
- [Model.BarcodeResponse](docs/BarcodeResponse.md)
- [Model.BarcodeResponseList](docs/BarcodeResponseList.md)
- [Model.BorderDashStyle](docs/BorderDashStyle.md)
- [Model.CaptionParams](docs/CaptionParams.md)
- [Model.ChecksumValidation](docs/ChecksumValidation.md)
- [Model.CodabarChecksumMode](docs/CodabarChecksumMode.md)
- [Model.CodabarParams](docs/CodabarParams.md)
- [Model.CodabarSymbol](docs/CodabarSymbol.md)
- [Model.CodablockParams](docs/CodablockParams.md)
- [Model.Code128Emulation](docs/Code128Emulation.md)
- [Model.Code16KParams](docs/Code16KParams.md)
- [Model.CodeLocation](docs/CodeLocation.md)
- [Model.CouponParams](docs/CouponParams.md)
- [Model.CustomerInformationInterpretingType](docs/CustomerInformationInterpretingType.md)
- [Model.DataBarParams](docs/DataBarParams.md)
- [Model.DataMatrixEccType](docs/DataMatrixEccType.md)
- [Model.DataMatrixEncodeMode](docs/DataMatrixEncodeMode.md)
- [Model.DataMatrixParams](docs/DataMatrixParams.md)
- [Model.DecodeBarcodeType](docs/DecodeBarcodeType.md)
- [Model.DiscUsage](docs/DiscUsage.md)
- [Model.DotCodeParams](docs/DotCodeParams.md)
- [Model.ECIEncodings](docs/ECIEncodings.md)
- [Model.EnableChecksum](docs/EnableChecksum.md)
- [Model.EncodeBarcodeType](docs/EncodeBarcodeType.md)
- [Model.Error](docs/Error.md)
- [Model.ErrorDetails](docs/ErrorDetails.md)
- [Model.FileVersions](docs/FileVersions.md)
- [Model.FilesList](docs/FilesList.md)
- [Model.FilesUploadResult](docs/FilesUploadResult.md)
- [Model.FontMode](docs/FontMode.md)
- [Model.FontParams](docs/FontParams.md)
- [Model.FontStyle](docs/FontStyle.md)
- [Model.GeneratorParams](docs/GeneratorParams.md)
- [Model.GeneratorParamsList](docs/GeneratorParamsList.md)
- [Model.ITF14BorderType](docs/ITF14BorderType.md)
- [Model.ITFParams](docs/ITFParams.md)
- [Model.MacroCharacter](docs/MacroCharacter.md)
- [Model.MaxiCodeParams](docs/MaxiCodeParams.md)
- [Model.ObjectExist](docs/ObjectExist.md)
- [Model.Padding](docs/Padding.md)
- [Model.PatchCodeParams](docs/PatchCodeParams.md)
- [Model.PatchFormat](docs/PatchFormat.md)
- [Model.Pdf417CompactionMode](docs/Pdf417CompactionMode.md)
- [Model.Pdf417ErrorLevel](docs/Pdf417ErrorLevel.md)
- [Model.Pdf417Params](docs/Pdf417Params.md)
- [Model.PostalParams](docs/PostalParams.md)
- [Model.PresetType](docs/PresetType.md)
- [Model.QREncodeMode](docs/QREncodeMode.md)
- [Model.QREncodeType](docs/QREncodeType.md)
- [Model.QRErrorLevel](docs/QRErrorLevel.md)
- [Model.QRVersion](docs/QRVersion.md)
- [Model.QrParams](docs/QrParams.md)
- [Model.ReaderParams](docs/ReaderParams.md)
- [Model.RegionPoint](docs/RegionPoint.md)
- [Model.ResultImageInfo](docs/ResultImageInfo.md)
- [Model.StorageExist](docs/StorageExist.md)
- [Model.StorageFile](docs/StorageFile.md)
- [Model.StructuredAppend](docs/StructuredAppend.md)
- [Model.TextAlignment](docs/TextAlignment.md)
- [Model.FileVersion](docs/FileVersion.md)

