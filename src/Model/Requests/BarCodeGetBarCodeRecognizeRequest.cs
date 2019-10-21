// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodeGetBarCodeRecognizeRequest.cs">
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
  /// Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarCodeApi.BarCodeGetBarCodeRecognize" /> operation.
  /// </summary>  
  public class BarCodeGetBarCodeRecognizeRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodeGetBarCodeRecognizeRequest"/> class.
        /// </summary>        
        public BarCodeGetBarCodeRecognizeRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodeGetBarCodeRecognizeRequest"/> class.
        /// </summary>
        /// <param name="name">The image name.</param>
        /// <param name="type">The barcode type.</param>
        /// <param name="checksumValidation">Checksum validation parameter.</param>
        /// <param name="stripFnc">Allows to strip FNC symbol in recognition results.</param>
        /// <param name="rotationAngle">Allows to correct angle of barcode.</param>
        /// <param name="barcodesCount">Count of barcodes to recognize.</param>
        /// <param name="rectX">Top left point X coordinate of  to recognize barcode inside.</param>
        /// <param name="rectY">Top left point Y coordinate of  to recognize barcode inside.</param>
        /// <param name="rectWidth">Width of  to recognize barcode inside.</param>
        /// <param name="rectHeight">Height of  to recognize barcode inside.</param>
        /// <param name="storage">The image storage.</param>
        /// <param name="folder">The image folder.</param>
        public BarCodeGetBarCodeRecognizeRequest(string name, string type = null, string checksumValidation = null, bool? stripFnc = null, int? rotationAngle = null, int? barcodesCount = null, int? rectX = null, int? rectY = null, int? rectWidth = null, int? rectHeight = null, string storage = null, string folder = null)             
        {
            this.name = name;
            this.type = type;
            this.checksumValidation = checksumValidation;
            this.stripFnc = stripFnc;
            this.rotationAngle = rotationAngle;
            this.barcodesCount = barcodesCount;
            this.rectX = rectX;
            this.rectY = rectY;
            this.rectWidth = rectWidth;
            this.rectHeight = rectHeight;
            this.storage = storage;
            this.folder = folder;
        }

        /// <summary>
        /// The image name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// The barcode type.
        /// </summary>  
        public string type { get; set; }

        /// <summary>
        /// Checksum validation parameter.
        /// </summary>  
        public string checksumValidation { get; set; }

        /// <summary>
        /// Allows to strip FNC symbol in recognition results.
        /// </summary>  
        public bool? stripFnc { get; set; }

        /// <summary>
        /// Allows to correct angle of barcode.
        /// </summary>  
        public int? rotationAngle { get; set; }

        /// <summary>
        /// Count of barcodes to recognize.
        /// </summary>  
        public int? barcodesCount { get; set; }

        /// <summary>
        /// Top left point X coordinate of  to recognize barcode inside.
        /// </summary>  
        public int? rectX { get; set; }

        /// <summary>
        /// Top left point Y coordinate of  to recognize barcode inside.
        /// </summary>  
        public int? rectY { get; set; }

        /// <summary>
        /// Width of  to recognize barcode inside.
        /// </summary>  
        public int? rectWidth { get; set; }

        /// <summary>
        /// Height of  to recognize barcode inside.
        /// </summary>  
        public int? rectHeight { get; set; }

        /// <summary>
        /// The image storage.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// The image folder.
        /// </summary>  
        public string folder { get; set; }
  }
}
