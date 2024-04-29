
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Created image info.
    /// </summary>
    public class ResultImageInfo : IToString
    {
        /// <summary>
        ///     Result file size.
        /// </summary>
        public long? FileSize { get; set; }

        /// <summary>
        ///     Result image width.
        /// </summary>
        public int? ImageWidth { get; set; }

        /// <summary>
        ///     Result image height.
        /// </summary>
        public int? ImageHeight { get; set; }

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
