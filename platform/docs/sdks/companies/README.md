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

﻿Creates a new company that can be used to assign connections to. 

If forbidden characters (see `name` pattern) are present in the request, a company will be created with the forbidden characters removed. For example, `Company (Codat[1])` with be created as `Company Codat1`.



### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Companies.CreateAsync(new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [CompanyRequestBody](../../Models/Shared/CompanyRequestBody.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[CreateCompanyResponse](../../Models/Operations/CreateCompanyResponse.md)**


## Delete

﻿
Permanently deletes a company, its connections and any cached data. This operation is irreversible. If the company ID does not exist an error is returned.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Companies.DeleteAsync(new DeleteCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [DeleteCompanyRequest](../../Models/Operations/DeleteCompanyRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[DeleteCompanyResponse](../../Models/Operations/DeleteCompanyResponse.md)**


## Get

﻿Returns the company for a valid identifier. If the identifier is for a deleted company, a not found response is returned.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Companies.GetAsync(new GetCompanyRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetCompanyRequest](../../Models/Operations/GetCompanyRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetCompanyResponse](../../Models/Operations/GetCompanyResponse.md)**


## List

﻿Returns a list of your companies. The company schema contains a list of [connections](https://docs.codat.io/platform-api#/schemas/Connection) related to the company.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Companies.ListAsync(new ListCompaniesRequest() {
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


## Update

﻿Updates both the name and description of the company.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Companies.UpdateAsync(new UpdateCompanyRequest() {
    CompanyRequestBody = new CompanyRequestBody() {
        Description = "Requested early access to the new financing scheme.",
        Name = "Bank of Dave",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateCompanyRequest](../../Models/Operations/UpdateCompanyRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[UpdateCompanyResponse](../../Models/Operations/UpdateCompanyResponse.md)**

