
using System.Text.Json.Serialization;


namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Specifies the file format of the image.
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum BarcodeImageFormat
    {
        /// <summary>
        ///     Enum value Png
        /// </summary>
        Png,

        /// <summary>
        ///     Enum value Jpeg
        /// </summary>
        Jpeg,

        /// <summary>
        ///     Enum value Svg
        /// </summary>
        Svg,

        /// <summary>
        ///     Enum value Tiff
        /// </summary>
        Tiff,

        /// <summary>
        ///     Enum value Gif
        /// </summary>
        Gif

    }
}
