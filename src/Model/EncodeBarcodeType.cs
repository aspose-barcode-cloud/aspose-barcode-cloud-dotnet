
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Model
{

    /// <summary>
    ///     See Aspose.BarCode.Generation.EncodeTypes
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum EncodeBarcodeType
    {
        /// <summary>
        ///     Enum value QR
        /// </summary>
        QR,

        /// <summary>
        ///     Enum value AustraliaPost
        /// </summary>
        AustraliaPost,

        /// <summary>
        ///     Enum value AustralianPosteParcel
        /// </summary>
        AustralianPosteParcel,

        /// <summary>
        ///     Enum value Aztec
        /// </summary>
        Aztec,

        /// <summary>
        ///     Enum value Codabar
        /// </summary>
        Codabar,

        /// <summary>
        ///     Enum value CodablockF
        /// </summary>
        CodablockF,

        /// <summary>
        ///     Enum value Code11
        /// </summary>
        Code11,

        /// <summary>
        ///     Enum value Code128
        /// </summary>
        Code128,

        /// <summary>
        ///     Enum value Code16K
        /// </summary>
        Code16K,

        /// <summary>
        ///     Enum value Code32
        /// </summary>
        Code32,

        /// <summary>
        ///     Enum value Code39
        /// </summary>
        Code39,

        /// <summary>
        ///     Enum value Code39FullASCII
        /// </summary>
        Code39FullASCII,

        /// <summary>
        ///     Enum value Code93
        /// </summary>
        Code93,

        /// <summary>
        ///     Enum value DataLogic2of5
        /// </summary>
        DataLogic2of5,

        /// <summary>
        ///     Enum value DataMatrix
        /// </summary>
        DataMatrix,

        /// <summary>
        ///     Enum value DatabarExpanded
        /// </summary>
        DatabarExpanded,

        /// <summary>
        ///     Enum value DatabarExpandedStacked
        /// </summary>
        DatabarExpandedStacked,

        /// <summary>
        ///     Enum value DatabarLimited
        /// </summary>
        DatabarLimited,

        /// <summary>
        ///     Enum value DatabarOmniDirectional
        /// </summary>
        DatabarOmniDirectional,

        /// <summary>
        ///     Enum value DatabarStacked
        /// </summary>
        DatabarStacked,

        /// <summary>
        ///     Enum value DatabarStackedOmniDirectional
        /// </summary>
        DatabarStackedOmniDirectional,

        /// <summary>
        ///     Enum value DatabarTruncated
        /// </summary>
        DatabarTruncated,

        /// <summary>
        ///     Enum value DeutschePostIdentcode
        /// </summary>
        DeutschePostIdentcode,

        /// <summary>
        ///     Enum value DeutschePostLeitcode
        /// </summary>
        DeutschePostLeitcode,

        /// <summary>
        ///     Enum value DotCode
        /// </summary>
        DotCode,

        /// <summary>
        ///     Enum value DutchKIX
        /// </summary>
        DutchKIX,

        /// <summary>
        ///     Enum value EAN13
        /// </summary>
        EAN13,

        /// <summary>
        ///     Enum value EAN14
        /// </summary>
        EAN14,

        /// <summary>
        ///     Enum value EAN8
        /// </summary>
        EAN8,

        /// <summary>
        ///     Enum value GS1Aztec
        /// </summary>
        GS1Aztec,

        /// <summary>
        ///     Enum value GS1CodablockF
        /// </summary>
        GS1CodablockF,

        /// <summary>
        ///     Enum value GS1Code128
        /// </summary>
        GS1Code128,

        /// <summary>
        ///     Enum value GS1DataMatrix
        /// </summary>
        GS1DataMatrix,

        /// <summary>
        ///     Enum value GS1DotCode
        /// </summary>
        GS1DotCode,

        /// <summary>
        ///     Enum value GS1HanXin
        /// </summary>
        GS1HanXin,

        /// <summary>
        ///     Enum value GS1MicroPdf417
        /// </summary>
        GS1MicroPdf417,

        /// <summary>
        ///     Enum value GS1QR
        /// </summary>
        GS1QR,

        /// <summary>
        ///     Enum value HanXin
        /// </summary>
        HanXin,

        /// <summary>
        ///     Enum value IATA2of5
        /// </summary>
        IATA2of5,

        /// <summary>
        ///     Enum value ISBN
        /// </summary>
        ISBN,

        /// <summary>
        ///     Enum value ISMN
        /// </summary>
        ISMN,

        /// <summary>
        ///     Enum value ISSN
        /// </summary>
        ISSN,

        /// <summary>
        ///     Enum value ITF14
        /// </summary>
        ITF14,

        /// <summary>
        ///     Enum value ITF6
        /// </summary>
        ITF6,

        /// <summary>
        ///     Enum value Interleaved2of5
        /// </summary>
        Interleaved2of5,

        /// <summary>
        ///     Enum value ItalianPost25
        /// </summary>
        ItalianPost25,

        /// <summary>
        ///     Enum value MSI
        /// </summary>
        MSI,

        /// <summary>
        ///     Enum value MacroPdf417
        /// </summary>
        MacroPdf417,

        /// <summary>
        ///     Enum value Mailmark
        /// </summary>
        Mailmark,

        /// <summary>
        ///     Enum value Matrix2of5
        /// </summary>
        Matrix2of5,

        /// <summary>
        ///     Enum value MaxiCode
        /// </summary>
        MaxiCode,

        /// <summary>
        ///     Enum value MicroPdf417
        /// </summary>
        MicroPdf417,

        /// <summary>
        ///     Enum value MicroQR
        /// </summary>
        MicroQR,

        /// <summary>
        ///     Enum value OPC
        /// </summary>
        OPC,

        /// <summary>
        ///     Enum value OneCode
        /// </summary>
        OneCode,

        /// <summary>
        ///     Enum value PZN
        /// </summary>
        PZN,

        /// <summary>
        ///     Enum value PatchCode
        /// </summary>
        PatchCode,

        /// <summary>
        ///     Enum value Pdf417
        /// </summary>
        Pdf417,

        /// <summary>
        ///     Enum value Pharmacode
        /// </summary>
        Pharmacode,

        /// <summary>
        ///     Enum value Planet
        /// </summary>
        Planet,

        /// <summary>
        ///     Enum value Postnet
        /// </summary>
        Postnet,

        /// <summary>
        ///     Enum value RM4SCC
        /// </summary>
        RM4SCC,

        /// <summary>
        ///     Enum value RectMicroQR
        /// </summary>
        RectMicroQR,

        /// <summary>
        ///     Enum value SCC14
        /// </summary>
        SCC14,

        /// <summary>
        ///     Enum value SSCC18
        /// </summary>
        SSCC18,

        /// <summary>
        ///     Enum value SingaporePost
        /// </summary>
        SingaporePost,

        /// <summary>
        ///     Enum value Standard2of5
        /// </summary>
        Standard2of5,

        /// <summary>
        ///     Enum value SwissPostParcel
        /// </summary>
        SwissPostParcel,

        /// <summary>
        ///     Enum value UPCA
        /// </summary>
        UPCA,

        /// <summary>
        ///     Enum value UPCE
        /// </summary>
        UPCE,

        /// <summary>
        ///     Enum value UpcaGs1Code128Coupon
        /// </summary>
        UpcaGs1Code128Coupon,

        /// <summary>
        ///     Enum value UpcaGs1DatabarCoupon
        /// </summary>
        UpcaGs1DatabarCoupon,

        /// <summary>
        ///     Enum value VIN
        /// </summary>
        VIN

    }
}
