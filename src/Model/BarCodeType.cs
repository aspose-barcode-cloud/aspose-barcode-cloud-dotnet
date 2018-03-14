// --------------------------------------------------------------------------------------------------------------------
// <copyright company="Aspose" file="BarCodeType.cs">
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
  using Newtonsoft.Json;
  using Newtonsoft.Json.Converters;
  
  /// <summary>
  /// Supported types of barcode for generation.
  /// </summary>  
  [JsonConverter(typeof(StringEnumConverter))]
  public  enum BarCodeType 
  {  	
		/// <summary>
        /// Enum value AustraliaPost
        /// </summary>            
        AustraliaPost,
		
		/// <summary>
        /// Enum value AustralianPosteParcel
        /// </summary>            
        AustralianPosteParcel,
		
		/// <summary>
        /// Enum value Aztec
        /// </summary>            
        Aztec,
		
		/// <summary>
        /// Enum value BooklandEAN
        /// </summary>            
        BooklandEAN,
		
		/// <summary>
        /// Enum value Codabar
        /// </summary>            
        Codabar,
		
		/// <summary>
        /// Enum value Code11
        /// </summary>            
        Code11,
		
		/// <summary>
        /// Enum value Code16K
        /// </summary>            
        Code16K,
		
		/// <summary>
        /// Enum value Code128
        /// </summary>            
        Code128,
		
		/// <summary>
        /// Enum value CodablockF
        /// </summary>            
        CodablockF,
		
		/// <summary>
        /// Enum value Code39Extended
        /// </summary>            
        Code39Extended,
		
		/// <summary>
        /// Enum value Code39Standard
        /// </summary>            
        Code39Standard,
		
		/// <summary>
        /// Enum value Code93Extended
        /// </summary>            
        Code93Extended,
		
		/// <summary>
        /// Enum value Code93Standard
        /// </summary>            
        Code93Standard,
		
		/// <summary>
        /// Enum value CompactPdf417
        /// </summary>            
        CompactPdf417,
		
		/// <summary>
        /// Enum value DatabarOmniDirectional
        /// </summary>            
        DatabarOmniDirectional,
		
		/// <summary>
        /// Enum value DatabarTruncated
        /// </summary>            
        DatabarTruncated,
		
		/// <summary>
        /// Enum value DatabarLimited
        /// </summary>            
        DatabarLimited,
		
		/// <summary>
        /// Enum value DatabarExpanded
        /// </summary>            
        DatabarExpanded,
		
		/// <summary>
        /// Enum value DatabarExpandedStacked
        /// </summary>            
        DatabarExpandedStacked,
		
		/// <summary>
        /// Enum value DatabarStacked
        /// </summary>            
        DatabarStacked,
		
		/// <summary>
        /// Enum value DatabarStackedOmniDirectional
        /// </summary>            
        DatabarStackedOmniDirectional,
		
		/// <summary>
        /// Enum value DataMatrix
        /// </summary>            
        DataMatrix,
		
		/// <summary>
        /// Enum value DeutschePostIdentcode
        /// </summary>            
        DeutschePostIdentcode,
		
		/// <summary>
        /// Enum value DeutschePostLeitcode
        /// </summary>            
        DeutschePostLeitcode,
		
		/// <summary>
        /// Enum value EAN128
        /// </summary>            
        EAN128,
		
		/// <summary>
        /// Enum value EAN13
        /// </summary>            
        EAN13,
		
		/// <summary>
        /// Enum value EAN14
        /// </summary>            
        EAN14,
		
		/// <summary>
        /// Enum value EAN8
        /// </summary>            
        EAN8,
		
		/// <summary>
        /// Enum value GS1Code128
        /// </summary>            
        GS1Code128,
		
		/// <summary>
        /// Enum value GS1CodablockF
        /// </summary>            
        GS1CodablockF,
		
		/// <summary>
        /// Enum value GS1DataMatrix
        /// </summary>            
        GS1DataMatrix,
		
		/// <summary>
        /// Enum value GS1QR
        /// </summary>            
        GS1QR,
		
		/// <summary>
        /// Enum value IATA2of5
        /// </summary>            
        IATA2of5,
		
		/// <summary>
        /// Enum value ISBN
        /// </summary>            
        ISBN,
		
		/// <summary>
        /// Enum value ISMN
        /// </summary>            
        ISMN,
		
		/// <summary>
        /// Enum value ISSN
        /// </summary>            
        ISSN,
		
		/// <summary>
        /// Enum value ITF14
        /// </summary>            
        ITF14,
		
		/// <summary>
        /// Enum value ITF6
        /// </summary>            
        ITF6,
		
		/// <summary>
        /// Enum value Interleaved2of5
        /// </summary>            
        Interleaved2of5,
		
		/// <summary>
        /// Enum value ItalianPost25
        /// </summary>            
        ItalianPost25,
		
		/// <summary>
        /// Enum value MaxiCode
        /// </summary>            
        MaxiCode,
		
		/// <summary>
        /// Enum value MSI
        /// </summary>            
        MSI,
		
		/// <summary>
        /// Enum value MicroPdf417
        /// </summary>            
        MicroPdf417,
		
		/// <summary>
        /// Enum value MacroPdf417
        /// </summary>            
        MacroPdf417,
		
		/// <summary>
        /// Enum value Matrix2of5
        /// </summary>            
        Matrix2of5,
		
		/// <summary>
        /// Enum value MicroQR
        /// </summary>            
        MicroQR,
		
		/// <summary>
        /// Enum value OPC
        /// </summary>            
        OPC,
		
		/// <summary>
        /// Enum value OneCode
        /// </summary>            
        OneCode,
		
		/// <summary>
        /// Enum value PZN
        /// </summary>            
        PZN,
		
		/// <summary>
        /// Enum value PatchCode
        /// </summary>            
        PatchCode,
		
		/// <summary>
        /// Enum value Pharmacode
        /// </summary>            
        Pharmacode,
		
		/// <summary>
        /// Enum value Pdf417
        /// </summary>            
        Pdf417,
		
		/// <summary>
        /// Enum value Planet
        /// </summary>            
        Planet,
		
		/// <summary>
        /// Enum value Postnet
        /// </summary>            
        Postnet,
		
		/// <summary>
        /// Enum value QR
        /// </summary>            
        QR,
		
		/// <summary>
        /// Enum value RM4SCC
        /// </summary>            
        RM4SCC,
		
		/// <summary>
        /// Enum value SingaporePost
        /// </summary>            
        SingaporePost,
		
		/// <summary>
        /// Enum value SCC14
        /// </summary>            
        SCC14,
		
		/// <summary>
        /// Enum value SSCC18
        /// </summary>            
        SSCC18,
		
		/// <summary>
        /// Enum value Standard2of5
        /// </summary>            
        Standard2of5,
		
		/// <summary>
        /// Enum value SwissPostParcel
        /// </summary>            
        SwissPostParcel,
		
		/// <summary>
        /// Enum value UPCA
        /// </summary>            
        UPCA,
		
		/// <summary>
        /// Enum value UPCE
        /// </summary>            
        UPCE,
		
		/// <summary>
        /// Enum value VIN
        /// </summary>            
        VIN,
		
		/// <summary>
        /// Enum value Code32
        /// </summary>            
        Code32,
		
		/// <summary>
        /// Enum value Datalogic2of5
        /// </summary>            
        Datalogic2of5,
		
		/// <summary>
        /// Enum value DotCode
        /// </summary>            
        DotCode,
		
		/// <summary>
        /// Enum value DutchKIX
        /// </summary>            
        DutchKIX
		
  }
}
