using System.IO;
using System.Linq;
using Aspose.BarCode.Cloud.Sdk.Api;
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

        private BarcodeApi _api;

        [Test]
        public void GenerateAndThenRecognizeTest()
        {
            Stream generated = _api.GetBarcodeGenerate(new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(), "Test"));

            BarcodeResponseList recognized = _api.PostBarcodeRecognizeFromUrlOrContent(
                new PostBarcodeRecognizeFromUrlOrContentRequest(
                    image: generated
                ));

            Assert.AreEqual(1, recognized.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), recognized.Barcodes.First().Type);
            Assert.AreEqual("Test", recognized.Barcodes.First().BarcodeValue);
        }
    }
}
