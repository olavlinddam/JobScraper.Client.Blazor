using System.Text.Json.Serialization;

namespace JobScraper.Client.DTOs
{
    public class JobListingDto
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
