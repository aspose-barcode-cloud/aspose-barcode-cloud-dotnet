using System;
using System.IO;
using System.Net;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers
{
    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        public string ProcessUrl(string url)
        {
            return url;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        public void ProcessResponse(HttpWebResponse response, Stream resultStream)
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                ThrowApiException(response, resultStream);
            }
        }

        private static void ThrowApiException(HttpWebResponse webResponse, Stream resultStream)
        {
            Exception resultException;
            try
            {
                resultStream.Position = 0;
                using (var responseReader = new StreamReader(resultStream))
                {
                    string responseData = responseReader.ReadToEnd();
                    var errorResponse = (ApiErrorResponse)
                        SerializationHelper.Deserialize(responseData,
                            typeof(ApiErrorResponse));
                    if (string.IsNullOrEmpty(errorResponse.Error.Code))
                    {
                        errorResponse.Error.Message = responseData;
                    }

                    resultException = new ApiException((int)webResponse.StatusCode,
                        $"{errorResponse.Error.Message}: {errorResponse.Error.Description}");
                }
            }
            catch (Exception)
            {
                throw new ApiException((int)webResponse.StatusCode, webResponse.StatusDescription);
            }

            throw resultException;
        }
    }
}
