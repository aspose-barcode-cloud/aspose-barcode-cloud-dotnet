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

#pragma warning disable CA2022
            await image.ReadAsync(buffer, 0, buffer.Length);
#pragma warning restore CA2022
            // Act
            BarcodeResponseList response = await _api.ScanBase64Async(
                    new ScanBase64Request()
                    {
                        FileBase64 = Convert.ToBase64String(buffer)
                    }
            );

            // Assert
            Assert.AreEqual(2, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

        [Test]
        public async Task ScanAsyncTest()
        {
            // Act
            BarcodeResponseList response = await _api.ScanAsync("https://products.aspose.app/barcode/scan/img/how-to/scan/step2.png");

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("http://en.m.wikipedia.org", response.Barcodes[0].BarcodeValue);
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
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

    }
}
