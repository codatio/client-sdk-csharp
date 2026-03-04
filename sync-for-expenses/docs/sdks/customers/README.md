# Customers

## Overview

Get, create, and update customers.

### Available Operations

* [List](#list) - List customers
* [Get](#get) - Get customer
* [Create](#create) - Create customer
* [Update](#update) - Update customer

## List

The *List customers* endpoint returns a list of [customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).
    

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Clear Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Exact (Netherlands)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Exact (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="FreeAgent" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="FreshBooks" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="KashFlow" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Oracle NetSuite" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="QuickBooks Desktop" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="QuickBooks Online" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Sage 200cloud" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Sage 50 (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Sage Intacct" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Wave" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Xero" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="list-customers" method="get" path="/companies/{companyId}/data/customers" example="Zoho Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCustomersRequest](../../Models/Requests/ListCustomersRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListCustomersResponse](../../Models/Requests/ListCustomersResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429              | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Get

The *Get customer* endpoint returns a single customer for a given customerId.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Clear Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Exact (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="FreeAgent" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="FreshBooks" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="KashFlow" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Oracle NetSuite" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="QuickBooks Online" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Sage 200cloud" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Sage Intacct" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Wave" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Xero" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-customer" method="get" path="/companies/{companyId}/data/customers/{customerId}" example="Zoho Books" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetCustomerRequest](../../Models/Requests/GetCustomerRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetCustomerResponse](../../Models/Requests/GetCustomerResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Create

The *Create customer* endpoint creates a new [customer](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="create-customer" method="post" path="/companies/{companyId}/connections/{connectionId}/push/customers" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateCustomerRequest req = new CreateCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Customer = new Customer() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        DefaultCurrency = "GBP",
        Contacts = new List<Contact>() {
            new Contact() {
                Phone = null,
                Status = CustomerStatus.Unknown,
                ModifiedDate = "2022-10-23T00:00:00Z",
            },
        },
        Status = CustomerStatus.Unknown,
    },
};

var res = await sdk.Customers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateCustomerRequest](../../Models/Requests/CreateCustomerRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[Models.Requests.CreateCustomerResponse](../../Models/Requests/CreateCustomerResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Update

The *Update customer* endpoint updates an existing [customer](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="update-customer" method="put" path="/companies/{companyId}/connections/{connectionId}/push/customers/{customerId}" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateCustomerRequest req = new UpdateCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    Customer = new Customer() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        DefaultCurrency = "GBP",
        Contacts = new List<Contact>() {
            new Contact() {
                Phone = new List<PhoneNumberItems>() {
                    new PhoneNumberItems() {
                        Number = "+44 25691 154789",
                        Type = ItemsType.Primary,
                    },
                },
                Status = CustomerStatus.Unknown,
                ModifiedDate = "2022-10-23T00:00:00Z",
            },
        },
        Status = CustomerStatus.Active,
    },
};

var res = await sdk.Customers.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateCustomerRequest](../../Models/Requests/UpdateCustomerRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[Models.Requests.UpdateCustomerResponse](../../Models/Requests/UpdateCustomerResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |