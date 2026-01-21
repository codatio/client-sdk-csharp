# Sales.Customers

## Overview

### Available Operations

* [List](#list) - List customers
* [Get](#get) - Get customer

## List

The *List customers* endpoint returns a list of [customers](https://docs.codat.io/lending-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/lending-api#/schemas/Customer) are people or organizations that place orders, make payments and recieve goods and/or services from the SMB.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-commerce-customers" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-customers" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCommerceCustomersRequest req = new ListCommerceCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Sales.Customers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListCommerceCustomersRequest](../../Models/Requests/ListCommerceCustomersRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[ListCommerceCustomersResponse](../../Models/Requests/ListCommerceCustomersResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get customer* endpoint returns a single customer for a given customerId.

[Customers](https://docs.codat.io/lending-api#/schemas/Customer) are people or organizations that place orders, make payments and receive goods and/or services from the SMB.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-commerce-customer" method="get" path="/companies/{companyId}/connections/{connectionId}/data/commerce-customers/{customerId}" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCommerceCustomerRequest req = new GetCommerceCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.Sales.Customers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetCommerceCustomerRequest](../../Models/Requests/GetCommerceCustomerRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[GetCommerceCustomerResponse](../../Models/Requests/GetCommerceCustomerResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |