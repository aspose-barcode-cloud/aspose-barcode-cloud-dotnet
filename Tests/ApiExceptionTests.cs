// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="ApiExceptionTests.cs">
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

using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ApiExceptionTests : TestsBase
    {
        [Test]
        public void GetBarcodeGenerateTestThrows()
        {
            // Arrange
            var config = new Configuration();
            var api = new BarcodeApi(config);
            var request = new GetBarcodeGenerateRequest(
                text: "Very sample text",
                type: EncodeBarcodeType.Code128.ToString(),
                format: "png"
            );

            // Act
            var ex = Assert.Throws<ApiException>(
                () => { api.GetBarcodeGenerate(request); });

            Assert.AreEqual(400, ex.ErrorCode);
            Assert.AreEqual("Bad Request", ex.Message);
        }
    }
}
