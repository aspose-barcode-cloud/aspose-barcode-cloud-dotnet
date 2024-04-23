
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum BorderDashStyle
    {
        /// <summary>
        ///     Enum value Solid
        /// </summary>
        Solid,

        /// <summary>
        ///     Enum value Dash
        /// </summary>
        Dash,

        /// <summary>
        ///     Enum value Dot
        /// </summary>
        Dot,

        /// <summary>
        ///     Enum value DashDot
        /// </summary>
        DashDot,

        /// <summary>
        ///     Enum value DashDotDot
        /// </summary>
        DashDotDot

    }
}
