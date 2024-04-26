// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutBarcodeRecognizeFromBodyRequest.cs">
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
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarcodeApi.PutBarcodeRecognizeFromBodyAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class PutBarcodeRecognizeFromBodyRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PutBarcodeRecognizeFromBodyRequest"/> class.
        /// </summary>
        /// <param name="name">The image file name.</param>
        /// <param name="readerParams">BarcodeReader object with parameters.</param>
        public PutBarcodeRecognizeFromBodyRequest(string name, ReaderParams readerParams)
        {
            this.name = name;
            this.readerParams = readerParams;
        }

        /// <summary>
        ///     The image file name.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     BarcodeReader object with parameters.
        /// </summary>
        public ReaderParams readerParams { get; set; }

        /// <summary>
        ///     Gets or sets type
        /// </summary>
        public string type { get; set; }

        /// <summary>
        ///     The storage name
        /// </summary>
        public string storage { get; set; }

        /// <summary>
        ///     The image folder.
        /// </summary>
        public string folder { get; set; }
    }
}
