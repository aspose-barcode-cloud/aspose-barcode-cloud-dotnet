
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Represents list of barcode generators
    /// </summary>
    public class GeneratorParamsList : IToString
    {
        /// <summary>
        ///     List of barcode generators
        /// </summary>
        public List<GeneratorParams> BarcodeBuilders { get; set; }

        /// <summary>
        ///     Shift step according to X axis
        /// </summary>
        public int? XStep { get; set; }

        /// <summary>
        ///     Shift step according to Y axis
        /// </summary>
        public int? YStep { get; set; }

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
