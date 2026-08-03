using Microsoft.AspNetCore.Mvc;
using RSSFeedReader.Api.Models;
using RSSFeedReader.Api.Services;

namespace RSSFeedReader.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public sealed class SubscriptionsController : ControllerBase
{
    private readonly SubscriptionService _subscriptionService;

    public SubscriptionsController(SubscriptionService subscriptionService)
    {
        _subscriptionService = subscriptionService;
    }

    [HttpGet]
    public ActionResult<IReadOnlyList<Subscription>> GetSubscriptions()
    {
        return Ok(_subscriptionService.GetSubscriptions());
    }

    [HttpPost]
    public IActionResult AddSubscription([FromBody] SubscriptionRequest request)
    {
        if (string.IsNullOrWhiteSpace(request.FeedUrl))
        {
            return BadRequest(new { error = "Feed URL is required." });
        }

        var subscription = _subscriptionService.AddSubscription(request.FeedUrl);

        if (subscription is null)
        {
            return Conflict(new { error = "Subscription already exists." });
        }

        return CreatedAtAction(nameof(GetSubscriptions), new { id = subscription.Id }, subscription);
    }
}

public sealed class SubscriptionRequest
{
    public string? FeedUrl { get; set; }
}
