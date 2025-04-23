
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Recognition mode.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RecognitionMode
    {
        /// <summary>
        ///     Enum value Fast
        /// </summary>
        Fast,

        /// <summary>
        ///     Enum value Normal
        /// </summary>
        Normal,

        /// <summary>
        ///     Enum value Excellent
        /// </summary>
        Excellent

    }
}
