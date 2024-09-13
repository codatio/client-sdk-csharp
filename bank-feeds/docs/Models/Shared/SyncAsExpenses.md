# SyncAsExpenses


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `EnableSync`                                                          | *bool*                                                                | :heavy_minus_sign:                                                    | True if expense sync is enabled.                                      |
| `Supplier`                                                            | [ConfigurationSupplier](../../Models/Shared/ConfigurationSupplier.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Customer`                                                            | [ConfigurationCustomer](../../Models/Shared/ConfigurationCustomer.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `SelectedBankAccountId`                                               | *string*                                                              | :heavy_minus_sign:                                                    | The bank account ID being synced.                                     |
| `BankAccountOptions`                                                  | List<[BankAccountOption](../../Models/Shared/BankAccountOption.md)>   | :heavy_minus_sign:                                                    | N/A                                                                   |