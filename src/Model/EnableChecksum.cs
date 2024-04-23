
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EnableChecksum
    {
        /// <summary>
        ///     Enum value Default
        /// </summary>
        Default,

        /// <summary>
        ///     Enum value Yes
        /// </summary>
        Yes,

        /// <summary>
        ///     Enum value No
        /// </summary>
        No

    }
}
