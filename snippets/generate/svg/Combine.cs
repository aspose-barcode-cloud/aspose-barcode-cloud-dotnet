using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;

using System;
using System.Globalization;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GenerateSnippets;

/// <summary>
/// Demonstrates generating two SVG barcodes via Aspose.BarCode Cloud and combining
/// them into a single SVG containing both codes side-by-side.
/// </summary>
internal static class Program
{
    private static readonly Encoding Utf8NoBom = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false);
    private const double BarcodeSpacing = 20d;

    private static Configuration MakeConfiguration()
    {
        var config = new Configuration();

        string? envToken = Environment.GetEnvironmentVariable("TEST_CONFIGURATION_ACCESS_TOKEN");
        if (string.IsNullOrEmpty(envToken))
        {
            config.ClientId = "Client Id from https://dashboard.aspose.cloud/applications";
            config.ClientSecret = "Client Secret from https://dashboard.aspose.cloud/applications";
        }
        else
        {
            config.JwtToken = envToken;
        }

        return config;
    }

    public static async Task Main(string[] args)
    {
        string fileName = Path.GetFullPath(Path.Join("Tests", "test_data", "combined.svg"));

        GenerateApi generateApi = new GenerateApi(MakeConfiguration());

        Task<string> eanTask = GenerateSvgAsync(generateApi,
            barcodeType: EncodeBarcodeType.EAN13,
            data: "5901234123457");

        Task<string> qrTask = GenerateSvgAsync(generateApi,
            barcodeType: EncodeBarcodeType.QR,
            data: "https://products.aspose.cloud/barcode/");

        await Task.WhenAll(eanTask, qrTask);

        string combinedSvg = CombineSvg(eanTask.Result, qrTask.Result);

        await File.WriteAllTextAsync(fileName, combinedSvg, Utf8NoBom);

        Console.WriteLine($"File '{fileName}' generated.");
    }

    private static async Task<string> GenerateSvgAsync(GenerateApi api, EncodeBarcodeType barcodeType, string data)
    {
        await using Stream generated = await api.GenerateAsync(
            barcodeType: barcodeType,
            data: data,
            imageFormat: BarcodeImageFormat.Svg);

        using var reader = new StreamReader(generated, Utf8NoBom, detectEncodingFromByteOrderMarks: true);
        return await reader.ReadToEndAsync();
    }

    private static string CombineSvg(string eanSvg, string qrSvg)
    {
        XDocument eanDoc = XDocument.Parse(eanSvg);
        XDocument qrDoc = XDocument.Parse(qrSvg);

        double eanWidth = ParseLength(eanDoc.Root?.Attribute("width"));
        double eanHeight = ParseLength(eanDoc.Root?.Attribute("height"));
        double qrWidth = ParseLength(qrDoc.Root?.Attribute("width"));
        double qrHeight = ParseLength(qrDoc.Root?.Attribute("height"));

        double combinedWidth = eanWidth + BarcodeSpacing + qrWidth;
        double combinedHeight = Math.Max(eanHeight, qrHeight);

        XNamespace svgNamespace = eanDoc.Root?.Name.Namespace ?? "http://www.w3.org/2000/svg";
        var combinedRoot = new XElement(svgNamespace + "svg",
            new XAttribute("xmlns", svgNamespace.NamespaceName),
            new XAttribute(XNamespace.Xmlns + "xlink", "http://www.w3.org/1999/xlink"),
            new XAttribute("width", ToInvariantLength(combinedWidth)),
            new XAttribute("height", ToInvariantLength(combinedHeight)),
            new XAttribute("viewBox", $"0 0 {ToInvariantLength(combinedWidth)} {ToInvariantLength(combinedHeight)}"));

        double eanOffsetY = Math.Max(0, (combinedHeight - eanHeight) / 2);
        double qrOffsetY = Math.Max(0, (combinedHeight - qrHeight) / 2);

        combinedRoot.Add(CreateNestedSvg(eanDoc, 0, eanOffsetY, "EAN13"));
        combinedRoot.Add(CreateNestedSvg(qrDoc, eanWidth + BarcodeSpacing, qrOffsetY, "QR"));

        return combinedRoot.ToString(SaveOptions.OmitDuplicateNamespaces);
    }

    private static XElement CreateNestedSvg(XDocument source, double offsetX, double offsetY, string label)
    {
        if (source.Root == null)
        {
            throw new InvalidOperationException("SVG document does not have a root element.");
        }

        var nested = new XElement(source.Root);
        nested.SetAttributeValue("x", ToInvariantLength(offsetX));
        nested.SetAttributeValue("y", ToInvariantLength(offsetY));
        nested.SetAttributeValue("data-barcode", label);
        return nested;
    }

    private static double ParseLength(XAttribute? attribute, double fallback = 100d)
    {
        return ParseLength(attribute?.Value, fallback);
    }

    private static double ParseLength(string? rawValue, double fallback = 100d)
    {
        if (string.IsNullOrWhiteSpace(rawValue))
        {
            return fallback;
        }

        var buffer = new StringBuilder();
        foreach (char c in rawValue)
        {
            if (char.IsDigit(c) || c == '.' || c == '-')
            {
                buffer.Append(c);
            }
            else if (buffer.Length > 0)
            {
                break;
            }
        }

        return double.TryParse(buffer.ToString(), NumberStyles.Float, CultureInfo.InvariantCulture, out double parsed)
            ? parsed
            : fallback;
    }

    private static string ToInvariantLength(double value)
    {
        return value.ToString("0.##", CultureInfo.InvariantCulture);
    }
}
