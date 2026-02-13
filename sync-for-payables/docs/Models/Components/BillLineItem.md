# BillLineItem


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `Description`                                               | *string*                                                    | :heavy_minus_sign:                                          | Friendly name of the goods or services received.            |
| `UnitAmount`                                                | *decimal*                                                   | :heavy_minus_sign:                                          | Unit price of the goods or service.                         |
| `Quantity`                                                  | *decimal*                                                   | :heavy_minus_sign:                                          | Number of units of goods or services received.              |
| `TaxAmount`                                                 | *decimal*                                                   | :heavy_minus_sign:                                          | Amount of tax applied to the line item.                     |
| `AccountRef`                                                | [BillAccountRef](../../Models/Components/BillAccountRef.md) | :heavy_minus_sign:                                          | Reference to the account to which the line item is linked.  |
| `TotalAmount`                                               | *decimal*                                                   | :heavy_minus_sign:                                          | Total amount of the line, including tax.                    |
| `TaxRateRef`                                                | [BillTaxRateRef](../../Models/Components/BillTaxRateRef.md) | :heavy_minus_sign:                                          | Reference to the tax rate to which the line item is linked. |
| `TrackingRefs`                                              | List<[TrackingRef](../../Models/Components/TrackingRef.md)> | :heavy_minus_sign:                                          | N/A                                                         |