// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodePutGenerateMultipleRequest.cs">
//   Copyright (c) 2018 Aspose.BarCode for Cloud
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
namespace Aspose.BarCode.Cloud.Sdk.Model.Requests 
{
  using Aspose.BarCode.Cloud.Sdk.Model; 

  /// <summary>
  /// Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarCodeApi.BarCodePutGenerateMultiple" /> operation.
  /// </summary>  
  public class BarCodePutGenerateMultipleRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePutGenerateMultipleRequest"/> class.
        /// </summary>        
        public BarCodePutGenerateMultipleRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePutGenerateMultipleRequest"/> class.
        /// </summary>
        /// <param name="name">New filename</param>
        /// <param name="dto">List of barcodes</param>
        /// <param name="format">Format of file</param>
        /// <param name="folder">Folder to place file to</param>
        public BarCodePutGenerateMultipleRequest(string name, BarCodeBuildersList dto = null, string format = null, string folder = null)             
        {
            this.name = name;
            this.dto = dto;
            this.format = format;
            this.folder = folder;
        }

        /// <summary>
        /// New filename
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// List of barcodes
        /// </summary>  
        public BarCodeBuildersList dto { get; set; }

        /// <summary>
        /// Format of file
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Folder to place file to
        /// </summary>  
        public string folder { get; set; }
  }
}
