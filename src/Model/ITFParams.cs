
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     ITF parameters.
    /// </summary>
    public class ITFParams : IToString
    {
        /// <summary>
        ///     Border type of ITF barcode. Default value: ITF14BorderType.Bar.
        /// </summary>
        public ITF14BorderType? BorderType { get; set; }

        /// <summary>
        ///     ITF border (bearer bar) thickness in Unit value. Default value: 12pt.
        /// </summary>
        public double? BorderThickness { get; set; }

        /// <summary>
        ///     Size of the quiet zones in xDimension. Default value: 10, meaning if xDimension = 2px than quiet zones will be 20px.
        /// </summary>
        public int? QuietZoneCoef { get; set; }

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
