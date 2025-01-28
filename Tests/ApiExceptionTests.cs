using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;

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
            GenerateApi api = new GenerateApi(clientId: "client id", clientSecret: "client secret");

            // Acts
            ApiException ex = Assert.ThrowsAsync<ApiException>(
                async () =>
                {
                    await api.GenerateAsync(data: "Very sample text",
                barcodeType: EncodeBarcodeType.Code128, imageFormat: BarcodeImageFormat.Png);
                });

            Assert.AreEqual(400, ex!.ErrorCode);
            Assert.AreEqual("{\"error\":\"invalid_client\"}: ", ex.Message);
        }
    }
}
