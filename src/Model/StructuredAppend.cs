
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     QR structured append parameters.
    /// </summary>
    public class StructuredAppend : IToString
    {
        /// <summary>
        ///     The index of the QR structured append mode barcode. Index starts from 0.
        /// </summary>
        public int? SequenceIndicator { get; set; }

        /// <summary>
        ///     QR structured append mode barcodes quantity. Max value is 16.
        /// </summary>
        public int? TotalCount { get; set; }

        /// <summary>
        ///     QR structured append mode parity data.
        /// </summary>
        public int? ParityByte { get; set; }

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
