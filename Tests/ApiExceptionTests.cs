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
            var api = new BarcodeApi(clientId: "client id", clientSecret: "client secret");
            var request = new GetBarcodeGenerateRequest(
                text: "Very sample text",
                type: EncodeBarcodeType.Code128.ToString()
            )
            {
                format = "png"
            };

            // Acts
            var ex = Assert.ThrowsAsync<ApiException>(
                async () => { await api.GetBarcodeGenerateAsync(request); });

            Assert.AreEqual(400, ex!.ErrorCode);
            Assert.AreEqual("Bad Request", ex.Message);
        }
    }
}
