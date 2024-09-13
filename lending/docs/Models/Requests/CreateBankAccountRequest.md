# CreateBankAccountRequest


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               | Example                                                                   |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `CompanyId`                                                               | *string*                                                                  | :heavy_check_mark:                                                        | Unique identifier for a company.                                          | 8a210b68-6988-11ed-a1eb-0242ac120002                                      |
| `ConnectionId`                                                            | *string*                                                                  | :heavy_check_mark:                                                        | Unique identifier for a connection.                                       | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                      |
| `TimeoutInMinutes`                                                        | *int*                                                                     | :heavy_minus_sign:                                                        | Time limit for the push operation to complete before it is timed out.     |                                                                           |
| `AllowSyncOnPushComplete`                                                 | *bool*                                                                    | :heavy_minus_sign:                                                        | Allow a sync upon push completion.                                        |                                                                           |
| `AccountingBankAccount`                                                   | [AccountingBankAccount](../../Models/Components/AccountingBankAccount.md) | :heavy_minus_sign:                                                        | N/A                                                                       |                                                                           |