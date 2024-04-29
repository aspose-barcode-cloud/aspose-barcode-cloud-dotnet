
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     DEPRECATED. This enum will be removed in future releases Function codewords for Code 128 emulation. Applied for MicroPDF417 only. Ignored for PDF417 and MacroPDF417 barcodes.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum Code128Emulation
    {
        /// <summary>
        ///     Enum value None
        /// </summary>
        None,

        /// <summary>
        ///     Enum value Code903
        /// </summary>
        Code903,

        /// <summary>
        ///     Enum value Code904
        /// </summary>
        Code904,

        /// <summary>
        ///     Enum value Code905
        /// </summary>
        Code905

    }
}
