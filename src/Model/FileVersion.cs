
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    public class FileVersion : IToString
    {
        /// <summary>
        ///     File or folder name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     True if it is a folder.
        /// </summary>
        public bool? IsFolder { get; set; }

        /// <summary>
        ///     File or folder last modified DateTime.
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        /// <summary>
        ///     File or folder size.
        /// </summary>
        public long? Size { get; set; }

        /// <summary>
        ///     File or folder path.
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        ///     File Version ID.
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        ///     Specifies whether the file is (true) or is not (false) the latest version of an file.
        /// </summary>
        public bool? IsLatest { get; set; }

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
