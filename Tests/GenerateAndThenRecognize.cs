using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
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
        [Category("AsyncTests")]
        public async Task GenerateAndThenRecognizeAsyncTest()
        {
            Stream generatedImage = await _api.GetBarcodeGenerateAsync(new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(), "Test"));

            BarcodeResponseList recognized = await _api.PostBarcodeRecognizeFromUrlOrContentAsync(
                new PostBarcodeRecognizeFromUrlOrContentRequest(generatedImage)
                {
                    Preset = PresetType.HighPerformance.ToString(),
                    Types = new List<DecodeBarcodeType>
                    {
                        DecodeBarcodeType.QR
                    }
                }
            );

            Assert.AreEqual(1, recognized.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), recognized.Barcodes.First().Type);
            Assert.AreEqual("Test", recognized.Barcodes.First().BarcodeValue);
            Assert.AreEqual(
                "{\"barcodes\":[{" +
                "\"barcodeValue\":\"Test\"," +
                "\"type\":\"QR\"," +
                "\"region\":[{\"x\":7,\"y\":7},{\"x\":49,\"y\":6},{\"x\":48,\"y\":48},{\"x\":6,\"y\":49}]}]}",
                recognized.ToString()
            );
        }
    }
}
