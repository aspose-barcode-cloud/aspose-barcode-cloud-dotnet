using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;
using Aspose.BarCode.Cloud.Sdk.Model.Requests;
using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class JwtAuthTests : TestsBase
    {
        [SetUp]
        public void Init()
        {
        }

        private async Task<string> FetchToken()
        {
            var url = $"{TestConfiguration.ApiBaseUrl}/connect/token";
            var formParams = new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials",
                ["client_id"] = TestConfiguration.AppSid,
                ["client_secret"] = TestConfiguration.AppKey
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
                ApiBaseUrl = TestConfiguration.ApiBaseUrl,
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
