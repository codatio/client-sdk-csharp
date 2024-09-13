# UpdateBillRequest


## Fields

| Field                                                                                                                                                                                                                                                                                                                         | Type                                                                                                                                                                                                                                                                                                                          | Required                                                                                                                                                                                                                                                                                                                      | Description                                                                                                                                                                                                                                                                                                                   | Example                                                                                                                                                                                                                                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `CompanyId`                                                                                                                                                                                                                                                                                                                   | *string*                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                            | Unique identifier for a company.                                                                                                                                                                                                                                                                                              | 8a210b68-6988-11ed-a1eb-0242ac120002                                                                                                                                                                                                                                                                                          |
| `ConnectionId`                                                                                                                                                                                                                                                                                                                | *string*                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                            | Unique identifier for a connection.                                                                                                                                                                                                                                                                                           | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                                                                                                                                                                                                                                                          |
| `BillId`                                                                                                                                                                                                                                                                                                                      | *string*                                                                                                                                                                                                                                                                                                                      | :heavy_check_mark:                                                                                                                                                                                                                                                                                                            | Unique identifier for a bill.                                                                                                                                                                                                                                                                                                 | 13d946f0-c5d5-42bc-b092-97ece17923ab                                                                                                                                                                                                                                                                                          |
| `TimeoutInMinutes`                                                                                                                                                                                                                                                                                                            | *int*                                                                                                                                                                                                                                                                                                                         | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                            | Time limit for the push operation to complete before it is timed out.                                                                                                                                                                                                                                                         |                                                                                                                                                                                                                                                                                                                               |
| `ForceUpdate`                                                                                                                                                                                                                                                                                                                 | *bool*                                                                                                                                                                                                                                                                                                                        | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                            | When updating data in the destination platform Codat checks the `sourceModifiedDate` against the `lastupdated` date from the accounting software, if they're different Codat will return an error suggesting you should initiate another pull of the data. If this is set to `true` then the update will override this check. |                                                                                                                                                                                                                                                                                                                               |
| `Bill`                                                                                                                                                                                                                                                                                                                        | [Bill](../../Models/Components/Bill.md)                                                                                                                                                                                                                                                                                       | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                            | N/A                                                                                                                                                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                                                               |