using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace RecognizeSnippets;

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

        string fileName = Path.GetFullPath(Path.Join(
            Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location),
            "..", "..", "..", "..", ".."
            "multi-types.png"
        ));

        byte[] imageBytes = await File.ReadAllBytesAsync(fileName);
        string imageBase64 = Convert.ToBase64String(imageBytes);


        var recognizeBase64Request = new RecognizeBase64Request
        {
            BarcodeTypes = new List<DecodeBarcodeType> { DecodeBarcodeType.QR, DecodeBarcodeType.Pdf417 },
            FileBase64 = imageBase64
        };

        var request = new BarcodeRecognizeBodyPostRequest(recognizeBase64Request);
        BarcodeResponseList response = await recognizeApi.BarcodeRecognizeBodyPostAsync(request);

        Console.WriteLine($"File '{fileName}' recognized, results: ");
        foreach(var result in response.Barcodes)
        {
             Console.WriteLine($"Value: '{result.BarcodeValue}', type: {result.Type}");
        }

    }
}
