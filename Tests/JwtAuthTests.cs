using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using Aspose.BarCode.Cloud.Sdk.Api;
using Aspose.BarCode.Cloud.Sdk.Model;

using Newtonsoft.Json.Linq;
using NUnit.Framework;

namespace Aspose.BarCode.Cloud.Sdk.Tests
{
    [TestFixture]
    public class JwtAuthTests : TestsBase
    {
        private async Task<string> FetchToken()
        {
            Dictionary<string, string> formParams = new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials",
                // ReSharper disable once RedundantToStringCall
                ["client_id"] = TestConfiguration.ClientId.ToString(),
                // ReSharper disable once RedundantToStringCall
                ["client_secret"] = TestConfiguration.ClientSecret.ToString()
            };
            FormUrlEncodedContent formContent = new FormUrlEncodedContent(formParams);
            HttpResponseMessage response = await new HttpClient().PostAsync(TestConfiguration.TokenUrl, formContent);
            response.EnsureSuccessStatusCode();
            JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());
            string accessToken = Convert.ToString(json["access_token"]);
            return accessToken;
        }

        [Test]
        public async Task CanUseExternalTokenWithAsync()
        {
            if (TestConfiguration.AuthType != AuthType.JWT)
            {
                Assert.Ignore($"Unsupported TestConfiguration.AuthType={TestConfiguration.AuthType}");
            }

            Configuration configWithToken = new Configuration
            {
                ApiBaseUrl = TestConfiguration.ApiBaseUrl,
                TokenUrl = TestConfiguration.TokenUrl,
                JwtToken = await FetchToken()
            };

            GenerateApi api = new GenerateApi(configWithToken);
            using Stream generated = await api.GenerateAsync(EncodeBarcodeType.QR, "Test");
            Assert.Greater(generated.Length, 0);
        }
    }
}
