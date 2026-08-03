namespace RSSFeedReader.UI.Models;

public sealed class Subscription
{
    public string Id { get; set; } = string.Empty;

    public string FeedUrl { get; set; } = string.Empty;

    public DateTimeOffset CreatedAt { get; set; }
}
