
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QREncodeMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value Bytes
        /// </summary>
        Bytes,

        /// <summary>
        ///     Enum value Utf8BOM
        /// </summary>
        Utf8BOM,

        /// <summary>
        ///     Enum value Utf16BEBOM
        /// </summary>
        Utf16BEBOM,

        /// <summary>
        ///     Enum value ECIEncoding
        /// </summary>
        ECIEncoding,

        /// <summary>
        ///     Enum value ExtendedCodetext
        /// </summary>
        ExtendedCodetext

    }
}
