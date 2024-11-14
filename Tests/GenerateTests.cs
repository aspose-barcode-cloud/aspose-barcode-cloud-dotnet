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
            // Test case for barcode_generate_barcode_type_get
            // Generate barcode
            var request = new BarcodeGenerateBarcodeTypeGetRequest(
                EncodeBarcodeType.Code128, "Hello!"
            );

            var response = await _api.BarcodeGenerateBarcodeTypeGetAsync(request);

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

            var request = new BarcodeGenerateBodyPostRequest(generatorParams);

            var response = await _api.BarcodeGenerateBodyPostAsync(request);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

        [Test]
        public async Task TestBarcodeGenerateMultipartPost()
        {
            // Test case for barcode_generate_form_post
            // Generate barcode from params in form
            var request = new BarcodeGenerateMultipartPostRequest(EncodeBarcodeType.QR, "54657374")
            {
                DataType = EncodeDataType.HexBytes
            };

            var response = await _api.BarcodeGenerateMultipartPostAsync(request);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

    }
}
