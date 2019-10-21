// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodeBuilder.cs">
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
  /// Represents BarCodeBuilder.
  /// </summary>  
  public class BarCodeBuilder 
  {                       
        /// <summary>
        /// Gets or sets type of barcode to generate.
        /// </summary>
        public BarCodeType? TypeOfBarCode { get; set; }

        /// <summary>
        /// Gets or sets  of barcode.
        /// </summary>
        public CodeLocation? CodeLocation { get; set; }

        /// <summary>
        /// Gets or sets  for barcode dimension parameers.
        /// </summary>
        public GraphicsUnit? GraphicsUnit { get; set; }

        /// <summary>
        /// Gets or sets  of the image.
        /// </summary>
        public ImageQualityMode? ImageQuality { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether checksum is enabled.
        /// </summary>
        public EnableChecksum? EnableChecksum { get; set; }

        /// <summary>
        /// Gets or sets text to encode.
        /// </summary>  
        public string Text { get; set; }
		
        /// <summary>
        /// Gets or sets  parameters.>
        /// </summary>  
        public Resolution Resolution { get; set; }
		
        /// <summary>
        /// Gets or sets smallest width unit of barcode.
        /// </summary>  
        public double? DimensionX { get; set; }
		
        /// <summary>
        /// Gets or sets smallest height unit of barcode.
        /// </summary>  
        public double? DimensionY { get; set; }
		
        /// <summary>
        /// Gets or sets a value indicating whether size of barcode changes automatically.
        /// </summary>  
        public bool? AutoSize { get; set; }
		
        /// <summary>
        /// Gets or sets height of the barcode.
        /// </summary>  
        public double? BarHeight { get; set; }
		
        /// <summary>
        /// Gets or sets height of the barcode image.
        /// </summary>  
        public double? ImageHeight { get; set; }
		
        /// <summary>
        /// Gets or sets width of the barcode image.
        /// </summary>  
        public double? ImageWidth { get; set; }
		
        /// <summary>
        /// Gets or sets angle of barcode orientation.
        /// </summary>  
        public double? RotationAngle { get; set; }
		
        /// <summary>
        /// Gets or sets  around barcode.
        /// </summary>  
        public Margins Margins { get; set; }
		
        /// <summary>
        /// Gets or sets background color.
        /// </summary>  
        public string BackColor { get; set; }
		
        /// <summary>
        /// Gets or sets foreground color.
        /// </summary>  
        public string ForeColor { get; set; }
		
        /// <summary>
        /// Gets or sets color of the code text.
        /// </summary>  
        public string CodeTextColor { get; set; }
		
        /// <summary>
        /// Gets or sets color of the border.
        /// </summary>  
        public string BorderColor { get; set; }
		
        /// <summary>
        /// Gets or sets a value indicating whether border is visible.
        /// </summary>  
        public bool? BorderVisible { get; set; }
		
        /// <summary>
        /// Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()  
        {
          var sb = new StringBuilder();
          sb.Append("class BarCodeBuilder {\n");
          sb.Append("  TypeOfBarCode: ").Append(this.TypeOfBarCode).Append("\n");
          sb.Append("  Text: ").Append(this.Text).Append("\n");
          sb.Append("  Resolution: ").Append(this.Resolution).Append("\n");
          sb.Append("  DimensionX: ").Append(this.DimensionX).Append("\n");
          sb.Append("  DimensionY: ").Append(this.DimensionY).Append("\n");
          sb.Append("  CodeLocation: ").Append(this.CodeLocation).Append("\n");
          sb.Append("  GraphicsUnit: ").Append(this.GraphicsUnit).Append("\n");
          sb.Append("  AutoSize: ").Append(this.AutoSize).Append("\n");
          sb.Append("  BarHeight: ").Append(this.BarHeight).Append("\n");
          sb.Append("  ImageHeight: ").Append(this.ImageHeight).Append("\n");
          sb.Append("  ImageWidth: ").Append(this.ImageWidth).Append("\n");
          sb.Append("  ImageQuality: ").Append(this.ImageQuality).Append("\n");
          sb.Append("  RotationAngle: ").Append(this.RotationAngle).Append("\n");
          sb.Append("  Margins: ").Append(this.Margins).Append("\n");
          sb.Append("  BackColor: ").Append(this.BackColor).Append("\n");
          sb.Append("  ForeColor: ").Append(this.ForeColor).Append("\n");
          sb.Append("  CodeTextColor: ").Append(this.CodeTextColor).Append("\n");
          sb.Append("  BorderColor: ").Append(this.BorderColor).Append("\n");
          sb.Append("  BorderVisible: ").Append(this.BorderVisible).Append("\n");
          sb.Append("  EnableChecksum: ").Append(this.EnableChecksum).Append("\n");
          sb.Append("}\n");
          return sb.ToString();
        }
    }
}
