using System.Collections.Generic;
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
        private IBarcodeApi _api;

        [SetUp]
        public void Init()
        {
            _api = new BarcodeApi(TestConfiguration);
        }


        [Test]
        public async Task ScanBarcodeAsyncTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            BarcodeResponseList response = await _api.ScanBarcodeAsync(
                new ScanBarcodeRequest(image)
                {
                    decodeTypes = new List<DecodeBarcodeType> { DecodeBarcodeType.Code128, DecodeBarcodeType.QR }
                }
            );

            // Assert
            Assert.AreEqual(2, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }


        [Test]
        public void ScanBarcodeAsyncTimeoutTest()
        {
            // Arrange
            using Stream image = GetTestImage("Test_PostGenerateMultiple.png");

            // Act
            var apiException = Assert.ThrowsAsync<ApiException>(async () =>
            {
                await _api.ScanBarcodeAsync(
                    new ScanBarcodeRequest(image)
                    {
                        timeout = 1
                    }
                );
            });

            // Assert
            Assert.IsNotNull(apiException);
            Assert.AreEqual(408, apiException.ErrorCode);
        }
    }
}
