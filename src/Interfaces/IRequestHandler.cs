using System.IO;
using System.Net;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    internal interface IRequestHandler
    {
        string ProcessUrl(string url);

        void BeforeSend(WebRequest request, Stream streamToSend);

        void ProcessResponse(HttpWebResponse response, Stream resultStream);
    }
}
