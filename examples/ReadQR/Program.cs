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
            new RecognizeBase64Request(new RecognizeBase64Request()
            {
                BarcodeTypes = new List<DecodeBarcodeType> { DecodeBarcodeType.QR },
                FileBase64 = imageBase64
            }
        ));

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
