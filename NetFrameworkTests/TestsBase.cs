using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aspose.BarCode.Cloud.Sdk.Api;
using System.Text.Json;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    public class TestsBase
    {
        private const string ENV_NAME_PREFIX = "TEST_CONFIGURATION_";

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
            string configFilename = Path.GetFullPath(Path.Combine(
                TestContext.CurrentContext.TestDirectory,
                "..", "..", "..",
                "Configuration.json"));
            if (File.Exists(configFilename))
            {
                using FileStream file = File.OpenRead(configFilename);
                return JsonSerializer.Deserialize<Configuration>(file)
                    ?? throw new Exception("Configuration file is empty or invalid");
            }
            Configuration config = LoadFromEnv();
            return config;
        }

        private static Configuration LoadFromEnv()
        {
            // Serialize default config to JSON then to a dictionary
            string jsonStr = JsonSerializer.Serialize(new Configuration());
            var dict = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonStr);

            if (dict == null)
                throw new Exception("Default configuration invalid");

            foreach (var key in new List<string>(dict.Keys))
            {
                var value = dict[key];

                // Accept strings and nulls (JSON null becomes null here)
                if (value != null && !(value is string))
                    continue;

                string envName = $"{ENV_NAME_PREFIX}{CamelCaseToUpper(key)}";
                string envValue = Environment.GetEnvironmentVariable(envName);
                if (!string.IsNullOrEmpty(envValue))
                {
                    dict[key] = envValue;
                }
            }
            // Serialize back and then deserialize to Configuration
            string updatedJson = JsonSerializer.Serialize(dict);
            var config = JsonSerializer.Deserialize<Configuration>(updatedJson);
            if (config == null)
                throw new Exception("Failed to create Configuration from environment variables");
            return config;
        }

        private static string CamelCaseToUpper(string name)
        {
            StringBuilder result = new StringBuilder();
            bool prevCharWasLower = false;
            foreach (char c in name)
            {
                if (char.IsUpper(c))
                {
                    if (prevCharWasLower)
                    {
                        result.Append('_');
                    }
                }

                result.Append(char.ToUpperInvariant(c));

                prevCharWasLower = char.IsLower(c);
            }

            return result.ToString();
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
