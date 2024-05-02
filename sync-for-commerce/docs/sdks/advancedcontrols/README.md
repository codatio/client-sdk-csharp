# AdvancedControls
(*AdvancedControls*)

## Overview

View and manage mapping configured for a company's commerce sync.

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
using System.Collections.Generic;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateCompany req = new CreateCompany() {
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<Items>() {
        new Items() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
    Name = "Bank of Dave",
};

var res = await sdk.AdvancedControls.CreateCompanyAsync(req);

// handle response
```

### Parameters

| Parameter                                             | Type                                                  | Required                                              | Description                                           |
| ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- | ----------------------------------------------------- |
| `request`                                             | [CreateCompany](../../Models/Shared/CreateCompany.md) | :heavy_check_mark:                                    | The request object to use for the request.            |


### Response

**[CreateCompanyResponse](../../Models/Operations/CreateCompanyResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503                    | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

## GetConfiguration

Returns a company's commerce sync configuration'.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetConfigurationRequest req = new GetConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AdvancedControls.GetConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetConfigurationRequest](../../Models/Operations/GetConfigurationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetConfigurationResponse](../../Models/Operations/GetConfigurationResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                    | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

## ListCompanies

Returns a list of companies.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListCompaniesRequest req = new ListCompaniesRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.AdvancedControls.ListCompaniesAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListCompaniesRequest](../../Models/Operations/ListCompaniesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListCompaniesResponse](../../Models/Operations/ListCompaniesResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

## SetConfiguration

Sets a company's commerce sync configuration.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

SetConfigurationRequest req = new SetConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AdvancedControls.SetConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [SetConfigurationRequest](../../Models/Operations/SetConfigurationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[SetConfigurationResponse](../../Models/Operations/SetConfigurationResponse.md)**
### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503            | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
