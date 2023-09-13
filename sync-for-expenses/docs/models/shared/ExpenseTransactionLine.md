# ExpenseTransactionLine


## Fields

| Field                                               | Type                                                | Required                                            | Description                                         | Example                                             |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `accountRef`                                        | [RecordRef](../../models/shared/RecordRef.md)       | :heavy_check_mark:                                  | N/A                                                 |                                                     |
| `netAmount`                                         | *decimal*                                           | :heavy_check_mark:                                  | Amount of the line, exclusive of tax.               | 110.42                                              |
| `taxAmount`                                         | *decimal*                                           | :heavy_check_mark:                                  | Amount of tax for the line.                         | 14.43                                               |
| `taxRateRef`                                        | [RecordRef](../../models/shared/RecordRef.md)       | :heavy_minus_sign:                                  | N/A                                                 |                                                     |
| `trackingRefs`                                      | List<[RecordRef](../../models/shared/RecordRef.md)> | :heavy_minus_sign:                                  | N/A                                                 |                                                     |