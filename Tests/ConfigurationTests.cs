﻿using System.IO;
using Aspose.BarCode.Cloud.Sdk;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConfigurationTests
    {

        [Test]
        public void DefaultParamsTest()
        {
            var config = new Configuration();
            
            Assert.AreEqual("https://api.aspose.cloud", config.ApiBaseUrl);
            Assert.AreEqual("https://api.aspose.cloud/v3.0", config.GetApiRootUrl());
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
        }


        [Test]
        public void CanSetAuthTypeAndTokenTest()
        {
            var config = new Configuration {JwtToken = "Test JWT token"};
            
            Assert.AreEqual("Test JWT token", config.JwtToken);
        }
    }
}