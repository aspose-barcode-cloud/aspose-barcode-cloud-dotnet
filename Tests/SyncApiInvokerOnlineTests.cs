using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Internal;
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
            ApiInvoker invoker = ApiInvokerFactory.CreateInvoker(TestConfiguration);
            string resourcePath = UrlHelper.AddQueryParameterToUrl(
                TestConfiguration.GetApiRootUrl() + "/barcode/scan",
                "fileUrl",
                "https://products.aspose.app/barcode/scan/img/how-to/scan/step2.png");

            string response = invoker.InvokeApi(resourcePath, "GET", null, null, null);
            BarcodeResponseList result = (BarcodeResponseList)SerializationHelper.Deserialize(
                response,
                typeof(BarcodeResponseList));

            Assert.AreEqual(1, result.Barcodes.Count);
            Assert.AreEqual(nameof(DecodeBarcodeType.QR), result.Barcodes[0].Type);
            Assert.AreEqual("http://en.m.wikipedia.org", result.Barcodes[0].BarcodeValue);
            StringAssert.Contains("\"barcodeValue\":\"http://en.m.wikipedia.org\"", result.ToString());
            StringAssert.Contains("\"BarcodeValue\":\"http://en.m.wikipedia.org\"", result.Barcodes[0].ToString());
            StringAssert.Contains("\"X\":", result.Barcodes[0].Region[0].ToString());
        }

        [Test]
        public void SyncScanBodyUsesOnlineApi()
        {
            ApiInvoker invoker = ApiInvokerFactory.CreateInvoker(TestConfiguration);
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
            ApiInvoker invoker = ApiInvokerFactory.CreateInvoker(TestConfiguration);
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
            ApiInvoker invoker = ApiInvokerFactory.CreateInvoker(TestConfiguration);

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
        public void ConfigurationJsonKeepsOnlineAuthMode()
        {
            string json = JsonSerializer.Serialize(TestConfiguration);

            StringAssert.Contains("\"AuthType\":\"", json);
            Assert.IsTrue(
                TestConfiguration.AuthType == AuthType.JWT ||
                TestConfiguration.AuthType == AuthType.ExternalAuth);
        }
    }
}
