# SyncAsExpenses


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `BankAccountOptions`                                                  | List<[BankAccountOption](../../Models/Shared/BankAccountOption.md)>   | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Customer`                                                            | [ConfigurationCustomer](../../Models/Shared/ConfigurationCustomer.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `EnableSync`                                                          | *bool*                                                                | :heavy_minus_sign:                                                    | True if expense sync is enabled.                                      |
| `SelectedBankAccountId`                                               | *string*                                                              | :heavy_minus_sign:                                                    | The bank account ID being synced.                                     |
| `Supplier`                                                            | [ConfigurationSupplier](../../Models/Shared/ConfigurationSupplier.md) | :heavy_minus_sign:                                                    | N/A                                                                   |