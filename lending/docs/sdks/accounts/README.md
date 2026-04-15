# FinancialStatements.Accounts

## Overview

### Available Operations

* [List](#list) - List accounts
* [Get](#get) - Get account

## List

﻿The *List accounts* endpoint returns a list of [accounts](https://docs.codat.io/lending-api#/schemas/Account) for a given company's connection.

[Accounts](https://docs.codat.io/lending-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Wave" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-accounts" method="get" path="/companies/{companyId}/data/accounts" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingAccountsRequest req = new ListAccountingAccountsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.FinancialStatements.Accounts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingAccountsRequest](../../Models/Requests/ListAccountingAccountsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingAccountsResponse](../../Models/Requests/ListAccountingAccountsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get account* endpoint returns a single account for a given accountId.

[Accounts](https://docs.codat.io/lending-api#/schemas/Account) are the categories a business uses to record accounting transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Wave

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Wave" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-account" method="get" path="/companies/{companyId}/data/accounts/{accountId}" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingAccountRequest req = new GetAccountingAccountRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    AccountId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.FinancialStatements.Accounts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetAccountingAccountRequest](../../Models/Requests/GetAccountingAccountRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetAccountingAccountResponse](../../Models/Requests/GetAccountingAccountResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |