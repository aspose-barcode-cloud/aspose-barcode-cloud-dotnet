
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Object exists
    /// </summary>
    public class ObjectExist : IToString
    {
        /// <summary>
        ///     Indicates that the file or folder exists.
        /// </summary>
        public bool? Exists { get; set; }

        /// <summary>
        ///     True if it is a folder, false if it is a file.
        /// </summary>
        public bool? IsFolder { get; set; }

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
