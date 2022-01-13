using System.IO;
using System.Linq;
using System.Text;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
	[TestFixture]
	public class GenerateAndThenRecognize : TestsBase
	{
		[SetUp]
		public void Init()
		{
			_api = new BarcodeApi(TestConfiguration);
		}

		private BarcodeApi _api;


		[Test]
		public void GenerateAndThenRecognizeTest()
		{
			Stream generated = _api.GetBarcodeGenerate(new GetBarcodeGenerateRequest(
				EncodeBarcodeType.QR.ToString(), "Test"));

			BarcodeResponseList recognized = _api.PostBarcodeRecognizeFromUrlOrContent(
				new PostBarcodeRecognizeFromUrlOrContentRequest(
					image: generated
				));

			Assert.AreEqual(1, recognized.Barcodes.Count);
			Assert.AreEqual(DecodeBarcodeType.QR.ToString(), recognized.Barcodes.First().Type);
			Assert.AreEqual("Test", recognized.Barcodes.First().BarcodeValue);
		}


		[Test]
		public void RecognizeFromStreamTest()
		{
			// Arrange
			string filePath = TestFilePath("qr.png");
			const string txtPath = "result.txt";

			// Act
			using (Stream st = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
			{
				PostBarcodeRecognizeFromUrlOrContentRequest request = new PostBarcodeRecognizeFromUrlOrContentRequest();
				request.Preset = PresetType.HighPerformance.ToString();
				request.image = st;
				request.Type = "all";

				// Recognition of a barcode from file on server with parameters in body.
				BarcodeResponseList result = _api.PostBarcodeRecognizeFromUrlOrContent(request);
				// Create a new file     
				using (FileStream fs = File.Create(txtPath))
				{
					// Add some text to file    
					var text = new UTF8Encoding(true).GetBytes(result.ToString());
					fs.Write(text, 0, text.Length);
				}
			}

			// Assert
			string savedText = File.ReadAllText(txtPath).Replace("\r", "");
			Assert.AreEqual(
				"class BarcodeResponseList {\n  Barcodes: System.Collections.Generic.List`1[Aspose.BarCode.Cloud.Sdk.Model.BarcodeResponse]\n}\n",
				savedText
			);
		}
	}
}
