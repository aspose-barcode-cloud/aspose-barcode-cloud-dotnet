# Aspose.BarCode.Cloud.Sdk.Api.BarcodeApi

All URIs are relative to *<https://api.aspose.cloud/v3.0>*

Method | HTTP request | Description
------ | ------------ | -----------
[**GetBarcodeGenerate**](BarcodeApi.md#getbarcodegenerate) | **GET** /barcode/generate | Generate barcode.
[**GetBarcodeRecognize**](BarcodeApi.md#getbarcoderecognize) | **GET** /barcode/{name}/recognize | Recognize barcode from a file on server.
[**PostBarcodeRecognizeFromUrlOrContent**](BarcodeApi.md#postbarcoderecognizefromurlorcontent) | **POST** /barcode/recognize | Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image with content-type \&quot;application/octet-stream\&quot;. An image can also be passed as a form field.
[**PostGenerateMultiple**](BarcodeApi.md#postgeneratemultiple) | **POST** /barcode/generateMultiple | Generate multiple barcodes and return in response stream
[**PutBarcodeGenerateFile**](BarcodeApi.md#putbarcodegeneratefile) | **PUT** /barcode/{name}/generate | Generate barcode and save on server (from query params or from file with json or xml content)
[**PutBarcodeRecognizeFromBody**](BarcodeApi.md#putbarcoderecognizefrombody) | **PUT** /barcode/{name}/recognize | Recognition of a barcode from file on server with parameters in body.
[**PutGenerateMultiple**](BarcodeApi.md#putgeneratemultiple) | **PUT** /barcode/{name}/generateMultiple | Generate image with multiple barcodes and put new file on server


## **GetBarcodeGenerate**

```csharp
System.IO.Stream GetBarcodeGenerate (string type, string text, string twoDDisplayText = null, string textLocation = null, string textAlignment = null, string textColor = null, string fontSizeMode = null, bool? noWrap = null, double? resolution = null, double? resolutionX = null, double? resolutionY = null, double? dimensionX = null, double? textSpace = null, string units = null, string sizeMode = null, double? barHeight = null, double? imageHeight = null, double? imageWidth = null, double? rotationAngle = null, string backColor = null, string barColor = null, string borderColor = null, double? borderWidth = null, string borderDashStyle = null, bool? borderVisible = null, string enableChecksum = null, bool? enableEscape = null, bool? filledBars = null, bool? alwaysShowChecksum = null, double? wideNarrowRatio = null, bool? validateText = null, string supplementData = null, double? supplementSpace = null, double? barWidthReduction = null, bool? useAntiAlias = null, string format = null)
```

Generate barcode.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
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
 **useAntiAlias** | **bool?**| Indicates whether is used anti-aliasing mode to render image. Anti-aliasing mode is applied to barcode and text drawing. | [optional]
 **format** | **string**| Result image format. | [optional]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff


## **GetBarcodeRecognize**

```csharp
BarcodeResponseList GetBarcodeRecognize (string name, string type = null, string checksumValidation = null, bool? detectEncoding = null, string preset = null, int? rectX = null, int? rectY = null, int? rectWidth = null, int? rectHeight = null, bool? stripFNC = null, int? timeout = null, int? medianSmoothingWindowSize = null, bool? allowMedianSmoothing = null, bool? allowComplexBackground = null, bool? allowDatamatrixIndustrialBarcodes = null, bool? allowDecreasedImage = null, bool? allowDetectScanGap = null, bool? allowIncorrectBarcodes = null, bool? allowInvertImage = null, bool? allowMicroWhiteSpotsRemoving = null, bool? allowOneDFastBarcodesDetector = null, bool? allowOneDWipedBarsRestoration = null, bool? allowQRMicroQrRestoration = null, bool? allowRegularImage = null, bool? allowSaltAndPepperFiltering = null, bool? allowWhiteSpotsRemoving = null, bool? checkMore1DVariants = null, bool? fastScanOnly = null, bool? allowAdditionalRestorations = null, double? regionLikelihoodThresholdPercent = null, List<int?> scanWindowSizes = null, double? similarity = null, bool? skipDiagonalSearch = null, bool? readTinyBarcodes = null, string australianPostEncodingTable = null, bool? ignoreEndingFillingPatternsForCTable = null, string storage = null, string folder = null)
```

Recognize barcode from a file on server.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **name** | **string**| The image file name. |
 **type** | **string**| The type of barcode to read. | [optional]
 **checksumValidation** | **string**| Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies | [optional]
 **detectEncoding** | **bool?**| A flag which force engine to detect codetext encoding for Unicode. | [optional]
 **preset** | **string**| Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality. | [optional]
 **rectX** | **int?**| Set X of top left corner of area for recognition. | [optional]
 **rectY** | **int?**| Set Y of top left corner of area for recognition. | [optional]
 **rectWidth** | **int?**| Set Width of area for recognition. | [optional]
 **rectHeight** | **int?**| Set Height of area for recognition. | [optional]
 **stripFNC** | **bool?**| Value indicating whether FNC symbol strip must be done. | [optional]
 **timeout** | **int?**| Timeout of recognition process in milliseconds. Default value is 15_000 (15 seconds). Maximum value is 60_000 (1 minute). In case of a timeout RequestTimeout (408) status will be returned. Try reducing the image size to avoid timeout. | [optional]
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
 **allowAdditionalRestorations** | **bool?**| Allows engine using additional image restorations to recognize corrupted barcodes. At this time, it is used only in MicroPdf417 barcode type. Default value: False. | [optional]
 **regionLikelihoodThresholdPercent** | **double?**| Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time. | [optional]
 **scanWindowSizes** | [**List&lt;int?&gt;**](int?.md)| Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality. | [optional]
 **similarity** | **double?**| Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9] | [optional]
 **skipDiagonalSearch** | **bool?**| Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time. | [optional]
 **readTinyBarcodes** | **bool?**| Allows engine to recognize tiny barcodes on large images. Ignored if AllowIncorrectBarcodes is set to True. Default value: False. | [optional]
 **australianPostEncodingTable** | **string**| Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other. | [optional]
 **ignoreEndingFillingPatternsForCTable** | **bool?**| The flag which force AustraliaPost decoder to ignore last filling patterns in Customer Information Field during decoding as CTable method. CTable encoding method does not have any gaps in encoding table and sequence \&quot;333\&quot; of filling patterns is decoded as letter \&quot;z\&quot;. | [optional]
 **storage** | **string**| The image storage. | [optional]
 **folder** | **string**| The image folder. | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **PostBarcodeRecognizeFromUrlOrContent**

```csharp
BarcodeResponseList PostBarcodeRecognizeFromUrlOrContent (string type = null, string checksumValidation = null, bool? detectEncoding = null, string preset = null, int? rectX = null, int? rectY = null, int? rectWidth = null, int? rectHeight = null, bool? stripFNC = null, int? timeout = null, int? medianSmoothingWindowSize = null, bool? allowMedianSmoothing = null, bool? allowComplexBackground = null, bool? allowDatamatrixIndustrialBarcodes = null, bool? allowDecreasedImage = null, bool? allowDetectScanGap = null, bool? allowIncorrectBarcodes = null, bool? allowInvertImage = null, bool? allowMicroWhiteSpotsRemoving = null, bool? allowOneDFastBarcodesDetector = null, bool? allowOneDWipedBarsRestoration = null, bool? allowQRMicroQrRestoration = null, bool? allowRegularImage = null, bool? allowSaltAndPepperFiltering = null, bool? allowWhiteSpotsRemoving = null, bool? checkMore1DVariants = null, bool? fastScanOnly = null, bool? allowAdditionalRestorations = null, double? regionLikelihoodThresholdPercent = null, List<int?> scanWindowSizes = null, double? similarity = null, bool? skipDiagonalSearch = null, bool? readTinyBarcodes = null, string australianPostEncodingTable = null, bool? ignoreEndingFillingPatternsForCTable = null, string url = null, System.IO.Stream image = null)
```

Recognize barcode from an url or from request body. Request body can contain raw data bytes of the image with content-type \"application/octet-stream\". An image can also be passed as a form field.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **type** | **string**| The type of barcode to read. | [optional]
 **checksumValidation** | **string**| Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies | [optional]
 **detectEncoding** | **bool?**| A flag which force engine to detect codetext encoding for Unicode. | [optional]
 **preset** | **string**| Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality. | [optional]
 **rectX** | **int?**| Set X of top left corner of area for recognition. | [optional]
 **rectY** | **int?**| Set Y of top left corner of area for recognition. | [optional]
 **rectWidth** | **int?**| Set Width of area for recognition. | [optional]
 **rectHeight** | **int?**| Set Height of area for recognition. | [optional]
 **stripFNC** | **bool?**| Value indicating whether FNC symbol strip must be done. | [optional]
 **timeout** | **int?**| Timeout of recognition process in milliseconds. Default value is 15_000 (15 seconds). Maximum value is 60_000 (1 minute). In case of a timeout RequestTimeout (408) status will be returned. Try reducing the image size to avoid timeout. | [optional]
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
 **allowAdditionalRestorations** | **bool?**| Allows engine using additional image restorations to recognize corrupted barcodes. At this time, it is used only in MicroPdf417 barcode type. Default value: False. | [optional]
 **regionLikelihoodThresholdPercent** | **double?**| Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time. | [optional]
 **scanWindowSizes** | [**List&lt;int?&gt;**](int?.md)| Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality. | [optional]
 **similarity** | **double?**| Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9] | [optional]
 **skipDiagonalSearch** | **bool?**| Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time. | [optional]
 **readTinyBarcodes** | **bool?**| Allows engine to recognize tiny barcodes on large images. Ignored if AllowIncorrectBarcodes is set to True. Default value: False. | [optional]
 **australianPostEncodingTable** | **string**| Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other. | [optional]
 **ignoreEndingFillingPatternsForCTable** | **bool?**| The flag which force AustraliaPost decoder to ignore last filling patterns in Customer Information Field during decoding as CTable method. CTable encoding method does not have any gaps in encoding table and sequence \&quot;333\&quot; of filling patterns is decoded as letter \&quot;z\&quot;. | [optional]
 **url** | **string**| The image file url. | [optional]
 **image** | **System.IO.Stream**| Image data | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded, application/octet-stream
- **Accept**: application/json


## **PostGenerateMultiple**

```csharp
System.IO.Stream PostGenerateMultiple (GeneratorParamsList generatorParamsList, string format = null)
```

Generate multiple barcodes and return in response stream

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **generatorParamsList** | [**GeneratorParamsList**](GeneratorParamsList.md)| List of barcodes |
 **format** | **string**| Format to return stream in | [optional] [default to png]

### Return type

System.IO.Stream

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: image/png, image/bmp, image/gif, image/jpeg, image/svg+xml, image/tiff


## **PutBarcodeGenerateFile**

```csharp
ResultImageInfo PutBarcodeGenerateFile (string name, string type, string text, string twoDDisplayText = null, string textLocation = null, string textAlignment = null, string textColor = null, string fontSizeMode = null, bool? noWrap = null, double? resolution = null, double? resolutionX = null, double? resolutionY = null, double? dimensionX = null, double? textSpace = null, string units = null, string sizeMode = null, double? barHeight = null, double? imageHeight = null, double? imageWidth = null, double? rotationAngle = null, string backColor = null, string barColor = null, string borderColor = null, double? borderWidth = null, string borderDashStyle = null, bool? borderVisible = null, string enableChecksum = null, bool? enableEscape = null, bool? filledBars = null, bool? alwaysShowChecksum = null, double? wideNarrowRatio = null, bool? validateText = null, string supplementData = null, double? supplementSpace = null, double? barWidthReduction = null, bool? useAntiAlias = null, string storage = null, string folder = null, string format = null)
```

Generate barcode and save on server (from query params or from file with json or xml content)

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
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
 **useAntiAlias** | **bool?**| Indicates whether is used anti-aliasing mode to render image. Anti-aliasing mode is applied to barcode and text drawing. | [optional]
 **storage** | **string**| Image&#39;s storage. | [optional]
 **folder** | **string**| Image&#39;s folder. | [optional]
 **format** | **string**| The image format. | [optional]

### Return type

[**ResultImageInfo**](ResultImageInfo.md)

### HTTP request headers

- **Content-Type**: multipart/form-data, application/x-www-form-urlencoded, application/json, application/xml
- **Accept**: application/json


## **PutBarcodeRecognizeFromBody**

```csharp
BarcodeResponseList PutBarcodeRecognizeFromBody (string name, ReaderParams readerParams, string type = null, string storage = null, string folder = null)
```

Recognition of a barcode from file on server with parameters in body.

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **name** | **string**| The image file name. |
 **readerParams** | [**ReaderParams**](ReaderParams.md)| BarcodeReader object with parameters. |
 **type** | **string**|  | [optional]
 **storage** | **string**| The storage name | [optional]
 **folder** | **string**| The image folder. | [optional]

### Return type

[**BarcodeResponseList**](BarcodeResponseList.md)

### HTTP request headers

- **Content-Type**: application/json
- **Accept**: application/json


## **PutGenerateMultiple**

```csharp
ResultImageInfo PutGenerateMultiple (string name, GeneratorParamsList generatorParamsList, string format = null, string folder = null, string storage = null)
```

Generate image with multiple barcodes and put new file on server

### Parameters

Name | Type | Description  | Notes
---- | ---- | ------------ | -----
 **name** | **string**| New filename |
 **generatorParamsList** | [**GeneratorParamsList**](GeneratorParamsList.md)| List of barcodes |
 **format** | **string**| Format of file | [optional] [default to png]
 **folder** | **string**| Folder to place file to | [optional]
 **storage** | **string**| The storage name | [optional]

### Return type

[**ResultImageInfo**](ResultImageInfo.md)

### HTTP request headers

- **Content-Type**: application/json, application/xml
- **Accept**: application/json

