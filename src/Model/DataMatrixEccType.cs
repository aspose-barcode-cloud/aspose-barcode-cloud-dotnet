
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DataMatrixEccType
    {
        /// <summary>
        ///     Enum value EccAuto
        /// </summary>
        EccAuto,

        /// <summary>
        ///     Enum value Ecc000
        /// </summary>
        Ecc000,

        /// <summary>
        ///     Enum value Ecc050
        /// </summary>
        Ecc050,

        /// <summary>
        ///     Enum value Ecc080
        /// </summary>
        Ecc080,

        /// <summary>
        ///     Enum value Ecc100
        /// </summary>
        Ecc100,

        /// <summary>
        ///     Enum value Ecc140
        /// </summary>
        Ecc140,

        /// <summary>
        ///     Enum value Ecc200
        /// </summary>
        Ecc200

    }
}
