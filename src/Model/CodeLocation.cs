
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum CodeLocation
    {
        /// <summary>
        ///     Enum value Below
        /// </summary>
        Below,

        /// <summary>
        ///     Enum value Above
        /// </summary>
        Above,

        /// <summary>
        ///     Enum value None
        /// </summary>
        None

    }
}
