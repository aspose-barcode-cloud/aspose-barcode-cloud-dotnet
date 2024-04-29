
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Caption
    /// </summary>
    public class CaptionParams : IToString
    {
        /// <summary>
        ///     Text alignment.
        /// </summary>
        public TextAlignment? Alignment { get; set; }

        /// <summary>
        ///     Caption text.
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        ///     Text color.
        /// </summary>
        public string Color { get; set; }

        /// <summary>
        ///     Is caption visible.
        /// </summary>
        public bool? Visible { get; set; }

        /// <summary>
        ///     Font.
        /// </summary>
        public FontParams Font { get; set; }

        /// <summary>
        ///     Padding.
        /// </summary>
        public Padding Padding { get; set; }

        /// <summary>
        ///     Specify word wraps (line breaks) within text. Default value: false.
        /// </summary>
        public bool? NoWrap { get; set; }

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
