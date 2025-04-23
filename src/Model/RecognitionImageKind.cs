
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Kind of image to recognize
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
