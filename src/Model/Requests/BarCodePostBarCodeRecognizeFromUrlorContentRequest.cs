// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodePostBarCodeRecognizeFromUrlorContentRequest.cs">
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
  /// Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.BarCodeApi.BarCodePostBarCodeRecognizeFromUrlorContent" /> operation.
  /// </summary>  
  public class BarCodePostBarCodeRecognizeFromUrlorContentRequest  
  {
        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePostBarCodeRecognizeFromUrlorContentRequest"/> class.
        /// </summary>        
        public BarCodePostBarCodeRecognizeFromUrlorContentRequest()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BarCodePostBarCodeRecognizeFromUrlorContentRequest"/> class.
        /// </summary>
        /// <param name="type">BarCode type.</param>
        /// <param name="checksumValidation">Checksum validation parameter.</param>
        /// <param name="stripFnc">Allows to strip FNC symbol in recognition results.</param>
        /// <param name="rotationAngle">Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0</param>
        /// <param name="url">The image file url.</param>
        /// <param name="imageData">Image data with image</param>
        public BarCodePostBarCodeRecognizeFromUrlorContentRequest(string type = null, string checksumValidation = null, bool? stripFnc = null, int? rotationAngle = null, string url = null, System.IO.Stream imageData = null)             
        {
            this.type = type;
            this.checksumValidation = checksumValidation;
            this.stripFnc = stripFnc;
            this.rotationAngle = rotationAngle;
            this.url = url;
            this.imageData = imageData;
        }

        /// <summary>
        /// BarCode type.
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
        /// Recognition of rotated barcode. Possible angles are 90, 180, 270, default is 0
        /// </summary>  
        public int? rotationAngle { get; set; }

        /// <summary>
        /// The image file url.
        /// </summary>  
        public string url { get; set; }

        /// <summary>
        /// Image data with image
        /// </summary>  
        public System.IO.Stream imageData { get; set; }
  }
}
