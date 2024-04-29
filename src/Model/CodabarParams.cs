
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Codabar parameters.
    /// </summary>
    public class CodabarParams : IToString
    {
        /// <summary>
        ///     Checksum algorithm for Codabar barcodes. Default value: CodabarChecksumMode.Mod16. To enable checksum calculation set value EnableChecksum.Yes to property EnableChecksum.
        /// </summary>
        public CodabarChecksumMode? ChecksumMode { get; set; }

        /// <summary>
        ///     Start symbol (character) of Codabar symbology. Default value: CodabarSymbol.A
        /// </summary>
        public CodabarSymbol? StartSymbol { get; set; }

        /// <summary>
        ///     Stop symbol (character) of Codabar symbology. Default value: CodabarSymbol.A
        /// </summary>
        public CodabarSymbol? StopSymbol { get; set; }

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
