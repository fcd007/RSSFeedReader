# Subscription API Contract

## Endpoints

### POST /api/subscriptions
Adds a new subscription to the in-memory list.

#### Request body
```json
{
  "feedUrl": "https://example.com/feed"
}
```

#### Success response
```json
{
  "id": "1",
  "feedUrl": "https://example.com/feed"
}
```

#### Validation response
```json
{
  "error": "Feed URL is required."
}
```

### GET /api/subscriptions
Returns the current list of subscriptions.

#### Success response
```json
[
  {
    "id": "1",
    "feedUrl": "https://example.com/feed"
  }
]
```
