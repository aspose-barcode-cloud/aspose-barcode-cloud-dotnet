using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Aspose.BarCode.Cloud.Sdk.Api;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    public class TestsBase
    {
        private const string EnvNamePrefix = "TEST_CONFIGURATION_";

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
            var configFilename = Path.Combine("..", "..", "..", "Configuration.json");
            if (File.Exists(configFilename))
            {
                using (StreamReader file = File.OpenText(configFilename))
                {
                    var serializer = new JsonSerializer();
                    return (Configuration) serializer.Deserialize(file, typeof(Configuration));
                }
            }

            var jsonStr = JsonConvert.SerializeObject(new Configuration());
            JObject obj = JObject.Parse(jsonStr);
            foreach (KeyValuePair<string, JToken> i in obj)
            {
                if (!(i.Value.Type == JTokenType.String || i.Value.Type == JTokenType.Null))
                {
                    continue;
                }

                var name = i.Key;
                var envName = $"{EnvNamePrefix}{CamelCaseToUpper(name)}";
                var envValue = Environment.GetEnvironmentVariable(envName);
                if (!string.IsNullOrEmpty(envValue))
                {
                    obj[name] = envValue;
                }
            }

            return JsonConvert.DeserializeObject<Configuration>(obj.ToString());
        }

        private static string CamelCaseToUpper(string name)
        {
            var result = new StringBuilder();
            var prevCharWasLower = false;
            foreach (var c in name)
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
            return Path.Combine("..", "..", "..", "test_data", fileName);
        }

        protected static Stream GetTestImage(string fileName)
        {
            var filePath = TestFilePath(fileName);
            return File.Open(filePath, FileMode.Open, FileAccess.Read);
        }
    }
}
