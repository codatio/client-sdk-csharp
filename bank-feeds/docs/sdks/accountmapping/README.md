# AccountMapping
(*AccountMapping*)

## Overview

Bank feed bank account mapping.

### Available Operations

* [Create](#create) - Create bank feed account mapping
* [Get](#get) - List bank feed account mappings

## Create

﻿The *Create bank account mapping* endpoint creates a new mapping between a source bank account and a potential account in the accounting platform (target account).

A bank feed account mapping is a specified link between the source account (provided by the Codat user) and the target account (the end users account in the underlying platform).

To find valid target account options, first call list bank feed account mappings.

This endpoint is only needed if building an account management UI.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateBankAccountMappingRequest req = new CreateBankAccountMappingRequest() {
    Zero = new Zero() {
        FeedStartDate = "2022-10-23T00:00:00Z",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.AccountMapping.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [CreateBankAccountMappingRequest](../../Models/Operations/CreateBankAccountMappingRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[CreateBankAccountMappingResponse](../../Models/Operations/CreateBankAccountMappingResponse.md)**


## Get

﻿The *List bank account mappings* endpoint returns information about a source bank account and any current or potential target mapping accounts.

A bank feed account mapping is a specified link between the source account (provided by the Codat user) and the target account (the end users account in the underlying platform).

This endpoint is only needed if building an account management UI.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetBankAccountMappingRequest req = new GetBankAccountMappingRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.AccountMapping.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetBankAccountMappingRequest](../../Models/Operations/GetBankAccountMappingRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[GetBankAccountMappingResponse](../../Models/Operations/GetBankAccountMappingResponse.md)**

