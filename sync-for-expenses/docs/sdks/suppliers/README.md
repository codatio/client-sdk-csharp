# Suppliers
(*Suppliers*)

## Overview

Suppliers

### Available Operations

* [Create](#create) - Create supplier
* [Get](#get) - Get supplier
* [List](#list) - List suppliers
* [Update](#update) - Update supplier

## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateSupplierRequest req = new CreateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<Items>() {
            new Items() {
                City = "Bakersfield",
                Country = "USA",
                Line1 = "Unit 51",
                Line2 = "Bakersfield Industrial Estate",
                Region = "California",
                Type = AccountingAddressType.Billing,
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
        Status = SupplierStatus.Unknown,
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


## Get

The *Get supplier* endpoint returns a single supplier for a given supplierId.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support getting a specific supplier.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetSupplierRequest req = new GetSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SupplierId = "7110701885",
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


## List

The *List suppliers* endpoint returns a list of [suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListSuppliersRequest req = new ListSuppliersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
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


## Update

The *Update supplier* endpoint updates an existing [supplier](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/sync-for-expenses-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateSupplierRequest req = new UpdateSupplierRequest() {
    Supplier = new Supplier() {
        Addresses = new List<Items>() {
            new Items() {
                City = "Bakersfield",
                Country = "USA",
                Line1 = "Unit 51",
                Line2 = "Bakersfield Industrial Estate",
                Region = "California",
                Type = AccountingAddressType.Billing,
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
        Status = SupplierStatus.Unknown,
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
    SupplierId = "EILBDVJVNUAGVKRQ",
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

