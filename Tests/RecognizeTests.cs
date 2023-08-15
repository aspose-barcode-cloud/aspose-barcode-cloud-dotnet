using System.IO;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class RecognizeTests : TestsBase
    {
        private IBarcodeApi _api;

        [SetUp]
        public void Init()
        {
            _api = new BarcodeApi(TestConfiguration);
        }

        [TearDown]
        public void Cleanup()
        {
        }


        [Test]
        public void RecognizeQrTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            BarcodeResponseList response = _api.PostBarcodeRecognizeFromUrlOrContent(
                new PostBarcodeRecognizeFromUrlOrContentRequest(image)
                {
                    Preset = PresetType.HighPerformance.ToString(),
                    Type = DecodeBarcodeType.QR.ToString()
                }
            );

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }


        [Test]
        public void RecognizeWithTimeoutTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            var apiException = Assert.Throws<ApiException>(() =>
            {
                _api.PostBarcodeRecognizeFromUrlOrContent(
                    new PostBarcodeRecognizeFromUrlOrContentRequest(image)
                    {
                        Preset = PresetType.HighPerformance.ToString(),
                        Type = DecodeBarcodeType.QR.ToString(),
                        Timeout = 1
                    }
                );
            });

            // Assert
            Assert.IsNotNull(apiException);
            Assert.AreEqual(408, apiException.ErrorCode);
        }
    }
}
