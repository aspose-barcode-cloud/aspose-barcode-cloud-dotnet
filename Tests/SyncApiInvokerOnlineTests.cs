using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers;
using Aspose.BarCode.Cloud.Sdk.Model;
using NUnit.Framework;
using SdkFileInfo = Aspose.BarCode.Cloud.Sdk.Internal.FileInfo;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class SyncApiInvokerOnlineTests : TestsBase
    {
        [Test]
        public void SyncScanGetUsesOnlineApi()
        {
            ApiInvoker invoker = CreateInvoker(TestConfiguration);
            string resourcePath = UrlHelper.AddQueryParameterToUrl(
                TestConfiguration.GetApiRootUrl() + "/barcode/scan",
                "fileUrl",
                "https://raw.githubusercontent.com/aspose-barcode-cloud/Aspose.BarCode-Cloud-SDK-for-.NET/main/Tests/test_data/Test_PostGenerateMultiple.png");

            string response = invoker.InvokeApi(resourcePath, "GET", null, null, null);
            BarcodeResponseList result = (BarcodeResponseList)SerializationHelper.Deserialize(
                response,
                typeof(BarcodeResponseList));

            Assert.AreEqual(2, result.Barcodes.Count);
            Assert.AreEqual(nameof(DecodeBarcodeType.QR), result.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", result.Barcodes[0].BarcodeValue);
            Assert.AreEqual(nameof(DecodeBarcodeType.Code128), result.Barcodes[1].Type);
            Assert.AreEqual("Hello world!", result.Barcodes[1].BarcodeValue);
            StringAssert.Contains("\"barcodeValue\":\"Hello world!\"", result.ToString());
            StringAssert.Contains("\"BarcodeValue\":\"Hello world!\"", result.Barcodes[0].ToString());
            StringAssert.Contains("\"X\":", result.Barcodes[0].Region[0].ToString());
        }

        [Test]
        public void SyncScanBodyUsesOnlineApi()
        {
            ApiInvoker invoker = CreateInvoker(TestConfiguration);
            byte[] imageBytes;
            using (Stream image = GetTestImage("Test_PostGenerateMultiple.png"))
            {
                imageBytes = StreamHelper.ReadAsBytes(image);
            }

            string body = SerializationHelper.Serialize(
                new ScanBase64Request
                {
                    FileBase64 = System.Convert.ToBase64String(imageBytes)
                });

            string response = invoker.InvokeApi(
                TestConfiguration.GetApiRootUrl() + "/barcode/scan-body",
                "POST",
                body,
                null,
                null);
            BarcodeResponseList result = (BarcodeResponseList)SerializationHelper.Deserialize(
                response,
                typeof(BarcodeResponseList));

            Assert.AreEqual(2, result.Barcodes.Count);
            Assert.AreEqual("Hello world!", result.Barcodes[0].BarcodeValue);
        }

        [Test]
        public void SyncScanMultipartUsesOnlineApi()
        {
            ApiInvoker invoker = CreateInvoker(TestConfiguration);
            byte[] imageBytes = File.ReadAllBytes(TestFilePath("Test_PostGenerateMultiple.png"));
            Dictionary<string, object> formParams = new Dictionary<string, object>
            {
                ["file"] = new SdkFileInfo("barcode.png", imageBytes)
            };

            string response = invoker.InvokeApi(
                TestConfiguration.GetApiRootUrl() + "/barcode/scan-multipart",
                "POST",
                null,
                null,
                formParams);
            BarcodeResponseList result = (BarcodeResponseList)SerializationHelper.Deserialize(
                response,
                typeof(BarcodeResponseList));

            Assert.AreEqual(2, result.Barcodes.Count);
            Assert.AreEqual("Hello world!", result.Barcodes[0].BarcodeValue);
        }

        [Test]
        public void SyncApiExceptionHandlerUsesOnlineApiError()
        {
            ApiInvoker invoker = CreateInvoker(TestConfiguration);

            ApiException exception = Assert.Throws<ApiException>(
                () => invoker.InvokeApi(
                    TestConfiguration.GetApiRootUrl() + "/barcode/scan",
                    "GET",
                    null,
                    null,
                    null));

            Assert.AreEqual(400, exception!.ErrorCode);
            StringAssert.Contains("fileUrl", exception.Message);
        }

        [Test]
        public void SyncDebugModeLogsOnlineRequestAndResponse()
        {
            using StringWriter writer = new StringWriter();
            TextWriterTraceListener listener = new TextWriterTraceListener(writer);
            Trace.Listeners.Add(listener);
            try
            {
                Configuration configuration = DebugConfiguration();
                ApiInvoker invoker = CreateInvoker(configuration);
                string resourcePath = UrlHelper.AddQueryParameterToUrl(
                    configuration.GetApiRootUrl() + "/barcode/scan",
                    "fileUrl",
                    "https://raw.githubusercontent.com/aspose-barcode-cloud/Aspose.BarCode-Cloud-SDK-for-.NET/main/Tests/test_data/Test_PostGenerateMultiple.png");

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
            StringAssert.Contains("Hello world!", trace);
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

        [Test]
        public void ConfigurationJsonKeepsOnlineAuthMode()
        {
            string json = JsonSerializer.Serialize(TestConfiguration);

            StringAssert.Contains("\"AuthType\":\"", json);
            Assert.IsTrue(
                TestConfiguration.AuthType == AuthType.JWT ||
                TestConfiguration.AuthType == AuthType.ExternalAuth);
        }

        private static ApiInvoker CreateInvoker(Configuration configuration)
        {
            List<IRequestHandler> requestHandlers = new List<IRequestHandler>();
            switch (configuration.AuthType)
            {
                case AuthType.JWT:
                    requestHandlers.Add(new JwtRequestHandler(configuration));
                    break;
                case AuthType.ExternalAuth:
                    requestHandlers.Add(new ExternalAuthorizationRequestHandler(configuration));
                    break;
                default:
                    throw new System.ArgumentOutOfRangeException(
                        $"Unknown AuthType={configuration.AuthType}.");
            }

            requestHandlers.Add(new DebugLogRequestHandler(configuration));
            requestHandlers.Add(new ApiExceptionRequestHandler());
            return new ApiInvoker(configuration, requestHandlers);
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
