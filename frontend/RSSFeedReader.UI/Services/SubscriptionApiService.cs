using System.Net.Http.Json;
using RSSFeedReader.UI.Models;

namespace RSSFeedReader.UI.Services;

public sealed class SubscriptionApiService(HttpClient httpClient)
{
    public async Task<IReadOnlyList<Subscription>> GetSubscriptionsAsync()
    {
        return await httpClient.GetFromJsonAsync<List<Subscription>>("subscriptions") ?? [];
    }

    public async Task<Subscription?> AddSubscriptionAsync(string feedUrl)
    {
        var response = await httpClient.PostAsJsonAsync("subscriptions", new { feedUrl });

        if (!response.IsSuccessStatusCode)
        {
            return null;
        }

        return await response.Content.ReadFromJsonAsync<Subscription>();
    }
}
