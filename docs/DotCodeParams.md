# Aspose.BarCode.Cloud.Sdk.Model.DotCodeParams

## Properties

Name | Type | Description | Notes
---- | ---- | ----------- | -----
**AspectRatio** | **double?** | Height/Width ratio of 2D BarCode module. | [optional]
**Columns** | **int?** | Identifies columns count. Sum of the number of rows plus the number of columns of a DotCode symbol must be odd. Number of columns must be at least 5. | [optional]
**EncodeMode** | **DotCodeEncodeMode** | Identifies DotCode encode mode. Default value: Auto. | [optional]
**ECIEncoding** | **ECIEncodings** | Identifies ECI encoding. Used when DotCodeEncodeMode is Auto. Default value: ISO-8859-1. | [optional]
**IsReaderInitialization** | **bool?** | Indicates whether code is used for instruct reader to interpret the following data as instructions for initialization or reprogramming of the bar code reader. Default value is false. | [optional]
**Rows** | **int?** | Identifies rows count. Sum of the number of rows plus the number of columns of a DotCode symbol must be odd. Number of rows must be at least 5. | [optional]

