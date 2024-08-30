using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class ApiExceptionTests : TestsBase
    {

        [Test]
        [Category("AsyncTests")]
        public void GetBarcodeGenerateAsyncTestThrows()
        {
            // Arrange
            var api = new GenerateApi(clientId: "client id", clientSecret: "client secret");
            var request = new BarcodeGenerateBarcodeTypeGetRequest(
                data: "Very sample text",
                dataType: EncodeDataType.StringData,
                barcodeType: EncodeBarcodeType.Code128
            )
            {
                ImageFormat = AvailableBarCodeImageFormat.Png
            };

            // Acts
            var ex = Assert.ThrowsAsync<ApiException>(
                async () => { await api.BarcodeGenerateBarcodeTypeGetAsync(request); });

            Assert.AreEqual(400, ex!.ErrorCode);
            Assert.AreEqual("Bad Request", ex.Message);
        }
    }
}
