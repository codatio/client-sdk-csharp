# RoutingInfo

Routing information for the bank. This does not include account number.


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `BankCode`                                                    | *string*                                                      | :heavy_minus_sign:                                            | The numeric identifier of the routing number                  |
| `Type`                                                        | [RoutingInfoType](../../Models/Components/RoutingInfoType.md) | :heavy_minus_sign:                                            | The type of routing number.                                   |