namespace RSSFeedReader.Api.Models;

public sealed class Subscription
{
    public Subscription(string id, string feedUrl, DateTimeOffset createdAt)
    {
        Id = id;
        FeedUrl = feedUrl;
        CreatedAt = createdAt;
    }

    public string Id { get; }

    public string FeedUrl { get; }

    public DateTimeOffset CreatedAt { get; }
}
