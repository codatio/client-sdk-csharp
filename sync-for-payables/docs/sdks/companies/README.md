# Companies
(*Companies*)

## Overview

Create and manage your SMB users' companies.

### Available Operations

* [List](#list) - List companies
* [Create](#create) - Create company
* [Update](#update) - Update company
* [Delete](#delete) - Delete a company
* [Get](#get) - Get company

## List

﻿The *List companies* endpoint returns a list of [companies] associated to your instances.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Companies.ListAsync(
    page: 1,
    pageSize: 100,
    query: "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    orderBy: "-modifiedDate"
);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     | Example                                                                                         |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `Page`                                                                                          | *int*                                                                                           | :heavy_minus_sign:                                                                              | Page number. [Read more](https://docs.codat.io/using-the-api/paging).                           | 1                                                                                               |
| `PageSize`                                                                                      | *int*                                                                                           | :heavy_minus_sign:                                                                              | Number of records to return in a page. [Read more](https://docs.codat.io/using-the-api/paging). | 100                                                                                             |
| `Query`                                                                                         | *string*                                                                                        | :heavy_minus_sign:                                                                              | Codat query string. [Read more](https://docs.codat.io/using-the-api/querying).                  | id=e3334455-1aed-4e71-ab43-6bccf12092ee                                                         |
| `OrderBy`                                                                                       | *string*                                                                                        | :heavy_minus_sign:                                                                              | Field to order results by. [Read more](https://docs.codat.io/using-the-api/ordering-results).   | -modifiedDate                                                                                   |

### Response

**[ListCompaniesResponse](../../Models/Requests/ListCompaniesResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503    | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Create

﻿Use the *Create company* endpoint to create a new [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) that represents your customer in Codat. 

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

If forbidden characters (see `name` pattern) are present in the request, a company will be created with the forbidden characters removed. For example, `Company (Codat[1])` with be created as `Company Codat1`.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Components;
using System.Collections.Generic;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<Items>() {
        new Items() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [CompanyRequestBody](../../Models/Components/CompanyRequestBody.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[CreateCompanyResponse](../../Models/Requests/CreateCompanyResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Update

﻿Use the *Update company* endpoint to update both the name and description of the company. 
If you use [groups](https://docs.codat.io/sync-for-payables-api#/schemas/Group) to manage a set of companies, use the [Add company](https://docs.codat.io/sync-for-payables-api#/operations/add-company-to-group) or [Remove company](https://docs.codat.io/sync-for-payables-api#/operations/remove-company-from-group) endpoints to add or remove a company from a group.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;
using System.Collections.Generic;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Companies.UpdateAsync(
    companyId: "8a210b68-6988-11ed-a1eb-0242ac120002",
    companyRequestBody: new CompanyRequestBody() {
        Name = "Bank of Dave",
        Description = "Requested early access to the new financing scheme.",
        Groups = new List<Items>() {
            new Items() {
                Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
            },
        },
    }
);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         | Example                                                             |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `CompanyId`                                                         | *string*                                                            | :heavy_check_mark:                                                  | Unique identifier for a company.                                    | 8a210b68-6988-11ed-a1eb-0242ac120002                                |
| `CompanyRequestBody`                                                | [CompanyRequestBody](../../Models/Components/CompanyRequestBody.md) | :heavy_minus_sign:                                                  | N/A                                                                 |                                                                     |

### Response

**[UpdateCompanyResponse](../../Models/Requests/UpdateCompanyResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Delete

﻿The *Delete company* endpoint permanently deletes a [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company), its [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) and any cached data. This operation is irreversible.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Companies.DeleteAsync(companyId: "8a210b68-6988-11ed-a1eb-0242ac120002");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `CompanyId`                          | *string*                             | :heavy_check_mark:                   | Unique identifier for a company.     | 8a210b68-6988-11ed-a1eb-0242ac120002 |

### Response

**[DeleteCompanyResponse](../../Models/Requests/DeleteCompanyResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |


## Get

﻿The *Get company* endpoint returns a single company for a given `companyId`.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage

```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Companies.GetAsync(companyId: "8a210b68-6988-11ed-a1eb-0242ac120002");

// handle response
```

### Parameters

| Parameter                            | Type                                 | Required                             | Description                          | Example                              |
| ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ | ------------------------------------ |
| `CompanyId`                          | *string*                             | :heavy_check_mark:                   | Unique identifier for a company.     | 8a210b68-6988-11ed-a1eb-0242ac120002 |

### Response

**[GetCompanyResponse](../../Models/Requests/GetCompanyResponse.md)**

### Errors

| Error Object                       | Status Code                        | Content Type                       |
| ---------------------------------- | ---------------------------------- | ---------------------------------- |
| Openapi.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503        | application/json                   |
| Openapi.Models.Errors.SDKException | 4xx-5xx                            | */*                                |
