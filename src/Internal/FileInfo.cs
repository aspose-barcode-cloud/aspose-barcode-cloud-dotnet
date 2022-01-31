using System.Net.Mime;

namespace Aspose.BarCode.Cloud.Sdk.Internal
{
    internal struct FileInfo
    {
        public FileInfo(string name, byte[] fileContent)
            : this()
        {
            Name = name;
            FileContent = fileContent;
            MimeType = MediaTypeNames.Application.Octet;
        }

        public string Name { get; set; }

        public string MimeType { get; set; }

        public byte[] FileContent { get; set; }
    }
}
