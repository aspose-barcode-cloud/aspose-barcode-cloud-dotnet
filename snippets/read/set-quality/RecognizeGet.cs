using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace RecgonizeSnippets;

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

    public static async Task Main(string[] args)
    {
        var recognizeApi = new RecognizeApi(MakeConfiguration());

        BarcodeResponseList result = await recognizeApi.RecognizeAsync(DecodeBarcodeType.QR,
         "https://products.aspose.app/barcode/scan/img/how-to/scan/step2.png",
            recognitionMode: RecognitionMode.Fast,
            recognitionImageKind: RecognitionImageKind.Photo);

        Console.WriteLine($"File recognized, result: '{result.Barcodes[0].BarcodeValue}'");
    }
}
