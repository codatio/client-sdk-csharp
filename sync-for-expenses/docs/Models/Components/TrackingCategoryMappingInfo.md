# TrackingCategoryMappingInfo


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             | Example                                                                 |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `Id`                                                                    | *string*                                                                | :heavy_minus_sign:                                                      | Unique identifier of the tracking category.                             | DEPARTMENT_2                                                            |
| `Name`                                                                  | *string*                                                                | :heavy_minus_sign:                                                      | Name of the tracking category as it appears in the accounting software. | New York                                                                |
| `HasChildren`                                                           | *bool*                                                                  | :heavy_minus_sign:                                                      | Boolean of whether the tracking category has child categories.          |                                                                         |
| `ParentId`                                                              | *string*                                                                | :heavy_minus_sign:                                                      | ID of the parent tracking category                                      | DEPARTMENTS                                                             |