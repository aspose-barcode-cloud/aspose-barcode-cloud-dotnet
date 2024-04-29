
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Error
    /// </summary>
    public class Error : IToString
    {
        /// <summary>
        ///     Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Inner Error
        /// </summary>
        public ErrorDetails InnerError { get; set; }

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
