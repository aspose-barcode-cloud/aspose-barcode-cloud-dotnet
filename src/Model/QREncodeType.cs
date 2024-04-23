
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QREncodeType
    {
        /// <summary>
        ///     Enum value Auto
        /// </summary>
        Auto,

        /// <summary>
        ///     Enum value ForceQR
        /// </summary>
        ForceQR,

        /// <summary>
        ///     Enum value ForceMicroQR
        /// </summary>
        ForceMicroQR

    }
}
