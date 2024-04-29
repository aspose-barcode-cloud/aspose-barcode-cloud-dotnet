
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     HanXin params.
    /// </summary>
    public class HanXinParams : IToString
    {
        /// <summary>
        ///     Encoding mode for XanXin barcodes. Default value: HanXinEncodeMode.Auto.
        /// </summary>
        public HanXinEncodeMode? EncodeMode { get; set; }

        /// <summary>
        ///     Allowed Han Xin error correction levels from L1 to L4. Default value: HanXinErrorLevel.L1.
        /// </summary>
        public HanXinErrorLevel? ErrorLevel { get; set; }

        /// <summary>
        ///     Allowed Han Xin versions, Auto and Version01 - Version84. Default value: HanXinVersion.Auto.
        /// </summary>
        public HanXinVersion? Version { get; set; }

        /// <summary>
        ///     Extended Channel Interpretation Identifiers. It is used to tell the barcode reader details about the used references for encoding the data in the symbol. Current implementation consists all well known charset encodings. Default value: ECIEncodings.ISO_8859_1
        /// </summary>
        public ECIEncodings? ECIEncoding { get; set; }

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
