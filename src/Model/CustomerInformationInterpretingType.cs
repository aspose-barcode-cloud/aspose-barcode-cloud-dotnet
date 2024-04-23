
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CustomerInformationInterpretingType
    {
        /// <summary>
        ///     Enum value CTable
        /// </summary>
        CTable,

        /// <summary>
        ///     Enum value NTable
        /// </summary>
        NTable,

        /// <summary>
        ///     Enum value Other
        /// </summary>
        Other

    }
}
