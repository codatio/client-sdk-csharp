# SourceAccountsSDK
(*SourceAccounts*)

## Overview

Source accounts act as a bridge to bank accounts in accounting software.

### Available Operations

* [Create](#create) - Create source account
* [Delete](#delete) - Delete source account
* [DeleteCredentials](#deletecredentials) - Delete all source account credentials
* [GenerateCredentials](#generatecredentials) - Generate source account credentials
* [List](#list) - List source accounts
* [Update](#update) - Update source account

## Create

The _Create Source Account_ endpoint allows you to create a representation of a bank account within Codat's domain. The company can then map the source account to an existing or new target account in their accounting software.

#### Account Mapping Variability

The method of mapping the source account to the target account varies depending on the accounting package your company uses.

#### Mapping Options:

1. **API Mapping**: Integrate the mapping journey directly into your application for a seamless user experience.
2. **Codat UI Mapping**: If you prefer a quicker setup, you can utilize Codat's provided user interface for mapping.
3. **Accounting Platform Mapping**: For some accounting software, the mapping process must be conducted within the software itself.

### Integration specific behaviour

| Bank Feed Integration | API Mapping | Codat UI Mapping | Accounting Platform Mapping |
| --------------------- | ----------- | ---------------- | --------------------------- |
| Xero                  | ✅          | ✅               |                             |
| FreeAgent             | ✅          | ✅               |                             |
| QuickBooks Online     |             |                  | ✅                          |
| Sage                  |             |                  | ✅                          |


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

var res = await sdk.SourceAccounts.CreateAsync(new CreateSourceAccountRequest() {
    SourceAccount = new SourceAccount() {
        AccountName = "bluetooth Extended",
        AccountNumber = "blue",
        AccountType = "grey technology East",
        Balance = 1697.27M,
        Currency = "GBP",
        FeedStartDate = "2022-10-23T00:00:00.000Z",
        Id = "<ID>",
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SortCode = "SUV quantify Polestar",
        Status = "physical Ameliorated",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [CreateSourceAccountRequest](../../models/operations/CreateSourceAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[CreateSourceAccountResponse](../../models/operations/CreateSourceAccountResponse.md)**


## Delete

The _Delete source account_ endpoint enables you to remove a source account.

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

var res = await sdk.SourceAccounts.DeleteAsync(new DeleteSourceAccountRequest() {
    AccountId = "7110701885",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [DeleteSourceAccountRequest](../../models/operations/DeleteSourceAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[DeleteSourceAccountResponse](../../models/operations/DeleteSourceAccountResponse.md)**


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
    RequestBody = "^upd|k\]Iy as bytes <<<>>>",
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

﻿The _List source accounts_ endpoint returns a list of [source accounts](https://docs.codat.io/bank-feeds-api#/schemas/BankFeedAccount) for a given company's connection.

[source accounts](https://docs.codat.io/bank-feeds-api#/schemas/BankFeedAccount) are the bank's bank account within Codat's domain from which transactions are synced into the accounting platform.


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

var res = await sdk.SourceAccounts.ListAsync(new ListSourceAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListSourceAccountsRequest](../../models/operations/ListSourceAccountsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[ListSourceAccountsResponse](../../models/operations/ListSourceAccountsResponse.md)**


## Update

﻿The _Update source account_ endpoint updates a single source account for a single data connection connected to a single company.


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

var res = await sdk.SourceAccounts.UpdateAsync(new UpdateSourceAccountRequest() {
    SourceAccount = new SourceAccount() {
        AccountName = "New Reactive dock",
        AccountNumber = "Analyst invoice",
        AccountType = "Islands",
        Balance = 4995.57M,
        Currency = "USD",
        FeedStartDate = "2022-10-23T00:00:00.000Z",
        Id = "<ID>",
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        SortCode = "Plastic Carolina syndicate",
        Status = "implement JBOD",
    },
    AccountId = "EILBDVJVNUAGVKRQ",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateSourceAccountRequest](../../models/operations/UpdateSourceAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[UpdateSourceAccountResponse](../../models/operations/UpdateSourceAccountResponse.md)**

