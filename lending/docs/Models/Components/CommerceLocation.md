# CommerceLocation

The Location datatype holds information on the geographic location at which stocks of products may be held, as referenced in the Products data type.

A Location also holds information on geographic locations where orders were placed, as referenced in the Orders data type.


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   | Example                                                       |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `ModifiedDate`                                                | *string*                                                      | :heavy_minus_sign:                                            | N/A                                                           | 2022-10-23T00:00:00Z                                          |
| `SourceModifiedDate`                                          | *string*                                                      | :heavy_minus_sign:                                            | N/A                                                           | 2022-10-23T00:00:00Z                                          |
| `Id`                                                          | *string*                                                      | :heavy_check_mark:                                            | A unique, persistent identifier for this record               | 13d946f0-c5d5-42bc-b092-97ece17923ab                          |
| `Name`                                                        | *string*                                                      | :heavy_minus_sign:                                            | Name of this location                                         |                                                               |
| `Address`                                                     | [CommerceAddress](../../Models/Components/CommerceAddress.md) | :heavy_minus_sign:                                            | N/A                                                           |                                                               |