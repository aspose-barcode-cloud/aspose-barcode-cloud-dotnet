// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="PutGenerateMultipleRequest.cs">
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
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarcodeApi.PutGenerateMultipleAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class PutGenerateMultipleRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="PutGenerateMultipleRequest"/> class.
        /// </summary>
        /// <param name="name">New filename</param>
        /// <param name="generatorParamsList">List of barcodes</param>
        public PutGenerateMultipleRequest(string name, GeneratorParamsList generatorParamsList)
        {
            this.name = name;
            this.generatorParamsList = generatorParamsList;
        }

        /// <summary>
        ///     New filename
        /// </summary>
        public string name { get; set; }

        /// <summary>
        ///     List of barcodes
        /// </summary>
        public GeneratorParamsList generatorParamsList { get; set; }

        /// <summary>
        ///     Format of file
        /// </summary>
        public string format { get; set; }

        /// <summary>
        ///     Folder to place file to
        /// </summary>
        public string folder { get; set; }

        /// <summary>
        ///     The storage name
        /// </summary>
        public string storage { get; set; }
    }
}
