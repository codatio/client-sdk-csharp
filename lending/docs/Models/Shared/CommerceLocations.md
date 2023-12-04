# CommerceLocations


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `Links`                                                           | [Links](../../Models/Shared/Links.md)                             | :heavy_check_mark:                                                | N/A                                                               |
| `PageNumber`                                                      | *long*                                                            | :heavy_check_mark:                                                | Current page number.                                              |
| `PageSize`                                                        | *long*                                                            | :heavy_check_mark:                                                | Number of items to return in results array.                       |
| `Results`                                                         | List<[CommerceLocation](../../Models/Shared/CommerceLocation.md)> | :heavy_minus_sign:                                                | N/A                                                               |
| `TotalResults`                                                    | *long*                                                            | :heavy_check_mark:                                                | Total number of items.                                            |