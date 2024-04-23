
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Code16K parameters.
    /// </summary>
    public class Code16KParams : IToString
    {
        /// <summary>
        ///     Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     Size of the left quiet zone in xDimension. Default value: 10, meaning if xDimension = 2px than left quiet zone will be 20px.
        /// </summary>
        public int? QuietZoneLeftCoef { get; set; }

        /// <summary>
        ///     Size of the right quiet zone in xDimension. Default value: 1, meaning if xDimension = 2px than right quiet zone will be 2px.
        /// </summary>
        public int? QuietZoneRightCoef { get; set; }

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
