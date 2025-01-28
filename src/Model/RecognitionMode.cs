
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Recognition mode.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
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
