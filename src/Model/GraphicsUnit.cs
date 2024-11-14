
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Subset of Aspose.Drawing.GraphicsUnit.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum GraphicsUnit
    {
        /// <summary>
        ///     Enum value Pixel
        /// </summary>
        Pixel,

        /// <summary>
        ///     Enum value Point
        /// </summary>
        Point,

        /// <summary>
        ///     Enum value Inch
        /// </summary>
        Inch,

        /// <summary>
        ///     Enum value Millimeter
        /// </summary>
        Millimeter

    }
}
