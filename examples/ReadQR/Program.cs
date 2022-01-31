using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using System;
using System.IO;
using System.Reflection;

namespace ReadQR
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

        static string ReadQR(IBarcodeApi api, string fileName)
        {
            using (FileStream imageStream = File.OpenRead(fileName))
            {
                BarcodeResponseList recognized = api.PostBarcodeRecognizeFromUrlOrContent(
                    new PostBarcodeRecognizeFromUrlOrContentRequest(image: imageStream)
                );

                return recognized.Barcodes[0].BarcodeValue;
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

            string result = ReadQR(api, fileName);
            Console.WriteLine($"File '{fileName}' recognized, result: '{result}'");
        }
    }
}
