# suppliers

## Overview

Suppliers

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
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.CreateAsync(new CreateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<SupplierAddresses>() {
            new SupplierAddresses() {
                City = "South Pollyshire",
                Country = "Cayman Islands",
                Line1 = "aspernatur",
                Line2 = "sequi",
                PostalCode = "85913-7808",
                Region = "inventore",
                Type = CodatSyncPayables.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "quibusdam",
        DefaultCurrency = "excepturi",
        EmailAddress = "nostrum",
        Id = "9f439e39-266c-4bd9-9f7a-a2b24113695d",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "01224 658 999",
        RegistrationNumber = "nisi",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.SupplierStatus.Active,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "repellat", new Dictionary<string, object>() {
                    { "eligendi", "quaerat" },
                    { "veniam", "perspiciatis" },
                    { "commodi", "dolores" },
                    { "dicta", "molestiae" },
                } },
                { "maxime", new Dictionary<string, object>() {
                    { "molestias", "quam" },
                } },
                { "molestiae", new Dictionary<string, object>() {
                    { "voluptate", "eum" },
                    { "consectetur", "velit" },
                } },
            },
        },
        SupplierName = "tempora",
        TaxNumber = "aspernatur",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 323569,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateSupplierRequest](../../models/operations/CreateSupplierRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.CreateSupplierResponse](../../models/operations/CreateSupplierResponse.md)**


## Get

The *Get supplier* endpoint returns a single supplier for a given `supplierId`.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support getting a specific supplier.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.GetAsync(new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "incidunt",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetSupplierRequest](../../models/operations/GetSupplierRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[GetSupplierResponse](../../models/operations/GetSupplierResponse.md)**


## GetCreateUpdateModel

The *Get create/update supplier model* endpoint returns the expected data for the request payload when creating and updating a [supplier](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company and integration.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating and updating a supplier.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.GetCreateUpdateModelAsync(new GetCreateUpdateSupplierModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetCreateUpdateSupplierModelRequest](../../models/operations/GetCreateUpdateSupplierModelRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |


### Response

**[GetCreateUpdateSupplierModelResponse](../../models/operations/GetCreateUpdateSupplierModelResponse.md)**


## List

The *List suppliers* endpoint returns a list of [suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payables-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.ListAsync(new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "alias",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListSuppliersRequest](../../models/operations/ListSuppliersRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListSuppliersResponse](../../models/operations/ListSuppliersResponse.md)**


## Update

The *Update supplier* endpoint updates an existing [supplier](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-payables-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/sync-for-payables-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating a supplier.


### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.UpdateAsync(new UpdateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<SupplierAddresses>() {
            new SupplierAddresses() {
                City = "Murlworth",
                Country = "Portugal",
                Line1 = "minima",
                Line2 = "cupiditate",
                PostalCode = "08550",
                Region = "perspiciatis",
                Type = CodatSyncPayables.Models.Shared.AccountingAddressType.Unknown,
            },
        },
        ContactName = "corporis",
        DefaultCurrency = "ullam",
        EmailAddress = "molestiae",
        Id = "389cedba-c7fd-4a39-994d-66bc2ae48063",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "01224 658 999",
        RegistrationNumber = "iste",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncPayables.Models.Shared.SupplierStatus.Unknown,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "libero", new Dictionary<string, object>() {
                    { "voluptatibus", "id" },
                    { "qui", "explicabo" },
                } },
                { "accusantium", new Dictionary<string, object>() {
                    { "nesciunt", "commodi" },
                    { "molestias", "atque" },
                } },
            },
        },
        SupplierName = "explicabo",
        TaxNumber = "totam",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    SupplierId = "ipsam",
    TimeoutInMinutes = 367727,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateSupplierRequest](../../models/operations/UpdateSupplierRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.UpdateSupplierResponse](../../models/operations/UpdateSupplierResponse.md)**
