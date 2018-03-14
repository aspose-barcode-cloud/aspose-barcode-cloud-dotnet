// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodeResponse.cs">
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

using System; 

namespace Aspose.BarCode.Cloud.Sdk.Model 
{
  using System.Collections;
  using System.Collections.Generic;
  using System.Runtime.Serialization;
  using System.Text;

  /// <summary>
  /// Represents information about barcode.
  /// </summary>  
  public class BarCodeResponse 
  {                       
        /// <summary>
        /// Gets or sets barcode data.
        /// </summary>  
        public string BarCodeValue { get; set; }
		
        /// <summary>
        /// Gets or sets type of the barcode.
        /// </summary>  
        public string BarCodeType { get; set; }
		
        /// <summary>
        /// Gets or sets region with barcode.
        /// </summary>  
        public List<Point> Region { get; set; }
		
        /// <summary>
        /// Gets or sets checksum of barcode.
        /// </summary>  
        public string Checksum { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BarCodeResponse {\n");
          sb.Append("  BarCodeValue: ").Append(this.BarCodeValue).Append("\n");
          sb.Append("  BarCodeType: ").Append(this.BarCodeType).Append("\n");
          sb.Append("  Region: ").Append(this.Region).Append("\n");
          sb.Append("  Checksum: ").Append(this.Checksum).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
