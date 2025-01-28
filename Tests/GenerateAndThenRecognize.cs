using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class GenerateAndThenRecognize : TestsBase
    {
        [SetUp]
        public void Init()
        {
            _generateApi = new GenerateApi(TestConfiguration);
            _scanApi = new ScanApi(TestConfiguration);
        }

        private IGenerateApi _generateApi;
        private IScanApi _scanApi;

        [Test]
        [Category("AsyncTests")]
        public async Task GenerateAndThenRecognizeAsyncTest()
        {
            Stream generatedImage = await _generateApi.GenerateAsync(EncodeBarcodeType.QR, "Test");

            BarcodeResponseList recognized = await _scanApi.ScanMultipartAsync(generatedImage);

            Assert.AreEqual(1, recognized.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), recognized.Barcodes.First().Type);
            Assert.AreEqual("Test", recognized.Barcodes.First().BarcodeValue);
            Assert.AreEqual(
                "{\"barcodes\":[{" +
                "\"barcodeValue\":\"Test\"," +
                "\"type\":\"QR\"," +
                "\"region\":[{\"x\":7,\"y\":7},{\"x\":49,\"y\":6},{\"x\":48,\"y\":48},{\"x\":6,\"y\":49}],\"checksum\":null}]}",
                recognized.ToString()
            );
        }
    }
}
