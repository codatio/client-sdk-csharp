# CodatLendingSuppliers
(*LoanWriteback.Suppliers*)

### Available Operations

* [Create](#create) - Create supplier
* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update supplier model

## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/lending-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/lending-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/lending-api#/operations/get-create-update-suppliers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateSupplierRequest req = new CreateSupplierRequest() {
    AccountingSupplier = new AccountingSupplier() {
        Addresses = new List<AccountingAddress>() {
            new AccountingAddress() {
                Type = AccountingAddressType.Billing,
            },
        },
        Metadata = new Metadata() {},
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "(877) 492-8687",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = SupplierStatus.Active,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "key", new Dictionary<string, object>() {
                    { "key", "string" },
                } },
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateSupplierRequest](../../Models/Operations/CreateSupplierRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[CreateSupplierResponse](../../Models/Operations/CreateSupplierResponse.md)**


## GetCreateUpdateModel

The *Get create/update supplier model* endpoint returns the expected data for the request payload when creating and updating a [supplier](https://docs.codat.io/lending-api#/schemas/Supplier) for a given company and integration.

[Suppliers](https://docs.codat.io/lending-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=suppliers) for integrations that support creating and updating a supplier.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetCreateUpdateSuppliersModelRequest](../../Models/Operations/GetCreateUpdateSuppliersModelRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[GetCreateUpdateSuppliersModelResponse](../../Models/Operations/GetCreateUpdateSuppliersModelResponse.md)**

