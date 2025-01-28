using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class RecognizeTests : TestsBase
    {
        private IRecognizeApi _api;

        [SetUp]
        public void Init()
        {
            _api = new RecognizeApi(TestConfiguration);
        }

        [TearDown]
        public void Cleanup()
        {
        }

        [Test]
        public async Task RecognizeBase64AsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            byte[] buffer = new byte[image.Length];
            await image.ReadAsync(buffer, 0, buffer.Length);

            // Act
            BarcodeResponseList response = await _api.RecognizeBase64Async(
                new RecognizeBase64Request()
                {
                    RecognitionImageKind = RecognitionImageKind.ClearImage,
                    RecognitionMode = RecognitionMode.Normal,
                    BarcodeTypes = new List<DecodeBarcodeType> { DecodeBarcodeType.QR },
                    FileBase64 = Convert.ToBase64String(buffer)
                }

            );

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

        [Test]
        public async Task RecognizeMultipartAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            BarcodeResponseList response = await _api.RecognizeMultipartAsync(DecodeBarcodeType.QR, image,
                recognitionImageKind: RecognitionImageKind.ClearImage, recognitionMode: RecognitionMode.Normal);

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

        [Test]
        public async Task RecognizeAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            BarcodeResponseList response = await _api.RecognizeAsync(DecodeBarcodeType.QR,
                "https://products.aspose.app/barcode/scan/img/how-to/scan/step2.png",
                recognitionImageKind: RecognitionImageKind.ClearImage,
                recognitionMode: RecognitionMode.Normal);

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("http://en.m.wikipedia.org", response.Barcodes[0].BarcodeValue);
        }

    }
}
