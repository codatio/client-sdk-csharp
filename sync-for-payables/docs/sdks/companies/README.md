# Companies

## Overview

Create and manage your SMB users' companies.

### Available Operations

* [List](#list) - List companies
* [Create](#create) - Create company
* [Replace](#replace) - Replace company
* [Update](#update) - Update company
* [Delete](#delete) - Delete a company
* [Get](#get) - Get company

## List

﻿The *List companies* endpoint returns a list of [companies](https://docs.codat.io/sync-for-payables-api#/schemas/Company) associated to your instances.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

## Filter by tags

The *List companies* endpoint supports the filtering of companies using [tags](https://docs.codat.io/using-the-api/managing-companies#add-metadata-to-a-company). It supports the following operators with [Codat’s query language](https://docs.codat.io/using-the-api/querying):

- equals (`=`)
- not equals (`!=`)
- contains (`~`)

For example, you can use the querying to filter companies tagged with a specific foreign key, region, or owning team: 
- Foreign key: `uid = {yourCustomerId}`
- Region: `region != uk`
- Owning team and region: `region = uk && owningTeam = invoice-finance`

### Example Usage: List of Companies

<!-- UsageSnippet language="csharp" operationID="list-companies" method="get" path="/companies" example="List of Companies" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
### Example Usage: One company

<!-- UsageSnippet language="csharp" operationID="list-companies" method="get" path="/companies" example="One company" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCompaniesRequest](../../Models/Requests/ListCompaniesRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListCompaniesResponse](../../Models/Requests/ListCompaniesResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

﻿Use the *Create company* endpoint to create a new [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) that represents your customer in Codat. 

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

If forbidden characters (see `name` pattern) are present in the request, a company will be created with the forbidden characters removed. For example, `Company (Codat[1])` with be created as `Company Codat1`.

### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-company" method="post" path="/companies" example="Malformed query" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
### Example Usage: With a description

<!-- UsageSnippet language="csharp" operationID="create-company" method="post" path="/companies" example="With a description" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Technicalium",
    Description = "Technology services, including web and app design and development",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
### Example Usage: With a tag

<!-- UsageSnippet language="csharp" operationID="create-company" method="post" path="/companies" example="With a tag" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
### Example Usage: With no description

<!-- UsageSnippet language="csharp" operationID="create-company" method="post" path="/companies" example="With no description" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Technicalium",
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

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400, 401, 402, 403, 429                        | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Replace

﻿Use the *Replace company* endpoint to replace the existing name, description, and tags of the company. Calling the endpoint will replace existing values even if new values haven't been defined in the payload.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

### Example Usage: Unauthorized

<!-- UsageSnippet language="csharp" operationID="replace-company" method="put" path="/companies/{companyId}" example="Unauthorized" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ReplaceCompanyRequest req = new ReplaceCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyRequestBody = new CompanyRequestBody() {
        Name = "Bank of Dave",
        Description = "Requested early access to the new financing scheme.",
    },
};

var res = await sdk.Companies.ReplaceAsync(req);

// handle response
```
### Example Usage: Update description

<!-- UsageSnippet language="csharp" operationID="replace-company" method="put" path="/companies/{companyId}" example="Update description" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ReplaceCompanyRequest req = new ReplaceCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyRequestBody = new CompanyRequestBody() {
        Name = "Same name",
        Description = "Additional documents required",
    },
};

var res = await sdk.Companies.ReplaceAsync(req);

// handle response
```
### Example Usage: Update name

<!-- UsageSnippet language="csharp" operationID="replace-company" method="put" path="/companies/{companyId}" example="Update name" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ReplaceCompanyRequest req = new ReplaceCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyRequestBody = new CompanyRequestBody() {
        Name = "New Name",
    },
};

var res = await sdk.Companies.ReplaceAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ReplaceCompanyRequest](../../Models/Requests/ReplaceCompanyRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ReplaceCompanyResponse](../../Models/Requests/ReplaceCompanyResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Update

﻿Use the *Update company* endpoint to update the name, description, or tags of the company.

The *Update company* endpoint doesn't have any required fields. If any of the fields provided are `null` or not provided, they won't be included in the update.  

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.

### Example Usage: Unauthorized

<!-- UsageSnippet language="csharp" operationID="update-company" method="patch" path="/companies/{companyId}" example="Unauthorized" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateCompanyRequest req = new UpdateCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyUpdateRequest = new CompanyUpdateRequest() {
        Name = "Bank of Dave",
        Description = "Requested early access to the new financing scheme.",
    },
};

var res = await sdk.Companies.UpdateAsync(req);

// handle response
```
### Example Usage: Update name

<!-- UsageSnippet language="csharp" operationID="update-company" method="patch" path="/companies/{companyId}" example="Update name" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateCompanyRequest req = new UpdateCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyUpdateRequest = new CompanyUpdateRequest() {
        Name = "New Name",
    },
};

var res = await sdk.Companies.UpdateAsync(req);

// handle response
```
### Example Usage: Update tags

<!-- UsageSnippet language="csharp" operationID="update-company" method="patch" path="/companies/{companyId}" example="Update tags" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateCompanyRequest req = new UpdateCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyUpdateRequest = new CompanyUpdateRequest() {
        Tags = new Dictionary<string, string>() {
            { "refrence", "new reference" },
        },
    },
};

var res = await sdk.Companies.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [UpdateCompanyRequest](../../Models/Requests/UpdateCompanyRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[UpdateCompanyResponse](../../Models/Requests/UpdateCompanyResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Delete

﻿The *Delete company* endpoint permanently deletes a [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company), its [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) and any cached data. This operation is irreversible.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="delete-company" method="delete" path="/companies/{companyId}" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DeleteCompanyRequest req = new DeleteCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.DeleteAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [DeleteCompanyRequest](../../Models/Requests/DeleteCompanyRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[DeleteCompanyResponse](../../Models/Requests/DeleteCompanyResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Get

﻿The *Get company* endpoint returns a single company for a given `companyId`.

A [company](https://docs.codat.io/sync-for-payables-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/sync-for-payables-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage: Parent multi-entity company

<!-- UsageSnippet language="csharp" operationID="get-company" method="get" path="/companies/{companyId}" example="Parent multi-entity company" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyRequest req = new GetCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.GetAsync(req);

// handle response
```
### Example Usage: Simple company

<!-- UsageSnippet language="csharp" operationID="get-company" method="get" path="/companies/{companyId}" example="Simple company" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyRequest req = new GetCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.GetAsync(req);

// handle response
```
### Example Usage: Subsidiary multi-entity company

<!-- UsageSnippet language="csharp" operationID="get-company" method="get" path="/companies/{companyId}" example="Subsidiary multi-entity company" -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyRequest req = new GetCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetCompanyRequest](../../Models/Requests/GetCompanyRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetCompanyResponse](../../Models/Requests/GetCompanyResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |