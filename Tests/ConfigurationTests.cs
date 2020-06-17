using System.Collections.Generic;
using System.IO;
using Aspose.BarCode.Cloud.Sdk.Api;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class ConfigurationTests
    {
        private readonly Dictionary<string, string> _headers = new Dictionary<string, string>
            { ["User-Agent"] = "Awesome SDK" };

        [Test]
        public void CanChangeApiBaseUrl()
        {
            var config = new Configuration
            {
                ApiBaseUrl = "http://localhost:12345"
            };

            Assert.AreEqual("http://localhost:12345/v3.0", config.GetApiRootUrl());
        }

        [Test]
        public void CanChangeDefaultHeaders()
        {
            // ReSharper disable once UseObjectOrCollectionInitializer
            var config = new Configuration();
            config.DefaultHeaders["User-Agent"] = "Awesome SDK";

            Assert.AreEqual("Awesome SDK", config.DefaultHeaders["User-Agent"]);
        }


        [Test]
        public void CanSetAuthTypeAndTokenTest()
        {
            var config = new Configuration { JwtToken = "Test JWT token" };

            Assert.AreEqual("Test JWT token", config.JwtToken);
            Assert.AreEqual(AuthType.ExternalAuth, config.AuthType);
        }

        [Test]
        public void CanSetDebugMode()
        {
            var config = new Configuration
            {
                DebugMode = true
            };

            Assert.AreEqual(true, config.DebugMode);
        }

        [Test]
        public void CanSetDefaultHeaders()
        {
            var config = new Configuration
            {
                DefaultHeaders = _headers
            };

            Assert.AreEqual("Awesome SDK", config.DefaultHeaders["User-Agent"]);
        }

        [Test]
        public void DefaultParamsTest()
        {
            var config = new Configuration();

            Assert.AreEqual("https://api.aspose.cloud", config.ApiBaseUrl);
            Assert.AreEqual("https://api.aspose.cloud/v3.0", config.GetApiRootUrl());
            Assert.AreEqual(false, config.DebugMode);
        }

        [Test]
        public void DeserializeTest()
        {
            Configuration config;
            using (StreamReader file = File.OpenText(Path.Combine("..", "..", "..", "Configuration.template.json")))
            {
                var serializer = new JsonSerializer();
                config = (Configuration) serializer.Deserialize(file, typeof(Configuration));
            }

            Assert.AreEqual("Test.AppKey", config.AppKey);
            Assert.AreEqual("Test.AppSid", config.AppSid);
            Assert.AreEqual(AuthType.JWT, config.AuthType);
        }

        [Test]
        public void GetApiVersionTest()
        {
            var config = new Configuration();

            Assert.AreEqual("3.0", config.ApiVersion);
        }
    }
}
