
using AdSystem.Models;

namespace AdSystem.Services;
public class WebApiClient
{
	private readonly HttpClient _httpClient;

	public WebApiClient(HttpClient httpClient)
	{
		_httpClient = httpClient;
	}

	// Get subscriber information by subscriber ID
	public async Task<SubscriberResponse?> GetSubscriberIDAsync(string subscriberID)
    {
        var response = await _httpClient.GetAsync($"api/subscribers/{subscriberID}");
        if (!response.IsSuccessStatusCode){
            return null;
		}

        return await response.Content.ReadFromJsonAsync<SubscriberResponse>();
    }
}