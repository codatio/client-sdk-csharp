# Companies
(*Companies*)

## Overview

Create and manage your Codat companies.

### Available Operations

* [Create](#create) - Create company
* [Delete](#delete) - Delete a company
* [Get](#get) - Get company
* [List](#list) - List companies
* [Update](#update) - Update company

## Create

﻿Use the *Create company* endpoint to create a new [company](https://docs.codat.io/bank-feeds-api#/schemas/Company) that represents your customer in Codat. 

A [company](https://docs.codat.io/bank-feeds-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/bank-feeds-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

If forbidden characters (see `name` pattern) are present in the request, a company will be created with the forbidden characters removed. For example, `Company (Codat[1])` with be created as `Company Codat1`.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CompanyRequestBody req = new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<Items>() {
        new Items() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
    Name = "Bank of Dave",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [CompanyRequestBody](../../Models/Shared/CompanyRequestBody.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[CreateCompanyResponse](../../Models/Operations/CreateCompanyResponse.md)**


## Delete

﻿The *Delete company* endpoint permanently deletes a [company](https://docs.codat.io/bank-feeds-api#/schemas/Company), its [connections](https://docs.codat.io/bank-feeds-api#/schemas/Connection) and any cached data. This operation is irreversible.

A [company](https://docs.codat.io/bank-feeds-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/bank-feeds-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

DeleteCompanyRequest req = new DeleteCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [DeleteCompanyRequest](../../Models/Operations/DeleteCompanyRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[DeleteCompanyResponse](../../Models/Operations/DeleteCompanyResponse.md)**


## Get

﻿The *Get company* endpoint returns a single company for a given `companyId`.

A [company](https://docs.codat.io/bank-feeds-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/bank-feeds-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCompanyRequest req = new GetCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetCompanyRequest](../../Models/Operations/GetCompanyRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetCompanyResponse](../../Models/Operations/GetCompanyResponse.md)**


## List

﻿The *List companies* endpoint returns a list of [companies] associated to your instances.

A [company](https://docs.codat.io/bank-feeds-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/bank-feeds-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListCompaniesRequest req = new ListCompaniesRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListCompaniesRequest](../../Models/Operations/ListCompaniesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListCompaniesResponse](../../Models/Operations/ListCompaniesResponse.md)**


## Update

﻿Use the *Update company* endpoint to update both the name and description of the company. 
If you use [groups](https://docs.codat.io/bank-feeds-api#/schemas/Group) to manage a set of companies, use the [Add company](https://docs.codat.io/bank-feeds-api#/operations/add-company-to-group) or [Remove company](https://docs.codat.io/bank-feeds-api#/operations/remove-company-from-group) endpoints to add or remove a company from a group.

A [company](https://docs.codat.io/bank-feeds-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/bank-feeds-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateCompanyRequest req = new UpdateCompanyRequest() {
    CompanyRequestBody = new CompanyRequestBody() {
        Description = "Requested early access to the new financing scheme.",
        Groups = new List<Items>() {
            new Items() {
                Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
            },
        },
        Name = "Bank of Dave",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateCompanyRequest](../../Models/Operations/UpdateCompanyRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[UpdateCompanyResponse](../../Models/Operations/UpdateCompanyResponse.md)**

