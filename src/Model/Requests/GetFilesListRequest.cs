// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="GetFilesListRequest.cs">
//   Copyright (c) 2024 Aspose.BarCode for Cloud
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
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.FolderApi.GetFilesListAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class GetFilesListRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GetFilesListRequest"/> class.
        /// </summary>
        /// <param name="path">Folder path e.g. &#39;/folder&#39;</param>
        public GetFilesListRequest(string path)
        {
            this.path = path;
        }

        /// <summary>
        ///     Folder path e.g. '/folder'
        /// </summary>
        public string path { get; set; }

        /// <summary>
        ///     Storage name
        /// </summary>
        public string storageName { get; set; }
    }
}
