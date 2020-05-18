using System.IO;
using Aspose.BarCode.Cloud.Sdk.Internal;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ConfigurationTests
    {
        [Test]
        public void DefaultConstructorTest()
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
        public void CustomHeadersAppliedTest()
        {
            Assert.Fail("Not implemented");
        }
    }
}
