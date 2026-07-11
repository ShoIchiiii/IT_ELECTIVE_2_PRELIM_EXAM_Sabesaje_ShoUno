using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises;

public static class UpdateReview
{
    public static async Task Run(HttpClient client)
    {
        // API endpoint
        string url = "https://jsonplaceholder.typicode.com/posts/1";

        // Correct JSON string (proper quotes)
        string jsonBody = @"{""id"": 1, ""title"": ""Updated"", ""body"": ""Even better than before!"", ""userId"": 1}";

        // Create content with correct media type
        var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

        // Send PUT request
        var response = await client.PutAsync(url, content);

        // Check status code
        if (response.StatusCode != HttpStatusCode.OK)
        {
            throw new Exception($"Expected 200 OK, got {response.StatusCode}");
        }

        // Read and parse response
        string responseJson = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(responseJson);

        // Get title and verify
        string title = doc.RootElement.GetProperty("title").GetString() ?? "";
        if (title != "Updated")
        {
            throw new Exception($"Expected title 'Updated', got '{title}'");
        }
    }
}