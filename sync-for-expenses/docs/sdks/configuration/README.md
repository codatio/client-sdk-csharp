# Configuration

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
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Configuration.GetAsync(new GetCompanyConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetCompanyConfigurationRequest](../../models/operations/GetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetCompanyConfigurationResponse](../../models/operations/GetCompanyConfigurationResponse.md)**


## GetMappingOptions

Gets the expense mapping options for a companies accounting software

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Configuration.GetMappingOptionsAsync(new GetMappingOptionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetMappingOptionsRequest](../../models/operations/GetMappingOptionsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |


### Response

**[GetMappingOptionsResponse](../../models/operations/GetMappingOptionsResponse.md)**


## Set

Sets a companies expense sync configuration

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Configuration.SetAsync(new SetCompanyConfigurationRequest() {
    CompanyConfiguration = new CompanyConfiguration() {
        BankAccount = new BankAccount() {
            Id = "32",
        },
        Customer = new CustomerDetails() {
            Id = "0f467cc8-796e-4d15-9a05-dfc2ddf7cc78",
        },
        Supplier = new SupplierDetails() {
            Id = "ca1ba928-fc81-4674-acb7-39205929396f",
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [SetCompanyConfigurationRequest](../../models/operations/SetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[SetCompanyConfigurationResponse](../../models/operations/SetCompanyConfigurationResponse.md)**

