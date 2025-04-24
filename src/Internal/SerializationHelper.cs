using System;
using System.IO;
using System.Xml;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Internal
{
    internal static class SerializationHelper
    {
        private static readonly JsonSerializerOptions JsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNameCaseInsensitive = true,
        };
        public static string Serialize(object obj)
        {
            try
            {
                return obj != null
                    ? JsonSerializer.Serialize(
                        obj, JsonOptions
                       )
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
                if (json.StartsWith("{", StringComparison.InvariantCulture) || json.StartsWith("[", StringComparison.InvariantCulture))
                {
                    object jObj = JsonSerializer.Deserialize(json, type, JsonOptions);
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
            catch (JsonException jsE)
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
