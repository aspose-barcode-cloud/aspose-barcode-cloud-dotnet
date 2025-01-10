using System;
using System.IO;
using Aspose.BarCode.Cloud.Sdk.Api;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
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

        protected TestsBase()
        {
            TestConfiguration = LoadTestConfiguration();
        }

        internal Configuration TestConfiguration { get; }

        private static Configuration LoadTestConfiguration()
        {
            return LoadFromEnv() ?? LoadFromFile() ?? throw new Exception("Unable to load test configuration");
        }

        private static Configuration? LoadFromFile()
        {
            string configFilename = Path.GetFullPath(Path.Combine(
                TestContext.CurrentContext.TestDirectory,
                "..", "..", "..",
                "Configuration.json"));
            if (File.Exists(configFilename))
            {
                using StreamReader file = File.OpenText(configFilename);
                using var reader = new JsonTextReader(file);
                var serializer = new JsonSerializer();
                return serializer.Deserialize<Configuration>(reader);
            }

            return null;
        }

        private static Configuration? LoadFromEnv()
        {
            string? maybeToken = Environment.GetEnvironmentVariable("TEST_CONFIGURATION_JWT_TOKEN");
            if (!string.IsNullOrEmpty(maybeToken))
            {
                return new Configuration
                {
                    JwtToken = maybeToken
                };
            }

            return null;
        }

        protected static string TestFilePath(string fileName)
        {
            return Path.GetFullPath(Path.Combine(
                TestContext.CurrentContext.TestDirectory,
                "..", "..", "..",
                "test_data",
                fileName));
        }

        protected static Stream GetTestImage(string fileName)
        {
            string filePath = TestFilePath(fileName);
            return File.Open(filePath, FileMode.Open, FileAccess.Read);
        }
    }
}
