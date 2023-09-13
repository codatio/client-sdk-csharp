# Sales.Customers

### Available Operations

* [Get](#get) - Get customer
* [List](#list) - List customers

## Get

The *Get customer* endpoint returns a single customer for a given customerId.

[Customers](https://docs.codat.io/commerce-api#/schemas/Customer) are people or organizations that place orders, make payments and receive goods and/or services from the SMB.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&dataType=commerce-customers) for integrations that support getting a specific customer.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sales.Customers.GetAsync(new GetCommerceCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "iure",
});

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetCommerceCustomerRequest](../../models/operations/GetCommerceCustomerRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetCommerceCustomerResponse](../../models/operations/GetCommerceCustomerResponse.md)**


## List

The *List customers* endpoint returns a list of [customers](https://docs.codat.io/commerce-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/commerce-api#/schemas/Customer) are people or organizations that place orders, make payments and recieve goods and/or services from the SMB.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Sales.Customers.ListAsync(new ListCommerceCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "culpa",
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListCommerceCustomersRequest](../../models/operations/ListCommerceCustomersRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListCommerceCustomersResponse](../../models/operations/ListCommerceCustomersResponse.md)**

