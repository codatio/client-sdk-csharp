# BillLineItem


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `AccountRef`                                                | [AccountReference](../../Models/Shared/AccountReference.md) | :heavy_minus_sign:                                          | Reference to the account to which the line item is linked.  |
| `Description`                                               | *string*                                                    | :heavy_minus_sign:                                          | Friendly name of the goods or services received.            |
| `Quantity`                                                  | *decimal*                                                   | :heavy_check_mark:                                          | Number of units of goods or services received.              |
| `TaxAmount`                                                 | *decimal*                                                   | :heavy_minus_sign:                                          | Amount of tax applied to the line item.                     |
| `TaxRateRef`                                                | [TaxRateReference](../../Models/Shared/TaxRateReference.md) | :heavy_minus_sign:                                          | Reference to the tax rate to which the line item is linked. |
| `TotalAmount`                                               | *decimal*                                                   | :heavy_minus_sign:                                          | Total amount of the line, including tax.                    |
| `UnitAmount`                                                | *decimal*                                                   | :heavy_minus_sign:                                          | Unit price of the goods or service.                         |