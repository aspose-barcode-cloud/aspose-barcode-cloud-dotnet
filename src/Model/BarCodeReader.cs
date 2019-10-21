// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodeReader.cs">
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

using System; 

namespace Aspose.BarCode.Cloud.Sdk.Model 
{
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;

  /// <summary>
  /// Represents BarCodeReader object.
  /// </summary>  
  public class BarCodeReader 
  {                       
        /// <summary>
        /// Gets or sets ChecksumValidation property.
        /// </summary>
        public ChecksumValidation? ChecksumValidation { get; set; }

        /// <summary>
        /// Gets or sets recognition mode.
        /// </summary>
        public RecognitionMode? RecognitionMode { get; set; }

        /// <summary>
        /// Gets or sets manual hints.
        /// </summary>
        public ManualHints? ManualHints { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether FNC symbol strip must be done.
        /// </summary>  
        public bool? StripFNC { get; set; }
		
        /// <summary>
        /// Gets or sets count of barcodes to recognize.
        /// </summary>  
        public int? BarCodesCount { get; set; }
		
        /// <summary>
        /// Gets or sets rotation correction angle.
        /// </summary>  
        public int? RotationAngle { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BarCodeReader {\n");
          sb.Append("  ChecksumValidation: ").Append(this.ChecksumValidation).Append("\n");
          sb.Append("  StripFNC: ").Append(this.StripFNC).Append("\n");
          sb.Append("  BarCodesCount: ").Append(this.BarCodesCount).Append("\n");
          sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
          sb.Append("  RecognitionMode: ").Append(this.RecognitionMode).Append("\n");
          sb.Append("  ManualHints: ").Append(this.ManualHints).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
