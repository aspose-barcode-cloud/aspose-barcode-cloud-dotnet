using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
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
        
        string fileName = Path.GetFullPath(Path.Join(
            Path.GetDirectoryName(Assembly.GetEntryAssembly()!.Location),
            "..", "..", "..", "..", ".."
            "qr.png"
        ));
        await using FileStream imageStream = File.OpenRead(fileName);
        byte[] imageBytes = new byte[imageStream.Length];
        await  imageStream.ReadAsync(imageBytes, 0, imageBytes.Length);
        string imageBase64 = Convert.ToBase64String(imageBytes);

        var base64Request = new ScanBase64Request {
            FileBase64 = imageBase64
        };
        var request = new BarcodeScanBodyPostRequest(base64Request);
        var result = await scanApi.BarcodeScanBodyPostAsync(request);

        Console.WriteLine($"File '{fileName}' recognized, result: '{result.Barcodes[0].BarcodeValue}'");
    }
}
