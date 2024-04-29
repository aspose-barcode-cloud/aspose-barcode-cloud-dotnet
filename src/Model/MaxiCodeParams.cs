
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     MaxiCode parameters.
    /// </summary>
    public class MaxiCodeParams : IToString
    {
        /// <summary>
        ///     Mode for MaxiCode barcodes.
        /// </summary>
        public MaxiCodeMode? Mode { get; set; }

        /// <summary>
        ///     Encoding mode for MaxiCode barcodes.
        /// </summary>
        public MaxiCodeEncodeMode? EncodeMode { get; set; }

        /// <summary>
        ///     Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }

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
