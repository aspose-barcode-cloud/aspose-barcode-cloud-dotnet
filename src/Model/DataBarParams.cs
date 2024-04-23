
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Databar parameters.
    /// </summary>
    public class DataBarParams : IToString
    {
        /// <summary>
        ///     Height/Width ratio of 2D BarCode module. Used for DataBar stacked.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     Columns count.
        /// </summary>
        public int? Columns { get; set; }

        /// <summary>
        ///     Rows count.
        /// </summary>
        public int? Rows { get; set; }

        /// <summary>
        ///     Enables flag of 2D composite component with DataBar barcode
        /// </summary>
        public bool? Is2DCompositeComponent { get; set; }

        /// <summary>
        ///     If this flag is set, it allows only GS1 encoding standard for Databar barcode types
        /// </summary>
        public bool? IsAllowOnlyGS1Encoding { get; set; }

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
