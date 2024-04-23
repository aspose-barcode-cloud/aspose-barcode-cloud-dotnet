
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     DataMatrix encoder&#39;s encoding mode, default to Auto
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataMatrixEncodeMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value ASCII
        /// </summary>
        ASCII,

        /// <summary>
        ///     Enum value Full
        /// </summary>
        Full,

        /// <summary>
        ///     Enum value Custom
        /// </summary>
        Custom,

        /// <summary>
        ///     Enum value C40
        /// </summary>
        C40,

        /// <summary>
        ///     Enum value Text
        /// </summary>
        Text,

        /// <summary>
        ///     Enum value EDIFACT
        /// </summary>
        EDIFACT,

        /// <summary>
        ///     Enum value ANSIX12
        /// </summary>
        ANSIX12,

        /// <summary>
        ///     Enum value ExtendedCodetext
        /// </summary>
        ExtendedCodetext

    }
}
