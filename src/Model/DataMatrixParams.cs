
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     DataMatrix parameters.
    /// </summary>
    public class DataMatrixParams : IToString
    {
        /// <summary>
        ///     Datamatrix ECC type. Default value: DataMatrixEccType.Ecc200.
        /// </summary>
        public DataMatrixEccType? DataMatrixEcc { get; set; }

        /// <summary>
        ///     Encode mode of Datamatrix barcode. Default value: DataMatrixEncodeMode.Auto.
        /// </summary>
        public DataMatrixEncodeMode? DataMatrixEncodeMode { get; set; }

        /// <summary>
        ///     Macro Characters 05 and 06 values are used to obtain more compact encoding in special modes. Can be used only with DataMatrixEccType.Ecc200 or DataMatrixEccType.EccAuto. Cannot be used with EncodeTypes.GS1DataMatrix Default value: MacroCharacters.None.
        /// </summary>
        public MacroCharacter? MacroCharacters { get; set; }

        /// <summary>
        ///     Sets a Datamatrix symbol size. Default value: DataMatrixVersion.Auto.
        /// </summary>
        public DataMatrixVersion? Version { get; set; }

        /// <summary>
        ///     Height/Width ratio of 2D BarCode module
        /// </summary>
        public double? AspectRatio { get; set; }

        /// <summary>
        ///     DEPRECATED: This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.
        /// </summary>
        [System.Obsolete("This property is obsolete and will be removed in future releases. Unicode symbols detection and encoding will be processed in Auto mode with Extended Channel Interpretation charset designator. Using of own encodings requires manual CodeText encoding into byte[] array.  Sets the encoding of codetext.", false)]
        public string TextEncoding { get; set; }

        /// <summary>
        ///     DEPRECATED: Will be replaced with 'DataMatrix.Version' in the next release  Columns count.
        /// </summary>
        [System.Obsolete("Will be replaced with 'DataMatrix.Version' in the next release  Columns count.", false)]
        public int? Columns { get; set; }

        /// <summary>
        ///     DEPRECATED: Will be replaced with 'DataMatrix.Version' in the next release  Rows count.
        /// </summary>
        [System.Obsolete("Will be replaced with 'DataMatrix.Version' in the next release  Rows count.", false)]
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
