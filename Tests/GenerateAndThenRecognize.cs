using System.IO;
using System.Linq;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class GenerateAndThenRecognize
    {
        private BarcodeApi _api;

        [SetUp]
        public void Init()
        {
            Configuration config;
            using (StreamReader file = File.OpenText(Path.Combine("..", "..", "..", "Configuration.json")))
            {
                var serializer = new JsonSerializer();
                config = (Configuration) serializer.Deserialize(file, typeof(Configuration));
            }

            _api = new BarcodeApi(config);
        }

        [Test]
        public void GenerateAndThenRecognizeTest()
        {
            Stream generated = _api.GetBarcodeGenerate(new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(), "Test"));

            BarcodeResponseList recognized = _api.PostBarcodeRecognizeFromUrlOrContent(new PostBarcodeRecognizeFromUrlOrContentRequest(
                image: generated
            ));
            
            Assert.AreEqual(1, recognized.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(),recognized.Barcodes.First().Type);
            Assert.AreEqual("Test",recognized.Barcodes.First().BarcodeValue);
        }
    }
}