// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MoveFileRequest.cs">
//   Copyright (c) 2025 Aspose.BarCode for Cloud
// </copyright>
// <summary>
//   Permission is hereby granted, free of charge, to any person obtaining a copy
//  of this software and associated documentation files (the "Software"), to deal
//  in the Software without restriction, including without limitation the rights
//  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
//  copies of the Software, and to permit persons to whom the Software is
//  furnished to do so, subject to the following conditions:
//
//  The above copyright notice and this permission notice shall be included in all
//  copies or substantial portions of the Software.
//
//  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
//  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
//  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
//  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
//  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
//  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
//  SOFTWARE.
// </summary>
// --------------------------------------------------------------------------------------------------------------------


using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Aspose.BarCode.Cloud.Sdk.Model.Requests
{
    /// <summary>
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.FileApi.MoveFileAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class MoveFileRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MoveFileRequest"/> class.
        /// </summary>
        /// <param name="srcPath">Source file path e.g. &#39;/src.ext&#39;</param>
        /// <param name="destPath">Destination file path e.g. &#39;/dest.ext&#39;</param>
        public MoveFileRequest(string srcPath, string destPath)
        {
            this.srcPath = srcPath;
            this.destPath = destPath;
        }

        /// <summary>
        ///     Source file path e.g. '/src.ext'
        /// </summary>
        public string srcPath { get; set; }

        /// <summary>
        ///     Destination file path e.g. '/dest.ext'
        /// </summary>
        public string destPath { get; set; }

        /// <summary>
        ///     Source storage name
        /// </summary>
        public string srcStorageName { get; set; }

        /// <summary>
        ///     Destination storage name
        /// </summary>
        public string destStorageName { get; set; }

        /// <summary>
        ///     File version ID to move
        /// </summary>
        public string versionId { get; set; }
    }
}
