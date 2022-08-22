using System;
using System.Collections.Specialized;
using System.Web;

namespace Aspose.BarCode.Cloud.Sdk.Internal
{
    internal static class UrlHelper
    {
        public static string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            if (parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString()))
            {
                url = url.Replace("/{" + parameterName + "}", string.Empty);
            }
            else
            {
                url = url.Replace("{" + parameterName + "}", parameterValue.ToString());
            }

            return url;
        }

        public static string AddQueryParameterToUrl(string url, string parameterName, object parameterValue)
        {
            if (url.Contains("{" + parameterName + "}"))
            {
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (url.Contains("%7B" + parameterName + "%7D"))
            {
                url = url.Replace("%7B", "{").Replace("%7D", "}");
                url = AddPathParameter(url, parameterName, parameterValue);
                return url;
            }

            if (parameterValue == null)
            {
                return url;
            }

            var uriBuilder = new UriBuilder(url);
            NameValueCollection query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query.Add(parameterName, parameterValue.ToString());
            uriBuilder.Query = query.ToString();

            return uriBuilder.ToString();
        }
    }
}
