
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     PatchCode parameters.
    /// </summary>
    public class PatchCodeParams : IToString
    {
        /// <summary>
        ///     PatchCode format. Choose PatchOnly to generate single PatchCode. Use page format to generate Patch page with PatchCodes as borders. Default value: PatchFormat.PatchOnly
        /// </summary>
        public PatchFormat? PatchFormat { get; set; }

        /// <summary>
        ///     Specifies codetext for an extra QR barcode, when PatchCode is generated in page mode.
        /// </summary>
        public string ExtraBarcodeText { get; set; }

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
