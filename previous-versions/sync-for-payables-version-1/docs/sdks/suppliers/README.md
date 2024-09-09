# Suppliers
(*Suppliers*)

## Overview

Get, create, and update Suppliers.

### Available Operations

* [Create](#create) - Create supplier
* [Get](#get) - Get supplier
* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update supplier model
* [List](#list) - List suppliers
* [Update](#update) - Update supplier

## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating a supplier.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Operations;
using Codat.Sync.Payables.V1.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CreateSupplierRequest req = new CreateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<Address>() {
            new Address() {
                City = "Bakersfield",
                Country = "USA",
                Line1 = "Unit 51",
                Line2 = "Bakersfield Industrial Estate",
                Region = "California",
                Type = Codat.Sync.Payables.V1.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "Kelly's Industrial Supplies",
        DefaultCurrency = "string",
        EmailAddress = "sales@kellysupplies.com",
        Id = "C520FFD4-F6F6-4FC2-A6D2-5D7088B2B14F",
        Metadata = new Metadata() {
            IsDeleted = true,
        },
        ModifiedDate = "2022-10-23T00:00:00Z",
        Phone = "07999 999999",
        RegistrationNumber = "string",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Status = Codat.Sync.Payables.V1.Models.Shared.SupplierStatus.Unknown,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "property1", new Dictionary<string, object>() {
                    { "property1", null },
                    { "property2", null },
                } },
                { "property2", new Dictionary<string, object>() {
                    { "property1", null },
                    { "property2", null },
                } },
            },
        },
        SupplierName = "Kelly's Industrial Supplies",
        TaxNumber = "string",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Suppliers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateSupplierRequest](../../Models/Operations/CreateSupplierRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[Models.Operations.CreateSupplierResponse](../../Models/Operations/CreateSupplierResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Get

The *Get supplier* endpoint returns a single supplier for a given `supplierId`.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support getting a specific supplier.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Operations;
using Codat.Sync.Payables.V1.Models.Shared;

var sdk = new CodatSyncPayables(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "<value>",
};

var res = await sdk.Suppliers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetSupplierRequest](../../Models/Operations/GetSupplierRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[GetSupplierResponse](../../Models/Operations/GetSupplierResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## GetCreateUpdateModel

The *Get create/update supplier model* endpoint returns the expected data for the request payload when creating and updating a [supplier](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company and integration.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating and updating a supplier.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Operations;
using Codat.Sync.Payables.V1.Models.Shared;

var sdk = new CodatSyncPayables(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetCreateUpdateSupplierModelRequest req = new GetCreateUpdateSupplierModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetCreateUpdateSupplierModelRequest](../../Models/Operations/GetCreateUpdateSupplierModelRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[GetCreateUpdateSupplierModelResponse](../../Models/Operations/GetCreateUpdateSupplierModelResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                       | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## List

The *List suppliers* endpoint returns a list of [suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Operations;
using Codat.Sync.Payables.V1.Models.Shared;

var sdk = new CodatSyncPayables(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
};

var res = await sdk.Suppliers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListSuppliersRequest](../../Models/Operations/ListSuppliersRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[ListSuppliersResponse](../../Models/Operations/ListSuppliersResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503               | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |


## Update

The *Update supplier* endpoint updates an existing [supplier](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating a supplier.


### Example Usage

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Operations;
using Codat.Sync.Payables.V1.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatSyncPayables(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

UpdateSupplierRequest req = new UpdateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<Address>() {
            new Address() {
                City = "Bakersfield",
                Country = "USA",
                Line1 = "Unit 51",
                Line2 = "Bakersfield Industrial Estate",
                Region = "California",
                Type = Codat.Sync.Payables.V1.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "Kelly's Industrial Supplies",
        DefaultCurrency = "string",
        EmailAddress = "sales@kellysupplies.com",
        Id = "C520FFD4-F6F6-4FC2-A6D2-5D7088B2B14F",
        Metadata = new Metadata() {
            IsDeleted = true,
        },
        ModifiedDate = "2022-10-23T00:00:00Z",
        Phone = "07999 999999",
        RegistrationNumber = "string",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Status = Codat.Sync.Payables.V1.Models.Shared.SupplierStatus.Unknown,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "property1", new Dictionary<string, object>() {
                    { "property1", null },
                    { "property2", null },
                } },
                { "property2", new Dictionary<string, object>() {
                    { "property1", null },
                    { "property2", null },
                } },
            },
        },
        SupplierName = "Kelly's Industrial Supplies",
        TaxNumber = "string",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    SupplierId = "<value>",
};

var res = await sdk.Suppliers.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateSupplierRequest](../../Models/Operations/UpdateSupplierRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |

### Response

**[Models.Operations.UpdateSupplierResponse](../../Models/Operations/UpdateSupplierResponse.md)**

### Errors

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |
