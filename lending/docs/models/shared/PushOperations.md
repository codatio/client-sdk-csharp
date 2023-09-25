# PushOperations


## Fields

| Field                                                       | Type                                                        | Required                                                    | Description                                                 |
| ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- | ----------------------------------------------------------- |
| `links`                                                     | [Links](../../models/shared/Links.md)                       | :heavy_check_mark:                                          | N/A                                                         |
| `pageNumber`                                                | *long*                                                      | :heavy_check_mark:                                          | Current page number.                                        |
| `pageSize`                                                  | *long*                                                      | :heavy_check_mark:                                          | Number of items to return in results array.                 |
| `results`                                                   | List<[PushOperation](../../models/shared/PushOperation.md)> | :heavy_minus_sign:                                          | N/A                                                         |
| `totalResults`                                              | *long*                                                      | :heavy_check_mark:                                          | Total number of items.                                      |