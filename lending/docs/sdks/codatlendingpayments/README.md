# Sales.Payments

## Overview

### Available Operations

* [List](#list) - List payments
* [Get](#get) - Get payment

## List

The *List payments* endpoint returns a list of [payments](https://docs.codat.io/lending-api#/schemas/Payment) for a given company's connection.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) contain details of all payments made by customers to the company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: BigCommerce

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="BigCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: Clover

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="Clover" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: Lightspeed K Trial

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="Lightspeed K Trial" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: Mollie

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="Mollie" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: PrestaShop

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="PrestaShop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: Shopify

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="Shopify" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: SumUp

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="SumUp" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: WooCommerce

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="WooCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```
### Example Usage: Zettle

<!-- UsageSnippet language="csharp" operationID="list-commerce-payments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments" example="Zettle" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommercePaymentsRequest req = new ListCommercePaymentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Payments.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [ListCommercePaymentsRequest](../../Models/Requests/ListCommercePaymentsRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |

### Response

**[ListCommercePaymentsResponse](../../Models/Requests/ListCommercePaymentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get payment* endpoint returns a single payment for a given paymentId.

[Payments](https://docs.codat.io/lending-api#/schemas/Payment) contain details of all payments made by customers to the company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: BigCommerce

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="BigCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: Clover

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="Clover" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: Lightspeed K Trial

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="Lightspeed K Trial" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: Mollie

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="Mollie" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: PrestaShop

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="PrestaShop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: Shopify

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="Shopify" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: SumUp

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="SumUp" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: WooCommerce

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="WooCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```
### Example Usage: Zettle

<!-- UsageSnippet language="csharp" operationID="get-commerce-payment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-payments/{paymentId}" example="Zettle" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommercePaymentRequest req = new GetCommercePaymentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    PaymentId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Payments.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetCommercePaymentRequest](../../Models/Requests/GetCommercePaymentRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetCommercePaymentResponse](../../Models/Requests/GetCommercePaymentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |