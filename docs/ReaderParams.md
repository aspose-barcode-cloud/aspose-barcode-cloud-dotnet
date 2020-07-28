# Aspose.BarCode.Cloud.Sdk.Model.ReaderParams
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **DecodeBarcodeType** | The type of barcode to read. | [optional] 
**ChecksumValidation** | **ChecksumValidation** | Enable checksum validation during recognition for 1D barcodes. Default is treated as Yes for symbologies which must contain checksum, as No where checksum only possible. Checksum never used: Codabar Checksum is possible: Code39 Standard/Extended, Standard2of5, Interleaved2of5, Matrix2of5, ItalianPost25, DeutschePostIdentcode, DeutschePostLeitcode, VIN Checksum always used: Rest symbologies | [optional] 
**DetectEncoding** | **bool?** | A flag which force engine to detect codetext encoding for Unicode. | [optional] 
**Preset** | **PresetType** | Preset allows to configure recognition quality and speed manually. You can quickly set up Preset by embedded presets: HighPerformance, NormalQuality, HighQuality, MaxBarCodes or you can manually configure separate options. Default value of Preset is NormalQuality. | [optional] 
**RectX** | **int?** | Set X for area for recognition. | [optional] 
**RectY** | **int?** | Set Y for area for recognition. | [optional] 
**RectWidth** | **int?** | Set Width of area for recognition. | [optional] 
**RectHeight** | **int?** | Set Height of area for recognition. | [optional] 
**StripFNC** | **bool?** | Value indicating whether FNC symbol strip must be done. | [optional] 
**Timeout** | **int?** | Timeout of recognition process. | [optional] 
**MedianSmoothingWindowSize** | **int?** | Window size for median smoothing. Typical values are 3 or 4. Default value is 3. AllowMedianSmoothing must be set. | [optional] 
**AllowMedianSmoothing** | **bool?** | Allows engine to enable median smoothing as additional scan. Mode helps to recognize noised barcodes. | [optional] 
**AllowComplexBackground** | **bool?** | Allows engine to recognize color barcodes on color background as additional scan. Extremely slow mode. | [optional] 
**AllowDatamatrixIndustrialBarcodes** | **bool?** | Allows engine for Datamatrix to recognize dashed industrial Datamatrix barcodes. Slow mode which helps only for dashed barcodes which consist from spots. | [optional] 
**AllowDecreasedImage** | **bool?** | Allows engine to recognize decreased image as additional scan. Size for decreasing is selected by internal engine algorithms. Mode helps to recognize barcodes which are noised and blurred but captured with high resolution. | [optional] 
**AllowDetectScanGap** | **bool?** | Allows engine to use gap between scans to increase recognition speed. Mode can make recognition problems with low height barcodes. | [optional] 
**AllowIncorrectBarcodes** | **bool?** | Allows engine to recognize barcodes which has incorrect checksum or incorrect values. Mode can be used to recognize damaged barcodes with incorrect text. | [optional] 
**AllowInvertImage** | **bool?** | Allows engine to recognize inverse color image as additional scan. Mode can be used when barcode is white on black background. | [optional] 
**AllowMicroWhiteSpotsRemoving** | **bool?** | Allows engine for Postal barcodes to recognize slightly noised images. Mode helps to recognize slightly damaged Postal barcodes. | [optional] 
**AllowOneDFastBarcodesDetector** | **bool?** | Allows engine for 1D barcodes to quickly recognize high quality barcodes which fill almost whole image. Mode helps to quickly recognize generated barcodes from Internet. | [optional] 
**AllowOneDWipedBarsRestoration** | **bool?** | Allows engine for 1D barcodes to recognize barcodes with single wiped/glued bars in pattern. | [optional] 
**AllowQRMicroQrRestoration** | **bool?** | Allows engine for QR/MicroQR to recognize damaged MicroQR barcodes. | [optional] 
**AllowRegularImage** | **bool?** | Allows engine to recognize regular image without any restorations as main scan. Mode to recognize image as is. | [optional] 
**AllowSaltAndPepperFiltering** | **bool?** | Allows engine to recognize barcodes with salt and pepper noise type. Mode can remove small noise with white and black dots. | [optional] 
**AllowWhiteSpotsRemoving** | **bool?** | Allows engine to recognize image without small white spots as additional scan. Mode helps to recognize noised image as well as median smoothing filtering. | [optional] 
**RegionLikelihoodThresholdPercent** | **double?** | Sets threshold for detected regions that may contain barcodes. Value 0.7 means that bottom 70% of possible regions are filtered out and not processed further. Region likelihood threshold must be between [0.05, 0.9] Use high values for clear images with few barcodes. Use low values for images with many barcodes or for noisy images. Low value may lead to a bigger recognition time. | [optional] 
**ScanWindowSizes** | **List&lt;int?&gt;** | Scan window sizes in pixels. Allowed sizes are 10, 15, 20, 25, 30. Scanning with small window size takes more time and provides more accuracy but may fail in detecting very big barcodes. Combining of several window sizes can improve detection quality. | [optional] 
**Similarity** | **double?** | Similarity coefficient depends on how homogeneous barcodes are. Use high value for for clear barcodes. Use low values to detect barcodes that ara partly damaged or not lighten evenly. Similarity coefficient must be between [0.5, 0.9] | [optional] 
**SkipDiagonalSearch** | **bool?** | Allows detector to skip search for diagonal barcodes. Setting it to false will increase detection time but allow to find diagonal barcodes that can be missed otherwise. Enabling of diagonal search leads to a bigger detection time. | [optional] 
**AustralianPostEncodingTable** | **CustomerInformationInterpretingType** | Interpreting Type for the Customer Information of AustralianPost BarCode.Default is CustomerInformationInterpretingType.Other. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

