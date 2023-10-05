# AccountBalance


## Fields

| Field                                           | Type                                            | Required                                        | Description                                     | Example                                         |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `Available`                                     | *decimal*                                       | :heavy_minus_sign:                              | The account's current balance                   |                                                 |
| `Currency`                                      | *string*                                        | :heavy_minus_sign:                              | The currency of the account                     | GBP                                             |
| `Pending`                                       | *decimal*                                       | :heavy_minus_sign:                              | Funds that are not yet available in the balance |                                                 |
| `Reserved`                                      | *object*                                        | :heavy_minus_sign:                              | Funds reserved as holdings                      |                                                 |