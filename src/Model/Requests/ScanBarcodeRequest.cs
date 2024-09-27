// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ScanBarcodeRequest.cs">
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
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarcodeApi.ScanBarcodeAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class ScanBarcodeRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ScanBarcodeRequest"/> class.
        /// </summary>
        /// <param name="imageFile">Image as file</param>
        public ScanBarcodeRequest(System.IO.Stream imageFile)
        {
            this.imageFile = imageFile;
        }

        /// <summary>
        ///     Image as file
        /// </summary>
        public System.IO.Stream imageFile { get; set; }

        /// <summary>
        ///     Types of barcode to recognize
        /// </summary>
        public List<DecodeBarcodeType> decodeTypes { get; set; }

        /// <summary>
        ///     Timeout of recognition process in milliseconds.  Default value is 15_000 (15 seconds).  Maximum value is 30_000 (1/2 minute).  In case of a timeout RequestTimeout (408) status will be returned.  Try reducing the image size to avoid timeout.
        /// </summary>
        public int? timeout { get; set; }

        /// <summary>
        ///     Checksum validation setting. Default is ON.
        /// </summary>
        public string checksumValidation { get; set; }
    }
}

