# SourceAccounts
(*SourceAccounts*)

## Overview

Provide and manage lists of source bank accounts.

### Available Operations

* [CreateBatch](#createbatch) - Create source accounts
* [Create](#create) - Create single source account
* [List](#list) - List source accounts
* [Update](#update) - Update source account
* [Delete](#delete) - Delete source account
* [GenerateCredentials](#generatecredentials) - Generate source account credentials
* [DeleteCredentials](#deletecredentials) - Delete all source account credentials

## CreateBatch

The _Batch create source accounts_ endpoint allows you to create multiple representations of your SMB's bank accounts within Codat's domain. The company can then map the source account to an existing or new target account in their accounting software.

> ### Versioning
> If you are integrating the Bank Feeds API with Codat after August 1, 2024, please use the v2 version of the API, as detailed in the schema below. For integrations completed before August 1, 2024, select the v1 version from the schema dropdown below.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using System.Collections.Generic;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CreateBatchSourceAccountRequest req = new CreateBatchSourceAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    RequestBody = CreateBatchSourceAccountRequestBody.CreateArrayOfSourceAccount(
        new List<SourceAccount>() {
            new SourceAccount() {
                Id = "acc-002",
                AccountName = "account-081",
                AccountType = "Credit",
                AccountNumber = "12345670",
                SortCode = "123456",
                Currency = "GBP",
                Balance = 99.99M,
                ModifiedDate = "2023-01-09T14:14:14.1057478Z",
                Status = Codat.BankFeeds.Models.Shared.SourceAccountStatus.Pending,
            },
            new SourceAccount() {
                Id = "acc-003",
                AccountName = "account-095",
                AccountType = "Credit",
                AccountNumber = "12345671",
                SortCode = "123456",
                Currency = "USD",
                Balance = 0M,
                ModifiedDate = "2023-01-09T14:14:14.1057478Z",
                Status = Codat.BankFeeds.Models.Shared.SourceAccountStatus.Pending,
            },
        }
    ),
};

var res = await sdk.SourceAccounts.CreateBatchAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [CreateBatchSourceAccountRequest](../../Models/Operations/CreateBatchSourceAccountRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[CreateBatchSourceAccountResponse](../../Models/Operations/CreateBatchSourceAccountResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Codat.BankFeeds.Models.Errors.ErrorMessage  | 400, 401, 402, 403, 404, 409, 429, 500, 503 | application/json                            |
| Codat.BankFeeds.Models.Errors.SDKException  | 4XX, 5XX                                    | \*/\*                                       |

## Create

The _Create Source Account_ endpoint allows you to create a representation of a bank account within Codat's domain. The company can then map the source account to an existing or new target account in their accounting software.

> ### Versioning
> If you are integrating the Bank Feeds API with Codat after August 1, 2024, please use the v2 version of the API, as detailed in the schema below. For integrations completed before August 1, 2024, select the v1 version from the schema dropdown below.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CreateSourceAccountRequest req = new CreateSourceAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    RequestBody = CreateSourceAccountRequestBody.CreateSourceAccountV2Prototype(
        new SourceAccountV2Prototype() {
            Currency = "USD",
            ModifiedDate = "2022-10-23T00:00:00Z",
            AccountInfo = new AccountInfo() {
                AccountOpenDate = "2022-10-23",
            },
        }
    ),
};

var res = await sdk.SourceAccounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [CreateSourceAccountRequest](../../Models/Operations/CreateSourceAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[CreateSourceAccountResponse](../../Models/Operations/CreateSourceAccountResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503     | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## List

﻿The _List source accounts_ endpoint returns a list of [source accounts](https://docs.codat.io/bank-feeds-api#/schemas/BankFeedAccount) for a given company's connection.

[Source accounts](https://docs.codat.io/bank-feeds-api#/schemas/BankFeedAccount) are the bank's bank account within Codat's domain from which transactions are synced into the accounting platform.

> ### Versioning
> If you are integrating the Bank Feeds API with Codat after August 1, 2024, please use the v2 version of the API, as detailed in the schema below. For integrations completed before August 1, 2024, select the v1 version from the schema dropdown below.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

ListSourceAccountsRequest req = new ListSourceAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.SourceAccounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListSourceAccountsRequest](../../Models/Operations/ListSourceAccountsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListSourceAccountsResponse](../../Models/Operations/ListSourceAccountsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503          | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## Update

﻿The _Update source account_ endpoint updates a single source account for a single data connection connected to a single company.

### Tips and pitfalls

* This endpoint only updates the `accountName` field.
* Updates made here apply exclusively to source accounts and will not affect target accounts in the accounting software.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

UpdateSourceAccountRequest req = new UpdateSourceAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountId = "EILBDVJVNUAGVKRQ",
    SourceAccount = new SourceAccount() {
        Id = "acc-003",
        AccountName = "account-095",
        AccountType = "Credit",
        AccountNumber = "12345671",
        SortCode = "123456",
        Currency = "USD",
        Balance = 0M,
        ModifiedDate = "2023-01-09T14:14:14.1057478Z",
        Status = Codat.BankFeeds.Models.Shared.SourceAccountStatus.Pending,
    },
};

var res = await sdk.SourceAccounts.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [UpdateSourceAccountRequest](../../Models/Operations/UpdateSourceAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[UpdateSourceAccountResponse](../../Models/Operations/UpdateSourceAccountResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503     | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## Delete

The _Delete source account_ endpoint enables you to remove a source account.

Removing a source account will also remove any mapping between the source bank feed bank accounts and the target bankfeed bank account.


### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

DeleteSourceAccountRequest req = new DeleteSourceAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountId = "7110701885",
};

var res = await sdk.SourceAccounts.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [DeleteSourceAccountRequest](../../Models/Operations/DeleteSourceAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[DeleteSourceAccountResponse](../../Models/Operations/DeleteSourceAccountResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503          | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## GenerateCredentials

﻿The _Generate bank account credentials_ endpoint can be used to generate credentials for QuickBooks Online to authenticate the Bank Feed in the QBO portal. Each time this endpoint is called, a new set of credentials will be generated.

The old credentials will still be valid until the revoke credentials endpoint is used, which will revoke all credentials associated to the data connection.

> **For QuickBooks Online only**
>
> Only call this endpoint when onboarding SMBs that use  QuickBooks Online.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GenerateCredentialsRequest req = new GenerateCredentialsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    RequestBody = System.Text.Encoding.UTF8.GetBytes("0xeCFd9fD7b9"),
};

var res = await sdk.SourceAccounts.GenerateCredentialsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GenerateCredentialsRequest](../../Models/Operations/GenerateCredentialsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GenerateCredentialsResponse](../../Models/Operations/GenerateCredentialsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503          | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |

## DeleteCredentials

The _Delete Bank Account Credentials_ endpoint serves as a comprehensive mechanism for revoking all existing authorization credentials that a company employs to establish its Bank Feed connection.

In cases where multiple credential sets have been generated, a single API call to this endpoint revokes all of them.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

DeleteBankFeedCredentialsRequest req = new DeleteBankFeedCredentialsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.SourceAccounts.DeleteCredentialsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [DeleteBankFeedCredentialsRequest](../../Models/Operations/DeleteBankFeedCredentialsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[DeleteBankFeedCredentialsResponse](../../Models/Operations/DeleteBankFeedCredentialsResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503          | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |