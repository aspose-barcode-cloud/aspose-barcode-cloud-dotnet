
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Kind of image to recognize
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RecognitionImageKind
    {
        /// <summary>
        ///     Enum value Photo
        /// </summary>
        Photo,

        /// <summary>
        ///     Enum value ScannedDocument
        /// </summary>
        ScannedDocument,

        /// <summary>
        ///     Enum value ClearImage
        /// </summary>
        ClearImage

    }
}
