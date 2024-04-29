
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DotCodeEncodeMode
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
        ///     Enum value ExtendedCodetext
        /// </summary>
        ExtendedCodetext

    }
}
