using System;
using System.IO;
using System.Xml;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Newtonsoft.Json;

namespace Aspose.BarCode.Cloud.Sdk.Internal
{
    internal static class SerializationHelper
    {
        public static string Serialize(object obj)
        {
            try
            {
                return obj != null
                    ? JsonConvert.SerializeObject(
                        obj,
                        new JsonSerializerSettings
                        {
                            NullValueHandling = NullValueHandling.Ignore
                        })
                    : null;
            }
            catch (Exception e)
            {
                throw new ApiException(500, e.Message);
            }
        }

        public static object Deserialize(string json, Type type)
        {
            try
            {
                if (json.StartsWith("{") || json.StartsWith("["))
                {
                    object jObj = JsonConvert.DeserializeObject(json, type);
                    if (jObj is IToString jToString)
                    {
                        jToString.SetSrcString(json);
                    }
                    return jObj;
                }

                throw new ApiException(500, $"Unknown serialization format: {json}");
            }
            catch (IOException e)
            {
                throw new ApiException(500, e.Message);
            }
            catch (JsonSerializationException jsE)
            {
                throw new ApiException(500, jsE.Message);
            }
            catch (XmlException xmlE)
            {
                throw new ApiException(500, xmlE.Message);
            }
        }
    }
}
