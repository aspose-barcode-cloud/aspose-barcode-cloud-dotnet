using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Aspose.BarCode.Cloud.Sdk.Api
{
    /// <summary>
    ///     Represents a set of configuration settings
    /// </summary>
    public class Configuration
    {
        /// <summary>
        ///     Default constructor
        /// </summary>
        public Configuration()
        {
            ApiBaseUrl = "https://api.aspose.cloud";
            DebugMode = false;
            ApiVersion = "4.0";
            AuthType = AuthType.JWT;
            TokenUrl = "https://id.aspose.cloud/connect/token";
            DefaultHeaders = new Dictionary<string, string>();
        }

        /// <summary>
        ///     Aspose Cloud API base URL.
        /// </summary>
        public string ApiBaseUrl { get; set; }

        /// <summary>
        ///     Aspose Cloud API auth URL.
        /// </summary>
        public string TokenUrl { get; set; }

        /// <summary>
        ///     Gets or sets the Client Secret.
        /// </summary>
        public string ClientSecret { get; set; }

        /// <summary>
        ///     Gets or sets the Client Id.
        /// </summary>
        public string ClientId { get; set; }

        /// <summary>
        ///     Gets or sets the Jwt token.
        ///     If set the library would handle auth internally
        /// </summary>
        public string JwtToken
        {
            get => _jwtToken;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    return;
                }

                AuthType = AuthType.ExternalAuth;
                _jwtToken = value;
            }
        }


        /// <summary>
        ///     Gets or sets a value indicating whether debug mode.
        /// </summary>
        public bool DebugMode { get; set; }

        /// <summary>
        ///     Authentication type.
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public AuthType AuthType { get; private set; }

        /// <summary>
        ///     Get or sets Cloud API Version.
        /// </summary>
        public string ApiVersion { get; }

        /// <summary>
        ///     Gets or sets HTTP headers
        /// </summary>
        public Dictionary<string, string> DefaultHeaders { get; set; }

        /// <summary>
        ///     Get API root url
        /// </summary>
        public string GetApiRootUrl()
        {
            string result = ApiBaseUrl + "/v" + ApiVersion;

            return result.EndsWith("/", StringComparison.InvariantCulture) ? result.Substring(0, result.Length - 1) : result;
        }

        private string _jwtToken;
    }
}
