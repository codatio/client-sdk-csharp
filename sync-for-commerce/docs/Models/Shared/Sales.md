# Sales


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `Accounts`                                                                | Dictionary<String, [ConfigAccount](../../Models/Shared/ConfigAccount.md)> | :heavy_minus_sign:                                                        | N/A                                                                       |
| `Grouping`                                                                | [Grouping](../../Models/Shared/Grouping.md)                               | :heavy_minus_sign:                                                        | N/A                                                                       |
| `InvoiceStatus`                                                           | [InvoiceStatus](../../Models/Shared/InvoiceStatus.md)                     | :heavy_minus_sign:                                                        | N/A                                                                       |
| `NewTaxRates`                                                             | [NewTaxRates](../../Models/Shared/NewTaxRates.md)                         | :heavy_minus_sign:                                                        | N/A                                                                       |
| `SalesCustomer`                                                           | [Customer](../../Models/Shared/Customer.md)                               | :heavy_minus_sign:                                                        | N/A                                                                       |
| `SyncSales`                                                               | *bool*                                                                    | :heavy_minus_sign:                                                        | Boolean indicator for syncing sales.                                      |
| `TaxRates`                                                                | Dictionary<String, [TaxRateAmount](../../Models/Shared/TaxRateAmount.md)> | :heavy_minus_sign:                                                        | N/A                                                                       |