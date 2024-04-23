
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Represents information about barcode.
    /// </summary>
    public class BarcodeResponse : IToString
    {
        /// <summary>
        ///     Barcode data.
        /// </summary>
        public string BarcodeValue { get; set; }

        /// <summary>
        ///     Type of the barcode.
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        ///     Region with barcode.
        /// </summary>
        public List<RegionPoint> Region { get; set; }

        /// <summary>
        ///     Checksum of barcode.
        /// </summary>
        public string Checksum { get; set; }

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
