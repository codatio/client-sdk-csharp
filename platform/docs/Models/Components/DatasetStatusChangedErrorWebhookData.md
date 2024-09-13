# DatasetStatusChangedErrorWebhookData


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `DataType`                                                        | [PropertieDataType](../../Models/Components/PropertieDataType.md) | :heavy_minus_sign:                                                | Available data types                                              | invoices                                                          |
| `DatasetStatus`                                                   | *string*                                                          | :heavy_minus_sign:                                                | The current status of the dataset's sync.                         |                                                                   |
| `DatasetId`                                                       | *string*                                                          | :heavy_minus_sign:                                                | Unique identifier for the dataset that completed its sync.        |                                                                   |