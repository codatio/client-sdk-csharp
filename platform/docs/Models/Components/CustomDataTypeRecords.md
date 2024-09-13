# CustomDataTypeRecords

Resulting records pulled from the source platform for a specific custom data type.


## Fields

| Field                                                                         | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `Results`                                                                     | List<[CustomDataTypeRecord](../../Models/Components/CustomDataTypeRecord.md)> | :heavy_minus_sign:                                                            | N/A                                                                           |
| `PageNumber`                                                                  | *long*                                                                        | :heavy_minus_sign:                                                            | Current page number.                                                          |
| `PageSize`                                                                    | *long*                                                                        | :heavy_minus_sign:                                                            | Number of items to return in results array.                                   |
| `TotalResults`                                                                | *long*                                                                        | :heavy_minus_sign:                                                            | Total number of items.                                                        |