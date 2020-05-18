using System;
using System.IO;

namespace Tests
{
    public class TestsBase
    {
        /// <summary>
        ///     Temp folder path
        /// </summary>
        protected static readonly string TempFolderPath = Path.Combine(
            "BarcodeTests",
            Guid.NewGuid().ToString()
        ).Replace("\\", "/");

        protected static string TestFilePath(string fileName)
        {
            return Path.Combine("..", "..", "..", "test_data", fileName);
        }

        protected static Stream GetTestImage(string fileName)
        {
            string filePath = TestFilePath(fileName);
            return File.Open(filePath, FileMode.Open, FileAccess.Read);
        }
    }
}
