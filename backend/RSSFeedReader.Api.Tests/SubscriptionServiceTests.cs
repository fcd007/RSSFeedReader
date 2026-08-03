using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Tests;

public class SubscriptionServiceTests
{
    [Fact]
    public void AddSubscription_AddsNewItemAndReturnsIt()
    {
        var service = new SubscriptionService();

        var result = service.AddSubscription("https://example.com/feed");

        Assert.NotNull(result);
        Assert.Equal("https://example.com/feed", result.FeedUrl);
        Assert.Contains(service.GetSubscriptions(), item => item.FeedUrl == "https://example.com/feed");
    }

    [Fact]
    public void AddSubscription_RejectsDuplicateFeedUrl()
    {
        var service = new SubscriptionService();

        service.AddSubscription("https://example.com/feed");
        var duplicate = service.AddSubscription("https://example.com/feed");

        Assert.Null(duplicate);
        Assert.Single(service.GetSubscriptions());
    }

    [Fact]
    public void AddSubscription_RejectsEmptyOrWhitespaceFeedUrl()
    {
        var service = new SubscriptionService();

        var result = service.AddSubscription("   ");

        Assert.Null(result);
        Assert.Empty(service.GetSubscriptions());
    }
}
