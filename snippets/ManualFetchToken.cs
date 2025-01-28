using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Snippets;

internal static class Program
{
    public static async Task Main(string[] args)
    {
        var clientId = "Client Id from https://dashboard.aspose.cloud/applications";
        var clientSecret = "Client Secret from https://dashboard.aspose.cloud/applications";

        //Check the clientId is changed to not break github ci pipeline
        if(clientId.StartsWith("Client Id"))
        {
            Console.WriteLine("Client Id not changed. Skip this snippet test.");
            return;

        }
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

        var response = await client.PostAsync("connect/token", payload);
        response.EnsureSuccessStatusCode();

        var strData = await response.Content.ReadAsStringAsync();

        JsonNode data = JsonSerializer.Deserialize<JsonNode>(strData)!;

        Console.WriteLine("Token reciewed successfullly.");
        // Uncomment next line to view token
        // Console.WriteLine(data["access_token"]!.GetValue<string>());
    }
}
