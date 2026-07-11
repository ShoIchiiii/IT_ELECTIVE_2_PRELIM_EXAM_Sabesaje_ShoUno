using System;
using System.Net;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace IT_ELECTIVE_2_PRELIM_EXAM_HttpClient.Exercises;

public static class FilterByIngredient
{
    public static async Task Run(HttpClient client)
    {
        // ✅ Correct URL
        string url = "https://www.themealdb.com/api/json/v1/1/filter.php?i=chicken_breast";
        var response = await client.GetAsync(url);

        if (response.StatusCode != HttpStatusCode.OK)
            throw new Exception($"Expected 200 OK, got {response.StatusCode}");

        string json = await response.Content.ReadAsStringAsync();
        using var doc = JsonDocument.Parse(json);
        var meals = doc.RootElement.GetProperty("meals");

        if (meals.ValueKind != JsonValueKind.Array || meals.GetArrayLength() < 1)
            throw new Exception("No meals found for chicken breast");
    }
}