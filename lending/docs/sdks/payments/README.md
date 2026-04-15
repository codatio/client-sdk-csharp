# AccountsReceivable.Payments

## Overview

### Available Operations

* [List](#list) - List payments
* [Get](#get) - Get payment

## List

The *List payments* endpoint returns a list of [payments](https://docs.codat.io/lending-api#/schemas/Payment) for a given company's connection.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="list-accounting-payments" method="get" path="/companies/{companyId}/data/payments" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingPaymentsRequest req = new ListAccountingPaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.Payments.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListAccountingPaymentsRequest](../../Models/Requests/ListAccountingPaymentsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[ListAccountingPaymentsResponse](../../Models/Requests/ListAccountingPaymentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get payment* endpoint returns a single payment for a given paymentId.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) represent an allocation of money within any customer accounts receivable account.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Clear Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Clear Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Dynamics 365 Business Central

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Dynamics 365 Business Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: FreshBooks

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="FreshBooks" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: KashFlow

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="KashFlow" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Sage 200cloud

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Sage 200cloud" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```
### Example Usage: Zoho Books

<!-- UsageSnippet language="csharp" operationID="get-accounting-payment" method="get" path="/companies/{companyId}/data/payments/{paymentId}" example="Zoho Books" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingPaymentRequest req = new GetAccountingPaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsReceivable.Payments.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetAccountingPaymentRequest](../../Models/Requests/GetAccountingPaymentRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[GetAccountingPaymentResponse](../../Models/Requests/GetAccountingPaymentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |