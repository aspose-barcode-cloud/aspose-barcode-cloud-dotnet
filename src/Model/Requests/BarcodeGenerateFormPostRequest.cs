// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarcodeGenerateFormPostRequest.cs">
//   Copyright (c) 2024 Aspose.BarCode for Cloud
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


using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Aspose.BarCode.Cloud.Sdk.Model.Requests
{
    /// <summary>
    ///     Request model for <see cref="Aspose.BarCode.Cloud.Sdk.Api.GenerateApi.BarcodeGenerateFormPostAsync" /> operation.
    /// </summary>
    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Global")]
    public class BarcodeGenerateFormPostRequest
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="BarcodeGenerateFormPostRequest"/> class.
        /// </summary>
        public BarcodeGenerateFormPostRequest(int? rotationAngle = null)
        {
            this.RotationAngle = rotationAngle;
        }

        /// <summary>
        ///     Gets or sets barcodeType
        /// </summary>
        public EncodeBarcodeType barcodeType { get; set; }

        /// <summary>
        ///     Gets or sets DataType
        /// </summary>
        public EncodeDataType DataType { get; set; }

        /// <summary>
        ///     Gets or sets Data
        /// </summary>
        public string Data { get; set; }

        /// <summary>
        ///     Gets or sets ImageFormat
        /// </summary>
        public AvailableBarCodeImageFormat ImageFormat { get; set; }

        /// <summary>
        ///     Gets or sets TwoDDisplayText
        /// </summary>
        public string TwoDDisplayText { get; set; }

        /// <summary>
        ///     Gets or sets TextLocation
        /// </summary>
        public CodeLocation TextLocation { get; set; }

        /// <summary>
        ///     Gets or sets TextAlignment
        /// </summary>
        public TextAlignment TextAlignment { get; set; }

        /// <summary>
        ///     Gets or sets ForegroundColor
        /// </summary>
        public string ForegroundColor { get; set; }

        /// <summary>
        ///     Gets or sets BackgroundColor
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     Gets or sets Units
        /// </summary>
        public AvailableGraphicsUnit Units { get; set; }

        /// <summary>
        ///     Gets or sets Resolution
        /// </summary>
        public float? Resolution { get; set; }

        /// <summary>
        ///     Gets or sets ImageHeight
        /// </summary>
        public float? ImageHeight { get; set; }

        /// <summary>
        ///     Gets or sets ImageWidth
        /// </summary>
        public float? ImageWidth { get; set; }

        /// <summary>
        ///     Gets or sets RotationAngle
        /// </summary>
        public int? RotationAngle { get; set; }
    }
}
