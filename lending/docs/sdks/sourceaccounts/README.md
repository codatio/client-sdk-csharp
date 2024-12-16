# SourceAccounts
(*LoanWriteback.SourceAccounts*)

## Overview

### Available Operations

* [Create](#create) - Create source account
* [CreateMapping](#createmapping) - Create bank feed account mapping

## Create

The _Create Source Account_ endpoint allows you to create a representation of a bank account within Codat's domain. The company can then map the source account to an existing or new target account in their accounting software.

> ### Versioning
> If you are integrating the Bank Feeds API with Codat after August 1, 2024, please use the v2 version of the API, as detailed in the schema below. For integrations completed before August 1, 2024, select the v1 version from the schema dropdown below.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateSourceAccountRequest req = new CreateSourceAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    RequestBody = CreateSourceAccountRequestBody.CreateSourceAccountV2(
        new SourceAccountV2() {
            Id = "acc-002",
            AccountName = "account-083",
            AccountType = Codat.Lending.Models.Components.SourceAccountV2AccountType.Savings,
            AccountNumber = "23456789",
            RoutingInfo = new RoutingInfo() {
                BankCode = "21001088",
                Type = Codat.Lending.Models.Components.RoutingInfoType.Bankcode,
            },
            Currency = "GBP",
            Balance = 400M,
            AccountInfo = new AccountInfo() {
                Description = "account description 2",
                Nickname = "account 1290",
                AccountOpenDate = "2023-05-23T00:00:00Z",
                AvailableBalance = 400M,
            },
            ModifiedDate = "2024-08-02T00:00:00.000Z",
            Status = Codat.Lending.Models.Components.SourceAccountV2Status.Pending,
            FeedStartDate = "2024-05-01T00:00:00Z",
        }
    ),
};

var res = await sdk.LoanWriteback.SourceAccounts.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [CreateSourceAccountRequest](../../Models/Requests/CreateSourceAccountRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[CreateSourceAccountResponse](../../Models/Requests/CreateSourceAccountResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## CreateMapping

﻿The *Create bank account mapping* endpoint creates a new mapping between a source bank account and a potential account in the accounting software (target account).

A bank feed account mapping is a specified link between the source account (provided by the Codat user) and the target account (the end user's account in the underlying software).

To find valid target account options, first call the [List bank feed account mappings](https://docs.codat.io//bank-feeds-api#/operations/get-bank-account-mapping) endpoint.

> **For custom builds only**
>
> Only use this endpoint if you are building your own account management UI.

#### Account mapping variability

The method of mapping the source account to the target account varies depending on the accounting software your company uses.

#### Mapping options:

1. **API Mapping**: Integrate the mapping journey directly into your application for a seamless user experience.
2. **Codat UI Mapping**: If you prefer a quicker setup, you can utilize Codat's provided user interface for mapping.
3. **Accounting Platform Mapping**: For some accounting software, the mapping process must be conducted within the software itself.

### Integration-specific behaviour

| Bank Feed Integration | API Mapping | Codat UI Mapping | Accounting Platform Mapping |
| --------------------- | ----------- | ---------------- | --------------------------- |
| Xero                  | ✅          | ✅               |                             |
| FreeAgent             | ✅          | ✅               |                             |
| Oracle NetSuite       | ✅          | ✅               |                             |
| Exact Online (NL)     | ✅          | ✅               |                             |
| QuickBooks Online     |             |                  | ✅                          |
| Sage                  |             |                  | ✅                          |

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateBankAccountMappingRequest req = new CreateBankAccountMappingRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankFeedBankAccountMapping = new BankFeedBankAccountMapping() {
        SourceAccountId = "acc-002",
        TargetAccountId = "account-081",
    },
};

var res = await sdk.LoanWriteback.SourceAccounts.CreateMappingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [CreateBankAccountMappingRequest](../../Models/Requests/CreateBankAccountMappingRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[CreateBankAccountMappingResponse](../../Models/Requests/CreateBankAccountMappingResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503   | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |