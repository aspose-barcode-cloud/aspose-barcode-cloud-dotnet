using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AuthSnippets;

internal static class Program
{
public static async Task Main(string[] args)
{
    var clientId = "Client Id from https://dashboard.aspose.cloud/applications";
    var clientSecret = "Client Secret from https://dashboard.aspose.cloud/applications";

    using var client = new HttpClient
    {
        BaseAddress = new Uri("https://id.aspose.cloud/")
    };

    var payload = new FormUrlEncodedContent(new[]
    {
        new KeyValuePair<string, string>("grant_type", "client_credentials"),
        new KeyValuePair<string, string>("client_id", clientId),
        new KeyValuePair<string, string>("client_secret", clientSecret)
    });

    try
    {
        var response = await client.PostAsync("connect/token", payload);
        response.EnsureSuccessStatusCode();

        var data = await response.Content.ReadAsStringAsync();
        Console.WriteLine(data);
    }
    catch (HttpRequestException ex)
    {
        Console.WriteLine($"Request error: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"An unexpected error occurred: {ex.Message}");
    }
}
}