# NewCompanySynchronizedWebhook

Webhook request body to notify that a new company has successfully synchronized at least one dataType for the first time.


## Fields

| Field                                                                                         | Type                                                                                          | Required                                                                                      | Description                                                                                   | Example                                                                                       |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `AlertId`                                                                                     | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier of the webhook event.                                                       |                                                                                               |
| `ClientId`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier for your client in Codat.                                                   |                                                                                               |
| `ClientName`                                                                                  | *string*                                                                                      | :heavy_minus_sign:                                                                            | Name of your client in Codat.                                                                 |                                                                                               |
| `CompanyId`                                                                                   | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier for your SMB in Codat.                                                      | 8a210b68-6988-11ed-a1eb-0242ac120002                                                          |
| `Data`                                                                                        | [NewCompanySynchronizedWebhookData](../../Models/Shared/NewCompanySynchronizedWebhookData.md) | :heavy_minus_sign:                                                                            | N/A                                                                                           |                                                                                               |
| `DataConnectionId`                                                                            | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier for a company's data connection.                                            | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                          |
| `Message`                                                                                     | *string*                                                                                      | :heavy_minus_sign:                                                                            | A human readable message about the webhook.                                                   |                                                                                               |
| `RuleId`                                                                                      | *string*                                                                                      | :heavy_minus_sign:                                                                            | Unique identifier for the rule.                                                               |                                                                                               |
| `RuleType`                                                                                    | *string*                                                                                      | :heavy_minus_sign:                                                                            | The type of rule.                                                                             |                                                                                               |