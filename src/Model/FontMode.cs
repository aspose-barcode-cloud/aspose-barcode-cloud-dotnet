
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FontMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value Manual
        /// </summary>
        Manual

    }
}
