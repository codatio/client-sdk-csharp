# BankFeedAccountMappingResponse

The result from POSTing a Bank Account mapping.


## Fields

| Field                                  | Type                                   | Required                               | Description                            |
| -------------------------------------- | -------------------------------------- | -------------------------------------- | -------------------------------------- |
| `Error`                                | *string*                               | :heavy_minus_sign:                     | Error returned during the post request |
| `Status`                               | *string*                               | :heavy_minus_sign:                     | Status of the POST request.            |
| `SourceAccountId`                      | *string*                               | :heavy_minus_sign:                     | Unique ID for the source account.      |
| `TargetAccountId`                      | *string*                               | :heavy_minus_sign:                     | Unique ID for the target account.      |