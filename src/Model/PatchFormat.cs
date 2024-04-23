
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PatchFormat
    {
        /// <summary>
        ///     Enum value PatchOnly
        /// </summary>
        PatchOnly,

        /// <summary>
        ///     Enum value A4
        /// </summary>
        A4,

        /// <summary>
        ///     Enum value A4_LANDSCAPE
        /// </summary>
        A4_LANDSCAPE,

        /// <summary>
        ///     Enum value US_Letter
        /// </summary>
        US_Letter,

        /// <summary>
        ///     Enum value US_Letter_LANDSCAPE
        /// </summary>
        US_Letter_LANDSCAPE

    }
}
