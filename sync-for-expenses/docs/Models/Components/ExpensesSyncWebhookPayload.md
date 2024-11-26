# ExpensesSyncWebhookPayload


## Fields

| Field                                                                           | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `ReferenceCompany`                                                              | [CompanyReference](../../Models/Components/CompanyReference.md)                 | :heavy_minus_sign:                                                              | N/A                                                                             |
| `SyncId`                                                                        | *string*                                                                        | :heavy_minus_sign:                                                              | Unique identifier of the sync.                                                  |
| `Transactions`                                                                  | List<[DefinitionTransaction](../../Models/Components/DefinitionTransaction.md)> | :heavy_minus_sign:                                                              | N/A                                                                             |