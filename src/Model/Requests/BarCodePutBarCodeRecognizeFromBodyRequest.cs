// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodePutBarCodeRecognizeFromBodyRequest.cs">
//   Copyright (c) 2019 Aspose.BarCode for Cloud
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
  /// Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarCodeApi.BarCodePutBarCodeRecognizeFromBody" /> operation.
  /// </summary>  
  public class BarCodePutBarCodeRecognizeFromBodyRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePutBarCodeRecognizeFromBodyRequest"/> class.
        /// </summary>        
        public BarCodePutBarCodeRecognizeFromBodyRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePutBarCodeRecognizeFromBodyRequest"/> class.
        /// </summary>
        /// <param name="name">The image name.</param>
        /// <param name="barcodeReader">BarCodeReader object with parameters.</param>
        /// <param name="type">The barcode type.</param>
        /// <param name="folder">The image folder.</param>
        public BarCodePutBarCodeRecognizeFromBodyRequest(string name, BarCodeReader barcodeReader = null, string type = null, string folder = null)             
        {
            this.name = name;
            this.barcodeReader = barcodeReader;
            this.type = type;
            this.folder = folder;
        }

        /// <summary>
        /// The image name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// BarCodeReader object with parameters.
        /// </summary>  
        public BarCodeReader barcodeReader { get; set; }

        /// <summary>
        /// The barcode type.
        /// </summary>  
        public string type { get; set; }

        /// <summary>
        /// The image folder.
        /// </summary>  
        public string folder { get; set; }
  }
}
