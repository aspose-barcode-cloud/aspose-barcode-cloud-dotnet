using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class JwtAuthTests
    {
        [SetUp]
        public void Init()
        {
            using (StreamReader file = File.OpenText(Path.Combine("..", "..", "..", "Configuration.json")))
            {
                var serializer = new JsonSerializer();
                _config = (Configuration) serializer.Deserialize(file, typeof(Configuration));
            }
        }

        private Configuration _config;

        private async Task<string> FetchToken()
        {
            var url = $"{_config.ApiBaseUrl}/connect/token";
            var formParams = new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials",
                ["client_id"] = _config.AppSid,
                ["client_secret"] = _config.AppKey
            };
            var formContent = new FormUrlEncodedContent(formParams);
            HttpResponseMessage response = await new HttpClient().PostAsync(url, formContent);
            response.EnsureSuccessStatusCode();
            dynamic json = JObject.Parse(await response.Content.ReadAsStringAsync());
            string accessToken = Convert.ToString(json.access_token);
            return accessToken;
        }

        [Test]
        public async Task CanUseExternalToken()
        {
            var configWithToken = new Configuration
            {
                ApiBaseUrl = _config.ApiBaseUrl,
                JwtToken = await FetchToken()
            };

            var api = new BarcodeApi(configWithToken);
            using (Stream generated = api.GetBarcodeGenerate(new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(), "Test")))
            {
                Assert.Greater(generated.Length, 0);
            }
        }
    }
}
