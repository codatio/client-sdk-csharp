# Companies
(*Companies*)

## Overview

Create and manage your SMB users' companies.

### Available Operations

* [List](#list) - List companies
* [Create](#create) - Create company
* [Get](#get) - Get company
* [Delete](#delete) - Delete a company
* [Replace](#replace) - Replace company
* [Update](#update) - Update company
* [AddProduct](#addproduct) - Add product
* [RemoveProduct](#removeproduct) - Remove product
* [RefreshProductData](#refreshproductdata) - Refresh product data
* [GetAccessToken](#getaccesstoken) - Get company access token

## List

﻿The *List companies* endpoint returns a list of [companies](https://docs.codat.io/platform-api#/schemas/Company) associated to your instances.

A [company](https://docs.codat.io/platform-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/platform-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

## Filter by tags

The *List companies* endpoint supports the filtering of companies using [tags](https://docs.codat.io/using-the-api/managing-companies#add-metadata-to-a-company). It supports the following operators with [Codat’s query language](https://docs.codat.io/using-the-api/querying):

- equals (`=`)
- not equals (`!=`)
- contains (`~`)

For example, you can use the querying to filter companies tagged with a specific foreign key, region, or owning team: 
- Foreign key: `uid = {yourCustomerId}`
- Region: `region != uk`
- Owning team and region: `region = uk && owningTeam = invoice-finance`

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-companies" method="get" path="/companies" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429              | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Create

﻿Use the *Create company* endpoint to create a new [company](https://docs.codat.io/platform-api#/schemas/Company) that represents your customer in Codat. 

A [company](https://docs.codat.io/platform-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/platform-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

If forbidden characters (see `name` pattern) are present in the request, a company will be created with the forbidden characters removed. For example, `Company (Codat[1])` with be created as `Company Codat1`.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="create-company" method="post" path="/companies" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Get

﻿The *Get company* endpoint returns a single company for a given `companyId`.

A [company](https://docs.codat.io/platform-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/platform-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-company" method="get" path="/companies/{companyId}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Delete

﻿The *Delete company* endpoint permanently deletes a [company](https://docs.codat.io/platform-api#/schemas/Company), its [connections](https://docs.codat.io/platform-api#/schemas/Connection) and any cached data. This operation is irreversible.

A [company](https://docs.codat.io/platform-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/platform-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="delete-company" method="delete" path="/companies/{companyId}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Replace

﻿Use the *Replace company* endpoint to replace the existing name, description, and tags of the company. Calling the endpoint will replace existing values even if new values haven't been defined in the payload.

A [company](https://docs.codat.io/platform-api#/schemas/Company) represents a business sharing access to their data.
Each company can have multiple [connections](https://docs.codat.io/platform-api#/schemas/Connection) to different data sources, such as one connection to Xero for accounting data, two connections to Plaid for two bank accounts, and a connection to Zettle for POS data.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="replace-company" method="put" path="/companies/{companyId}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Update

﻿Use the *Update company* endpoint to update the name, description, or tags of the company.

The *Update company* endpoint doesn't have any required fields. If any of the fields provided are `null` or not provided, they won't be included in the update.  

A [company](https://docs.codat.io/platform-api#/schemas/Company) represents a business sharing access to their data.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="update-company" method="patch" path="/companies/{companyId}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## AddProduct

Use the *Add product* endpoint to enable a product for the company specified by `companyId`.

> Note: This feature is currently in alpha and available only to participants in the development program.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="add-product" method="put" path="/companies/{companyId}/products/{productIdentifier}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

AddProductRequest req = new AddProductRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ProductIdentifier = "bank-feeds",
};

var res = await sdk.Companies.AddProductAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [AddProductRequest](../../Models/Requests/AddProductRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[AddProductResponse](../../Models/Requests/AddProductResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## RemoveProduct

Use the *Remove product* endpoint to disable a product for the company specified by `companyId`.

> Note: This feature is currently in alpha and available only to participants in the development program.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="remove-product" method="delete" path="/companies/{companyId}/products/{productIdentifier}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RemoveProductRequest req = new RemoveProductRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ProductIdentifier = "bank-feeds",
};

var res = await sdk.Companies.RemoveProductAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [RemoveProductRequest](../../Models/Requests/RemoveProductRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[RemoveProductResponse](../../Models/Requests/RemoveProductResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## RefreshProductData

Use the **Refresh product data** endpoint to manually refresh data for a custom product for a specific company.

### Tips and traps

- This endpoint only supports refreshing data for **custom products** and can't be used for Codat's standard solutions. Refer to [individual solutions' documentation](https://docs.codat.io/) instead.
- If a data sync is already in progress for a custom product, the refresh request will return a `Bad request (400)` response.
- If a company has multiple custom products enabled, you can refresh data for each product individually.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="refresh-product-data" method="post" path="/companies/{companyId}/products/{productIdentifier}/refresh" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

RefreshProductDataRequest req = new RefreshProductDataRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ProductIdentifier = "bank-feeds",
};

var res = await sdk.Companies.RefreshProductDataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [RefreshProductDataRequest](../../Models/Requests/RefreshProductDataRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[RefreshProductDataResponse](../../Models/Requests/RefreshProductDataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429              | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## GetAccessToken

Use the _Get company access token_ endpoint to return an access token for the specified company ID. The token is valid for one day. 

The token is required by Codat's embeddable UIs (such as [Connections SDK](https://docs.codat.io/auth-flow/optimize/connection-management) and [Link SDK](https://docs.codat.io/auth-flow/authorize-embedded-link)) to verify the identity of the user and improve the reliability of data provided by them.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-company-access-token" method="get" path="/companies/{companyId}/accessToken" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyAccessTokenRequest req = new GetCompanyAccessTokenRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Companies.GetAccessTokenAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCompanyAccessTokenRequest](../../Models/Requests/GetCompanyAccessTokenRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetCompanyAccessTokenResponse](../../Models/Requests/GetCompanyAccessTokenResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |