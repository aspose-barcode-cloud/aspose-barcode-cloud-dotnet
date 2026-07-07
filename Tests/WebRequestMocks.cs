using System.Net;
using Moq;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    public interface IWebRequestFactory
    {
        WebRequest Create(string uri);
    }

    internal static class WebRequestMocks
    {
        internal static Mock<IWebRequestFactory> RequestFactoryMock()
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

        internal static HttpWebResponse CreateResponse(HttpStatusCode statusCode)
        {
            Mock<HttpWebResponse> responseMock = new Mock<HttpWebResponse>();
            responseMock.Setup(c => c.StatusCode).Returns(statusCode);
            return responseMock.Object;
        }
    }
}
