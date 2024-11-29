using System;
using System.Collections;
using System.Collections.Specialized;
using System.Web;

namespace Aspose.BarCode.Cloud.Sdk.Internal
{
    internal static class UrlHelper
    {
        public static string AddPathParameter(string url, string parameterName, object parameterValue)
        {
            url = parameterValue == null || string.IsNullOrEmpty(parameterValue.ToString())
                ? url.Replace("/{" + parameterName + "}", string.Empty)
                : url.Replace("{" + parameterName + "}", parameterValue.ToString());

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

            UriBuilder uriBuilder = new UriBuilder(url);
            NameValueCollection query = HttpUtility.ParseQueryString(uriBuilder.Query);

            if (parameterValue is string stringValue)
            {
                query.Add(parameterName, stringValue);
            }
            else if (parameterValue is ICollection collection)
            {
                foreach (object item in collection)
                {
                    query.Add(parameterName, item.ToString());
                }
            }
            else
            {
                query.Add(parameterName, parameterValue.ToString());
            }

            uriBuilder.Query = query.ToString();

            return uriBuilder.ToString();
        }
    }
}
