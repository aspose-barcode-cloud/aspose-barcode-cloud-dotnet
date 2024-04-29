
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     QR parameters.
    /// </summary>
    public class QrParams : IToString
    {
        /// <summary>
        ///     QR / MicroQR selector mode. Select ForceQR for standard QR symbols, Auto for MicroQR.
        /// </summary>
        public QREncodeType? EncodeType { get; set; }

        /// <summary>
        ///     Extended Channel Interpretation Identifiers. It is used to tell the barcode reader details about the used references for encoding the data in the symbol. Current implementation consists all well known charset encodings.
        /// </summary>
        public ECIEncodings? ECIEncoding { get; set; }

        /// <summary>
        ///     QR symbology type of BarCode&#39;s encoding mode. Default value: QREncodeMode.Auto.
        /// </summary>
        public QREncodeMode? EncodeMode { get; set; }

        /// <summary>
        ///     Level of Reed-Solomon error correction for QR barcode. From low to high: LevelL, LevelM, LevelQ, LevelH. see QRErrorLevel.
        /// </summary>
        public QRErrorLevel? ErrorLevel { get; set; }

        /// <summary>
        ///     Version of QR Code. From Version1 to Version40 for QR code and from M1 to M4 for MicroQr. Default value is QRVersion.Auto.
        /// </summary>
        public QRVersion? Version { get; set; }

        /// <summary>
        ///     Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.
        /// </summary>
        [System.Obsolete("This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.", false)]
        public string TextEncoding { get; set; }

        /// <summary>
        ///     QR structured append parameters.
        /// </summary>
        public StructuredAppend StructuredAppend { get; set; }

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
