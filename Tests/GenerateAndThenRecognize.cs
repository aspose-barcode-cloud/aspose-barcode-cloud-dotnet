using System.IO;
using System.Linq;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class GenerateAndThenRecognize : TestsBase
    {
        [SetUp]
        public void Init()
        {
            _api = new BarcodeApi(TestConfiguration);
        }

        private IBarcodeApi _api;

        [Test]
        public void GenerateAndThenRecognizeTest()
        {
            Stream generatedImage = _api.GetBarcodeGenerate(new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(), "Test"));

            BarcodeResponseList recognized = _api.PostBarcodeRecognizeFromUrlOrContent(
                new PostBarcodeRecognizeFromUrlOrContentRequest(generatedImage)
            );

            Assert.AreEqual(1, recognized.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), recognized.Barcodes.First().Type);
            Assert.AreEqual("Test", recognized.Barcodes.First().BarcodeValue);
            Assert.AreEqual(
                "{\"barcodes\":[{" +
                "\"barcodeValue\":\"Test\"," +
                "\"type\":\"QR\"," +
                "\"region\":[{\"x\":7,\"y\":7},{\"x\":49,\"y\":7},{\"x\":49,\"y\":49},{\"x\":7,\"y\":49}]}]}",
                recognized.ToString()
            );
        }
    }
}
