
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FontStyle
    {
        /// <summary>
        ///     Enum value Regular
        /// </summary>
        Regular,

        /// <summary>
        ///     Enum value Bold
        /// </summary>
        Bold,

        /// <summary>
        ///     Enum value Italic
        /// </summary>
        Italic,

        /// <summary>
        ///     Enum value Underline
        /// </summary>
        Underline,

        /// <summary>
        ///     Enum value Strikeout
        /// </summary>
        Strikeout

    }
}
