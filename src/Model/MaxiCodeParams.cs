// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="MaxiCodeParams.cs">
//   Copyright (c) 2020 Aspose.BarCode for Cloud
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

//
// This source code was auto-generated by AsposeBarcodeCloudCodegen.
//

using System;

namespace Aspose.BarCode.Cloud.Sdk.Model
{
  using System.Collections;
  using System.Collections.Generic;
  using System.Net;
  using System.Runtime.Serialization;
  using System.Text;

  /// <summary>
  /// MaxiCode parameters.
  /// </summary>
  public class MaxiCodeParams
  {
        /// <summary>
        /// Height/Width ratio of 2D BarCode module.
        /// </summary>
        public double? AspectRatio { get; set; }
        /// <summary>
        /// MaxiCode encode mode.
        /// </summary>
        public int? EncodeMode { get; set; }
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
          var sb = new StringBuilder();
          sb.Append("class MaxiCodeParams {\n");
          sb.Append("  AspectRatio: ").Append(this.AspectRatio).Append("\n");
          sb.Append("  EncodeMode: ").Append(this.EncodeMode).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}