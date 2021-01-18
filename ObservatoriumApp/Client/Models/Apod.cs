using System;
using System.Text.Json.Serialization;

namespace ObservatoriumApp.Client.Models
{
    public class Apod
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("url")]
        public string ImageUrl { get; set; }

        [JsonPropertyName("hdurl")]
        public string HdUrl { get; set; }

        [JsonPropertyName("explanation")]
        public string Description { get; set; }

        [JsonPropertyName("thumbnail_url")]
        public string ThumbnailUrl { get; set; }

        [JsonPropertyName("copyright")]
        public string Copyright { get; set; }
    }
}
