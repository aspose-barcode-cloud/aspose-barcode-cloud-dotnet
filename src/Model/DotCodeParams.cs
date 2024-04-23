
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     DotCode parameters.
    /// </summary>
    public class DotCodeParams : IToString
    {
        /// <summary>
        ///     Identifies DotCode encode mode. Default value: Auto.
        /// </summary>
        public DotCodeEncodeMode? EncodeMode { get; set; }

        /// <summary>
        ///     Identifies ECI encoding. Used when DotCodeEncodeMode is Auto. Default value: ISO-8859-1.
        /// </summary>
        public ECIEncodings? ECIEncoding { get; set; }

        /// <summary>
        ///     Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     Identifies columns count. Sum of the number of rows plus the number of columns of a DotCode symbol must be odd. Number of columns must be at least 5.
        /// </summary>
        public int? Columns { get; set; }

        /// <summary>
        ///     Indicates whether code is used for instruct reader to interpret the following data as instructions for initialization or reprogramming of the bar code reader. Default value is false.
        /// </summary>
        public bool? IsReaderInitialization { get; set; }

        /// <summary>
        ///     Identifies rows count. Sum of the number of rows plus the number of columns of a DotCode symbol must be odd. Number of rows must be at least 5.
        /// </summary>
        public int? Rows { get; set; }

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
