# Aspose.BarCode Cloud SDK for .NET

[![License](https://img.shields.io/github/license/aspose-barcode-cloud/aspose-barcode-cloud-dotnet)](LICENSE)
[![.NET Core Linux](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/dotnet-core.yml/badge.svg?branch=main)](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/dotnet-core.yml)
[![.NET Framework Windows](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/net-framework.yml/badge.svg?branch=main)](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/net-framework.yml)
[![Nuget](https://img.shields.io/nuget/v/Aspose.BarCode-Cloud)](https://www.nuget.org/packages/Aspose.BarCode-Cloud/)

- API version: 3.0
- SDK version: 24.5.0

## Demo applications

[Scan QR](https://products.aspose.app/barcode/scanqr) | [Generate Barcode](https://products.aspose.app/barcode/generate) | [Recognize Barcode](https://products.aspose.app/barcode/recognize)
:---: | :---: | :---:
[![ScanQR](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_scanqr-app-48.png)](https://products.aspose.app/barcode/scanqr) | [![Generate](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_generate-app-48.png)](https://products.aspose.app/barcode/generate) | [![Recognize](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_recognize-app-48.png)](https://products.aspose.app/barcode/recognize)
[**Generate Wi-Fi QR**](https://products.aspose.app/barcode/wifi-qr) | [**Embed Barcode**](https://products.aspose.app/barcode/embed) | [**Scan Barcode**](https://products.aspose.app/barcode/scan)
[![Wi-FiQR](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_wifi-qr-app-48.png)](https://products.aspose.app/barcode/wifi-qr) | [![Embed](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_embed-app-48.png)](https://products.aspose.app/barcode/embed) | [![Scan](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_scan-app-48.png)](https://products.aspose.app/barcode/scan)

[Aspose.BarCode for Cloud](https://products.aspose.cloud/barcode/) is a REST API for Linear, 2D and postal barcode generation and recognition in the cloud. API recognizes and generates barcode images in a variety of formats. Barcode REST API allows to specify barcode image attributes like image width, height, border style and output image format in order to customize the generation process. Developers can also specify the barcode type and text attributes such as text location and font styles in order to suit the application requirements.

This repository contains Aspose.BarCode Cloud SDK for .NET source code. This SDK allows you to work with Aspose.BarCode for Cloud REST APIs in your .NET Core or .NET Framework applications quickly and easily.

Aspose.BarCode Cloud SDK for .NET provides cross-platform bindings for:

- .NET 5 and higher
- .NET Standard 2.0 and higher
- .NET Core 3.1 and higher
- .NET Framework 4.6.2 and higher

To use these SDKs, you will need Client Id and Client Secret which can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/applications) (free registration in Aspose Cloud is required for this).

## How to use the SDK?

The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.BarCode-Cloud/) (recommended).

## Prerequisites

To use Aspose.BarCode Cloud SDK for .NET you need to register an account with [Aspose Cloud](https://www.aspose.cloud) and lookup/create Client Secret and Client Id at [Cloud Dashboard](https://dashboard.aspose.cloud/applications). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/).

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

## Recognize QR code

The examples below show how you can recognize QR code from image:

```csharp
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace ReadQR;

internal static class Program
{
    private static Configuration MakeConfiguration()
    {
        var config = new Configuration();

        string? envToken = Environment.GetEnvironmentVariable("TEST_CONFIGURATION_JWT_TOKEN");
        if (string.IsNullOrEmpty(envToken))
        {
            config.ClientId = "Client Id from https://dashboard.aspose.cloud/applications";
            config.ClientSecret = "Client Secret from https://dashboard.aspose.cloud/applications";
        }
        else
        {
            config.JwtToken = envToken;
        }

        return config;
    }

    private static async Task<string> ReadQR(IBarcodeApi api, string fileName)
    {
        await using FileStream imageStream = File.OpenRead(fileName);
        BarcodeResponseList recognized = await api.ScanBarcodeAsync(
            new ScanBarcodeRequest(imageStream)
            {
                decodeTypes = new List<DecodeBarcodeType> { DecodeBarcodeType.QR }
            }
        );

        return recognized.Barcodes[0].BarcodeValue;
    }

    public static async Task Main(string[] args)
    {
        string fileName = Path.GetFullPath(Path.Join(
            Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location),
            "..", "..", "..", "..",
            "qr.png"
        ));

        var api = new BarcodeApi(MakeConfiguration());

        string result = await ReadQR(api, fileName);
        Console.WriteLine($"File '{fileName}' recognized, result: '{result}'");
    }
}

```

## Generate QR code

The examples below show how you can generate QR code and save it into local file using Aspose.BarCode-Cloud library:

```csharp
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace GenerateQR;

internal static class Program
{
    private static Configuration MakeConfiguration()
    {
        var config = new Configuration();

        string? envToken = Environment.GetEnvironmentVariable("TEST_CONFIGURATION_JWT_TOKEN");
        if (string.IsNullOrEmpty(envToken))
        {
            config.ClientId = "Client Id from https://dashboard.aspose.cloud/applications";
            config.ClientSecret = "Client Secret from https://dashboard.aspose.cloud/applications";
        }
        else
        {
            config.JwtToken = envToken;
        }

        return config;
    }

    private static async Task GenerateQR(IBarcodeApi api, string fileName)
    {
        await using Stream generated = await api.GetBarcodeGenerateAsync(
            new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(),
                "QR code text")
            {
                TextLocation = CodeLocation.None.ToString(),
                format = "png"
            });
        await using FileStream stream = File.Create(fileName);
        await generated.CopyToAsync(stream);
    }

    public static async Task Main(string[] args)
    {
        string fileName = Path.GetFullPath(Path.Join(
            Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location),
            "..", "..", "..", "..",
            "qr.png"
        ));

        BarcodeApi api = new BarcodeApi(MakeConfiguration());

        await GenerateQR(api, fileName);
        Console.WriteLine($"File '{fileName}' generated.");
    }
}

```

## Dependencies

- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

## Licensing

All Aspose.BarCode for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

## Resources

- [**Website**](https://www.aspose.cloud)
- [**Product Home**](https://products.aspose.cloud/barcode/)
- [**Documentation**](https://docs.aspose.cloud/barcode/)
- [**Free Support Forum**](https://forum.aspose.cloud/c/barcode)
- [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)
- [**Blog**](https://blog.aspose.cloud/categories/aspose.barcode-cloud-product-family/)

## Documentation for API Endpoints

All URIs are relative to *<https://api.aspose.cloud/v3.0>*

Class | Method | HTTP request | Description
----- | ------ | ------------ | -----------
*BarcodeApi* | [**GetBarcodeGenerate**](docs/BarcodeApi.md#getbarcodegenerate) | **GET** /barcode/generate | Generate barcode.
*BarcodeApi* | [**GetBarcodeRecognize**](docs/BarcodeApi.md#getbarcoderecognize) | **GET** /barcode/{name}/recognize | Recognize barcode from a file on server.
*BarcodeApi* | [**PostBarcodeRecognizeFromUrlOrContent**](docs/BarcodeApi.md#postbarcoderecognizefromurlorcontent) | **POST** /barcode/recognize | Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image with content-type \"application/octet-stream\". An image can also be passed as a form field.
*BarcodeApi* | [**PostGenerateMultiple**](docs/BarcodeApi.md#postgeneratemultiple) | **POST** /barcode/generateMultiple | Generate multiple barcodes and return in response stream
*BarcodeApi* | [**PutBarcodeGenerateFile**](docs/BarcodeApi.md#putbarcodegeneratefile) | **PUT** /barcode/{name}/generate | Generate barcode and save on server (from query params or from file with json or xml content)
*BarcodeApi* | [**PutBarcodeRecognizeFromBody**](docs/BarcodeApi.md#putbarcoderecognizefrombody) | **PUT** /barcode/{name}/recognize | Recognition of a barcode from file on server with parameters in body.
*BarcodeApi* | [**PutGenerateMultiple**](docs/BarcodeApi.md#putgeneratemultiple) | **PUT** /barcode/{name}/generateMultiple | Generate image with multiple barcodes and put new file on server
*BarcodeApi* | [**ScanBarcode**](docs/BarcodeApi.md#scanbarcode) | **POST** /barcode/scan | Quickly scan a barcode from an image.
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
- [Model.AztecEncodeMode](docs/AztecEncodeMode.md)
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
- [Model.Code128EncodeMode](docs/Code128EncodeMode.md)
- [Model.Code128Params](docs/Code128Params.md)
- [Model.Code16KParams](docs/Code16KParams.md)
- [Model.CodeLocation](docs/CodeLocation.md)
- [Model.CouponParams](docs/CouponParams.md)
- [Model.CustomerInformationInterpretingType](docs/CustomerInformationInterpretingType.md)
- [Model.DataBarParams](docs/DataBarParams.md)
- [Model.DataMatrixEccType](docs/DataMatrixEccType.md)
- [Model.DataMatrixEncodeMode](docs/DataMatrixEncodeMode.md)
- [Model.DataMatrixParams](docs/DataMatrixParams.md)
- [Model.DataMatrixVersion](docs/DataMatrixVersion.md)
- [Model.DecodeBarcodeType](docs/DecodeBarcodeType.md)
- [Model.DiscUsage](docs/DiscUsage.md)
- [Model.DotCodeEncodeMode](docs/DotCodeEncodeMode.md)
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
- [Model.HanXinEncodeMode](docs/HanXinEncodeMode.md)
- [Model.HanXinErrorLevel](docs/HanXinErrorLevel.md)
- [Model.HanXinParams](docs/HanXinParams.md)
- [Model.HanXinVersion](docs/HanXinVersion.md)
- [Model.ITF14BorderType](docs/ITF14BorderType.md)
- [Model.ITFParams](docs/ITFParams.md)
- [Model.MacroCharacter](docs/MacroCharacter.md)
- [Model.MaxiCodeEncodeMode](docs/MaxiCodeEncodeMode.md)
- [Model.MaxiCodeMode](docs/MaxiCodeMode.md)
- [Model.MaxiCodeParams](docs/MaxiCodeParams.md)
- [Model.ObjectExist](docs/ObjectExist.md)
- [Model.Padding](docs/Padding.md)
- [Model.PatchCodeParams](docs/PatchCodeParams.md)
- [Model.PatchFormat](docs/PatchFormat.md)
- [Model.Pdf417CompactionMode](docs/Pdf417CompactionMode.md)
- [Model.Pdf417ErrorLevel](docs/Pdf417ErrorLevel.md)
- [Model.Pdf417MacroTerminator](docs/Pdf417MacroTerminator.md)
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

