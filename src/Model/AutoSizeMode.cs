
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AutoSizeMode
    {
        /// <summary>
        ///     Enum value None
        /// </summary>
        None,

        /// <summary>
        ///     Enum value Nearest
        /// </summary>
        Nearest,

        /// <summary>
        ///     Enum value Interpolation
        /// </summary>
        Interpolation

    }
}
