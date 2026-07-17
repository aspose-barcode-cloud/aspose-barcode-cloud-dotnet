using System;
using System.IO;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class ScanTests : TestsBase
    {
        private IScanApi _api;

        [SetUp]
        public void Init()
        {
            _api = new ScanApi(TestConfiguration);
        }


        [Test]
        public async Task ScanBase64AsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            byte[] buffer = new byte[image.Length];

            _ = await image.ReadAsync(buffer, 0, buffer.Length);
            // Act
            BarcodeResponseList response = await _api.ScanBase64Async(
                    new ScanBase64Request()
                    {
                        FileBase64 = Convert.ToBase64String(buffer)
                    }
            );

            // Assert
            Assert.AreEqual(2, response.Barcodes.Count);
            Assert.AreEqual(nameof(DecodeBarcodeType.QR), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

        [Test]
        public async Task ScanAsyncTest()
        {
            // Act
            BarcodeResponseList response = await _api.ScanAsync("https://raw.githubusercontent.com/aspose-barcode-cloud/Aspose.BarCode-Cloud-SDK-for-.NET/main/Tests/test_data/Test_PostGenerateMultiple.png");

            // Assert
            Assert.AreEqual(2, response.Barcodes.Count);
            Assert.AreEqual(nameof(DecodeBarcodeType.QR), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
            Assert.AreEqual(nameof(DecodeBarcodeType.Code128), response.Barcodes[1].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[1].BarcodeValue);
        }

        [Test]
        public async Task ScanMultipartAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            BarcodeResponseList response = await _api.ScanMultipartAsync(image);

            // Assert
            Assert.AreEqual(2, response.Barcodes.Count);
            Assert.AreEqual(nameof(DecodeBarcodeType.QR), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

    }
}
