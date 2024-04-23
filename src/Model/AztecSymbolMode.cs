
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AztecSymbolMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value Compact
        /// </summary>
        Compact,

        /// <summary>
        ///     Enum value FullRange
        /// </summary>
        FullRange,

        /// <summary>
        ///     Enum value Rune
        /// </summary>
        Rune

    }
}
