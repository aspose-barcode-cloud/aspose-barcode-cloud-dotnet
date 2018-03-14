// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodeGetBarCodeGenerateRequest.cs">
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
  /// Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarCodeApi.BarCodeGetBarCodeGenerate" /> operation.
  /// </summary>  
  public class BarCodeGetBarCodeGenerateRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodeGetBarCodeGenerateRequest"/> class.
        /// </summary>        
        public BarCodeGetBarCodeGenerateRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodeGetBarCodeGenerateRequest"/> class.
        /// </summary>
        /// <param name="text">The code text.</param>
        /// <param name="type">BarCode type.</param>
        /// <param name="format">Result format.</param>
        /// <param name="resolutionX">Horizontal resolution.</param>
        /// <param name="resolutionY">Vertical resolution.</param>
        /// <param name="dimensionX">Smallest width of barcode unit (bar or space).</param>
        /// <param name="dimensionY">Smallest height of barcode unit (for 2D barcodes).</param>
        /// <param name="enableChecksum">Sets if checksum will be generated.</param>
        public BarCodeGetBarCodeGenerateRequest(string text = null, string type = null, string format = null, double? resolutionX = null, double? resolutionY = null, double? dimensionX = null, double? dimensionY = null, string enableChecksum = null)             
        {
            this.text = text;
            this.type = type;
            this.format = format;
            this.resolutionX = resolutionX;
            this.resolutionY = resolutionY;
            this.dimensionX = dimensionX;
            this.dimensionY = dimensionY;
            this.enableChecksum = enableChecksum;
        }

        /// <summary>
        /// The code text.
        /// </summary>  
        public string text { get; set; }

        /// <summary>
        /// BarCode type.
        /// </summary>  
        public string type { get; set; }

        /// <summary>
        /// Result format.
        /// </summary>  
        public string format { get; set; }

        /// <summary>
        /// Horizontal resolution.
        /// </summary>  
        public double? resolutionX { get; set; }

        /// <summary>
        /// Vertical resolution.
        /// </summary>  
        public double? resolutionY { get; set; }

        /// <summary>
        /// Smallest width of barcode unit (bar or space).
        /// </summary>  
        public double? dimensionX { get; set; }

        /// <summary>
        /// Smallest height of barcode unit (for 2D barcodes).
        /// </summary>  
        public double? dimensionY { get; set; }

        /// <summary>
        /// Sets if checksum will be generated.
        /// </summary>  
        public string enableChecksum { get; set; }
  }
}
