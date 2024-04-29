
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ITF14BorderType
    {
        /// <summary>
        ///     Enum value None
        /// </summary>
        None,

        /// <summary>
        ///     Enum value Frame
        /// </summary>
        Frame,

        /// <summary>
        ///     Enum value Bar
        /// </summary>
        Bar,

        /// <summary>
        ///     Enum value FrameOut
        /// </summary>
        FrameOut,

        /// <summary>
        ///     Enum value BarOut
        /// </summary>
        BarOut

    }
}
