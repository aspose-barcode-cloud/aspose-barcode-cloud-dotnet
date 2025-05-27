
using System;
using System.Collections.Generic;
using Aspose.BarCode.Cloud.Sdk.Interfaces;
using Aspose.BarCode.Cloud.Sdk.Internal;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     Barcode image optional parameters
    /// </summary>
    public class BarcodeImageParams : IToString
    {
        /// <summary>
        ///     Gets or sets ImageFormat
        /// </summary>
        public BarcodeImageFormat? ImageFormat { get; set; }

        /// <summary>
        ///     Gets or sets TextLocation
        /// </summary>
        public CodeLocation? TextLocation { get; set; }

        /// <summary>
        ///     Gets or sets Units
        /// </summary>
        public GraphicsUnit? Units { get; set; }

        /// <summary>
        ///     Specify the displaying bars and content Color. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: Black.
        /// </summary>
        public string ForegroundColor { get; set; }

        /// <summary>
        ///     Background color of the barcode image. Value: Color name from https://reference.aspose.com/drawing/net/system.drawing/color/ or ARGB value started with #. For example: AliceBlue or #FF000000 Default value: White.
        /// </summary>
        public string BackgroundColor { get; set; }

        /// <summary>
        ///     Resolution of the BarCode image. One value for both dimensions. Default value: 96 dpi. Decimal separator is dot.
        /// </summary>
        public float? Resolution { get; set; }

        /// <summary>
        ///     Height of the barcode image in given units. Default units: pixel. Decimal separator is dot.
        /// </summary>
        public float? ImageHeight { get; set; }

        /// <summary>
        ///     Width of the barcode image in given units. Default units: pixel. Decimal separator is dot.
        /// </summary>
        public float? ImageWidth { get; set; }

        /// <summary>
        ///     BarCode image rotation angle, measured in degree, e.g. RotationAngle = 0 or RotationAngle = 360 means no rotation. If RotationAngle NOT equal to 90, 180, 270 or 0, it may increase the difficulty for the scanner to read the image. Default value: 0.
        /// </summary>
        public int? RotationAngle { get; set; }

        /// <summary>
        ///     Get the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            return _srcString ?? SerializationHelper.Serialize(this);
        }

        private string _srcString;
        /// <summary>
        ///   Set the string presentation of the object
        /// </summary>
        public void SetSrcString(string value)
        {
            _srcString = value;
        }
    }
}
