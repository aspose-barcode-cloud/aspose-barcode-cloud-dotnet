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
    public class GenerateTests : TestsBase
    {
        private IGenerateApi _api;

        [SetUp]
        public void Init()
        {
            _api = new GenerateApi(TestConfiguration);
        }

        [Test]
        public async Task TestBarcodeGenerateBarcodeTypeGet()
        {

            var response = await _api.GenerateAsync(EncodeBarcodeType.Code128, "Hello!");

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

        [Test]
        public async Task TestBarcodeGenerateBodyPost()
        {
            // Test case for barcode_generate_body_post
            // Generate barcode from params in body
            var imageParams = new BarcodeImageParams
            {
                ImageFormat = BarcodeImageFormat.Jpeg
            };

            var encodeData = new EncodeData()
            {
                Data = "VGVzdA==",
                DataType = EncodeDataType.Base64Bytes
            };

            var generatorParams = new GenerateParams()
            {
                BarcodeType = EncodeBarcodeType.QR,
                EncodeData = encodeData,
                BarcodeImageParams = imageParams
            };


            var response = await _api.GenerateBodyAsync(generatorParams);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

        [Test]
        public async Task TestBarcodeGenerateMultipartPost()
        {

            var response = await _api.GenerateMultipartAsync(EncodeBarcodeType.QR, "54657374", dataType: EncodeDataType.HexBytes);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

    }
}
