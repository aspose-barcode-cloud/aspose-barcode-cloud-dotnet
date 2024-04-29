
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///
    /// </summary>
    public class ApiError : IToString
    {
        /// <summary>
        ///     Gets or sets Code
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        ///     Gets or sets Message
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        ///     Gets or sets Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        ///     Gets or sets DateTime
        /// </summary>
        public DateTime? DateTime { get; set; }

        /// <summary>
        ///     Gets or sets InnerError
        /// </summary>
        public ApiError InnerError { get; set; }

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
