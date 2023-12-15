# CustomDataTypeRecords

Resulting records pulled from the source platform for a specific custom data type.


## Fields

| Field                                                                     | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `PageNumber`                                                              | *long*                                                                    | :heavy_minus_sign:                                                        | Current page number.                                                      |
| `PageSize`                                                                | *long*                                                                    | :heavy_minus_sign:                                                        | Number of items to return in results array.                               |
| `Results`                                                                 | List<[CustomDataTypeRecord](../../Models/Shared/CustomDataTypeRecord.md)> | :heavy_minus_sign:                                                        | N/A                                                                       |
| `TotalResults`                                                            | *long*                                                                    | :heavy_minus_sign:                                                        | Total number of items.                                                    |