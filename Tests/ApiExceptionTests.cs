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
        public void GetBarcodeGenerateTestThrows()
        {
            // Arrange
            var api = new BarcodeApi(clientId: "client id", clientSecret: "client secret");
            var request = new GetBarcodeGenerateRequest(
                text: "Very sample text",
                type: EncodeBarcodeType.Code128.ToString(),
                format: "png"
            );

            // Act
            var ex = Assert.Throws<ApiException>(
                () => { api.GetBarcodeGenerate(request); });

            Assert.AreEqual(400, ex.ErrorCode);
            Assert.AreEqual("Bad Request", ex.Message);
        }
    }
}
