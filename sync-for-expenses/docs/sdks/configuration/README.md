# Configuration
(*Configuration*)

## Overview

Manage mapping options and sync configuration.

### Available Operations

* [Get](#get) - Get company configuration
* [GetMappingOptions](#getmappingoptions) - Mapping options
* [Set](#set) - Set company configuration

## Get

Gets a companies expense sync configuration

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCompanyConfigurationRequest req = new GetCompanyConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Configuration.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetCompanyConfigurationRequest](../../Models/Operations/GetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetCompanyConfigurationResponse](../../Models/Operations/GetCompanyConfigurationResponse.md)**


## GetMappingOptions

Gets the expense mapping options for a companies accounting software

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetMappingOptionsRequest req = new GetMappingOptionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Configuration.GetMappingOptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetMappingOptionsRequest](../../Models/Operations/GetMappingOptionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetMappingOptionsResponse](../../Models/Operations/GetMappingOptionsResponse.md)**


## Set

Sets a companies expense sync configuration

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

SetCompanyConfigurationRequest req = new SetCompanyConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Configuration.SetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [SetCompanyConfigurationRequest](../../Models/Operations/SetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[SetCompanyConfigurationResponse](../../Models/Operations/SetCompanyConfigurationResponse.md)**

