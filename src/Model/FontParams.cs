
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Font.
    /// </summary>
    public class FontParams : IToString
    {
        /// <summary>
        ///     Font style.
        /// </summary>
        public FontStyle? Style { get; set; }

        /// <summary>
        ///     Font family.
        /// </summary>
        public string Family { get; set; }

        /// <summary>
        ///     Font size in units.
        /// </summary>
        public double? Size { get; set; }

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
