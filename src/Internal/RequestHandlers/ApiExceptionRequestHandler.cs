using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Aspose.BarCode.Cloud.Sdk.Internal.RequestHandlers
{
    internal class ApiExceptionRequestHandler : IRequestHandler
    {
        public void Preparing()
        {

        }

        public Task PreparingAsync()
        {
            return Task.CompletedTask;
        }

        public void BeforeSend(WebRequest request, Stream streamToSend)
        {
        }

        public Task BeforeSendAsync(HttpRequestMessage request)
        {
            return Task.CompletedTask;
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
                using (StreamReader responseReader = new StreamReader(resultStream))
                {
                    string responseData = responseReader.ReadToEnd();
                    ApiErrorResponse errorResponse = new ApiErrorResponse()
                    {
                        Error = new ApiError()
                    };
                    try
                    {
                        errorResponse = (ApiErrorResponse)
                            SerializationHelper.Deserialize(responseData,
                                typeof(ApiErrorResponse));
                    }
                    catch
                    {
                    }
                    if (string.IsNullOrEmpty(errorResponse.Error?.Code))
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

        public async Task ProcessResponseAsync(HttpResponseMessage response)
        {
            if (response.StatusCode != HttpStatusCode.OK)
            {
                await ThrowApiException(response);
            }
        }

        private static async Task ThrowApiException(HttpResponseMessage response)
        {
            Exception resultException;
            try
            {
                using (Stream resultStream = await response.Content.ReadAsStreamAsync())
                {
                    resultStream.Position = 0;
                    using (StreamReader responseReader = new StreamReader(resultStream))
                    {
                        string responseData = await responseReader.ReadToEndAsync();
                        ApiErrorResponse errorResponse = new ApiErrorResponse()
                        {
                            Error = new ApiError()
                        };
                        try
                        {
                            errorResponse = (ApiErrorResponse)
                                SerializationHelper.Deserialize(responseData,
                                    typeof(ApiErrorResponse));
                        }
                        catch
                        {
                        }
                        if (string.IsNullOrEmpty(errorResponse.Error?.Code))
                        {
                            errorResponse.Error.Message = responseData;
                        }

                        resultException = new ApiException((int)response.StatusCode,
                            $"{errorResponse.Error.Message}: {errorResponse.Error.Description}");
                    }
                }
            }
            catch (Exception)
            {
                throw new ApiException((int)response.StatusCode, response.ReasonPhrase);
            }

            throw resultException;
        }
    }
}
