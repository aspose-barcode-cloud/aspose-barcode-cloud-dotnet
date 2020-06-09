// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarcodeApi.cs">
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

using System.IO;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;

namespace Aspose.BarCode.Cloud.Sdk.Interfaces
{
    public interface IBarcodeApi
    {
        /// <summary>
        ///     Generate barcode.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeGenerateRequest" /></param>
        /// <returns>
        ///     <see cref="System.IO.Stream" />
        /// </returns>
        Stream GetBarcodeGenerate(GetBarcodeGenerateRequest request);

        /// <summary>
        ///     Recognize barcode from a file on server.
        /// </summary>
        /// <param name="request">Request. <see cref="GetBarcodeRecognizeRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        BarcodeResponseList GetBarcodeRecognize(GetBarcodeRecognizeRequest request);

        /// <summary>
        ///     Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image or encoded
        ///     with base64.
        /// </summary>
        /// <param name="request">Request. <see cref="PostBarcodeRecognizeFromUrlOrContentRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        BarcodeResponseList PostBarcodeRecognizeFromUrlOrContent(PostBarcodeRecognizeFromUrlOrContentRequest request);

        /// <summary>
        ///     Generate multiple barcodes and return in response stream
        /// </summary>
        /// <param name="request">Request. <see cref="PostGenerateMultipleRequest" /></param>
        /// <returns>
        ///     <see cref="System.IO.Stream" />
        /// </returns>
        Stream PostGenerateMultiple(PostGenerateMultipleRequest request);

        /// <summary>
        ///     Generate barcode and save on server (from query params or from file with json or xml content)
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeGenerateFileRequest" /></param>
        /// <returns>
        ///     <see cref="ResultImageInfo" />
        /// </returns>
        ResultImageInfo PutBarcodeGenerateFile(PutBarcodeGenerateFileRequest request);

        /// <summary>
        ///     Recognition of a barcode from file on server with parameters in body.
        /// </summary>
        /// <param name="request">Request. <see cref="PutBarcodeRecognizeFromBodyRequest" /></param>
        /// <returns>
        ///     <see cref="BarcodeResponseList" />
        /// </returns>
        BarcodeResponseList PutBarcodeRecognizeFromBody(PutBarcodeRecognizeFromBodyRequest request);

        /// <summary>
        ///     Generate image with multiple barcodes and put new file on server
        /// </summary>
        /// <param name="request">Request. <see cref="PutGenerateMultipleRequest" /></param>
        /// <returns>
        ///     <see cref="ResultImageInfo" />
        /// </returns>
        ResultImageInfo PutGenerateMultiple(PutGenerateMultipleRequest request);
    }
}
