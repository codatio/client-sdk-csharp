# GetCreateUpdateModelOptionsByDataTypeRequest


## Fields

| Field                                                             | Type                                                              | Required                                                          | Description                                                       | Example                                                           |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `CompanyId`                                                       | *string*                                                          | :heavy_check_mark:                                                | Unique identifier for a company.                                  | 8a210b68-6988-11ed-a1eb-0242ac120002                              |
| `ConnectionId`                                                    | *string*                                                          | :heavy_check_mark:                                                | Unique identifier for a connection.                               | 2e9d2c44-f675-40ba-8049-353bfcb5e171                              |
| `DataType`                                                        | [Models.Components.DataType](../../Models/Components/DataType.md) | :heavy_check_mark:                                                | The key of a Codat data type.                                     | invoices                                                          |