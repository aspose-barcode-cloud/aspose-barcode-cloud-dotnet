using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace ScanSnippets;

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
        var scanApi = new ScanApi(MakeConfiguration());

        string fileName = Path.GetFullPath(Path.Join("Tests", "test_data",
            "qr.png"
        ));

        byte[] imageBytes = await File.ReadAllBytesAsync(fileName);
        string imageBase64 = Convert.ToBase64String(imageBytes);

        var request = new ScanBase64Request
        {
            FileBase64 = imageBase64
        };

        var result = await scanApi.ScanBase64Async(request);

        Console.WriteLine($"File '{fileName}' recognized, result: '{result.Barcodes[0].BarcodeValue}'");
    }
}
