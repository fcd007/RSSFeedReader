using RSSFeedReader.Api.Models;

namespace RSSFeedReader.Api.Services;

public sealed class SubscriptionService
{
    private readonly List<Subscription> _subscriptions = [];

    public Subscription? AddSubscription(string? feedUrl)
    {
        if (string.IsNullOrWhiteSpace(feedUrl))
        {
            return null;
        }

        var normalizedUrl = feedUrl.Trim();

        if (_subscriptions.Any(subscription => subscription.FeedUrl.Equals(normalizedUrl, StringComparison.OrdinalIgnoreCase)))
        {
            return null;
        }

        var subscription = new Subscription(Guid.NewGuid().ToString("N"), normalizedUrl, DateTimeOffset.UtcNow);
        _subscriptions.Add(subscription);
        return subscription;
    }

    public IReadOnlyList<Subscription> GetSubscriptions() => _subscriptions.AsReadOnly();
}
