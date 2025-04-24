using System.Collections.Generic;
using System.IO;
using Aspose.BarCode.Cloud.Sdk.Api;
using System.Text.Json;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class ConfigurationTests
    {
        private readonly Dictionary<string, string> _headers = new Dictionary<string, string>
        {
            ["User-Agent"] = "Awesome SDK"
        };


        [Test]
        public void CanChangeApiBaseUrl()
        {
            Configuration config = new Configuration
            {
                ApiBaseUrl = "http://localhost:47972"
            };

            Assert.AreEqual("http://localhost:47972/v4.0", config.GetApiRootUrl());
        }


        [Test]
        public void CanChangeDefaultHeaders()
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            Configuration config = new Configuration();
            config.DefaultHeaders["User-Agent"] = "Awesome SDK";

            Assert.AreEqual("Awesome SDK", config.DefaultHeaders["User-Agent"]);
        }


        [Test]
        public void CanSetAuthTypeAndTokenTest()
        {
            Configuration config = new Configuration
            {
                JwtToken = "Test JWT token"
            };

            Assert.AreEqual("Test JWT token", config.JwtToken);
            Assert.AreEqual(AuthType.ExternalAuth, config.AuthType);
        }


        [Test]
        public void CanSetDebugMode()
        {
            Configuration config = new Configuration
            {
                DebugMode = true
            };

            Assert.AreEqual(true, config.DebugMode);
        }


        [Test]
        public void CanSetDefaultHeaders()
        {
            Configuration config = new Configuration
            {
                DefaultHeaders = _headers
            };

            Assert.AreEqual("Awesome SDK", config.DefaultHeaders["User-Agent"]);
        }


        [Test]
        public void DefaultParamsTest()
        {
            Configuration config = new Configuration();

            Assert.AreEqual("https://api.aspose.cloud", config.ApiBaseUrl);
            Assert.AreEqual("https://api.aspose.cloud/v4.0", config.GetApiRootUrl());
            Assert.AreEqual("https://id.aspose.cloud/connect/token", config.TokenUrl);
            Assert.AreEqual(false, config.DebugMode);
        }


        [Test]
        public void DeserializeTest()
        {
            using FileStream file = File.OpenRead(Path.Combine(
                TestContext.CurrentContext.TestDirectory,
                "..", "..", "..",
                "Configuration.template.json"));
            var config = JsonSerializer.Deserialize<Configuration>(file);

            Assert.IsNotNull(config);
            Assert.AreEqual("Client Secret from https://dashboard.aspose.cloud/applications", config.ClientSecret);
            Assert.AreEqual("Client Id from https://dashboard.aspose.cloud/applications", config.ClientId);
            Assert.AreEqual(AuthType.JWT, config.AuthType);
        }


        [Test]
        public void GetApiVersionTest()
        {
            Configuration config = new Configuration();

            Assert.AreEqual("4.0", config.ApiVersion);
        }


        [Test]
        public void SerializationTest()
        {
            Configuration config = new Configuration();

            Assert.AreEqual(
                "{\"" +
                "ApiBaseUrl\":\"https://api.aspose.cloud\",\"" +
                "TokenUrl\":\"https://id.aspose.cloud/connect/token\",\"" +
                "ClientSecret\":null,\"" +
                "ClientId\":null,\"" +
                "JwtToken\":null,\"" +
                "DebugMode\":false,\"" +
                "AuthType\":\"JWT\",\"" +
                "ApiVersion\":\"4.0\",\"" +
                "DefaultHeaders\":{}" +
                "}",
                JsonSerializer.Serialize(config));
        }
    }
}
