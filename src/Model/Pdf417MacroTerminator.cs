
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Pdf417MacroTerminator
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value None
        /// </summary>
        None,

        /// <summary>
        ///     Enum value Set
        /// </summary>
        Set

    }
}
