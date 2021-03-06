using System;

namespace Aspose.BarCode.Cloud.Sdk.Api
{
    /// <summary>
    ///     API Exception
    /// </summary>
    public class ApiException : Exception
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ApiException" /> class.
        /// </summary>
        /// <param name="errorCode">HTTP status code.</param>
        /// <param name="message">Error message.</param>
        public ApiException(int errorCode, string message) : base(message)
        {
            ErrorCode = errorCode;
        }

        /// <summary>
        ///     Gets or sets the error code (HTTP status code)
        /// </summary>
        /// <value>The error code (HTTP status code).</value>
        public int ErrorCode { get; }
    }
}
