
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CodabarChecksumMode
    {
        /// <summary>
        ///     Enum value Mod10
        /// </summary>
        Mod10,

        /// <summary>
        ///     Enum value Mod16
        /// </summary>
        Mod16

    }
}
