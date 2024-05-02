# ProductCategories
(*Sales.ProductCategories*)

### Available Operations

* [Get](#get) - Get product category
* [List](#list) - List product categories

## Get

The *Get product* endpoint returns a single product for a given productId.

[Product categories](https://docs.codat.io/lending-api#/schemas/ProductCategory) are used to classify a group of products together, either by type (e.g. "Furniture"), or sometimes by tax profile.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/commerce?view=tab-by-data-type&dataType=commerce-productCategories) for integrations that support getting a specific product.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCommerceProductCategoryRequest req = new GetCommerceProductCategoryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ProductId = "<value>",
};

var res = await sdk.Sales.ProductCategories.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetCommerceProductCategoryRequest](../../Models/Operations/GetCommerceProductCategoryRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[GetCommerceProductCategoryResponse](../../Models/Operations/GetCommerceProductCategoryResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## List

The *List product categories* endpoint returns a list of [product categories](https://docs.codat.io/lending-api#/schemas/ProductCategory) for a given company's connection.

[Product categories](https://docs.codat.io/lending-api#/schemas/ProductCategory) are used to classify a group of products together, either by type (e.g. "Furniture"), or sometimes by tax profile.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListCommerceProductCategoriesRequest req = new ListCommerceProductCategoriesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Sales.ProductCategories.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [ListCommerceProductCategoriesRequest](../../Models/Operations/ListCommerceProductCategoriesRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[ListCommerceProductCategoriesResponse](../../Models/Operations/ListCommerceProductCategoriesResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503      | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
