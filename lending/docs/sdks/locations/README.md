# Locations
(*Sales.Locations*)

### Available Operations

* [Get](#get) - Get location
* [List](#list) - List locations

## Get

The *Get location* endpoint returns a single location for a given locationId.

[Locations](https://docs.codat.io/lending-api#/schemas/Location) hold information on the geographic location at which stocks of [products](https://docs.codat.io/lending-api#/schemas/Product) may be held or where [orders](https://docs.codat.io/lending-api#/schemas/Order) were placed.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&dataType=commerce-locations) for integrations that support getting a specific location.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCommerceLocationRequest req = new GetCommerceLocationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    LocationId = "<value>",
};

var res = await sdk.Sales.Locations.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GetCommerceLocationRequest](../../Models/Operations/GetCommerceLocationRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GetCommerceLocationResponse](../../Models/Operations/GetCommerceLocationResponse.md)**


## List

The *List locations* endpoint returns a list of [locations](https://docs.codat.io/lending-api#/schemas/Location) for a given company's connection.

[Locations](https://docs.codat.io/lending-api#/schemas/Location) hold information on the geographic location at which stocks of [products](https://docs.codat.io/lending-api#/schemas/Product) may be held or where [orders](https://docs.codat.io/lending-api#/schemas/Order) were placed.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListCommerceLocationsRequest req = new ListCommerceLocationsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Sales.Locations.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [ListCommerceLocationsRequest](../../Models/Operations/ListCommerceLocationsRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[ListCommerceLocationsResponse](../../Models/Operations/ListCommerceLocationsResponse.md)**

