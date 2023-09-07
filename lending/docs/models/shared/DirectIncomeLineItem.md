# DirectIncomeLineItem


## Fields

| Field                                                                                                                                                                                                                                                                                               | Type                                                                                                                                                                                                                                                                                                | Required                                                                                                                                                                                                                                                                                            | Description                                                                                                                                                                                                                                                                                         |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `accountRef`                                                                                                                                                                                                                                                                                        | [AccountRef](../../models/shared/AccountRef.md)                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.                                                                                                                                               |
| `description`                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | A user-friendly name of the goods or services.                                                                                                                                                                                                                                                      |
| `discountAmount`                                                                                                                                                                                                                                                                                    | *float*                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Discount amount for the line before tax.                                                                                                                                                                                                                                                            |
| `discountPercentage`                                                                                                                                                                                                                                                                                | *float*                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Discount percentage for the line before tax.                                                                                                                                                                                                                                                        |
| `itemRef`                                                                                                                                                                                                                                                                                           | [ItemRef](../../models/shared/ItemRef.md)                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Reference to the item the line is linked to.                                                                                                                                                                                                                                                        |
| `quantity`                                                                                                                                                                                                                                                                                          | *float*                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                  | The number of units of goods or services received.<br/><br/>Note: If the platform does not provide this information, the quantity will be mapped as 1.                                                                                                                                              |
| `subTotal`                                                                                                                                                                                                                                                                                          | *float*                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | The amount of the line, inclusive of discounts, but exclusive of tax.                                                                                                                                                                                                                               |
| `taxAmount`                                                                                                                                                                                                                                                                                         | *float*                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | The amount of tax for the line.<br/>Note: If the platform does not provide this information, the quantity will be mapped as 0.00.                                                                                                                                                                   |
| `taxRateRef`                                                                                                                                                                                                                                                                                        | [TaxRateRef](../../models/shared/TaxRateRef.md)                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Data types that reference a tax rate, for example invoice and bill line items, use a taxRateRef that includes the ID and name of the linked tax rate.<br/><br/>Found on:<br/><br/>- Bill line items<br/>- Bill Credit Note line items<br/>- Credit Note line items<br/>- Direct incomes line items<br/>- Invoice line items<br/>- Items |
| `totalAmount`                                                                                                                                                                                                                                                                                       | *float*                                                                                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | The total amount of the line, including tax.                                                                                                                                                                                                                                                        |
| `trackingCategoryRefs`                                                                                                                                                                                                                                                                              | List<[TrackingCategoryRef](../../models/shared/TrackingCategoryRef.md)>                                                                                                                                                                                                                             | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | An array of categories against which this direct cost is tracked.                                                                                                                                                                                                                                   |
| `unitAmount`                                                                                                                                                                                                                                                                                        | *float*                                                                                                                                                                                                                                                                                             | :heavy_check_mark:                                                                                                                                                                                                                                                                                  | The price of each unit of goods or services.<br/>Note: If the platform does not provide this information, the unit amount will be mapped to the total amount.                                                                                                                                       |