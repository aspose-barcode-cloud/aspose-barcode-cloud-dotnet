
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QRErrorLevel
    {
        /// <summary>
        ///     Enum value LevelL
        /// </summary>
        LevelL,

        /// <summary>
        ///     Enum value LevelM
        /// </summary>
        LevelM,

        /// <summary>
        ///     Enum value LevelQ
        /// </summary>
        LevelQ,

        /// <summary>
        ///     Enum value LevelH
        /// </summary>
        LevelH

    }
}
