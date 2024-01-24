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
        private async Task<string> FetchToken()
        {
            var formParams = new Dictionary<string, string>
            {
                ["grant_type"] = "client_credentials",
                // ReSharper disable once RedundantToStringCall
                ["client_id"] = TestConfiguration.ClientId.ToString(),
                // ReSharper disable once RedundantToStringCall
                ["client_secret"] = TestConfiguration.ClientSecret.ToString()
            };
            var formContent = new FormUrlEncodedContent(formParams);
            HttpResponseMessage response = await new HttpClient().PostAsync(TestConfiguration.TokenUrl, formContent);
            response.EnsureSuccessStatusCode();
            JObject json = JObject.Parse(await response.Content.ReadAsStringAsync());
            var accessToken = Convert.ToString(json["access_token"]);
            return accessToken;
        }


        [Test]
        public async Task CanUseExternalToken()
        {
            if (TestConfiguration.AuthType != AuthType.JWT)
            {
                Assert.Ignore($"Unsupported TestConfiguration.AuthType={TestConfiguration.AuthType}");
            }

            var configWithToken = new Configuration
            {
                ApiBaseUrl = TestConfiguration.ApiBaseUrl,
                TokenUrl = TestConfiguration.TokenUrl,
                JwtToken = await FetchToken()
            };

            var api = new BarcodeApi(configWithToken);
#pragma warning disable CS0612 // Method is obsolete
            using Stream generated = api.GetBarcodeGenerate(
                new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(), "Test")
                );
#pragma warning restore CS0612 // Method is obsolete
            Assert.Greater(generated.Length, 0);
        }

        [Test]
        public async Task CanUseExternalTokenWithAsync()
        {
            if (TestConfiguration.AuthType != AuthType.JWT)
            {
                Assert.Ignore($"Unsupported TestConfiguration.AuthType={TestConfiguration.AuthType}");
            }

            var configWithToken = new Configuration
            {
                ApiBaseUrl = TestConfiguration.ApiBaseUrl,
                TokenUrl = TestConfiguration.TokenUrl,
                JwtToken = await FetchToken()
            };

            var api = new BarcodeApi(configWithToken);
            using Stream generated = await api.GetBarcodeGenerateAsync(
                new GetBarcodeGenerateRequest(
                EncodeBarcodeType.QR.ToString(), "Test")
                );
            Assert.Greater(generated.Length, 0);
        }
    }
}
