using System.IO;
using System.Text;

namespace Aspose.BarCode.Cloud.Sdk.Internal
{
    internal static class StreamHelper
    {
        public static void CopyTo(Stream source, Stream destination, int bufferSize = 81920)
        {
            if (source.CanSeek)
            {
                source.Flush();
                source.Position = 0;
            }

            byte[] array = new byte[bufferSize];
            int count;
            while ((count = source.Read(array, 0, array.Length)) != 0)
            {
                destination.Write(array, 0, count);
            }
        }

        public static byte[] ReadAsBytes(Stream input)
        {
            byte[] buffer = new byte[16 * 1024];
            using (MemoryStream ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }

                return ms.ToArray();
            }
        }

        public static void CopyStreamToStringBuilder(StringBuilder sb, Stream stream)
        {
            if (stream == null || !stream.CanRead)
            {
                return;
            }

            Stream streamToRead;
            if (!stream.CanSeek)
            {
                streamToRead = new MemoryStream(1024);
                CopyTo(stream, streamToRead);
            }
            else
            {
                streamToRead = stream;
            }

            streamToRead.Seek(0, SeekOrigin.Begin);
            StreamReader bodyReader = new StreamReader(streamToRead);
            if (bodyReader.Peek() != -1)
            {
                string content = bodyReader.ReadToEnd();
                streamToRead.Seek(0, SeekOrigin.Begin);

                sb.AppendLine("Body:");
                sb.AppendLine(content);
            }
        }
    }
}
