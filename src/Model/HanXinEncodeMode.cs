
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum HanXinEncodeMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value Binary
        /// </summary>
        Binary,

        /// <summary>
        ///     Enum value ECI
        /// </summary>
        ECI,

        /// <summary>
        ///     Enum value Unicode
        /// </summary>
        Unicode,

        /// <summary>
        ///     Enum value URI
        /// </summary>
        URI,

        /// <summary>
        ///     Enum value Extended
        /// </summary>
        Extended

    }
}
