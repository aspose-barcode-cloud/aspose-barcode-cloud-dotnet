using System;
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
    public class ScanTests : TestsBase
    {
        private IScanApi _api;

        [SetUp]
        public void Init()
        {
            _api = new ScanApi(TestConfiguration);
        }


        [Test]
        public async Task BarcodeScanBodyPostAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            byte[] buffer = new byte[image.Length];

            await image.ReadAsync(buffer, 0, buffer.Length);
            // Act
            BarcodeResponseList response = await _api.BarcodeScanBodyPostAsync(
                new BarcodeScanBodyPostRequest(
                    new ScanBase64Request()
                    {
                        FileBase64 = Convert.ToBase64String(buffer)
                    }
                    )

            );

            // Assert
            Assert.AreEqual(2, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

        [Test]
        public async Task BarcodeScanGetAsyncTest()
        {
            // Act
            BarcodeResponseList response = await _api.BarcodeScanGetAsync(new BarcodeScanGetRequest("https://products.aspose.app/barcode/scan/img/how-to/scan/step2.png"));

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("http://en.m.wikipedia.org", response.Barcodes[0].BarcodeValue);
        }

        [Test]
        public async Task BarcodeScanFormPostAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            BarcodeResponseList response = await _api.BarcodeScanFormPostAsync(
                new BarcodeScanFormPostRequest(image)
            );

            // Assert
            Assert.AreEqual(2, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }

        //[Test]
        //public void ScanBarcodeAsyncTimeoutTest()
        //{
        //    // Arrange
        //    using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

        //    // Act
        //    var apiException = Assert.ThrowsAsync<ApiException>(async () =>
        //    {
        //        await _api.ScanBarcodeAsync(
        //            new ScanBarcodeRequest(image)
        //            {
        //                timeout = 1
        //            }
        //        );
        //    });

        //    // Assert
        //    Assert.IsNotNull(apiException);
        //    Assert.AreEqual(408, apiException.ErrorCode);
        //}
    }
}
