﻿using System.IO;
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
                new PostBarcodeRecognizeFromUrlOrContentRequest(
                    image: image,
                    preset: PresetType.HighPerformance.ToString(),
                    type: DecodeBarcodeType.QR.ToString()
                )
            );

            // Assert
            Assert.AreEqual(1, response.Barcodes.Count);
            Assert.AreEqual(DecodeBarcodeType.QR.ToString(), response.Barcodes[0].Type);
            Assert.AreEqual("Hello world!", response.Barcodes[0].BarcodeValue);
        }
    }
}