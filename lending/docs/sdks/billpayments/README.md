# AccountsPayable.BillPayments

## Overview

### Available Operations

* [List](#list) - List bill payments
* [Get](#get) - Get bill payment

## List

The *List bill payments* endpoint returns a list of [bill payments](https://docs.codat.io/lending-api#/schemas/BillPayment) for a given company's connection.

[Bill payments](https://docs.codat.io/lending-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-payments" method="get" path="/companies/{companyId}/data/billPayments" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillPaymentsRequest req = new ListAccountingBillPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.BillPayments.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAccountingBillPaymentsRequest](../../Models/Requests/ListAccountingBillPaymentsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListAccountingBillPaymentsResponse](../../Models/Requests/ListAccountingBillPaymentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get bill payment* endpoint returns a single bill payment for a given billPaymentId.

[Bill payments](https://docs.codat.io/lending-api#/schemas/BillPayment) are an allocation of money within any customer accounts payable account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-payment" method="get" path="/companies/{companyId}/data/billPayments/{billPaymentId}" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillPaymentRequest req = new GetAccountingBillPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillPaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.BillPayments.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetAccountingBillPaymentRequest](../../Models/Requests/GetAccountingBillPaymentRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[GetAccountingBillPaymentResponse](../../Models/Requests/GetAccountingBillPaymentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |