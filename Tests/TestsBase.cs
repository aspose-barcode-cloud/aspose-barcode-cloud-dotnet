using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aspose.BarCode.Cloud.Sdk.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
                using StreamReader file = File.OpenText(configFilename);
                using JsonTextReader reader = new JsonTextReader(file);
                JsonSerializer serializer = new JsonSerializer();
                return serializer.Deserialize<Configuration>(reader);
            }

            Configuration config = LoadFromEnv();

            return config;
        }

        private static Configuration LoadFromEnv()
        {
            string jsonStr = JsonConvert.SerializeObject(new Configuration());
            JObject obj = JObject.Parse(jsonStr);
            foreach (KeyValuePair<string, JToken> i in obj)
            {
                if (!(i.Value.Type == JTokenType.String || i.Value.Type == JTokenType.Null))
                {
                    continue;
                }

                string name = i.Key;
                string envName = $"{ENV_NAME_PREFIX}{CamelCaseToUpper(name)}";
                string envValue = Environment.GetEnvironmentVariable(envName);
                if (!string.IsNullOrEmpty(envValue))
                {
                    obj[name] = envValue;
                }
            }

            return JsonConvert.DeserializeObject<Configuration>(obj.ToString());
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
