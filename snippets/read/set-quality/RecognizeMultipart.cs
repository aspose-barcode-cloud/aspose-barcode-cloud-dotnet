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
            "aztec.png"
        ));

        using var fileStream = File.OpenRead(fileName);
        var request = new BarcodeRecognizeMultipartPostRequest(DecodeBarcodeType.Aztec, fileStream)
        {
            RecognitionMode = RecognitionMode.Normal,
            ImageKind = RecognitionImageKind.ScannedDocument
        };

        BarcodeResponseList result = await recognizeApi.BarcodeRecognizeMultipartPostAsync(request);

        Console.WriteLine($"File '{fileName}' recognized, result: '{result.Barcodes[0].BarcodeValue}'");
    }
}
