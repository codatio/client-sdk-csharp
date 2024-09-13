# DirectCostLineItem


## Fields

| Field                                                                                                                                                                                                                                                                                               | Type                                                                                                                                                                                                                                                                                                | Required                                                                                                                                                                                                                                                                                            | Description                                                                                                                                                                                                                                                                                         | Example                                                                                                                                                                                                                                                                                             |
| --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `Description`                                                                                                                                                                                                                                                                                       | *string*                                                                                                                                                                                                                                                                                            | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Friendly name of the goods or services.                                                                                                                                                                                                                                                             |                                                                                                                                                                                                                                                                                                     |
| `UnitAmount`                                                                                                                                                                                                                                                                                        | *decimal*                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                  | Price of each unit of goods or services.<br/>Note: If the platform does not provide this information, the unit amount will be mapped to the total amount.                                                                                                                                           |                                                                                                                                                                                                                                                                                                     |
| `Quantity`                                                                                                                                                                                                                                                                                          | *decimal*                                                                                                                                                                                                                                                                                           | :heavy_check_mark:                                                                                                                                                                                                                                                                                  | Number of units of goods or services received.<br/><br/>Note: If the platform does not provide this information, the quantity will be mapped as 1.                                                                                                                                                  |                                                                                                                                                                                                                                                                                                     |
| `DiscountAmount`                                                                                                                                                                                                                                                                                    | *decimal*                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Discount amount for the line before tax.                                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                                                                                     |
| `DiscountPercentage`                                                                                                                                                                                                                                                                                | *decimal*                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Discount percentage for the line before tax.                                                                                                                                                                                                                                                        |                                                                                                                                                                                                                                                                                                     |
| `SubTotal`                                                                                                                                                                                                                                                                                          | *decimal*                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Amount of the line, inclusive of discounts but exclusive of tax.                                                                                                                                                                                                                                    |                                                                                                                                                                                                                                                                                                     |
| `TaxAmount`                                                                                                                                                                                                                                                                                         | *decimal*                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Amount of tax for the line.                                                                                                                                                                                                                                                                         |                                                                                                                                                                                                                                                                                                     |
| `TotalAmount`                                                                                                                                                                                                                                                                                       | *decimal*                                                                                                                                                                                                                                                                                           | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Total amount of the line, including tax.                                                                                                                                                                                                                                                            |                                                                                                                                                                                                                                                                                                     |
| `AccountRef`                                                                                                                                                                                                                                                                                        | [AccountRef](../../Models/Components/AccountRef.md)                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Data types that reference an account, for example bill and invoice line items, use an accountRef that includes the ID and name of the linked account.                                                                                                                                               | {<br/>"Example": {<br/>"value": {<br/>"accountRef": {<br/>"id": "4f78a6b0-e9bb-40f2-82fd-f3a2daa1fd0a",<br/>"name": "Business Current Account"<br/>}<br/>}<br/>}<br/>}                                                                                                                              |
| `TaxRateRef`                                                                                                                                                                                                                                                                                        | [TaxRateRef](../../Models/Components/TaxRateRef.md)                                                                                                                                                                                                                                                 | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Data types that reference a tax rate, for example invoice and bill line items, use a taxRateRef that includes the ID and name of the linked tax rate.<br/><br/>Found on:<br/><br/>- Bill line items<br/>- Bill Credit Note line items<br/>- Credit Note line items<br/>- Direct incomes line items<br/>- Invoice line items<br/>- Items |                                                                                                                                                                                                                                                                                                     |
| `ItemRef`                                                                                                                                                                                                                                                                                           | [PropertieItemRef](../../Models/Components/PropertieItemRef.md)                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | Reference to the item the line is linked to.                                                                                                                                                                                                                                                        |                                                                                                                                                                                                                                                                                                     |
| ~~`TrackingCategoryRefs`~~                                                                                                                                                                                                                                                                          | List<[TrackingCategoryRef](../../Models/Components/TrackingCategoryRef.md)>                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | : warning: ** DEPRECATED **: This will be removed in a future release, please migrate away from it as soon as possible.<br/><br/>Collection of categories against which this direct cost is tracked.                                                                                                |                                                                                                                                                                                                                                                                                                     |
| `Tracking`                                                                                                                                                                                                                                                                                          | [Tracking](../../Models/Components/Tracking.md)                                                                                                                                                                                                                                                     | :heavy_minus_sign:                                                                                                                                                                                                                                                                                  | N/A                                                                                                                                                                                                                                                                                                 |                                                                                                                                                                                                                                                                                                     |