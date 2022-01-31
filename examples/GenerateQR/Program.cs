using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using System;
using System.IO;
using System.Reflection;

namespace GenerateQR
{
    class Program
    {
        static Configuration MakeConfiguration()
        {
            var config = new Configuration();

            var envToken = Environment.GetEnvironmentVariable("TEST_CONFIGURATION_JWT_TOKEN");
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

        static void GenerateQR(IBarcodeApi api, string fileName)
        {
            using (Stream generated = api.GetBarcodeGenerate(
                new GetBarcodeGenerateRequest(
                    EncodeBarcodeType.QR.ToString(),
                    "QR code text",
                    textLocation: "None", format: "png"))
            )
            {
                using (FileStream stream = File.Create(fileName))
                {
                    generated.CopyTo(stream);
                }
            }
        }

        static void Main(string[] args)
        {
            string fileName = Path.GetFullPath(Path.Join(
                Path.GetDirectoryName(Assembly.GetEntryAssembly().Location),
                "..", "..", "..", "..",
                "qr.png"
                ));

            var api = new BarcodeApi(MakeConfiguration());

            GenerateQR(api, fileName);
            Console.WriteLine($"File '{fileName}' generated.");
        }
    }
}
