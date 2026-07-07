using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Aspose.BarCode.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class DebugLogOnlineTests : TestsBase
    {
        [Test]
        public void SyncDebugModeLogsOnlineRequestAndResponse()
        {
            using StringWriter writer = new StringWriter();
            TextWriterTraceListener listener = new TextWriterTraceListener(writer);
            Trace.Listeners.Add(listener);
            try
            {
                Configuration configuration = DebugConfiguration();
                ApiInvoker invoker = ApiInvokerFactory.CreateInvoker(configuration);
                string resourcePath = UrlHelper.AddQueryParameterToUrl(
                    configuration.GetApiRootUrl() + "/barcode/scan",
                    "fileUrl",
                    "https://products.aspose.app/barcode/scan/img/how-to/scan/step2.png");

                string response = invoker.InvokeApi(resourcePath, "GET", null, null, null);

                Assert.IsNotEmpty(response);
                Trace.Flush();
            }
            finally
            {
                Trace.Listeners.Remove(listener);
                listener.Dispose();
            }

            string trace = writer.ToString();
            StringAssert.Contains("GET:", trace);
            StringAssert.Contains("Response 200", trace);
            StringAssert.Contains("http://en.m.wikipedia.org", trace);
        }

        [Test]
        public async Task AsyncDebugModeLogsOnlineRequestAndResponse()
        {
            using StringWriter writer = new StringWriter();
            TextWriterTraceListener listener = new TextWriterTraceListener(writer);
            Trace.Listeners.Add(listener);
            try
            {
                ScanApi api = new ScanApi(DebugConfiguration());
                byte[] imageBytes = File.ReadAllBytes(TestFilePath("Test_PostGenerateMultiple.png"));

                BarcodeResponseList response = await api.ScanBase64Async(
                    new ScanBase64Request
                    {
                        FileBase64 = System.Convert.ToBase64String(imageBytes)
                    });

                Assert.AreEqual(2, response.Barcodes.Count);
                Trace.Flush();
            }
            finally
            {
                Trace.Listeners.Remove(listener);
                listener.Dispose();
            }

            string trace = writer.ToString();
            StringAssert.Contains("POST:", trace);
            StringAssert.Contains("Response 200", trace);
            StringAssert.Contains("Hello world!", trace);
        }

        private Configuration DebugConfiguration()
        {
            Configuration configuration = new Configuration
            {
                ApiBaseUrl = TestConfiguration.ApiBaseUrl,
                TokenUrl = TestConfiguration.TokenUrl,
                ClientId = TestConfiguration.ClientId,
                ClientSecret = TestConfiguration.ClientSecret,
                DebugMode = true,
                DefaultHeaders = new Dictionary<string, string>(TestConfiguration.DefaultHeaders)
            };

            if (TestConfiguration.AuthType == AuthType.ExternalAuth)
            {
                configuration.JwtToken = TestConfiguration.JwtToken;
            }

            return configuration;
        }
    }
}
