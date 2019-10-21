// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodePutBarCodeGenerateFileRequest.cs">
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
  /// Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarCodeApi.BarCodePutBarCodeGenerateFile" /> operation.
  /// </summary>  
  public class BarCodePutBarCodeGenerateFileRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePutBarCodeGenerateFileRequest"/> class.
        /// </summary>        
        public BarCodePutBarCodeGenerateFileRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePutBarCodeGenerateFileRequest"/> class.
        /// </summary>
        /// <param name="name">The image name.</param>
        /// <param name="file">File to upload</param>
        /// <param name="text">BarCode&#39;s text.</param>
        /// <param name="type">The barcode type.</param>
        /// <param name="format">The image format.</param>
        /// <param name="resolutionX">Horizontal resolution.</param>
        /// <param name="resolutionY">Vertical resolution.</param>
        /// <param name="dimensionX">Smallest width of barcode unit (bar or space).</param>
        /// <param name="dimensionY">Smallest height of barcode unit (for 2D barcodes).</param>
        /// <param name="codeLocation">property of the barcode. </param>
        /// <param name="grUnit">Measurement of barcode properties. </param>
        /// <param name="autoSize">Sets if barcode size will be updated automatically. </param>
        /// <param name="barHeight">Height of the bar. </param>
        /// <param name="imageHeight">Height of the image. </param>
        /// <param name="imageWidth">Width of the image. </param>
        /// <param name="imageQuality">Detepmines  of the barcode image. </param>
        /// <param name="rotAngle">Angle of barcode orientation. </param>
        /// <param name="topMargin">Top margin. </param>
        /// <param name="bottomMargin">Bottom margin. </param>
        /// <param name="leftMargin">Left margin. </param>
        /// <param name="rightMargin">Right margin. </param>
        /// <param name="enableChecksum">Sets if checksum will be generated.</param>
        /// <param name="storage">Image&#39;s storage.</param>
        /// <param name="folder">Image&#39;s folder.</param>
        public BarCodePutBarCodeGenerateFileRequest(string name, System.IO.Stream file, string text = null, string type = null, string format = null, double? resolutionX = null, double? resolutionY = null, double? dimensionX = null, double? dimensionY = null, string codeLocation = null, string grUnit = null, string autoSize = null, double? barHeight = null, double? imageHeight = null, double? imageWidth = null, string imageQuality = null, double? rotAngle = null, double? topMargin = null, double? bottomMargin = null, double? leftMargin = null, double? rightMargin = null, string enableChecksum = null, string storage = null, string folder = null)             
        {
            this.name = name;
            this.File = file;
            this.text = text;
            this.type = type;
            this.format = format;
            this.resolutionX = resolutionX;
            this.resolutionY = resolutionY;
            this.dimensionX = dimensionX;
            this.dimensionY = dimensionY;
            this.codeLocation = codeLocation;
            this.grUnit = grUnit;
            this.autoSize = autoSize;
            this.barHeight = barHeight;
            this.imageHeight = imageHeight;
            this.imageWidth = imageWidth;
            this.imageQuality = imageQuality;
            this.rotAngle = rotAngle;
            this.topMargin = topMargin;
            this.bottomMargin = bottomMargin;
            this.leftMargin = leftMargin;
            this.rightMargin = rightMargin;
            this.enableChecksum = enableChecksum;
            this.storage = storage;
            this.folder = folder;
        }

        /// <summary>
        /// The image name.
        /// </summary>  
        public string name { get; set; }

        /// <summary>
        /// File to upload
        /// </summary>  
        public System.IO.Stream File { get; set; }

        /// <summary>
        /// BarCode's text.
        /// </summary>  
        public string text { get; set; }

        /// <summary>
        /// The barcode type.
        /// </summary>  
        public string type { get; set; }

        /// <summary>
        /// The image format.
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
        /// property of the barcode. 
        /// </summary>  
        public string codeLocation { get; set; }

        /// <summary>
        /// Measurement of barcode properties. 
        /// </summary>  
        public string grUnit { get; set; }

        /// <summary>
        /// Sets if barcode size will be updated automatically. 
        /// </summary>  
        public string autoSize { get; set; }

        /// <summary>
        /// Height of the bar. 
        /// </summary>  
        public double? barHeight { get; set; }

        /// <summary>
        /// Height of the image. 
        /// </summary>  
        public double? imageHeight { get; set; }

        /// <summary>
        /// Width of the image. 
        /// </summary>  
        public double? imageWidth { get; set; }

        /// <summary>
        /// Detepmines  of the barcode image. 
        /// </summary>  
        public string imageQuality { get; set; }

        /// <summary>
        /// Angle of barcode orientation. 
        /// </summary>  
        public double? rotAngle { get; set; }

        /// <summary>
        /// Top margin. 
        /// </summary>  
        public double? topMargin { get; set; }

        /// <summary>
        /// Bottom margin. 
        /// </summary>  
        public double? bottomMargin { get; set; }

        /// <summary>
        /// Left margin. 
        /// </summary>  
        public double? leftMargin { get; set; }

        /// <summary>
        /// Right margin. 
        /// </summary>  
        public double? rightMargin { get; set; }

        /// <summary>
        /// Sets if checksum will be generated.
        /// </summary>  
        public string enableChecksum { get; set; }

        /// <summary>
        /// Image's storage.
        /// </summary>  
        public string storage { get; set; }

        /// <summary>
        /// Image's folder.
        /// </summary>  
        public string folder { get; set; }
  }
}
