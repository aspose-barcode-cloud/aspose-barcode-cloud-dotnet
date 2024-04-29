
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     See QualitySettings allows to configure recognition quality and speed manually.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PresetType
    {
        /// <summary>
        ///     Enum value HighPerformance
        /// </summary>
        HighPerformance,

        /// <summary>
        ///     Enum value NormalQuality
        /// </summary>
        NormalQuality,

        /// <summary>
        ///     Enum value HighQualityDetection
        /// </summary>
        HighQualityDetection,

        /// <summary>
        ///     Enum value MaxQualityDetection
        /// </summary>
        MaxQualityDetection,

        /// <summary>
        ///     Enum value HighQuality
        /// </summary>
        HighQuality,

        /// <summary>
        ///     Enum value MaxBarCodes
        /// </summary>
        MaxBarCodes

    }
}
