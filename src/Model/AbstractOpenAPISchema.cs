// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="Configuration.cs">
//   Copyright (c) 2026 Aspose.BarCode for Cloud
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
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aspose.BarCode.Cloud.Sdk.Model
{
    /// <summary>
    ///  Abstract base class for oneOf, anyOf schemas in the OpenAPI specification
    /// </summary>
    public abstract partial class AbstractOpenAPISchema
    {
        /// <summary>
        ///  Custom JSON serializer
        /// </summary>
        public static readonly JsonSerializerOptions SerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = false,
            // To ignore comments or trailing commas, set these:
            ReadCommentHandling = JsonCommentHandling.Disallow,
            UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
            AllowTrailingCommas = false,
        };


        /// <summary>
        /// Custom JSON serializer options for objects with additional properties.
        /// </summary>
        public static readonly JsonSerializerOptions AdditionalPropertiesSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            PropertyNameCaseInsensitive = false,

            ReadCommentHandling = JsonCommentHandling.Disallow,
            AllowTrailingCommas = false,

        };

        /// <summary>
        /// Gets or Sets the actual instance
        /// </summary>
        public abstract Object ActualInstance { get; set; }

        /// <summary>
        /// Gets or Sets IsNullable to indicate whether the instance is nullable
        /// </summary>
        public bool IsNullable { get; protected set; }

        /// <summary>
        /// Gets or Sets the schema type, which can be either `oneOf` or `anyOf`
        /// </summary>
        public string SchemaType { get; protected set; }

        /// <summary>
        /// Converts the instance into JSON string.
        /// </summary>
        public abstract string ToJson();
    }
}
