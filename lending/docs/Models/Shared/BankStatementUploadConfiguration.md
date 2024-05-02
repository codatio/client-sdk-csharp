# BankStatementUploadConfiguration

Configuration settings for uploading banking data to Codat


## Fields

| Field                                                        | Type                                                         | Required                                                     | Description                                                  |
| ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ | ------------------------------------------------------------ |
| `AccountId`                                                  | *string*                                                     | :heavy_minus_sign:                                           | The ID of the account in the third-party platform            |
| `ProviderId`                                                 | *string*                                                     | :heavy_minus_sign:                                           | TrueLayer provider ID (only required if source is TrueLayer) |
| `Source`                                                     | [Source](../../Models/Shared/Source.md)                      | :heavy_minus_sign:                                           | The source of the banking data that determines its format    |