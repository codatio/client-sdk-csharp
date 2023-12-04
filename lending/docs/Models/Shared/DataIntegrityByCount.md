# DataIntegrityByCount


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `MatchPercentage`                                                                  | *decimal*                                                                          | :heavy_minus_sign:                                                                 | The percentage of records of the type specified in the route which have a match.   |
| `Matched`                                                                          | *decimal*                                                                          | :heavy_minus_sign:                                                                 | The number of records of the type specified in the route which do have a match.    |
| `Total`                                                                            | *decimal*                                                                          | :heavy_minus_sign:                                                                 | The total of unmatched and matched.                                                |
| `Unmatched`                                                                        | *decimal*                                                                          | :heavy_minus_sign:                                                                 | The number of records of the type specified in the route which don't have a match. |