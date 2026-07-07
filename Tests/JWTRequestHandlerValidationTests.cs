using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers;
using Moq;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class JWTRequestHandlerValidationTests : TestsBase
    {
        [SetUp]
        public void Init()
        {
            _requestFactory = WebRequestMocks.RequestFactoryMock();
        }

        private Mock<IWebRequestFactory> _requestFactory;

        [Test]
        public void TestJwtConfigurationValidation()
        {
            JwtRequestHandler missingClientIdHandler = new JwtRequestHandler(new Configuration());
            ApiException missingClientId = Assert.Throws<ApiException>(
                () => missingClientIdHandler.Preparing());
            Assert.AreEqual(403, missingClientId!.ErrorCode);
            Assert.AreEqual("Missing required parameter 'ClientId'", missingClientId.Message);

            JwtRequestHandler missingClientSecretHandler = new JwtRequestHandler(
                new Configuration { ClientId = "client-id" });
            ApiException missingClientSecret = Assert.Throws<ApiException>(
                () => missingClientSecretHandler.Preparing());
            Assert.AreEqual(403, missingClientSecret!.ErrorCode);
            Assert.AreEqual("Missing required parameter 'ClientSecret'", missingClientSecret.Message);

            JwtRequestHandler missingTokenHandler = new JwtRequestHandler(
                new Configuration { ClientId = "client-id", ClientSecret = "client-secret" });
            WebRequest request = _requestFactory.Object.Create("http://some url/");
            ApiException missingToken = Assert.Throws<ApiException>(
                () => missingTokenHandler.BeforeSend(request, new MemoryStream()));
            Assert.AreEqual(403, missingToken!.ErrorCode);
            Assert.AreEqual("Missing required parameter '_accessToken'", missingToken.Message);
        }

        [Test]
        public async Task TestJwtConfigurationValidationAsync()
        {
            JwtRequestHandler missingClientIdHandler = new JwtRequestHandler(new Configuration());
            ApiException missingClientId = Assert.ThrowsAsync<ApiException>(
                async () => await missingClientIdHandler.PreparingAsync());
            Assert.AreEqual(403, missingClientId!.ErrorCode);
            Assert.AreEqual("Missing required parameter 'ClientId'", missingClientId.Message);

            JwtRequestHandler missingClientSecretHandler = new JwtRequestHandler(
                new Configuration { ClientId = "client-id" });
            ApiException missingClientSecret = Assert.ThrowsAsync<ApiException>(
                async () => await missingClientSecretHandler.PreparingAsync());
            Assert.AreEqual(403, missingClientSecret!.ErrorCode);
            Assert.AreEqual("Missing required parameter 'ClientSecret'", missingClientSecret.Message);

            JwtRequestHandler missingTokenHandler = new JwtRequestHandler(
                new Configuration { ClientId = "client-id", ClientSecret = "client-secret" });
            ApiException missingToken = Assert.Throws<ApiException>(
                () => missingTokenHandler.BeforeSendAsync(new HttpRequestMessage()).GetAwaiter().GetResult());
            Assert.AreEqual(403, missingToken!.ErrorCode);
            Assert.AreEqual("Missing required parameter '_accessToken'", missingToken.Message);
        }

        [Test]
        public void TestJwtRefreshValidatesConfiguration()
        {
            HttpWebResponse response401 = WebRequestMocks.CreateResponse(HttpStatusCode.Unauthorized);
            JwtRequestHandler jwtHandler = new JwtRequestHandler(new Configuration());

            ApiException exception = Assert.Throws<ApiException>(
                () => jwtHandler.ProcessResponse(response401, new MemoryStream()));

            Assert.AreEqual(403, exception!.ErrorCode);
            Assert.AreEqual("Missing required parameter 'ClientId'", exception.Message);
        }

        [Test]
        public async Task TestJwtRefreshValidatesConfigurationAsync()
        {
            HttpResponseMessage response401 = new HttpResponseMessage(HttpStatusCode.Unauthorized);
            JwtRequestHandler jwtHandler = new JwtRequestHandler(new Configuration());

            ApiException exception = Assert.ThrowsAsync<ApiException>(
                async () => await jwtHandler.ProcessResponseAsync(response401));

            Assert.AreEqual(403, exception!.ErrorCode);
            Assert.AreEqual("Missing required parameter 'ClientId'", exception.Message);
        }

        [Test]
        public async Task TestJwtHandlerIgnoresExternalAuthConfiguration()
        {
            Configuration configuration = new Configuration { JwtToken = "external-token" };
            JwtRequestHandler jwtHandler = new JwtRequestHandler(configuration);

            jwtHandler.Preparing();
            await jwtHandler.PreparingAsync();

            WebRequest syncRequest = _requestFactory.Object.Create("http://some url/");
            jwtHandler.BeforeSend(syncRequest, new MemoryStream());
            Assert.IsNull(syncRequest.Headers["Authorization"]);

            HttpRequestMessage asyncRequest = new HttpRequestMessage();
            await jwtHandler.BeforeSendAsync(asyncRequest);
            Assert.IsFalse(asyncRequest.Headers.Contains("Authorization"));

            jwtHandler.ProcessResponse(WebRequestMocks.CreateResponse(HttpStatusCode.Unauthorized), new MemoryStream());
            await jwtHandler.ProcessResponseAsync(new HttpResponseMessage(HttpStatusCode.Unauthorized));
        }
    }
}
