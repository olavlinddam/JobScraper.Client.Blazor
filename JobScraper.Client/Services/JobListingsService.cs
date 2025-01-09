using System.Text.Json;
using JobScraper.Client.DTOs;

namespace JobScraper.Client.Services;

public class JobListingsService
{
    private readonly HttpClient _httpClient;

    public JobListingsService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<JobListingDto>> GetJobListings()
    {
        var response = await _httpClient.GetAsync("api/JobListing/job-listings");

        if (response.IsSuccessStatusCode)
        {
            var content = await response.Content.ReadAsStringAsync();
            var listings = JsonSerializer.Deserialize<List<JobListingDto>>(content) ?? [];
            return listings;
        }

        throw new HttpRequestException($"Error: {response.StatusCode}");
    }
}