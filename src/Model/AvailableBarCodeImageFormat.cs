
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Specifies the file format of the image.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AvailableBarCodeImageFormat
    {
        /// <summary>
        ///     Enum value Gif
        /// </summary>
        Gif,

        /// <summary>
        ///     Enum value Jpeg
        /// </summary>
        Jpeg,

        /// <summary>
        ///     Enum value Png
        /// </summary>
        Png,

        /// <summary>
        ///     Enum value Tiff
        /// </summary>
        Tiff,

        /// <summary>
        ///     Enum value Svg
        /// </summary>
        Svg

    }
}
