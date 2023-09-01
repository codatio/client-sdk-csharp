# sourceAccounts

## Overview

Source accounts act as a bridge to bank accounts in accounting software.

### Available Operations

* [Create](#create) - Create a bank feed bank account
* [Delete](#delete) - Delete bank feed bank account
* [DeleteCredentials](#deletecredentials) - Delete all source account credentials
* [GenerateCredentials](#generatecredentials) - Generate source account credentials
* [List](#list) - List bank feed bank accounts
* [Update](#update) - Update bank feed bank account

## Create

Post a BankFeed BankAccount for a single data source connected. to a single company.

### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SourceAccounts.CreateAsync(new CreateBankFeedRequest() {
    BankFeedAccount = new BankFeedAccount() {
        AccountName = "deserunt",
        AccountNumber = "suscipit",
        AccountType = "iure",
        Balance = 2975.34F,
        Currency = "EUR",
        FeedStartDate = "2022-10-23T00:00:00.000Z",
        Id = "f467cc87-96ed-4151-a05d-fc2ddf7cc78c",
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SortCode = "dicta",
        Status = "nam",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateBankFeedRequest](../../models/operations/CreateBankFeedRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[CreateBankFeedResponse](../../models/operations/CreateBankFeedResponse.md)**


## Delete

The *delete bank feed bank account* endpoint enables you to remove a source account.

Removing a source account will also remove any mapping between the source bank feed bank accounts and the target bankfeed bank account.

### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SourceAccounts.DeleteAsync(new DeleteBankFeedBankAccountRequest() {
    AccountId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [DeleteBankFeedBankAccountRequest](../../models/operations/DeleteBankFeedBankAccountRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[DeleteBankFeedBankAccountResponse](../../models/operations/DeleteBankFeedBankAccountResponse.md)**


## DeleteCredentials

The _Delete Bank Account Credentials_ endpoint serves as a comprehensive mechanism for revoking all existing authorization credentials that a company employs to establish its Bank Feed connection.

In cases where multiple credential sets have been generated, a single API call to this endpoint revokes all of them.

### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SourceAccounts.DeleteCredentialsAsync(new DeleteBankFeedCredentialsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [DeleteBankFeedCredentialsRequest](../../models/operations/DeleteBankFeedCredentialsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[DeleteBankFeedCredentialsResponse](../../models/operations/DeleteBankFeedCredentialsResponse.md)**


## GenerateCredentials

﻿The _Generate Bank Account Credentials_ endpoint can be used to generate credentials for QuickBooks Online to use for authentication of the Bank Feed in their portal, each time this is used a new set of credentials will be generated.

The old credentials will still be valid until the revoke credentials endpoint is used, which will revoke all credentials associated to the data connection.


### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SourceAccounts.GenerateCredentialsAsync(new GenerateCredentialsRequest() {
    RequestBody = "occaecati as bytes <<<>>>",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GenerateCredentialsRequest](../../models/operations/GenerateCredentialsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GenerateCredentialsResponse](../../models/operations/GenerateCredentialsResponse.md)**


## List

﻿The *List bank feed bank accounts* endpoint returns a list of [bank feed accounts](https://docs.codat.io/bank-feeds-api#/schemas/BankFeedAccount) for a given company's connection.

[Bank feed accounts](https://docs.codat.io/bank-feeds-api#/schemas/BankFeedAccount) are the bank's bank account from which transactions are synced into the accounting platform.



### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SourceAccounts.ListAsync(new ListBankFeedsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListBankFeedsRequest](../../models/operations/ListBankFeedsRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListBankFeedsResponse](../../models/operations/ListBankFeedsResponse.md)**


## Update

﻿The *Update bank feed bank account* endpoint updates a single bank feed bank account for a single data source connected to a single company.

### Example Usage

```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SourceAccounts.UpdateAsync(new UpdateBankFeedRequest() {
    BankFeedAccount = new BankFeedAccount() {
        AccountName = "fugit",
        AccountNumber = "deleniti",
        AccountType = "hic",
        Balance = 7586.16F,
        Currency = "USD",
        FeedStartDate = "2022-10-23T00:00:00.000Z",
        Id = "6742cb73-9205-4929-b96f-ea7596eb10fa",
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SortCode = "laborum",
        Status = "dolores",
    },
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateBankFeedRequest](../../models/operations/UpdateBankFeedRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[UpdateBankFeedResponse](../../models/operations/UpdateBankFeedResponse.md)**

