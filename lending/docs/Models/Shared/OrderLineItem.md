# OrderLineItem


## Fields

| Field                                                                                        | Type                                                                                         | Required                                                                                     | Description                                                                                  | Example                                                                                      |
| -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------- |
| `DiscountAllocations`                                                                        | List<[OrderDiscountAllocation](../../Models/Shared/OrderDiscountAllocation.md)>              | :heavy_minus_sign:                                                                           | N/A                                                                                          |                                                                                              |
| `Id`                                                                                         | *string*                                                                                     | :heavy_check_mark:                                                                           | A unique, persistent identifier for this record                                              | 13d946f0-c5d5-42bc-b092-97ece17923ab                                                         |
| `ProductRef`                                                                                 | [ProductRef](../../Models/Shared/ProductRef.md)                                              | :heavy_minus_sign:                                                                           | Reference that links the line item to the correct product details.                           |                                                                                              |
| `ProductVariantRef`                                                                          | [ProductVariantRef](../../Models/Shared/ProductVariantRef.md)                                | :heavy_minus_sign:                                                                           | Reference that links the line item to the specific version of product that has been ordered. |                                                                                              |
| `Quantity`                                                                                   | *decimal*                                                                                    | :heavy_minus_sign:                                                                           | Number of units of the product sold.<br/>For refunds, quantity is negative.<br/>             |                                                                                              |
| `TaxPercentage`                                                                              | *decimal*                                                                                    | :heavy_minus_sign:                                                                           | Percentage rate (from 0 to 100) of any sales tax applied to the unit price.                  | 0                                                                                            |
| `Taxes`                                                                                      | List<[TaxComponentAllocation](../../Models/Shared/TaxComponentAllocation.md)>                | :heavy_minus_sign:                                                                           | Taxes breakdown as applied to order lines.                                                   |                                                                                              |
| `TotalAmount`                                                                                | *decimal*                                                                                    | :heavy_minus_sign:                                                                           | Total amount of the line item, including discounts and tax.                                  |                                                                                              |
| `TotalTaxAmount`                                                                             | *decimal*                                                                                    | :heavy_minus_sign:                                                                           | Total amount of tax applied to the line item, factoring in any discounts.                    |                                                                                              |
| `UnitPrice`                                                                                  | *decimal*                                                                                    | :heavy_minus_sign:                                                                           | Price per unit of goods or services, excluding discounts and tax.                            |                                                                                              |