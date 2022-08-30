using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers;
using Moq;
using Newtonsoft.Json.Linq;
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
            var jwtHandler = new JwtRequestHandler(TestConfiguration);
            jwtHandler.ProcessUrl("http://some url/");

            // act
            WebRequest request = _requestFactory.Object.Create("http://some url/");
            jwtHandler.BeforeSend(request, new MemoryStream());

            // assert
            Assert.Contains("Authorization", request.Headers.Keys);
            var auth = request.Headers["Authorization"];
            Assert.Greater(auth.Length, "Bearer ".Length);
            var token = auth.Substring("Bearer ".Length);
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
            var response401 = (HttpWebResponse)unauthorizedRequest.GetResponse();
            Assert.AreEqual(HttpStatusCode.Unauthorized, response401.StatusCode);

            var jwtHandler = new JwtRequestHandler(TestConfiguration);

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
            var auth = request2.Headers["Authorization"];
            Assert.Greater(auth.Length, "Bearer ".Length);
            var token = auth.Substring("Bearer ".Length);
            AssertTokenIsValid(token);
        }

        private static Mock<IWebRequestFactory> RequestFactoryMock()
        {
            var responseMock = new Mock<HttpWebResponse>();
            responseMock.Setup(c => c.StatusCode).Returns(HttpStatusCode.Unauthorized);

            var requestMock = new Mock<WebRequest>();
            requestMock.Setup(c => c.GetResponse()).Returns(responseMock.Object);
            requestMock.Setup(c => c.Headers).Returns(new WebHeaderCollection());

            var requestFactory = new Mock<IWebRequestFactory>();
            requestFactory.Setup(c => c.Create(It.IsAny<string>()))
                .Returns(requestMock.Object);
            return requestFactory;
        }

        private static void AssertTokenIsValid(string token)
        {
            var firstPartBeforeDot = new string(token.TakeWhile(c => c != '.').ToArray());
            byte[] tokenBytes = Convert.FromBase64String(firstPartBeforeDot);
            JObject tokenHeader = JObject.Parse(Encoding.UTF8.GetString(tokenBytes));

            Assert.AreEqual("JWT", tokenHeader["typ"]?.ToString());
        }
    }
}
