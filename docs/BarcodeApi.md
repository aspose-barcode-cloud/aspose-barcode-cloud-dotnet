# Aspose.BarCode.Cloud.Sdk.Api.BarcodeApi

All URIs are relative to *https://api.aspose.cloud/v3.0*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetBarcodeGenerate**](BarcodeApi.md#getbarcodegenerate) | **GET** /barcode/generate | Generate barcode.
[**GetBarcodeRecognize**](BarcodeApi.md#getbarcoderecognize) | **GET** /barcode/{name}/recognize | Recognize barcode from a file on server.
[**PostBarcodeRecognizeFromUrlOrContent**](BarcodeApi.md#postbarcoderecognizefromurlorcontent) | **POST** /barcode/recognize | Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image or encoded with base64.
[**PostGenerateMultiple**](BarcodeApi.md#postgeneratemultiple) | **POST** /barcode/generateMultiple | Generate multiple barcodes and return in response stream
[**PutBarcodeGenerateFile**](BarcodeApi.md#putbarcodegeneratefile) | **PUT** /barcode/{name}/generate | Generate barcode and save on server (from query params or from file with json or xml content)
[**PutBarcodeRecognizeFromBody**](BarcodeApi.md#putbarcoderecognizefrombody) | **PUT** /barcode/{name}/recognize | Recognition of a barcode from file on server with parameters in body.
[**PutGenerateMultiple**](BarcodeApi.md#putgeneratemultiple) | **PUT** /barcode/{name}/generateMultiple | Generate image with multiple barcodes and put new file on server


<a name="getbarcodegenerate"></a>
# **GetBarcodeGenerate**
> System.IO.Stream GetBarcodeGenerate (string type, string text, string twoDDisplayText = null, string textLocation = null, string textAlignment = null, string textColor = null, string fontSizeMode = null, bool? noWrap = null, double? resolution = null, double? resolutionX = null, double? resolutionY = null, double? dimensionX = null, double? textSpace = null, string units = null, string sizeMode = null, double? barHeight = null, double? imageHeight = null, double? imageWidth = null, double? rotationAngle = null, string backColor = null, string barColor = null, string borderColor = null, double? borderWidth = null, string borderDashStyle = null, bool? borderVisible = null, string enableChecksum = null, bool? enableEscape = null, bool? filledBars = null, bool? alwaysShowChecksum = null, double? wideNarrowRatio = null, bool? validateText = null, string supplementData = null, double? supplementSpace = null, double? barWidthReduction = null, string format = null)

Generate barcode.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class GetBarcodeGenerateExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarcodeApi();
            var type = type_example;  // string | Type of barcode to generate.
            var text = text_example;  // string | Text to encode.
            var twoDDisplayText = twoDDisplayText_example;  // string | Text that will be displayed instead of codetext in 2D barcodes. Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode (optional) 
            var textLocation = textLocation_example;  // string | Specify the displaying Text Location, set to CodeLocation.None to hide CodeText. Default value: CodeLocation.Below. (optional) 
            var textAlignment = textAlignment_example;  // string | Text alignment. (optional) 
            var textColor = textColor_example;  // string | Specify the displaying CodeText's Color. Default value: Color.Black. (optional) 
            var fontSizeMode = fontSizeMode_example;  // string | Specify FontSizeMode. If FontSizeMode is set to Auto, font size will be calculated automatically based on xDimension value. It is recommended to use FontSizeMode.Auto especially in AutoSizeMode.Nearest or AutoSizeMode.Interpolation. Default value: FontSizeMode.Auto. (optional) 
            var noWrap = true;  // bool? | Specify word wraps (line breaks) within text. Default value: false. (optional) 
            var resolution = 1.2;  // double? | Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. (optional) 
            var resolutionX = 1.2;  // double? | DEPRECATED: Use 'Resolution' instead. (optional) 
            var resolutionY = 1.2;  // double? | DEPRECATED: Use 'Resolution' instead. (optional) 
            var dimensionX = 1.2;  // double? | The smallest width of the unit of BarCode bars or spaces. Increase this will increase the whole barcode image width. Ignored if AutoSizeMode property is set to AutoSizeMode.Nearest or AutoSizeMode.Interpolation. (optional) 
            var textSpace = 1.2;  // double? | Space between the CodeText and the BarCode in Unit value. Default value: 2pt. Ignored for EAN8, EAN13, UPCE, UPCA, ISBN, ISMN, ISSN, UpcaGs1DatabarCoupon. (optional) 
            var units = units_example;  // string | Common Units for all measuring in query. Default units: pixel. (optional) 
            var sizeMode = sizeMode_example;  // string | Specifies the different types of automatic sizing modes. Default value: AutoSizeMode.None. (optional) 
            var barHeight = 1.2;  // double? | Height of the barcode in given units. Default units: pixel. (optional) 
            var imageHeight = 1.2;  // double? | Height of the barcode image in given units. Default units: pixel. (optional) 
            var imageWidth = 1.2;  // double? | Width of the barcode image in given units. Default units: pixel. (optional) 
            var rotationAngle = 1.2;  // double? | BarCode image rotation angle, measured in degree, e.g. RotationAngle = 0 or RotationAngle = 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. (optional) 
            var backColor = backColor_example;  // string | Background color of the barcode image. Default value: Color.White. (optional) 
            var barColor = barColor_example;  // string | Bars color. Default value: Color.Black. (optional) 
            var borderColor = borderColor_example;  // string | Border color. Default value: Color.Black. (optional) 
            var borderWidth = 1.2;  // double? | Border width. Default value: 0. Ignored if Visible is set to false. (optional) 
            var borderDashStyle = borderDashStyle_example;  // string | Border dash style. Default value: BorderDashStyle.Solid. (optional) 
            var borderVisible = true;  // bool? | Border visibility. If false than parameter Width is always ignored (0). Default value: false. (optional) 
            var enableChecksum = enableChecksum_example;  // string | Enable checksum during generation 1D barcodes. Default is treated as Yes for symbology which must contain checksum, as No where checksum only possible. Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN, Codabar Checksum always used: Rest symbology (optional) 
            var enableEscape = true;  // bool? | Indicates whether explains the character \"\\\" as an escape character in CodeText property. Used for Pdf417, DataMatrix, Code128 only If the EnableEscape is true, \"\\\" will be explained as a special escape character. Otherwise, \"\\\" acts as normal characters. Aspose.BarCode supports input decimal ascii code and mnemonic for ASCII control-code characters. For example, \\013 and \\\\CR stands for CR. (optional) 
            var filledBars = true;  // bool? | Value indicating whether bars are filled. Only for 1D barcodes. Default value: true. (optional) 
            var alwaysShowChecksum = true;  // bool? | Always display checksum digit in the human readable text for Code128 and GS1Code128 barcodes. (optional) 
            var wideNarrowRatio = 1.2;  // double? | Wide bars to Narrow bars ratio. Default value: 3, that is, wide bars are 3 times as wide as narrow bars. Used for ITF, PZN, PharmaCode, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, IATA2of5, VIN, DeutschePost, OPC, Code32, DataLogic2of5, PatchCode, Code39Extended, Code39Standard (optional) 
            var validateText = true;  // bool? | Only for 1D barcodes. If codetext is incorrect and value set to true - exception will be thrown. Otherwise codetext will be corrected to match barcode's specification. Exception always will be thrown for: Databar symbology if codetext is incorrect. Exception always will not be thrown for: AustraliaPost, SingaporePost, Code39Extended, Code93Extended, Code16K, Code128 symbology if codetext is incorrect. (optional) 
            var supplementData = supplementData_example;  // string | Supplement parameters. Used for Interleaved2of5, Standard2of5, EAN13, EAN8, UPCA, UPCE, ISBN, ISSN, ISMN. (optional) 
            var supplementSpace = 1.2;  // double? | Space between main the BarCode and supplement BarCode. (optional) 
            var barWidthReduction = 1.2;  // double? | Bars reduction value that is used to compensate ink spread while printing. (optional) 
            var format = format_example;  // string | Result image format. (optional) 

            try
            {
                // Generate barcode.
                System.IO.Stream result = apiInstance.GetBarcodeGenerate(type, text, twoDDisplayText, textLocation, textAlignment, textColor, fontSizeMode, noWrap, resolution, resolutionX, resolutionY, dimensionX, textSpace, units, sizeMode, barHeight, imageHeight, imageWidth, rotationAngle, backColor, barColor, borderColor, borderWidth, borderDashStyle, borderVisible, enableChecksum, enableEscape, filledBars, alwaysShowChecksum, wideNarrowRatio, validateText, supplementData, supplementSpace, barWidthReduction, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.GetBarcodeGenerate: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| Type of barcode to generate. | 
 **text** | **string**| Text to encode. | 
 **twoDDisplayText** | **string**| Text that will be displayed instead of codetext in 2D barcodes. Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode | [optional] 
 **textLocation** | **string**| Specify the displaying Text Location, set to CodeLocation.None to hide CodeText. Default value: CodeLocation.Below. | [optional] 
 **textAlignment** | **string**| Text alignment. | [optional] 
 **textColor** | **string**| Specify the displaying CodeText&#39;s Color. Default value: Color.Black. | [optional] 
 **fontSizeMode** | **string**| Specify FontSizeMode. If FontSizeMode is set to Auto, font size will be calculated automatically based on xDimension value. It is recommended to use FontSizeMode.Auto especially in AutoSizeMode.Nearest or AutoSizeMode.Interpolation. Default value: FontSizeMode.Auto. | [optional] 
 **noWrap** | **bool?**| Specify word wraps (line breaks) within text. Default value: false. | [optional] 
 **resolution** | **double?**| Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. | [optional] 
 **resolutionX** | **double?**| DEPRECATED: Use &#39;Resolution&#39; instead. | [optional] 
 **resolutionY** | **double?**| DEPRECATED: Use &#39;Resolution&#39; instead. | [optional] 
 **dimensionX** | **double?**| The smallest width of the unit of BarCode bars or spaces. Increase this will increase the whole barcode image width. Ignored if AutoSizeMode property is set to AutoSizeMode.Nearest or AutoSizeMode.Interpolation. | [optional] 
 **textSpace** | **double?**| Space between the CodeText and the BarCode in Unit value. Default value: 2pt. Ignored for EAN8, EAN13, UPCE, UPCA, ISBN, ISMN, ISSN, UpcaGs1DatabarCoupon. | [optional] 
 **units** | **string**| Common Units for all measuring in query. Default units: pixel. | [optional] 
 **sizeMode** | **string**| Specifies the different types of automatic sizing modes. Default value: AutoSizeMode.None. | [optional] 
 **barHeight** | **double?**| Height of the barcode in given units. Default units: pixel. | [optional] 
 **imageHeight** | **double?**| Height of the barcode image in given units. Default units: pixel. | [optional] 
 **imageWidth** | **double?**| Width of the barcode image in given units. Default units: pixel. | [optional] 
 **rotationAngle** | **double?**| BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. | [optional] 
 **backColor** | **string**| Background color of the barcode image. Default value: Color.White. | [optional] 
 **barColor** | **string**| Bars color. Default value: Color.Black. | [optional] 
 **borderColor** | **string**| Border color. Default value: Color.Black. | [optional] 
 **borderWidth** | **double?**| Border width. Default value: 0. Ignored if Visible is set to false. | [optional] 
 **borderDashStyle** | **string**| Border dash style. Default value: BorderDashStyle.Solid. | [optional] 
 **borderVisible** | **bool?**| Border visibility. If false than parameter Width is always ignored (0). Default value: false. | [optional] 
 **enableChecksum** | **string**| Enable checksum during generation 1D barcodes. Default is treated as Yes for symbology which must contain checksum, as No where checksum only possible. Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN, Codabar Checksum always used: Rest symbology | [optional] 
 **enableEscape** | **bool?**| Indicates whether explains the character \&quot;\\\&quot; as an escape character in CodeText property. Used for Pdf417, DataMatrix, Code128 only If the EnableEscape is true, \&quot;\\\&quot; will be explained as a special escape character. Otherwise, \&quot;\\\&quot; acts as normal characters. Aspose.BarCode supports input decimal ascii code and mnemonic for ASCII control-code characters. For example, \\013 and \\\\CR stands for CR. | [optional] 
 **filledBars** | **bool?**| Value indicating whether bars are filled. Only for 1D barcodes. Default value: true. | [optional] 
 **alwaysShowChecksum** | **bool?**| Always display checksum digit in the human readable text for Code128 and GS1Code128 barcodes. | [optional] 
 **wideNarrowRatio** | **double?**| Wide bars to Narrow bars ratio. Default value: 3, that is, wide bars are 3 times as wide as narrow bars. Used for ITF, PZN, PharmaCode, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, IATA2of5, VIN, DeutschePost, OPC, Code32, DataLogic2of5, PatchCode, Code39Extended, Code39Standard | [optional] 
 **validateText** | **bool?**| Only for 1D barcodes. If codetext is incorrect and value set to true - exception will be thrown. Otherwise codetext will be corrected to match barcode&#39;s specification. Exception always will be thrown for: Databar symbology if codetext is incorrect. Exception always will not be thrown for: AustraliaPost, SingaporePost, Code39Extended, Code93Extended, Code16K, Code128 symbology if codetext is incorrect. | [optional] 
 **supplementData** | **string**| Supplement parameters. Used for Interleaved2of5, Standard2of5, EAN13, EAN8, UPCA, UPCE, ISBN, ISSN, ISMN. | [optional] 
 **supplementSpace** | **double?**| Space between main the BarCode and supplement BarCode. | [optional] 
 **barWidthReduction** | **double?**| Bars reduction value that is used to compensate ink spread while printing. | [optional] 
 **format** | **string**| Result image format. | [optional] 

### Return type

**System.IO.Stream**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getbarcoderecognize"></a>
# **GetBarcodeRecognize**
> BarcodeResponseList GetBarcodeRecognize (string name, string type = null, string checksumValidation = null, bool? detectEncoding = null, string preset = null, int? rectX = null, int? rectY = null, int? rectWidth = null, int? rectHeight = null, bool? stripFNC = null, int? timeout = null, int? medianSmoothingWindowSize = null, bool? allowMedianSmoothing = null, bool? allowComplexBackground = null, bool? allowDatamatrixIndustrialBarcodes = null, bool? allowDecreasedImage = null, bool? allowDetectScanGap = null, bool? allowIncorrectBarcodes = null, bool? allowInvertImage = null, bool? allowMicroWhiteSpotsRemoving = null, bool? allowOneDFastBarcodesDetector = null, bool? allowOneDWipedBarsRestoration = null, bool? allowQRMicroQrRestoration = null, bool? allowRegularImage = null, bool? allowSaltAndPepperFiltering = null, bool? allowWhiteSpotsRemoving = null, bool? checkMore1DVariants = null, bool? fastScanOnly = null, double? regionLikelihoodThresholdPercent = null, List<int?> scanWindowSizes = null, double? similarity = null, bool? skipDiagonalSearch = null, bool? readTinyBarcodes = null, string australianPostEncodingTable = null, bool? ignoreEndingFillingPatternsForCTable = null, string rectangleRegion = null, string storage = null, string folder = null)

Recognize barcode from a file on server.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class GetBarcodeRecognizeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarcodeApi();
            var name = name_example;  // string | The image file name.
            var type = type_example;  // string | The type of barcode to read. (optional) 
            var checksumValidation = checksumValidation_example;  // string | Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies (optional) 
            var detectEncoding = true;  // bool? | A flag which force engine to detect codetext encoding for Unicode. (optional) 
            var preset = preset_example;  // string | Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality. (optional) 
            var rectX = 56;  // int? | Set X for area for recognition. (optional) 
            var rectY = 56;  // int? | Set Y for area for recognition. (optional) 
            var rectWidth = 56;  // int? | Set Width of area for recognition. (optional) 
            var rectHeight = 56;  // int? | Set Height of area for recognition. (optional) 
            var stripFNC = true;  // bool? | Value indicating whether FNC symbol strip must be done. (optional) 
            var timeout = 56;  // int? | Timeout of recognition process. (optional) 
            var medianSmoothingWindowSize = 56;  // int? | Window size for median smoothing. Typical values are 3 or 4. Default value is 3. AllowMedianSmoothing must be set. (optional) 
            var allowMedianSmoothing = true;  // bool? | Allows engine to enable median smoothing as additional scan. Mode helps to recognize noised barcodes. (optional) 
            var allowComplexBackground = true;  // bool? | Allows engine to recognize color barcodes on color background as additional scan. Extremely slow mode. (optional) 
            var allowDatamatrixIndustrialBarcodes = true;  // bool? | Allows engine for Datamatrix to recognize dashed industrial Datamatrix barcodes. Slow mode which helps only for dashed barcodes which consist from spots. (optional) 
            var allowDecreasedImage = true;  // bool? | Allows engine to recognize decreased image as additional scan. Size for decreasing is selected by internal engine algorithms. Mode helps to recognize barcodes which are noised and blurred but captured with high resolution. (optional) 
            var allowDetectScanGap = true;  // bool? | Allows engine to use gap between scans to increase recognition speed. Mode can make recognition problems with low height barcodes. (optional) 
            var allowIncorrectBarcodes = true;  // bool? | Allows engine to recognize barcodes which has incorrect checksum or incorrect values. Mode can be used to recognize damaged barcodes with incorrect text. (optional) 
            var allowInvertImage = true;  // bool? | Allows engine to recognize inverse color image as additional scan. Mode can be used when barcode is white on black background. (optional) 
            var allowMicroWhiteSpotsRemoving = true;  // bool? | Allows engine for Postal barcodes to recognize slightly noised images. Mode helps to recognize slightly damaged Postal barcodes. (optional) 
            var allowOneDFastBarcodesDetector = true;  // bool? | Allows engine for 1D barcodes to quickly recognize high quality barcodes which fill almost whole image. Mode helps to quickly recognize generated barcodes from Internet. (optional) 
            var allowOneDWipedBarsRestoration = true;  // bool? | Allows engine for 1D barcodes to recognize barcodes with single wiped/glued bars in pattern. (optional) 
            var allowQRMicroQrRestoration = true;  // bool? | Allows engine for QR/MicroQR to recognize damaged MicroQR barcodes. (optional) 
            var allowRegularImage = true;  // bool? | Allows engine to recognize regular image without any restorations as main scan. Mode to recognize image as is. (optional) 
            var allowSaltAndPepperFiltering = true;  // bool? | Allows engine to recognize barcodes with salt and pepper noise type. Mode can remove small noise with white and black dots. (optional) 
            var allowWhiteSpotsRemoving = true;  // bool? | Allows engine to recognize image without small white spots as additional scan. Mode helps to recognize noised image as well as median smoothing filtering. (optional) 
            var checkMore1DVariants = true;  // bool? | Allows engine to recognize 1D barcodes with checksum by checking more recognition variants. Default value: False. (optional) 
            var fastScanOnly = true;  // bool? | Allows engine for 1D barcodes to quickly recognize middle slice of an image and return result without using any time-consuming algorithms. Default value: False. (optional) 
            var regionLikelihoodThresholdPercent = 1.2;  // double? | Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time. (optional) 
            var scanWindowSizes = new List<int?>(); // List<int?> | Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality. (optional) 
            var similarity = 1.2;  // double? | Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9] (optional) 
            var skipDiagonalSearch = true;  // bool? | Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time. (optional) 
            var readTinyBarcodes = true;  // bool? | Allows engine to recognize tiny barcodes on large images. Ignored if AllowIncorrectBarcodes is set to True. Default value: False. (optional) 
            var australianPostEncodingTable = australianPostEncodingTable_example;  // string | Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other. (optional) 
            var ignoreEndingFillingPatternsForCTable = true;  // bool? | The flag which force AustraliaPost decoder to ignore last filling patterns in Customer Information Field during decoding as CTable method.  CTable encoding method does not have any gaps in encoding table and sequnce \"333\" of filling paterns is decoded as letter \"z\". (optional) 
            var rectangleRegion = rectangleRegion_example;  // string |  (optional) 
            var storage = storage_example;  // string | The image storage. (optional) 
            var folder = folder_example;  // string | The image folder. (optional) 

            try
            {
                // Recognize barcode from a file on server.
                BarcodeResponseList result = apiInstance.GetBarcodeRecognize(name, type, checksumValidation, detectEncoding, preset, rectX, rectY, rectWidth, rectHeight, stripFNC, timeout, medianSmoothingWindowSize, allowMedianSmoothing, allowComplexBackground, allowDatamatrixIndustrialBarcodes, allowDecreasedImage, allowDetectScanGap, allowIncorrectBarcodes, allowInvertImage, allowMicroWhiteSpotsRemoving, allowOneDFastBarcodesDetector, allowOneDWipedBarsRestoration, allowQRMicroQrRestoration, allowRegularImage, allowSaltAndPepperFiltering, allowWhiteSpotsRemoving, checkMore1DVariants, fastScanOnly, regionLikelihoodThresholdPercent, scanWindowSizes, similarity, skipDiagonalSearch, readTinyBarcodes, australianPostEncodingTable, ignoreEndingFillingPatternsForCTable, rectangleRegion, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.GetBarcodeRecognize: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The image file name. | 
 **type** | **string**| The type of barcode to read. | [optional] 
 **checksumValidation** | **string**| Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies | [optional] 
 **detectEncoding** | **bool?**| A flag which force engine to detect codetext encoding for Unicode. | [optional] 
 **preset** | **string**| Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality. | [optional] 
 **rectX** | **int?**| Set X for area for recognition. | [optional] 
 **rectY** | **int?**| Set Y for area for recognition. | [optional] 
 **rectWidth** | **int?**| Set Width of area for recognition. | [optional] 
 **rectHeight** | **int?**| Set Height of area for recognition. | [optional] 
 **stripFNC** | **bool?**| Value indicating whether FNC symbol strip must be done. | [optional] 
 **timeout** | **int?**| Timeout of recognition process. | [optional] 
 **medianSmoothingWindowSize** | **int?**| Window size for median smoothing. Typical values are 3 or 4. Default value is 3. AllowMedianSmoothing must be set. | [optional] 
 **allowMedianSmoothing** | **bool?**| Allows engine to enable median smoothing as additional scan. Mode helps to recognize noised barcodes. | [optional] 
 **allowComplexBackground** | **bool?**| Allows engine to recognize color barcodes on color background as additional scan. Extremely slow mode. | [optional] 
 **allowDatamatrixIndustrialBarcodes** | **bool?**| Allows engine for Datamatrix to recognize dashed industrial Datamatrix barcodes. Slow mode which helps only for dashed barcodes which consist from spots. | [optional] 
 **allowDecreasedImage** | **bool?**| Allows engine to recognize decreased image as additional scan. Size for decreasing is selected by internal engine algorithms. Mode helps to recognize barcodes which are noised and blurred but captured with high resolution. | [optional] 
 **allowDetectScanGap** | **bool?**| Allows engine to use gap between scans to increase recognition speed. Mode can make recognition problems with low height barcodes. | [optional] 
 **allowIncorrectBarcodes** | **bool?**| Allows engine to recognize barcodes which has incorrect checksum or incorrect values. Mode can be used to recognize damaged barcodes with incorrect text. | [optional] 
 **allowInvertImage** | **bool?**| Allows engine to recognize inverse color image as additional scan. Mode can be used when barcode is white on black background. | [optional] 
 **allowMicroWhiteSpotsRemoving** | **bool?**| Allows engine for Postal barcodes to recognize slightly noised images. Mode helps to recognize slightly damaged Postal barcodes. | [optional] 
 **allowOneDFastBarcodesDetector** | **bool?**| Allows engine for 1D barcodes to quickly recognize high quality barcodes which fill almost whole image. Mode helps to quickly recognize generated barcodes from Internet. | [optional] 
 **allowOneDWipedBarsRestoration** | **bool?**| Allows engine for 1D barcodes to recognize barcodes with single wiped/glued bars in pattern. | [optional] 
 **allowQRMicroQrRestoration** | **bool?**| Allows engine for QR/MicroQR to recognize damaged MicroQR barcodes. | [optional] 
 **allowRegularImage** | **bool?**| Allows engine to recognize regular image without any restorations as main scan. Mode to recognize image as is. | [optional] 
 **allowSaltAndPepperFiltering** | **bool?**| Allows engine to recognize barcodes with salt and pepper noise type. Mode can remove small noise with white and black dots. | [optional] 
 **allowWhiteSpotsRemoving** | **bool?**| Allows engine to recognize image without small white spots as additional scan. Mode helps to recognize noised image as well as median smoothing filtering. | [optional] 
 **checkMore1DVariants** | **bool?**| Allows engine to recognize 1D barcodes with checksum by checking more recognition variants. Default value: False. | [optional] 
 **fastScanOnly** | **bool?**| Allows engine for 1D barcodes to quickly recognize middle slice of an image and return result without using any time-consuming algorithms. Default value: False. | [optional] 
 **regionLikelihoodThresholdPercent** | **double?**| Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time. | [optional] 
 **scanWindowSizes** | [**List&lt;int?&gt;**](int?.md)| Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality. | [optional] 
 **similarity** | **double?**| Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9] | [optional] 
 **skipDiagonalSearch** | **bool?**| Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time. | [optional] 
 **readTinyBarcodes** | **bool?**| Allows engine to recognize tiny barcodes on large images. Ignored if AllowIncorrectBarcodes is set to True. Default value: False. | [optional] 
 **australianPostEncodingTable** | **string**| Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other. | [optional] 
 **ignoreEndingFillingPatternsForCTable** | **bool?**| The flag which force AustraliaPost decoder to ignore last filling patterns in Customer Information Field during decoding as CTable method.  CTable encoding method does not have any gaps in encoding table and sequnce \&quot;333\&quot; of filling paterns is decoded as letter \&quot;z\&quot;. | [optional] 
 **rectangleRegion** | **string**|  | [optional] 
 **storage** | **string**| The image storage. | [optional] 
 **folder** | **string**| The image folder. | [optional] 

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postbarcoderecognizefromurlorcontent"></a>
# **PostBarcodeRecognizeFromUrlOrContent**
> BarcodeResponseList PostBarcodeRecognizeFromUrlOrContent (string type = null, string checksumValidation = null, bool? detectEncoding = null, string preset = null, int? rectX = null, int? rectY = null, int? rectWidth = null, int? rectHeight = null, bool? stripFNC = null, int? timeout = null, int? medianSmoothingWindowSize = null, bool? allowMedianSmoothing = null, bool? allowComplexBackground = null, bool? allowDatamatrixIndustrialBarcodes = null, bool? allowDecreasedImage = null, bool? allowDetectScanGap = null, bool? allowIncorrectBarcodes = null, bool? allowInvertImage = null, bool? allowMicroWhiteSpotsRemoving = null, bool? allowOneDFastBarcodesDetector = null, bool? allowOneDWipedBarsRestoration = null, bool? allowQRMicroQrRestoration = null, bool? allowRegularImage = null, bool? allowSaltAndPepperFiltering = null, bool? allowWhiteSpotsRemoving = null, bool? checkMore1DVariants = null, bool? fastScanOnly = null, double? regionLikelihoodThresholdPercent = null, List<int?> scanWindowSizes = null, double? similarity = null, bool? skipDiagonalSearch = null, bool? readTinyBarcodes = null, string australianPostEncodingTable = null, bool? ignoreEndingFillingPatternsForCTable = null, string rectangleRegion = null, string url = null, System.IO.Stream image = null)

Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image or encoded with base64.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class PostBarcodeRecognizeFromUrlOrContentExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarcodeApi();
            var type = type_example;  // string | The type of barcode to read. (optional) 
            var checksumValidation = checksumValidation_example;  // string | Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies (optional) 
            var detectEncoding = true;  // bool? | A flag which force engine to detect codetext encoding for Unicode. (optional) 
            var preset = preset_example;  // string | Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality. (optional) 
            var rectX = 56;  // int? | Set X for area for recognition. (optional) 
            var rectY = 56;  // int? | Set Y for area for recognition. (optional) 
            var rectWidth = 56;  // int? | Set Width of area for recognition. (optional) 
            var rectHeight = 56;  // int? | Set Height of area for recognition. (optional) 
            var stripFNC = true;  // bool? | Value indicating whether FNC symbol strip must be done. (optional) 
            var timeout = 56;  // int? | Timeout of recognition process. (optional) 
            var medianSmoothingWindowSize = 56;  // int? | Window size for median smoothing. Typical values are 3 or 4. Default value is 3. AllowMedianSmoothing must be set. (optional) 
            var allowMedianSmoothing = true;  // bool? | Allows engine to enable median smoothing as additional scan. Mode helps to recognize noised barcodes. (optional) 
            var allowComplexBackground = true;  // bool? | Allows engine to recognize color barcodes on color background as additional scan. Extremely slow mode. (optional) 
            var allowDatamatrixIndustrialBarcodes = true;  // bool? | Allows engine for Datamatrix to recognize dashed industrial Datamatrix barcodes. Slow mode which helps only for dashed barcodes which consist from spots. (optional) 
            var allowDecreasedImage = true;  // bool? | Allows engine to recognize decreased image as additional scan. Size for decreasing is selected by internal engine algorithms. Mode helps to recognize barcodes which are noised and blurred but captured with high resolution. (optional) 
            var allowDetectScanGap = true;  // bool? | Allows engine to use gap between scans to increase recognition speed. Mode can make recognition problems with low height barcodes. (optional) 
            var allowIncorrectBarcodes = true;  // bool? | Allows engine to recognize barcodes which has incorrect checksum or incorrect values. Mode can be used to recognize damaged barcodes with incorrect text. (optional) 
            var allowInvertImage = true;  // bool? | Allows engine to recognize inverse color image as additional scan. Mode can be used when barcode is white on black background. (optional) 
            var allowMicroWhiteSpotsRemoving = true;  // bool? | Allows engine for Postal barcodes to recognize slightly noised images. Mode helps to recognize slightly damaged Postal barcodes. (optional) 
            var allowOneDFastBarcodesDetector = true;  // bool? | Allows engine for 1D barcodes to quickly recognize high quality barcodes which fill almost whole image. Mode helps to quickly recognize generated barcodes from Internet. (optional) 
            var allowOneDWipedBarsRestoration = true;  // bool? | Allows engine for 1D barcodes to recognize barcodes with single wiped/glued bars in pattern. (optional) 
            var allowQRMicroQrRestoration = true;  // bool? | Allows engine for QR/MicroQR to recognize damaged MicroQR barcodes. (optional) 
            var allowRegularImage = true;  // bool? | Allows engine to recognize regular image without any restorations as main scan. Mode to recognize image as is. (optional) 
            var allowSaltAndPepperFiltering = true;  // bool? | Allows engine to recognize barcodes with salt and pepper noise type. Mode can remove small noise with white and black dots. (optional) 
            var allowWhiteSpotsRemoving = true;  // bool? | Allows engine to recognize image without small white spots as additional scan. Mode helps to recognize noised image as well as median smoothing filtering. (optional) 
            var checkMore1DVariants = true;  // bool? | Allows engine to recognize 1D barcodes with checksum by checking more recognition variants. Default value: False. (optional) 
            var fastScanOnly = true;  // bool? | Allows engine for 1D barcodes to quickly recognize middle slice of an image and return result without using any time-consuming algorithms. Default value: False. (optional) 
            var regionLikelihoodThresholdPercent = 1.2;  // double? | Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time. (optional) 
            var scanWindowSizes = new List<int?>(); // List<int?> | Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality. (optional) 
            var similarity = 1.2;  // double? | Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9] (optional) 
            var skipDiagonalSearch = true;  // bool? | Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time. (optional) 
            var readTinyBarcodes = true;  // bool? | Allows engine to recognize tiny barcodes on large images. Ignored if AllowIncorrectBarcodes is set to True. Default value: False. (optional) 
            var australianPostEncodingTable = australianPostEncodingTable_example;  // string | Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other. (optional) 
            var ignoreEndingFillingPatternsForCTable = true;  // bool? | The flag which force AustraliaPost decoder to ignore last filling patterns in Customer Information Field during decoding as CTable method.  CTable encoding method does not have any gaps in encoding table and sequnce \"333\" of filling paterns is decoded as letter \"z\". (optional) 
            var rectangleRegion = rectangleRegion_example;  // string |  (optional) 
            var url = url_example;  // string | The image file url. (optional) 
            var image = new System.IO.Stream(); // System.IO.Stream | Image data (optional) 

            try
            {
                // Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image or encoded with base64.
                BarcodeResponseList result = apiInstance.PostBarcodeRecognizeFromUrlOrContent(type, checksumValidation, detectEncoding, preset, rectX, rectY, rectWidth, rectHeight, stripFNC, timeout, medianSmoothingWindowSize, allowMedianSmoothing, allowComplexBackground, allowDatamatrixIndustrialBarcodes, allowDecreasedImage, allowDetectScanGap, allowIncorrectBarcodes, allowInvertImage, allowMicroWhiteSpotsRemoving, allowOneDFastBarcodesDetector, allowOneDWipedBarsRestoration, allowQRMicroQrRestoration, allowRegularImage, allowSaltAndPepperFiltering, allowWhiteSpotsRemoving, checkMore1DVariants, fastScanOnly, regionLikelihoodThresholdPercent, scanWindowSizes, similarity, skipDiagonalSearch, readTinyBarcodes, australianPostEncodingTable, ignoreEndingFillingPatternsForCTable, rectangleRegion, url, image);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.PostBarcodeRecognizeFromUrlOrContent: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | **string**| The type of barcode to read. | [optional] 
 **checksumValidation** | **string**| Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies | [optional] 
 **detectEncoding** | **bool?**| A flag which force engine to detect codetext encoding for Unicode. | [optional] 
 **preset** | **string**| Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality. | [optional] 
 **rectX** | **int?**| Set X for area for recognition. | [optional] 
 **rectY** | **int?**| Set Y for area for recognition. | [optional] 
 **rectWidth** | **int?**| Set Width of area for recognition. | [optional] 
 **rectHeight** | **int?**| Set Height of area for recognition. | [optional] 
 **stripFNC** | **bool?**| Value indicating whether FNC symbol strip must be done. | [optional] 
 **timeout** | **int?**| Timeout of recognition process. | [optional] 
 **medianSmoothingWindowSize** | **int?**| Window size for median smoothing. Typical values are 3 or 4. Default value is 3. AllowMedianSmoothing must be set. | [optional] 
 **allowMedianSmoothing** | **bool?**| Allows engine to enable median smoothing as additional scan. Mode helps to recognize noised barcodes. | [optional] 
 **allowComplexBackground** | **bool?**| Allows engine to recognize color barcodes on color background as additional scan. Extremely slow mode. | [optional] 
 **allowDatamatrixIndustrialBarcodes** | **bool?**| Allows engine for Datamatrix to recognize dashed industrial Datamatrix barcodes. Slow mode which helps only for dashed barcodes which consist from spots. | [optional] 
 **allowDecreasedImage** | **bool?**| Allows engine to recognize decreased image as additional scan. Size for decreasing is selected by internal engine algorithms. Mode helps to recognize barcodes which are noised and blurred but captured with high resolution. | [optional] 
 **allowDetectScanGap** | **bool?**| Allows engine to use gap between scans to increase recognition speed. Mode can make recognition problems with low height barcodes. | [optional] 
 **allowIncorrectBarcodes** | **bool?**| Allows engine to recognize barcodes which has incorrect checksum or incorrect values. Mode can be used to recognize damaged barcodes with incorrect text. | [optional] 
 **allowInvertImage** | **bool?**| Allows engine to recognize inverse color image as additional scan. Mode can be used when barcode is white on black background. | [optional] 
 **allowMicroWhiteSpotsRemoving** | **bool?**| Allows engine for Postal barcodes to recognize slightly noised images. Mode helps to recognize slightly damaged Postal barcodes. | [optional] 
 **allowOneDFastBarcodesDetector** | **bool?**| Allows engine for 1D barcodes to quickly recognize high quality barcodes which fill almost whole image. Mode helps to quickly recognize generated barcodes from Internet. | [optional] 
 **allowOneDWipedBarsRestoration** | **bool?**| Allows engine for 1D barcodes to recognize barcodes with single wiped/glued bars in pattern. | [optional] 
 **allowQRMicroQrRestoration** | **bool?**| Allows engine for QR/MicroQR to recognize damaged MicroQR barcodes. | [optional] 
 **allowRegularImage** | **bool?**| Allows engine to recognize regular image without any restorations as main scan. Mode to recognize image as is. | [optional] 
 **allowSaltAndPepperFiltering** | **bool?**| Allows engine to recognize barcodes with salt and pepper noise type. Mode can remove small noise with white and black dots. | [optional] 
 **allowWhiteSpotsRemoving** | **bool?**| Allows engine to recognize image without small white spots as additional scan. Mode helps to recognize noised image as well as median smoothing filtering. | [optional] 
 **checkMore1DVariants** | **bool?**| Allows engine to recognize 1D barcodes with checksum by checking more recognition variants. Default value: False. | [optional] 
 **fastScanOnly** | **bool?**| Allows engine for 1D barcodes to quickly recognize middle slice of an image and return result without using any time-consuming algorithms. Default value: False. | [optional] 
 **regionLikelihoodThresholdPercent** | **double?**| Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time. | [optional] 
 **scanWindowSizes** | [**List&lt;int?&gt;**](int?.md)| Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality. | [optional] 
 **similarity** | **double?**| Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9] | [optional] 
 **skipDiagonalSearch** | **bool?**| Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time. | [optional] 
 **readTinyBarcodes** | **bool?**| Allows engine to recognize tiny barcodes on large images. Ignored if AllowIncorrectBarcodes is set to True. Default value: False. | [optional] 
 **australianPostEncodingTable** | **string**| Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other. | [optional] 
 **ignoreEndingFillingPatternsForCTable** | **bool?**| The flag which force AustraliaPost decoder to ignore last filling patterns in Customer Information Field during decoding as CTable method.  CTable encoding method does not have any gaps in encoding table and sequnce \&quot;333\&quot; of filling paterns is decoded as letter \&quot;z\&quot;. | [optional] 
 **rectangleRegion** | **string**|  | [optional] 
 **url** | **string**| The image file url. | [optional] 
 **image** | **System.IO.Stream**| Image data | [optional] 

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: multipart/form-data, application/octet-stream
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="postgeneratemultiple"></a>
# **PostGenerateMultiple**
> System.IO.Stream PostGenerateMultiple (GeneratorParamsList generatorParamsList, string format = null)

Generate multiple barcodes and return in response stream

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class PostGenerateMultipleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarcodeApi();
            var generatorParamsList = new GeneratorParamsList(); // GeneratorParamsList | List of barcodes
            var format = format_example;  // string | Format to return stream in (optional)  (default to png)

            try
            {
                // Generate multiple barcodes and return in response stream
                System.IO.Stream result = apiInstance.PostGenerateMultiple(generatorParamsList, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.PostGenerateMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **generatorParamsList** | [**GeneratorParamsList**](GeneratorParamsList.md)| List of barcodes | 
 **format** | **string**| Format to return stream in | [optional] [default to png]

### Return type

**System.IO.Stream**

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbarcodegeneratefile"></a>
# **PutBarcodeGenerateFile**
> ResultImageInfo PutBarcodeGenerateFile (string name, string type, string text, string twoDDisplayText = null, string textLocation = null, string textAlignment = null, string textColor = null, string fontSizeMode = null, bool? noWrap = null, double? resolution = null, double? resolutionX = null, double? resolutionY = null, double? dimensionX = null, double? textSpace = null, string units = null, string sizeMode = null, double? barHeight = null, double? imageHeight = null, double? imageWidth = null, double? rotationAngle = null, string backColor = null, string barColor = null, string borderColor = null, double? borderWidth = null, string borderDashStyle = null, bool? borderVisible = null, string enableChecksum = null, bool? enableEscape = null, bool? filledBars = null, bool? alwaysShowChecksum = null, double? wideNarrowRatio = null, bool? validateText = null, string supplementData = null, double? supplementSpace = null, double? barWidthReduction = null, string storage = null, string folder = null, string format = null)

Generate barcode and save on server (from query params or from file with json or xml content)

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class PutBarcodeGenerateFileExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarcodeApi();
            var name = name_example;  // string | The image file name.
            var type = type_example;  // string | Type of barcode to generate.
            var text = text_example;  // string | Text to encode.
            var twoDDisplayText = twoDDisplayText_example;  // string | Text that will be displayed instead of codetext in 2D barcodes. Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode (optional) 
            var textLocation = textLocation_example;  // string | Specify the displaying Text Location, set to CodeLocation.None to hide CodeText. Default value: CodeLocation.Below. (optional) 
            var textAlignment = textAlignment_example;  // string | Text alignment. (optional) 
            var textColor = textColor_example;  // string | Specify the displaying CodeText's Color. Default value: Color.Black. (optional) 
            var fontSizeMode = fontSizeMode_example;  // string | Specify FontSizeMode. If FontSizeMode is set to Auto, font size will be calculated automatically based on xDimension value. It is recommended to use FontSizeMode.Auto especially in AutoSizeMode.Nearest or AutoSizeMode.Interpolation. Default value: FontSizeMode.Auto. (optional) 
            var noWrap = true;  // bool? | Specify word wraps (line breaks) within text. Default value: false. (optional) 
            var resolution = 1.2;  // double? | Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. (optional) 
            var resolutionX = 1.2;  // double? | DEPRECATED: Use 'Resolution' instead. (optional) 
            var resolutionY = 1.2;  // double? | DEPRECATED: Use 'Resolution' instead. (optional) 
            var dimensionX = 1.2;  // double? | The smallest width of the unit of BarCode bars or spaces. Increase this will increase the whole barcode image width. Ignored if AutoSizeMode property is set to AutoSizeMode.Nearest or AutoSizeMode.Interpolation. (optional) 
            var textSpace = 1.2;  // double? | Space between the CodeText and the BarCode in Unit value. Default value: 2pt. Ignored for EAN8, EAN13, UPCE, UPCA, ISBN, ISMN, ISSN, UpcaGs1DatabarCoupon. (optional) 
            var units = units_example;  // string | Common Units for all measuring in query. Default units: pixel. (optional) 
            var sizeMode = sizeMode_example;  // string | Specifies the different types of automatic sizing modes. Default value: AutoSizeMode.None. (optional) 
            var barHeight = 1.2;  // double? | Height of the barcode in given units. Default units: pixel. (optional) 
            var imageHeight = 1.2;  // double? | Height of the barcode image in given units. Default units: pixel. (optional) 
            var imageWidth = 1.2;  // double? | Width of the barcode image in given units. Default units: pixel. (optional) 
            var rotationAngle = 1.2;  // double? | BarCode image rotation angle, measured in degree, e.g. RotationAngle = 0 or RotationAngle = 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. (optional) 
            var backColor = backColor_example;  // string | Background color of the barcode image. Default value: Color.White. (optional) 
            var barColor = barColor_example;  // string | Bars color. Default value: Color.Black. (optional) 
            var borderColor = borderColor_example;  // string | Border color. Default value: Color.Black. (optional) 
            var borderWidth = 1.2;  // double? | Border width. Default value: 0. Ignored if Visible is set to false. (optional) 
            var borderDashStyle = borderDashStyle_example;  // string | Border dash style. Default value: BorderDashStyle.Solid. (optional) 
            var borderVisible = true;  // bool? | Border visibility. If false than parameter Width is always ignored (0). Default value: false. (optional) 
            var enableChecksum = enableChecksum_example;  // string | Enable checksum during generation 1D barcodes. Default is treated as Yes for symbology which must contain checksum, as No where checksum only possible. Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN, Codabar Checksum always used: Rest symbology (optional) 
            var enableEscape = true;  // bool? | Indicates whether explains the character \"\\\" as an escape character in CodeText property. Used for Pdf417, DataMatrix, Code128 only If the EnableEscape is true, \"\\\" will be explained as a special escape character. Otherwise, \"\\\" acts as normal characters. Aspose.BarCode supports input decimal ascii code and mnemonic for ASCII control-code characters. For example, \\013 and \\\\CR stands for CR. (optional) 
            var filledBars = true;  // bool? | Value indicating whether bars are filled. Only for 1D barcodes. Default value: true. (optional) 
            var alwaysShowChecksum = true;  // bool? | Always display checksum digit in the human readable text for Code128 and GS1Code128 barcodes. (optional) 
            var wideNarrowRatio = 1.2;  // double? | Wide bars to Narrow bars ratio. Default value: 3, that is, wide bars are 3 times as wide as narrow bars. Used for ITF, PZN, PharmaCode, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, IATA2of5, VIN, DeutschePost, OPC, Code32, DataLogic2of5, PatchCode, Code39Extended, Code39Standard (optional) 
            var validateText = true;  // bool? | Only for 1D barcodes. If codetext is incorrect and value set to true - exception will be thrown. Otherwise codetext will be corrected to match barcode's specification. Exception always will be thrown for: Databar symbology if codetext is incorrect. Exception always will not be thrown for: AustraliaPost, SingaporePost, Code39Extended, Code93Extended, Code16K, Code128 symbology if codetext is incorrect. (optional) 
            var supplementData = supplementData_example;  // string | Supplement parameters. Used for Interleaved2of5, Standard2of5, EAN13, EAN8, UPCA, UPCE, ISBN, ISSN, ISMN. (optional) 
            var supplementSpace = 1.2;  // double? | Space between main the BarCode and supplement BarCode. (optional) 
            var barWidthReduction = 1.2;  // double? | Bars reduction value that is used to compensate ink spread while printing. (optional) 
            var storage = storage_example;  // string | Image's storage. (optional) 
            var folder = folder_example;  // string | Image's folder. (optional) 
            var format = format_example;  // string | The image format. (optional) 

            try
            {
                // Generate barcode and save on server (from query params or from file with json or xml content)
                ResultImageInfo result = apiInstance.PutBarcodeGenerateFile(name, type, text, twoDDisplayText, textLocation, textAlignment, textColor, fontSizeMode, noWrap, resolution, resolutionX, resolutionY, dimensionX, textSpace, units, sizeMode, barHeight, imageHeight, imageWidth, rotationAngle, backColor, barColor, borderColor, borderWidth, borderDashStyle, borderVisible, enableChecksum, enableEscape, filledBars, alwaysShowChecksum, wideNarrowRatio, validateText, supplementData, supplementSpace, barWidthReduction, storage, folder, format);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.PutBarcodeGenerateFile: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The image file name. | 
 **type** | **string**| Type of barcode to generate. | 
 **text** | **string**| Text to encode. | 
 **twoDDisplayText** | **string**| Text that will be displayed instead of codetext in 2D barcodes. Used for: Aztec, Pdf417, DataMatrix, QR, MaxiCode, DotCode | [optional] 
 **textLocation** | **string**| Specify the displaying Text Location, set to CodeLocation.None to hide CodeText. Default value: CodeLocation.Below. | [optional] 
 **textAlignment** | **string**| Text alignment. | [optional] 
 **textColor** | **string**| Specify the displaying CodeText&#39;s Color. Default value: Color.Black. | [optional] 
 **fontSizeMode** | **string**| Specify FontSizeMode. If FontSizeMode is set to Auto, font size will be calculated automatically based on xDimension value. It is recommended to use FontSizeMode.Auto especially in AutoSizeMode.Nearest or AutoSizeMode.Interpolation. Default value: FontSizeMode.Auto. | [optional] 
 **noWrap** | **bool?**| Specify word wraps (line breaks) within text. Default value: false. | [optional] 
 **resolution** | **double?**| Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. | [optional] 
 **resolutionX** | **double?**| DEPRECATED: Use &#39;Resolution&#39; instead. | [optional] 
 **resolutionY** | **double?**| DEPRECATED: Use &#39;Resolution&#39; instead. | [optional] 
 **dimensionX** | **double?**| The smallest width of the unit of BarCode bars or spaces. Increase this will increase the whole barcode image width. Ignored if AutoSizeMode property is set to AutoSizeMode.Nearest or AutoSizeMode.Interpolation. | [optional] 
 **textSpace** | **double?**| Space between the CodeText and the BarCode in Unit value. Default value: 2pt. Ignored for EAN8, EAN13, UPCE, UPCA, ISBN, ISMN, ISSN, UpcaGs1DatabarCoupon. | [optional] 
 **units** | **string**| Common Units for all measuring in query. Default units: pixel. | [optional] 
 **sizeMode** | **string**| Specifies the different types of automatic sizing modes. Default value: AutoSizeMode.None. | [optional] 
 **barHeight** | **double?**| Height of the barcode in given units. Default units: pixel. | [optional] 
 **imageHeight** | **double?**| Height of the barcode image in given units. Default units: pixel. | [optional] 
 **imageWidth** | **double?**| Width of the barcode image in given units. Default units: pixel. | [optional] 
 **rotationAngle** | **double?**| BarCode image rotation angle, measured in degree, e.g. RotationAngle &#x3D; 0 or RotationAngle &#x3D; 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0. | [optional] 
 **backColor** | **string**| Background color of the barcode image. Default value: Color.White. | [optional] 
 **barColor** | **string**| Bars color. Default value: Color.Black. | [optional] 
 **borderColor** | **string**| Border color. Default value: Color.Black. | [optional] 
 **borderWidth** | **double?**| Border width. Default value: 0. Ignored if Visible is set to false. | [optional] 
 **borderDashStyle** | **string**| Border dash style. Default value: BorderDashStyle.Solid. | [optional] 
 **borderVisible** | **bool?**| Border visibility. If false than parameter Width is always ignored (0). Default value: false. | [optional] 
 **enableChecksum** | **string**| Enable checksum during generation 1D barcodes. Default is treated as Yes for symbology which must contain checksum, as No where checksum only possible. Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN, Codabar Checksum always used: Rest symbology | [optional] 
 **enableEscape** | **bool?**| Indicates whether explains the character \&quot;\\\&quot; as an escape character in CodeText property. Used for Pdf417, DataMatrix, Code128 only If the EnableEscape is true, \&quot;\\\&quot; will be explained as a special escape character. Otherwise, \&quot;\\\&quot; acts as normal characters. Aspose.BarCode supports input decimal ascii code and mnemonic for ASCII control-code characters. For example, \\013 and \\\\CR stands for CR. | [optional] 
 **filledBars** | **bool?**| Value indicating whether bars are filled. Only for 1D barcodes. Default value: true. | [optional] 
 **alwaysShowChecksum** | **bool?**| Always display checksum digit in the human readable text for Code128 and GS1Code128 barcodes. | [optional] 
 **wideNarrowRatio** | **double?**| Wide bars to Narrow bars ratio. Default value: 3, that is, wide bars are 3 times as wide as narrow bars. Used for ITF, PZN, PharmaCode, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, IATA2of5, VIN, DeutschePost, OPC, Code32, DataLogic2of5, PatchCode, Code39Extended, Code39Standard | [optional] 
 **validateText** | **bool?**| Only for 1D barcodes. If codetext is incorrect and value set to true - exception will be thrown. Otherwise codetext will be corrected to match barcode&#39;s specification. Exception always will be thrown for: Databar symbology if codetext is incorrect. Exception always will not be thrown for: AustraliaPost, SingaporePost, Code39Extended, Code93Extended, Code16K, Code128 symbology if codetext is incorrect. | [optional] 
 **supplementData** | **string**| Supplement parameters. Used for Interleaved2of5, Standard2of5, EAN13, EAN8, UPCA, UPCE, ISBN, ISSN, ISMN. | [optional] 
 **supplementSpace** | **double?**| Space between main the BarCode and supplement BarCode. | [optional] 
 **barWidthReduction** | **double?**| Bars reduction value that is used to compensate ink spread while printing. | [optional] 
 **storage** | **string**| Image&#39;s storage. | [optional] 
 **folder** | **string**| Image&#39;s folder. | [optional] 
 **format** | **string**| The image format. | [optional] 

### Return type

[**ResultImageInfo**](ResultImageInfo.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json, application/xml, multipart/form-data
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putbarcoderecognizefrombody"></a>
# **PutBarcodeRecognizeFromBody**
> BarcodeResponseList PutBarcodeRecognizeFromBody (string name, ReaderParams readerParams, string type = null, string storage = null, string folder = null)

Recognition of a barcode from file on server with parameters in body.

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class PutBarcodeRecognizeFromBodyExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarcodeApi();
            var name = name_example;  // string | The image file name.
            var readerParams = new ReaderParams(); // ReaderParams | BarcodeReader object with parameters.
            var type = type_example;  // string |  (optional) 
            var storage = storage_example;  // string | The storage name (optional) 
            var folder = folder_example;  // string | The image folder. (optional) 

            try
            {
                // Recognition of a barcode from file on server with parameters in body.
                BarcodeResponseList result = apiInstance.PutBarcodeRecognizeFromBody(name, readerParams, type, storage, folder);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.PutBarcodeRecognizeFromBody: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| The image file name. | 
 **readerParams** | [**ReaderParams**](ReaderParams.md)| BarcodeReader object with parameters. | 
 **type** | **string**|  | [optional] 
 **storage** | **string**| The storage name | [optional] 
 **folder** | **string**| The image folder. | [optional] 

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="putgeneratemultiple"></a>
# **PutGenerateMultiple**
> ResultImageInfo PutGenerateMultiple (string name, GeneratorParamsList generatorParamsList, string format = null, string folder = null, string storage = null)

Generate image with multiple barcodes and put new file on server

### Example
```csharp
using System;
using System.Diagnostics;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Client;
using Aspose.BarCode.Cloud.Sdk.Model;

namespace Example
{
    public class PutGenerateMultipleExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: JWT
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new BarcodeApi();
            var name = name_example;  // string | New filename
            var generatorParamsList = new GeneratorParamsList(); // GeneratorParamsList | List of barcodes
            var format = format_example;  // string | Format of file (optional)  (default to png)
            var folder = folder_example;  // string | Folder to place file to (optional) 
            var storage = storage_example;  // string | The storage name (optional) 

            try
            {
                // Generate image with multiple barcodes and put new file on server
                ResultImageInfo result = apiInstance.PutGenerateMultiple(name, generatorParamsList, format, folder, storage);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling BarcodeApi.PutGenerateMultiple: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **name** | **string**| New filename | 
 **generatorParamsList** | [**GeneratorParamsList**](GeneratorParamsList.md)| List of barcodes | 
 **format** | **string**| Format of file | [optional] [default to png]
 **folder** | **string**| Folder to place file to | [optional] 
 **storage** | **string**| The storage name | [optional] 

### Return type

[**ResultImageInfo**](ResultImageInfo.md)

### Authorization

[JWT](../README.md#JWT)

### HTTP request headers

 - **Content-Type**: application/json, application/xml
 - **Accept**: application/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

