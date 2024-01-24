using System.IO;
using System.Threading.Tasks;
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
#pragma warning disable CS0612 // Method is obsolete
            BarcodeResponseList response = _api.PostBarcodeRecognizeFromUrlOrContent(
#pragma warning restore CS0612 // Method is obsolete
                new PostBarcodeRecognizeFromUrlOrContentRequest(image)
                {
                    Preset = PresetType.HighPerformance.ToString(),
                    Type = DecodeBarcodeType.QR.ToString(),
                    Timeout = 30_000
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
#pragma warning disable CS0612 // Method is obsolete
                _api.PostBarcodeRecognizeFromUrlOrContent(
#pragma warning restore CS0612 // Method is obsolete
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

        [Test]
        public async Task RecognizeQrAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            BarcodeResponseList response = await _api.PostBarcodeRecognizeFromUrlOrContentAsync(
                new PostBarcodeRecognizeFromUrlOrContentRequest(image)
                {
                    Preset = PresetType.HighPerformance.ToString(),
                    Type = DecodeBarcodeType.QR.ToString(),
                    Timeout = 30_000
                }
            );

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }


        [Test]
        public void RecognizeWithTimeoutAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            var apiException = Assert.ThrowsAsync<ApiException>(async () =>
            {
                await _api.PostBarcodeRecognizeFromUrlOrContentAsync(
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
