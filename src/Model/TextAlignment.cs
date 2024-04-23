
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TextAlignment
    {
        /// <summary>
        ///     Enum value Left
        /// </summary>
        Left,

        /// <summary>
        ///     Enum value Center
        /// </summary>
        Center,

        /// <summary>
        ///     Enum value Right
        /// </summary>
        Right

    }
}
