# Sales.Orders

## Overview

### Available Operations

* [List](#list) - List orders
* [Get](#get) - Get order

## List

The *List orders* endpoint returns a list of [orders](https://docs.codat.io/lending-api#/schemas/Order) for a given company's connection.

[Orders](https://docs.codat.io/lending-api#/schemas/Order) contain the transaction details for all products sold by the company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage: Amazon Seller Central

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Amazon Seller Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: BigCommerce

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="BigCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Clover

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Clover" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Lightspeed K Trial

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Lightspeed K Trial" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Mollie

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Mollie" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Mollie Test

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Mollie Test" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Partner Commerce

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Partner Commerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: PrestaShop

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="PrestaShop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Shopify

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Shopify" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Square

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Square" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: SumUp

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="SumUp" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: WooCommerce

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="WooCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```
### Example Usage: Zettle

<!-- UsageSnippet language="csharp" operationID="list-commerce-orders" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders" example="Zettle" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceOrdersRequest req = new ListCommerceOrdersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Orders.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [ListCommerceOrdersRequest](../../Models/Requests/ListCommerceOrdersRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[ListCommerceOrdersResponse](../../Models/Requests/ListCommerceOrdersResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get order* endpoint returns a single order for a given orderId.

[Orders](https://docs.codat.io/lending-api#/schemas/Order) contain the transaction details for all products sold by the company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage: Amazon Seller Central

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Amazon Seller Central" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: BigCommerce

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="BigCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Clover

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Clover" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Lightspeed K Trial

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Lightspeed K Trial" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Mollie

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Mollie" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Mollie Test

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Mollie Test" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Partner Commerce

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Partner Commerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: PrestaShop

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="PrestaShop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Shopify

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Shopify" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Square

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Square" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: SumUp

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="SumUp" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: WooCommerce

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="WooCommerce" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```
### Example Usage: Zettle

<!-- UsageSnippet language="csharp" operationID="get-commerce-order" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-orders/{orderId}" example="Zettle" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceOrderRequest req = new GetCommerceOrderRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Orders.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetCommerceOrderRequest](../../Models/Requests/GetCommerceOrderRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetCommerceOrderResponse](../../Models/Requests/GetCommerceOrderResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |