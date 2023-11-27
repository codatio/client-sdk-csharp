# AdvancedControls
(*AdvancedControls*)

## Overview

Advanced company management and sync preferences.

### Available Operations

* [CreateCompany](#createcompany) - Create company
* [GetConfiguration](#getconfiguration) - Get company configuration
* [ListCompanies](#listcompanies) - List companies
* [SetConfiguration](#setconfiguration) - Set configuration

## CreateCompany

Creates a Codat company

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AdvancedControls.CreateCompanyAsync(new CreateCompany() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
});

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `request`                                             | [CreateCompany](../../Models/Shared/CreateCompany.md) | :heavy_check_mark:                                    | The request object to use for the request.            |


### Response

**[CreateCompanyResponse](../../Models/Operations/CreateCompanyResponse.md)**


## GetConfiguration

Returns a company's commerce sync configuration'.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AdvancedControls.GetConfigurationAsync(new GetConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetConfigurationRequest](../../Models/Operations/GetConfigurationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetConfigurationResponse](../../Models/Operations/GetConfigurationResponse.md)**


## ListCompanies

Returns a list of companies.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AdvancedControls.ListCompaniesAsync(new ListCompaniesRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListCompaniesRequest](../../Models/Operations/ListCompaniesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListCompaniesResponse](../../Models/Operations/ListCompaniesResponse.md)**


## SetConfiguration

Sets a company's commerce sync configuration.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AdvancedControls.SetConfigurationAsync(new SetConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [SetConfigurationRequest](../../Models/Operations/SetConfigurationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[SetConfigurationResponse](../../Models/Operations/SetConfigurationResponse.md)**

