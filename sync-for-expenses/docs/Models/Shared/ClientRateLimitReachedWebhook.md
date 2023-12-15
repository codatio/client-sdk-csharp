# ClientRateLimitReachedWebhook

Webhook request body for a client that has reached their rate limit.


## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `AlertId`                                                                                     | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier of the webhook event.                                                       |
| `ClientId`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier for your client in Codat.                                                   |
| `ClientName`                                                                                  | *string*                                                                                      | :heavy_minus_sign:                                                                            | Name of your client in Codat.                                                                 |
| `Data`                                                                                        | [ClientRateLimitReachedWebhookData](../../Models/Shared/ClientRateLimitReachedWebhookData.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |
| `Message`                                                                                     | *string*                                                                                      | :heavy_minus_sign:                                                                            | A human readable message about the webhook.                                                   |
| `RuleId`                                                                                      | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier for the rule.                                                               |
| `RuleType`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | The type of rule.                                                                             |