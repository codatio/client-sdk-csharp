# PushOperationTimedOutWebhookData


## Fields

| Field                                                                                                                                                                 | Type                                                                                                                                                                  | Required                                                                                                                                                              | Description                                                                                                                                                           | Example                                                                                                                                                               |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `DataType`                                                                                                                                                            | [Models.Shared.DataType](../../Models/Shared/DataType.md)                                                                                                             | :heavy_minus_sign:                                                                                                                                                    | Available Data types                                                                                                                                                  | invoices                                                                                                                                                              |
| `PushOperationGuid`                                                                                                                                                   | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted. |                                                                                                                                                                       |
| `PushOperationKey`                                                                                                                                                    | *string*                                                                                                                                                              | :heavy_minus_sign:                                                                                                                                                    | A unique identifier generated by Codat to represent this single push operation. This identifier can be used to track the status of the push, and should be persisted. |                                                                                                                                                                       |