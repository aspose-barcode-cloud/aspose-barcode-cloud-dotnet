
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Barcode recognize request
    /// </summary>
    public class RecognizeBase64Request : IToString
    {
        /// <summary>
        ///     Gets or sets RecognitionMode
        /// </summary>
        public RecognitionMode? RecognitionMode { get; set; }

        /// <summary>
        ///     Gets or sets RecognitionImageKind
        /// </summary>
        public RecognitionImageKind? RecognitionImageKind { get; set; }

        /// <summary>
        ///     Array of decode types to find on barcode
        /// </summary>
        public List<DecodeBarcodeType> BarcodeTypes { get; set; }

        /// <summary>
        ///     Barcode image bytes encoded as base-64.
        /// </summary>
        public string FileBase64 { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return _srcString ?? SerializationHelper.Serialize(this);
        }

        private string _srcString;
        /// <summary>
        ///   Set the string presentation of the object
        /// </summary>
        public void SetSrcString(string value)
        {
            _srcString = value;
        }
    }
}
