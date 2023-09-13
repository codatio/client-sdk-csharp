# AccountBalance


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     | Example                                         |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `available`                                     | *decimal*                                       | :heavy_minus_sign:                              | The account's current balance                   |                                                 |
| `currency`                                      | *string*                                        | :heavy_minus_sign:                              | The currency of the account                     | GBP                                             |
| `pending`                                       | *decimal*                                       | :heavy_minus_sign:                              | Funds that are not yet available in the balance |                                                 |
| `reserved`                                      | *object*                                        | :heavy_minus_sign:                              | Funds reserved as holdings                      |                                                 |