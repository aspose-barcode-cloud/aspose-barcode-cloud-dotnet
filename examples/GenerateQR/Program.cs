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
