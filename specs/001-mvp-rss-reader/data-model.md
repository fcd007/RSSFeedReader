# Data Model: MVP RSS Reader

## Entities

### Subscription
- **Id**: Unique identifier for the subscription
- **FeedUrl**: The URL provided by the user
- **CreatedAt**: Timestamp for when the subscription was added

### SubscriptionList
- **Items**: A collection of subscriptions currently available in the session

## Relationships

- A subscription list contains zero or more subscriptions.
- Each subscription belongs to exactly one active list for the current session.

## Validation Rules

- Feed URL must be non-empty.
- Duplicate feed URLs should be rejected in the same session.
