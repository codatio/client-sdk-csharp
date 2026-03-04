# Suppliers

## Overview

Get, create, and update suppliers.

### Available Operations

* [List](#list) - List suppliers
* [Get](#get) - Get supplier
* [Create](#create) - Create supplier
* [Update](#update) - Update supplier

## List

The *List suppliers* endpoint returns a list of [suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-all-data-types).

### Supported Integrations

| Integration                   | Supported |
|-------------------------------|-----------|
| Dynamics 365 Business Central | Yes       |
| FreeAgent                     | Yes       |
| Oracle NetSuite               | Yes       |
| QuickBooks Desktop            | Yes       |
| QuickBooks Online             | Yes       |
| Sage Intacct                  | Yes       |
| Xero                          | Yes       |
| Zoho Books                    | Yes       |


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Clear Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Exact (Netherlands)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Exact (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="FreeAgent" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="FreshBooks" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="KashFlow" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Oracle NetSuite" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="QuickBooks Desktop" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="QuickBooks Online" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Sage 200cloud" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Sage 50 (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Sage Intacct" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Wave" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Xero" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="list-suppliers" method="get" path="/companies/{companyId}/data/suppliers" example="Zoho Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListSuppliersRequest](../../Models/Requests/ListSuppliersRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListSuppliersResponse](../../Models/Requests/ListSuppliersResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429              | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Get

The *Get supplier* endpoint returns a single supplier for a given supplierId.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-all-data-types).

### Supported Integrations

| Integration                   | Supported |
|-------------------------------|-----------|
| Dynamics 365 Business Central | Yes       |
| FreeAgent                     | Yes       |
| Oracle NetSuite               | Yes       |
| QuickBooks Desktop            | Yes       |
| QuickBooks Online             | Yes       |
| Sage Intacct                  | Yes       |
| Xero                          | Yes       |
| Zoho Books                    | Yes       |


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Clear Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Exact (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="FreeAgent" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="FreshBooks" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="KashFlow" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Oracle NetSuite" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="QuickBooks Online" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Sage 200cloud" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Sage Intacct" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Wave" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Xero" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-supplier" method="get" path="/companies/{companyId}/data/suppliers/{supplierId}" example="Zoho Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetSupplierRequest](../../Models/Requests/GetSupplierRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetSupplierResponse](../../Models/Requests/GetSupplierResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-suppliers-model).

### Supported Integrations

| Integration                   | Supported |
|-------------------------------|-----------|
| Dynamics 365 Business Central | Yes       |
| FreeAgent                     | Yes       |
| Oracle NetSuite               | Yes       |
| QuickBooks Desktop            | Yes       |
| QuickBooks Online             | Yes       |
| Sage Intacct                  | Yes       |
| Xero                          | Yes       |
| Zoho Books                    | Yes       |


### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-supplier" method="post" path="/companies/{companyId}/connections/{connectionId}/push/suppliers" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateSupplierRequest req = new CreateSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Supplier = new Supplier() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Id = "C520FFD4-F6F6-4FC2-A6D2-5D7088B2B14F",
        SupplierName = "Kelly's Industrial Supplies",
        ContactName = "Kelly's Industrial Supplies",
        EmailAddress = "sales@kellysupplies.com",
        Phone = "07999 999999",
        Addresses = new List<Items>() {
            new Items() {
                Type = AccountingAddressType.Billing,
                Line1 = "Unit 51",
                Line2 = "Bakersfield Industrial Estate",
                City = "Bakersfield",
                Region = "California",
                Country = "USA",
            },
        },
        RegistrationNumber = "string",
        TaxNumber = "string",
        Status = SupplierStatus.Unknown,
        DefaultCurrency = "string",
        Metadata = new Metadata() {
            IsDeleted = true,
        },
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "property1", new Dictionary<string, object>() {
                    { "property1", "<value>" },
                    { "property2", "<value>" },
                } },
                { "property2", new Dictionary<string, object>() {
                    { "property1", "<value>" },
                    { "property2", "<value>" },
                } },
            },
        },
    },
};

var res = await sdk.Suppliers.CreateAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="create-supplier" method="post" path="/companies/{companyId}/connections/{connectionId}/push/suppliers" example="Sage Intacct" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateSupplierRequest req = new CreateSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Supplier = new Supplier() {
        Id = "73593",
        SupplierName = "test 20230420 1004",
        ContactName = "Joe Bloggs",
        Status = SupplierStatus.Active,
    },
};

var res = await sdk.Suppliers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateSupplierRequest](../../Models/Requests/CreateSupplierRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[Models.Requests.CreateSupplierResponse](../../Models/Requests/CreateSupplierResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Update

The *Update supplier* endpoint updates an existing [supplier](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-suppliers-model).

### Supported Integrations

| Integration       | Supported |
|-------------------|-----------|
| FreeAgent         | Yes       |
| QuickBooks Online | Yes       |
| Xero              | Yes       |


### Example Usage

<!-- UsageSnippet language="csharp" operationID="update-supplier" method="put" path="/companies/{companyId}/connections/{connectionId}/push/suppliers/{supplierId}" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateSupplierRequest req = new UpdateSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    Supplier = new Supplier() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Id = "C520FFD4-F6F6-4FC2-A6D2-5D7088B2B14F",
        SupplierName = "Kelly's Industrial Supplies",
        ContactName = "Kelly's Industrial Supplies",
        EmailAddress = "sales@kellysupplies.com",
        Phone = "07999 999999",
        Addresses = new List<Items>() {
            new Items() {
                Type = AccountingAddressType.Billing,
                Line1 = "Unit 51",
                Line2 = "Bakersfield Industrial Estate",
                City = "Bakersfield",
                Region = "California",
                Country = "USA",
            },
        },
        RegistrationNumber = "string",
        TaxNumber = "string",
        Status = SupplierStatus.Unknown,
        DefaultCurrency = "string",
        Metadata = new Metadata() {
            IsDeleted = true,
        },
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "property1", new Dictionary<string, object>() {
                    { "property1", "<value>" },
                    { "property2", "<value>" },
                } },
                { "property2", new Dictionary<string, object>() {
                    { "property1", "<value>" },
                    { "property2", "<value>" },
                } },
            },
        },
    },
};

var res = await sdk.Suppliers.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateSupplierRequest](../../Models/Requests/UpdateSupplierRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[Models.Requests.UpdateSupplierResponse](../../Models/Requests/UpdateSupplierResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |