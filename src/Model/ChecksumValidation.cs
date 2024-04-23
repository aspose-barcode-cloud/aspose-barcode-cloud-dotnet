
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ChecksumValidation
    {
        /// <summary>
        ///     Enum value Default
        /// </summary>
        Default,

        /// <summary>
        ///     Enum value On
        /// </summary>
        On,

        /// <summary>
        ///     Enum value Off
        /// </summary>
        Off

    }
}
