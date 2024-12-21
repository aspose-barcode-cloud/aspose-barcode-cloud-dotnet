using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

using System;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;

namespace GenerateSnippets;

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
        string fileName = Path.GetFullPath(Path.Join("Tests", "test_data",
            "qr.png"
        ));

        GenerateApi generateApi = new GenerateApi(MakeConfiguration());

        Stream generated = await generateApi.GenerateAsync(EncodeBarcodeType.QR, "Aspose.BarCode.Cloud",
                        imageHeight: 200,
                        imageWidth: 200,
                        resolution: 300,
                        units: GraphicsUnit.Pixel
            );

        await using FileStream stream = File.Create(fileName);
        await generated.CopyToAsync(stream);

        Console.WriteLine($"File '{fileName}' generated.");
    }
}
