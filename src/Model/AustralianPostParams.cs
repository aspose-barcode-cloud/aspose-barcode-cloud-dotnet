
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     AustralianPost barcode parameters.
    /// </summary>
    public class AustralianPostParams : IToString
    {
        /// <summary>
        ///     Interpreting type for the Customer Information of AustralianPost, default to CustomerInformationInterpretingType.Other
        /// </summary>
        public CustomerInformationInterpretingType? EncodingTable { get; set; }

        /// <summary>
        ///     Short bar's height of AustralianPost barcode.
        /// </summary>
        public double? ShortBarHeight { get; set; }

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
