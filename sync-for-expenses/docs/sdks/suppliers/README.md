# suppliers

## Overview

Suppliers

### Available Operations

* [Create](#create) - Create supplier
* [Get](#get) - Get supplier
* [List](#list) - List suppliers
* [Update](#update) - Update supplier

## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/accounting-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/accounting-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/accounting-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating an account.


### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.CreateAsync(new CreateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<SupplierAccountingAddress>() {
            new SupplierAccountingAddress() {
                City = "Kohlerberg",
                Country = "Faroe Islands",
                Line1 = "qui",
                Line2 = "cupiditate",
                PostalCode = "87165-2117",
                Region = "facilis",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "quam",
        DefaultCurrency = "molestias",
        EmailAddress = "temporibus",
        Id = "2322715b-f0cb-4b1e-b1b8-b90f3443a110",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "01224 658 999",
        RegistrationNumber = "consequatur",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.SupplierStatus.Archived,
        SupplementalData = new SupplierSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "porro", new Dictionary<string, object>() {
                    { "doloribus", "ut" },
                } },
            },
        },
        SupplierName = "facilis",
        TaxNumber = "cupiditate",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 181631,
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

The *Get supplier* endpoint returns a single supplier for a given supplierId.

[Suppliers](https://docs.codat.io/accounting-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support getting a specific supplier.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).


### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.GetAsync(new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetSupplierRequest](../../models/operations/GetSupplierRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[GetSupplierResponse](../../models/operations/GetSupplierResponse.md)**


## List

The *List suppliers* endpoint returns a list of [suppliers](https://docs.codat.io/accounting-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/accounting-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.ListAsync(new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "laudantium",
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

The *Update supplier* endpoint updates an existing [supplier](https://docs.codat.io/accounting-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/accounting-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/accounting-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating an account.


### Example Usage

```csharp
using CodatSyncExpenses;
using CodatSyncExpenses.Models.Shared;
using CodatSyncExpenses.Models.Operations;

var sdk = new CodatSyncExpensesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Suppliers.UpdateAsync(new UpdateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<SupplierAccountingAddress>() {
            new SupplierAccountingAddress() {
                City = "Krisworth",
                Country = "Senegal",
                Line1 = "vero",
                Line2 = "omnis",
                PostalCode = "29428",
                Region = "tenetur",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "hic",
        DefaultCurrency = "distinctio",
        EmailAddress = "quod",
        Id = "7abd74dd-39c0-4f5d-acff-7c70a45626d4",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "(877) 492-8687",
        RegistrationNumber = "laudantium",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.SupplierStatus.Unknown,
        SupplementalData = new SupplierSupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "maiores", new Dictionary<string, object>() {
                    { "quasi", "ex" },
                } },
            },
        },
        SupplierName = "nulla",
        TaxNumber = "excepturi",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    ForceUpdate = false,
    SupplierId = "EILBDVJVNUAGVKRQ",
    TimeoutInMinutes = 343605,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateSupplierRequest](../../models/operations/UpdateSupplierRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.UpdateSupplierResponse](../../models/operations/UpdateSupplierResponse.md)**

