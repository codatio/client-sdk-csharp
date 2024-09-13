# PushOperationTimedOutWebhookData


## Fields

| Field                                                                                                                                                                 | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `DataType`                                                                                                                                                            | [PropertieDataType](../../Models/Components/PropertieDataType.md)                                                                                                     | :heavy_minus_sign:                                                                                                                                                    | Available data types                                                                                                                                                  | invoices                                                                                                                                                              |
| `PushOperationKey`                                                                                                                                                    | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted. |                                                                                                                                                                       |
| `PushOperationGuid`                                                                                                                                                   | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted. |                                                                                                                                                                       |