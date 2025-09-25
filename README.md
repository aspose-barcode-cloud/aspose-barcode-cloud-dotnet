# Aspose.BarCode Cloud SDK for .NET

[![License](https://img.shields.io/github/license/aspose-barcode-cloud/aspose-barcode-cloud-dotnet)](LICENSE)
[![.NET Core Linux](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/dotnet-core.yml/badge.svg?branch=main)](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/dotnet-core.yml)
[![.NET Framework Windows](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/net-framework.yml/badge.svg?branch=main)](https://github.com/aspose-barcode-cloud/aspose-barcode-cloud-dotnet/actions/workflows/net-framework.yml)
[![Nuget](https://img.shields.io/nuget/v/Aspose.BarCode-Cloud)](https://www.nuget.org/packages/Aspose.BarCode-Cloud/)

- API version: 4.0
- SDK version: 25.9.0

## SDK and API Version Compatibility:

- SDK Version 25.1 and Later: Starting from SDK version 25.1, all subsequent versions are compatible with API Version v4.0.
- SDK Version 24.12 and Earlier: These versions are compatible with API Version v3.0.

## Demo applications

[Scan QR](https://products.aspose.app/barcode/scanqr) | [Generate Barcode](https://products.aspose.app/barcode/generate) | [Recognize Barcode](https://products.aspose.app/barcode/recognize)
:---: | :---: | :---:
[![ScanQR](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_scanqr-app-48.png)](https://products.aspose.app/barcode/scanqr) | [![Generate](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_generate-app-48.png)](https://products.aspose.app/barcode/generate) | [![Recognize](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_recognize-app-48.png)](https://products.aspose.app/barcode/recognize)
[**Generate Wi-Fi QR**](https://products.aspose.app/barcode/wifi-qr) | [**Embed Barcode**](https://products.aspose.app/barcode/embed) | [**Scan Barcode**](https://products.aspose.app/barcode/scan)
[![Wi-FiQR](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_wifi-qr-app-48.png)](https://products.aspose.app/barcode/wifi-qr) | [![Embed](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_embed-app-48.png)](https://products.aspose.app/barcode/embed) | [![Scan](https://raw.githubusercontent.com/aspose-barcode-cloud/aspose-barcode-cloud-codegen/main/img/aspose_scan-app-48.png)](https://products.aspose.app/barcode/scan)

[Aspose.BarCode for Cloud](https://products.aspose.cloud/barcode/) is a REST API for Linear, 2D and postal barcode generation and recognition in the cloud. API recognizes and generates barcode images in a variety of formats. Barcode REST API allows to specify barcode image attributes like image width, height, border style and output image format in order to customize the generation process. Developers can also specify the barcode type and text attributes such as text location and font styles in order to suit the application requirements.

This repository contains Aspose.BarCode Cloud SDK for .NET source code. This SDK allows you to work with Aspose.BarCode for Cloud REST APIs in your .NET Core or .NET Framework applications quickly and easily.

Aspose.BarCode Cloud SDK for .NET provides cross-platform bindings for:

- .NET 8 and higher
- .NET Standard 2.0 and higher
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

    private static async Task<string> ReadQR(IRecognizeApi api, string fileName)
    {
        byte[] imageBytes = await File.ReadAllBytesAsync(fileName);
        string imageBase64 = Convert.ToBase64String(imageBytes);

        BarcodeResponseList recognized = await api.RecognizeBase64Async(
            new RecognizeBase64Request()
            {
                BarcodeTypes = new List<DecodeBarcodeType> { DecodeBarcodeType.QR },
                FileBase64 = imageBase64
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

        var api = new RecognizeApi(MakeConfiguration());

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

    private static async Task GenerateQR(IGenerateApi api, string fileName)
    {
        await using Stream generated = await api.GenerateAsync(
                EncodeBarcodeType.QR,
                "QR code text",
                textLocation: CodeLocation.None,
                imageFormat: BarcodeImageFormat.Png
            );
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

        GenerateApi api = new GenerateApi(MakeConfiguration());

        await GenerateQR(api, fileName);
        Console.WriteLine($"File '{fileName}' generated.");
    }
}

```

## Dependencies

- [System.Text.Json](https://www.nuget.org/packages/System.Text.json)

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

All URIs are relative to *<https://api.aspose.cloud/v4.0>*

Class | Method | HTTP request | Description
----- | ------ | ------------ | -----------
*GenerateApi* | [**Generate**](docs/GenerateApi.md#generate) | **GET** /barcode/generate/{barcodeType} | Generate barcode using GET request with parameters in route and query string.
*GenerateApi* | [**GenerateBody**](docs/GenerateApi.md#generatebody) | **POST** /barcode/generate-body | Generate barcode using POST request with parameters in body in json or xml format.
*GenerateApi* | [**GenerateMultipart**](docs/GenerateApi.md#generatemultipart) | **POST** /barcode/generate-multipart | Generate barcode using POST request with parameters in multipart form.
*RecognizeApi* | [**Recognize**](docs/RecognizeApi.md#recognize) | **GET** /barcode/recognize | Recognize barcode from file on server in the Internet using GET requests with parameter in query string. For recognizing files from your hard drive use `recognize-body` or `recognize-multipart` endpoints instead.
*RecognizeApi* | [**RecognizeBase64**](docs/RecognizeApi.md#recognizebase64) | **POST** /barcode/recognize-body | Recognize barcode from file in request body using POST requests with parameters in body in json or xml format.
*RecognizeApi* | [**RecognizeMultipart**](docs/RecognizeApi.md#recognizemultipart) | **POST** /barcode/recognize-multipart | Recognize barcode from file in request body using POST requests with parameters in multipart form.
*ScanApi* | [**Scan**](docs/ScanApi.md#scan) | **GET** /barcode/scan | Scan barcode from file on server in the Internet using GET requests with parameter in query string. For scaning files from your hard drive use `scan-body` or `scan-multipart` endpoints instead.
*ScanApi* | [**ScanBase64**](docs/ScanApi.md#scanbase64) | **POST** /barcode/scan-body | Scan barcode from file in request body using POST requests with parameter in body in json or xml format.
*ScanApi* | [**ScanMultipart**](docs/ScanApi.md#scanmultipart) | **POST** /barcode/scan-multipart | Scan barcode from file in request body using POST requests with parameter in multipart form.

## Documentation for Models

- [Model.ApiError](docs/ApiError.md)
- [Model.ApiErrorResponse](docs/ApiErrorResponse.md)
- [Model.BarcodeImageFormat](docs/BarcodeImageFormat.md)
- [Model.BarcodeImageParams](docs/BarcodeImageParams.md)
- [Model.BarcodeResponse](docs/BarcodeResponse.md)
- [Model.BarcodeResponseList](docs/BarcodeResponseList.md)
- [Model.CodeLocation](docs/CodeLocation.md)
- [Model.DecodeBarcodeType](docs/DecodeBarcodeType.md)
- [Model.EncodeBarcodeType](docs/EncodeBarcodeType.md)
- [Model.EncodeData](docs/EncodeData.md)
- [Model.EncodeDataType](docs/EncodeDataType.md)
- [Model.GenerateParams](docs/GenerateParams.md)
- [Model.GraphicsUnit](docs/GraphicsUnit.md)
- [Model.RecognitionImageKind](docs/RecognitionImageKind.md)
- [Model.RecognitionMode](docs/RecognitionMode.md)
- [Model.RecognizeBase64Request](docs/RecognizeBase64Request.md)
- [Model.RegionPoint](docs/RegionPoint.md)
- [Model.ScanBase64Request](docs/ScanBase64Request.md)

