// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Margins.cs">
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
  /// Represents margins around barcode.
  /// </summary>  
  public class Margins 
  {                       
        /// <summary>
        /// Gets or sets left margin.
        /// </summary>  
        public double? Left { get; set; }
		
        /// <summary>
        /// Gets or sets Right margin.
        /// </summary>  
        public double? Right { get; set; }
		
        /// <summary>
        /// Gets or sets top margin.
        /// </summary>  
        public double? Top { get; set; }
		
        /// <summary>
        /// Gets or sets bottom margin.
        /// </summary>  
        public double? Bottom { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class Margins {\n");
          sb.Append("  Left: ").Append(this.Left).Append("\n");
          sb.Append("  Right: ").Append(this.Right).Append("\n");
          sb.Append("  Top: ").Append(this.Top).Append("\n");
          sb.Append("  Bottom: ").Append(this.Bottom).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
