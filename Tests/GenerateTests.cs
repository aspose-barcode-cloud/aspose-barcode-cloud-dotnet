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

            Stream response = await _api.GenerateAsync(EncodeBarcodeType.Code128, "Hello!");

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

        [Test]
        public async Task TestBarcodeGenerateBodyPost()
        {
            // Test case for barcode_generate_body_post
            // Generate barcode from params in body
            BarcodeImageParams imageParams = new BarcodeImageParams
            {
                ImageFormat = BarcodeImageFormat.Jpeg
            };

            EncodeData encodeData = new EncodeData()
            {
                Data = "VGVzdA==",
                DataType = EncodeDataType.Base64Bytes
            };

            GenerateParams generatorParams = new GenerateParams()
            {
                BarcodeType = EncodeBarcodeType.QR,
                EncodeData = encodeData,
                BarcodeImageParams = imageParams
            };


            Stream response = await _api.GenerateBodyAsync(generatorParams);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

        [Test]
        public async Task TestBarcodeGenerateMultipartPost()
        {

            Stream response = await _api.GenerateMultipartAsync(EncodeBarcodeType.QR, "54657374", dataType: EncodeDataType.HexBytes);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

        [Test]
        public async Task TestBarcodeGenerateGetWithQrParameters()
        {
            BarcodeImageParams barcodeImageParams = CreateBarcodeImageParams();
            QrParams qrParams = new QrParams
            {
                QrEncodeMode = QREncodeMode.Auto,
                QrErrorLevel = QRErrorLevel.LevelH,
                QrVersion = QRVersion.Auto,
                QrECIEncoding = ECIEncodings.NONE,
                QrAspectRatio = 1
            };

            Stream response = await _api.GenerateAsync(
                EncodeBarcodeType.QR,
                "Hello QR!",
                barcodeImageParams: barcodeImageParams,
                qrParams: qrParams);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
            StringAssert.Contains("\"ImageFormat\":\"Png\"", barcodeImageParams.ToString());
            StringAssert.Contains("\"QrErrorLevel\":\"LevelH\"", qrParams.ToString());
        }

        [Test]
        public async Task TestBarcodeGenerateMultipartWithCode128Parameters()
        {
            Code128Params code128Params = new Code128Params
            {
                Code128EncodeMode = Code128EncodeMode.Auto
            };

            Stream response = await _api.GenerateMultipartAsync(
                EncodeBarcodeType.Code128,
                "1234567890",
                barcodeImageParams: CreateBarcodeImageParams(),
                code128Params: code128Params);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
            StringAssert.Contains("\"Code128EncodeMode\":\"Auto\"", code128Params.ToString());
        }

        [Test]
        public async Task TestBarcodeGenerateMultipartWithAllParameterGroups()
        {
            Stream response = await _api.GenerateMultipartAsync(
                EncodeBarcodeType.QR,
                "All generation parameters",
                EncodeDataType.StringData,
                CreateBarcodeImageParams(),
                new QrParams
                {
                    QrEncodeMode = QREncodeMode.Auto,
                    QrErrorLevel = QRErrorLevel.LevelM,
                    QrVersion = QRVersion.Auto,
                    QrECIEncoding = ECIEncodings.NONE,
                    QrAspectRatio = 1,
                    MicroQRVersion = MicroQRVersion.M4,
                    RectMicroQrVersion = RectMicroQRVersion.R11x99
                },
                new Code128Params
                {
                    Code128EncodeMode = Code128EncodeMode.Auto
                },
                new Pdf417Params
                {
                    Pdf417EncodeMode = Pdf417EncodeMode.Auto,
                    Pdf417ErrorLevel = Pdf417ErrorLevel.Level2,
                    Pdf417ECIEncoding = ECIEncodings.NONE,
                    Pdf417MacroCharacters = MacroCharacter.None,
                    Pdf417Truncate = false,
                    Pdf417Columns = 0,
                    Pdf417Rows = 0,
                    Pdf417AspectRatio = 3,
                    Pdf417IsReaderInitialization = false,
                    Pdf417IsLinked = false,
                    Pdf417IsCode128Emulation = false
                });

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
        }

        [Test]
        public async Task TestBarcodeGenerateBodyWithPdf417Parameters()
        {
            GenerateParams generatorParams = new GenerateParams()
            {
                BarcodeType = EncodeBarcodeType.Pdf417,
                EncodeData = new EncodeData
                {
                    Data = "Pdf417 parameter coverage",
                    DataType = EncodeDataType.StringData
                },
                BarcodeImageParams = CreateBarcodeImageParams(),
                Pdf417Params = new Pdf417Params
                {
                    Pdf417EncodeMode = Pdf417EncodeMode.Auto,
                    Pdf417ErrorLevel = Pdf417ErrorLevel.Level2,
                    Pdf417ECIEncoding = ECIEncodings.NONE,
                    Pdf417MacroCharacters = MacroCharacter.None,
                    Pdf417Truncate = false,
                    Pdf417Columns = 0,
                    Pdf417Rows = 0,
                    Pdf417AspectRatio = 3,
                    Pdf417IsReaderInitialization = false,
                    Pdf417IsLinked = false,
                    Pdf417IsCode128Emulation = false
                }
            };

            Stream response = await _api.GenerateBodyAsync(generatorParams);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
            StringAssert.Contains("\"BarcodeType\":\"Pdf417\"", generatorParams.ToString());
            StringAssert.Contains("\"Pdf417ErrorLevel\":\"Level2\"", generatorParams.Pdf417Params.ToString());
        }

        [Test]
        public async Task TestBarcodeGenerateMicroQrParameters()
        {
            QrParams qrParams = new QrParams
            {
                MicroQRVersion = MicroQRVersion.M4
            };

            Stream response = await _api.GenerateAsync(
                EncodeBarcodeType.MicroQR,
                "123",
                qrParams: qrParams);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
            StringAssert.Contains("\"MicroQRVersion\":\"M4\"", qrParams.ToString());
        }

        [Test]
        public async Task TestBarcodeGenerateRectMicroQrParameters()
        {
            QrParams qrParams = new QrParams
            {
                RectMicroQrVersion = RectMicroQRVersion.R11x99
            };

            Stream response = await _api.GenerateAsync(
                EncodeBarcodeType.RectMicroQR,
                "1234567890",
                qrParams: qrParams);

            long contentLength = response.Length;
            Assert.True(contentLength > 0, "Content length is zero or negative");
            StringAssert.Contains("\"RectMicroQrVersion\":\"R11x99\"", qrParams.ToString());
        }

        private static BarcodeImageParams CreateBarcodeImageParams()
        {
            return new BarcodeImageParams
            {
                ImageFormat = BarcodeImageFormat.Png,
                TextLocation = CodeLocation.Below,
                ForegroundColor = "Black",
                BackgroundColor = "White",
                Units = GraphicsUnit.Pixel,
                Resolution = 96,
                ImageHeight = 120,
                ImageWidth = 240,
                RotationAngle = 0
            };
        }
    }
}
