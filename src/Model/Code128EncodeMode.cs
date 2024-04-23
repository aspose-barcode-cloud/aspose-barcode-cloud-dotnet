
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Code128EncodeMode
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value CodeA
        /// </summary>
        CodeA,

        /// <summary>
        ///     Enum value CodeB
        /// </summary>
        CodeB,

        /// <summary>
        ///     Enum value CodeAB
        /// </summary>
        CodeAB,

        /// <summary>
        ///     Enum value CodeC
        /// </summary>
        CodeC,

        /// <summary>
        ///     Enum value CodeAC
        /// </summary>
        CodeAC,

        /// <summary>
        ///     Enum value CodeBC
        /// </summary>
        CodeBC

    }
}
