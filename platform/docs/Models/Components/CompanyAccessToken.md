# CompanyAccessToken

Details of the access token provisioned for a company.


## Fields

| Field                                                 | Type                                                  | Required                                              | Description                                           | Example                                               |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `ExpiresIn`                                           | *long*                                                | :heavy_check_mark:                                    | The number of seconds until the access token expires. | 86400                                                 |
| `AccessToken`                                         | *string*                                              | :heavy_check_mark:                                    | The access token for the company.                     |                                                       |
| `TokenType`                                           | *string*                                              | :heavy_check_mark:                                    | The type of token.                                    | Bearer                                                |