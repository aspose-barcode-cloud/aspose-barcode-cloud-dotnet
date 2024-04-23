
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Padding around barcode.
    /// </summary>
    public class Padding : IToString
    {
        /// <summary>
        ///     Left padding.
        /// </summary>
        public double? Left { get; set; }

        /// <summary>
        ///     Right padding.
        /// </summary>
        public double? Right { get; set; }

        /// <summary>
        ///     Top padding.
        /// </summary>
        public double? Top { get; set; }

        /// <summary>
        ///     Bottom padding.
        /// </summary>
        public double? Bottom { get; set; }

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
