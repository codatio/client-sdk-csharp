# ExpenseTransactionLine


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `AccountRef`                                        | [RecordRef](../../models/shared/RecordRef.md)       | :heavy_check_mark:                                  | N/A                                                 |                                                     |
| `NetAmount`                                         | *decimal*                                           | :heavy_check_mark:                                  | Amount of the line, exclusive of tax.               | 110.42                                              |
| `TaxAmount`                                         | *decimal*                                           | :heavy_check_mark:                                  | Amount of tax for the line.                         | 14.43                                               |
| `TaxRateRef`                                        | [RecordRef](../../models/shared/RecordRef.md)       | :heavy_minus_sign:                                  | N/A                                                 |                                                     |
| `TrackingRefs`                                      | List<[RecordRef](../../models/shared/RecordRef.md)> | :heavy_minus_sign:                                  | N/A                                                 |                                                     |