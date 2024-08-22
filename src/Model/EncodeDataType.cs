
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Types of data can be encoded to barcode
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncodeDataType
    {
        /// <summary>
        ///     Enum value StringData
        /// </summary>
        StringData,

        /// <summary>
        ///     Enum value Base64Bytes
        /// </summary>
        Base64Bytes,

        /// <summary>
        ///     Enum value HexBytes
        /// </summary>
        HexBytes

    }
}
