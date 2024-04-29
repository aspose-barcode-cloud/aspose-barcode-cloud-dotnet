
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Pdf417CompactionMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value Text
        /// </summary>
        Text,

        /// <summary>
        ///     Enum value Numeric
        /// </summary>
        Numeric,

        /// <summary>
        ///     Enum value Binary
        /// </summary>
        Binary

    }
}
