
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Aztec parameters.
    /// </summary>
    public class AztecParams : IToString
    {
        /// <summary>
        ///     Aztec Symbol mode. Default value: AztecSymbolMode.Auto.
        /// </summary>
        public AztecSymbolMode? SymbolMode { get; set; }

        /// <summary>
        ///     Encoding mode for Aztec barcodes. Default value: Auto
        /// </summary>
        public AztecEncodeMode? EncodeMode { get; set; }

        /// <summary>
        ///     Identifies ECI encoding. Used when AztecEncodeMode is Auto. Default value: ISO-8859-1.
        /// </summary>
        public ECIEncodings? ECIEncoding { get; set; }

        /// <summary>
        ///     Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     Level of error correction of Aztec types of barcode. Value should between 10 to 95.
        /// </summary>
        public int? ErrorLevel { get; set; }

        /// <summary>
        ///     DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.
        /// </summary>
        [System.Obsolete("This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.", false)]
        public string TextEncoding { get; set; }

        /// <summary>
        ///     Used to instruct the reader to interpret the data contained within the symbol as programming for reader initialization.
        /// </summary>
        public bool? IsReaderInitialization { get; set; }

        /// <summary>
        ///     Gets or sets layers count of Aztec symbol. Layers count should be in range from 1 to 3 for Compact mode and in range from 1 to 32 for Full Range mode. Default value: 0 (auto).
        /// </summary>
        public int? LayersCount { get; set; }

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
