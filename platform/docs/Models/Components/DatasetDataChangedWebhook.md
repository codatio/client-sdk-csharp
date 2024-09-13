# DatasetDataChangedWebhook

Webhook request body to notify that a data synchronization has completed.


## Fields

| Field                                                                                                                                                    | Type                                                                                                                                                     | Required                                                                                                                                                 | Description                                                                                                                                              | Example                                                                                                                                                  |
| -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ClientId`                                                                                                                                               | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | Unique identifier for your client in Codat.                                                                                                              |                                                                                                                                                          |
| `ClientName`                                                                                                                                             | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | Name of your client in Codat.                                                                                                                            |                                                                                                                                                          |
| `CompanyId`                                                                                                                                              | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | Unique identifier for your SMB in Codat.                                                                                                                 | 8a210b68-6988-11ed-a1eb-0242ac120002                                                                                                                     |
| `DataConnectionId`                                                                                                                                       | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | Unique identifier for a company's data connection.                                                                                                       | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                                                                                     |
| ~~`RuleId`~~                                                                                                                                             | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | : warning: ** DEPRECATED **: This will be removed in a future release, please migrate away from it as soon as possible.<br/><br/>Unique identifier for the rule. |                                                                                                                                                          |
| `RuleType`                                                                                                                                               | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | The type of rule.                                                                                                                                        |                                                                                                                                                          |
| `AlertId`                                                                                                                                                | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | Unique identifier of the webhook event.                                                                                                                  |                                                                                                                                                          |
| `Message`                                                                                                                                                | *string*                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                       | A human-readable message about the webhook.                                                                                                              |                                                                                                                                                          |
| `Data`                                                                                                                                                   | [DatasetDataChangedWebhookData](../../Models/Components/DatasetDataChangedWebhookData.md)                                                                | :heavy_minus_sign:                                                                                                                                       | N/A                                                                                                                                                      |                                                                                                                                                          |