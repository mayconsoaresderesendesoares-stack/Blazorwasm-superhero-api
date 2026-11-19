using System.Text.Json.Serialization;

namespace BlazorWasmSuperHeroApi.Models
{
    public class SuperHeroResponse
    {
        [JsonPropertyName("response")]
        public string Response { get; set; } = string.Empty;

        [JsonPropertyName("results-for")]
        public string ResultsFor { get; set; } = string.Empty;

        [JsonPropertyName("results")]
        public List<SuperHero>? Results { get; set; }
    }

    public class SuperHero
    {
        [JsonPropertyName("id")]
        public string Id { get; set; } = string.Empty;

        [JsonPropertyName("name")]
        public string Name { get; set; } = string.Empty;

        [JsonPropertyName("powerstats")]
        public Powerstats Powerstats { get; set; } = new();

        [JsonPropertyName("biography")]
        public Biography Biography { get; set; } = new();

        [JsonPropertyName("image")]
        public ImageInfo Image { get; set; } = new();
    }

    public class Powerstats
    {
        [JsonPropertyName("intelligence")]
        public string Intelligence { get; set; } = string.Empty;

        [JsonPropertyName("strength")]
        public string Strength { get; set; } = string.Empty;

        [JsonPropertyName("speed")]
        public string Speed { get; set; } = string.Empty;

        [JsonPropertyName("combat")]
        public string Combat { get; set; } = string.Empty;
    }

    public class Biography
    {
        [JsonPropertyName("full-name")]
        public string FullName { get; set; } = string.Empty;

        [JsonPropertyName("first-appearance")]
        public string FirstAppearance { get; set; } = string.Empty;

        [JsonPropertyName("publisher")]
        public string Publisher { get; set; } = string.Empty;
    }

    public class ImageInfo
    {
        [JsonPropertyName("url")]
        public string Url { get; set; } = string.Empty;
    }
}