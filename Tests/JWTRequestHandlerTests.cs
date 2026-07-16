using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers;
using Moq;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    public interface IWebRequestFactory
    {
        WebRequest Create(string uri);
    }

    [TestFixture]
    public class JWTRequestHandlerTests : TestsBase
    {
        [SetUp]
        public void Init()
        {
            _requestFactory = RequestFactoryMock();
        }

        private Mock<IWebRequestFactory> _requestFactory;


        [Test]
        public void TestTokenFetched()
        {
            if (TestConfiguration.AuthType != AuthType.JWT)
            {
                Assert.Ignore($"Unsupported TestConfiguration.AuthType={TestConfiguration.AuthType}");
            }

            // arrange
            JwtRequestHandler jwtHandler = new JwtRequestHandler(TestConfiguration);
            jwtHandler.Preparing();

            // act
            WebRequest request = _requestFactory.Object.Create("http://some url/");
            jwtHandler.BeforeSend(request, new MemoryStream());

            // assert
            Assert.Contains("Authorization", request.Headers.Keys);
            string auth = request.Headers["Authorization"];
            Assert.Greater(auth.Length, "Bearer ".Length);
            string token = auth.Substring("Bearer ".Length);
            AssertTokenIsValid(token);
        }


        [Test]
        public void TestTokenRefresh()
        {
            if (TestConfiguration.AuthType != AuthType.JWT)
            {
                Assert.Ignore($"Unsupported TestConfiguration.AuthType={TestConfiguration.AuthType}");
            }

            // arrange
            WebRequest unauthorizedRequest = _requestFactory.Object.Create("http://some url/");
            unauthorizedRequest.Method = WebRequestMethods.Http.Get;
            HttpWebResponse response401 = (HttpWebResponse)unauthorizedRequest.GetResponse();
            Assert.AreEqual(HttpStatusCode.Unauthorized, response401.StatusCode);

            JwtRequestHandler jwtHandler = new JwtRequestHandler(TestConfiguration);

            // act
            Assert.Throws<NeedRepeatRequestException>(
                () =>
                {
                    // Should manage 401, fetch new token and store it
                    // And throw NeedRepeatRequestException
                    jwtHandler.ProcessResponse(response401, new MemoryStream());
                });

            WebRequest request2 = _requestFactory.Object.Create("http://some url/");
            jwtHandler.BeforeSend(request2, new MemoryStream());

            Assert.Contains("Authorization", request2.Headers.Keys);
            string auth = request2.Headers["Authorization"];
            Assert.Greater(auth.Length, "Bearer ".Length);
            string token = auth.Substring("Bearer ".Length);
            AssertTokenIsValid(token);
        }

        [Test]
        public async Task TestTokenFetchedAsync()
        {
            if (TestConfiguration.AuthType != AuthType.JWT)
            {
                Assert.Ignore($"Unsupported TestConfiguration.AuthType={TestConfiguration.AuthType}");
            }

            // arrange
            JwtRequestHandler jwtHandler = new JwtRequestHandler(TestConfiguration);
            await jwtHandler.PreparingAsync();

            // act
            HttpRequestMessage request = new HttpRequestMessage();
            await jwtHandler.BeforeSendAsync(request);

            // assert
            Assert.IsTrue(request.Headers.Contains("Authorization"));
            string auth = request.Headers.Authorization.ToString();
            Assert.Greater(auth.Length, "Bearer ".Length);
            string token = auth.Substring("Bearer ".Length);
            AssertTokenIsValid(token);
        }


        [Test]
        public async Task TestTokenRefreshAsync()
        {
            if (TestConfiguration.AuthType != AuthType.JWT)
            {
                Assert.Ignore($"Unsupported TestConfiguration.AuthType={TestConfiguration.AuthType}");
            }

            // arrange
            HttpResponseMessage response401 = new HttpResponseMessage(HttpStatusCode.Unauthorized);

            JwtRequestHandler jwtHandler = new JwtRequestHandler(TestConfiguration);

            // act
            Assert.ThrowsAsync<NeedRepeatRequestException>(
                async () =>
                {
                    // Should manage 401, fetch new token and store it
                    // And throw NeedRepeatRequestException
                    await jwtHandler.ProcessResponseAsync(response401);
                });

            // arrange
            HttpRequestMessage request2 = new HttpRequestMessage();
            await jwtHandler.BeforeSendAsync(request2);

            // assert
            Assert.IsTrue(request2.Headers.Contains("Authorization"));
            string auth = request2.Headers.Authorization.ToString();
            Assert.Greater(auth.Length, "Bearer ".Length);
            string token = auth.Substring("Bearer ".Length);
            AssertTokenIsValid(token);
        }

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
            HttpWebResponse response401 = CreateResponse(HttpStatusCode.Unauthorized);
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

            jwtHandler.ProcessResponse(CreateResponse(HttpStatusCode.Unauthorized), new MemoryStream());
            await jwtHandler.ProcessResponseAsync(new HttpResponseMessage(HttpStatusCode.Unauthorized));
        }

        private static Mock<IWebRequestFactory> RequestFactoryMock()
        {
            Mock<HttpWebResponse> responseMock = new Mock<HttpWebResponse>();
            responseMock.Setup(c => c.StatusCode).Returns(HttpStatusCode.Unauthorized);

            Mock<WebRequest> requestMock = new Mock<WebRequest>();
            requestMock.Setup(c => c.GetResponse()).Returns(responseMock.Object);
            requestMock.Setup(c => c.Headers).Returns(new WebHeaderCollection());

            Mock<IWebRequestFactory> requestFactory = new Mock<IWebRequestFactory>();
            requestFactory.Setup(c => c.Create(It.IsAny<string>()))
                .Returns(requestMock.Object);
            return requestFactory;
        }

        private static HttpWebResponse CreateResponse(HttpStatusCode statusCode)
        {
            Mock<HttpWebResponse> responseMock = new Mock<HttpWebResponse>();
            responseMock.Setup(c => c.StatusCode).Returns(statusCode);
            return responseMock.Object;
        }

        private static void AssertTokenIsValid(string token)
        {
            string firstPartBeforeDot = new string(token.TakeWhile(c => c != '.').ToArray());
            byte[] tokenBytes = Convert.FromBase64String(firstPartBeforeDot);
            JsonElement tokenHeader = JsonDocument.Parse(Encoding.UTF8.GetString(tokenBytes)).RootElement;

            Assert.AreEqual("JWT", tokenHeader.GetProperty("typ").GetString());
        }
    }
}
