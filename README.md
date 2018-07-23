# Aspose.BarCode for Cloud .NET SDK
[Aspose.BarCode for Cloud](https://products.aspose.cloud/barcode/cloud) is a REST API for Linear, 2D and postal barcode generation and recognition in the cloud. API recognizes and generates barcode images in a variety of formats. Barcode REST API allows to specify barcode image attributes like image width, height, border style and output image format in order to customize the generation process. Developers can also specify the barcode type and text attributes such as text location and font styles in order to suit the application requirements.

This repository contains Aspose.BarCode for Cloud .NET SDK source code. This SDK allows you to work with Aspose.BarCode for Cloud REST APIs in your .NET Core or .NET Standard applications quickly and easily.

Aspose.BarCode for Cloud .NET SDK provides cross-platform bindings for:
- .NET Standard 2.0
- .NET Framework 2.0 and higher

To use these SDKs, you will need App SID and App Key which can be looked up at [Aspose Cloud Dashboard](https://dashboard.aspose.cloud/#/apps) (free registration in Aspose Cloud is required for this).

## How to use the SDK?
The complete source code is available in this repository folder. You can either directly use it in your project via source code or get [NuGet distribution](https://www.nuget.org/packages/Aspose.BarCode-Cloud/) (recommended).

## Prerequisites

To use Aspose.BarCode for Cloud .NET SDK you need to register an account with [Aspose Cloud](https://www.aspose.cloud/) and lookup/create App Key and SID at [Cloud Dashboard](https://dashboard.aspose.cloud/#/apps). There is free quota available. For more details, see [Aspose Cloud Pricing](https://purchase.aspose.cloud/pricing).

## Installation

### Install Aspose.BarCode-Cloud via NuGet

From the command line:

	nuget install Aspose.BarCode-Cloud

From Package Manager:

	PM> Install-Package Aspose.BarCode-Cloud

From within Visual Studio:

1. Open the Solution Explorer.
2. Right-click on a project within your solution.
3. Click on *Manage NuGet Packages...*
4. Click on the *Browse* tab and search for "Aspose.BarCode-Cloud".
5. Click on the Aspose.BarCode-Cloud package, select the appropriate version in the right-tab and click *Install*.

## Sample usage

The examples below show how you can generate Code128 barcode and save it into local file using Aspose.BarCode-Cloud library:
```csharp
var barCodeApi = new BarCodeApi(AppKey, AppSid);
using (Stream response = api.BarCodeGetBarCodeGenerate(new BarCodeGetBarCodeGenerateRequest("Sample text", "Code128", "jpg")))
using (FileStream stream = File.Create("out.jpg"))
{
   response.CopyTo(stream);
}
```

## Dependencies
- .NET Framework 2.0 or later, .NET Standard 2.0
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/)

# Licensing
All Aspose.BarCode for Cloud SDKs, helper scripts and templates are licensed under [MIT License](LICENSE).

# Resources
+ [**Website**](https://www.aspose.cloud)
+ [**Product Home**](https://products.aspose.cloud/barcode/cloud)
+ [**Documentation**](https://docs.aspose.cloud/display/barcodecloud/Home)
+ [**Free Support Forum**](https://forum.aspose.cloud/c/barcode)
+ [**Paid Support Helpdesk**](https://helpdesk.aspose.cloud/)
+ [**Blog**](https://blog.aspose.cloud/category/aspose-products/aspose-barcode-product-family/)
