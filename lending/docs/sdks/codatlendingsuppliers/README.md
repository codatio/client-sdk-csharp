# LoanWriteback.Suppliers

## Overview

### Available Operations

* [GetCreateUpdateModel](#getcreateupdatemodel) - Get create/update supplier model
* [Create](#create) - Create supplier

## GetCreateUpdateModel

The *Get create/update supplier model* endpoint returns the expected data for the request payload when creating and updating a [supplier](https://docs.codat.io/lending-api#/schemas/Supplier) for a given company and integration.

[Suppliers](https://docs.codat.io/lending-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behavior**

See the *response examples* for integration-specific indicative models.


### Example Usage: Exact (Netherlands)

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Exact (Netherlands)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: Exact (UK)

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Exact (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: FreeAgent

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="FreeAgent" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: MYOB AccountRight and Essentials

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="MYOB AccountRight and Essentials" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: Oracle NetSuite

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Oracle NetSuite" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Desktop

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="QuickBooks Desktop" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="QuickBooks Online" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: QuickBooks Online Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="QuickBooks Online Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: Sage 50 (UK)

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Sage 50 (UK)" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: Sage Business Cloud Accounting

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Sage Business Cloud Accounting" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: Sandbox

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Sandbox" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```
### Example Usage: Xero

<!-- UsageSnippet language="csharp" operationID="get-create-update-suppliers-model" method="get" path="/companies/{companyId}/connections/{connectionId}/options/suppliers" example="Xero" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateSuppliersModelRequest req = new GetCreateUpdateSuppliersModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.LoanWriteback.Suppliers.GetCreateUpdateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [GetCreateUpdateSuppliersModelRequest](../../Models/Requests/GetCreateUpdateSuppliersModelRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[GetCreateUpdateSuppliersModelResponse](../../Models/Requests/GetCreateUpdateSuppliersModelResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Create

The *Create supplier* endpoint creates a new [supplier](https://docs.codat.io/lending-api#/schemas/Supplier) for a given company's connection.

[Suppliers](https://docs.codat.io/lending-api#/schemas/Supplier) are people or organizations that provide something, such as a product or service.

**Integration-specific behavior**

Required data may vary by integration. To see what data to post, first call [Get create/update supplier model](https://docs.codat.io/lending-api#/operations/get-create-update-suppliers-model).


### Example Usage: Malformed query

<!-- UsageSnippet language="csharp" operationID="create-supplier" method="post" path="/companies/{companyId}/connections/{connectionId}/push/suppliers" example="Malformed query" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateSupplierRequest req = new CreateSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingSupplier = new AccountingSupplier() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Id = "C520FFD4-F6F6-4FC2-A6D2-5D7088B2B14F",
        SupplierName = "Kelly's Industrial Supplies",
        ContactName = "Kelly's Industrial Supplies",
        EmailAddress = "sales@kellysupplies.com",
        Phone = "07999 999999",
        Addresses = new List<AccountingAddress>() {
            new AccountingAddress() {
                Type = AccountingAddressType.Billing,
                Line1 = "Unit 51",
                Line2 = "Bakersfield Industrial Estate",
                City = "Bakersfield",
                Region = "California",
                Country = "USA",
            },
        },
        RegistrationNumber = "string",
        TaxNumber = "string",
        Status = SupplierStatus.Unknown,
        DefaultCurrency = "string",
        Metadata = new Metadata() {
            IsDeleted = true,
        },
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "property1", new Dictionary<string, object>() {
                    { "property1", "<value>" },
                    { "property2", "<value>" },
                } },
                { "property2", new Dictionary<string, object>() {
                    { "property1", "<value>" },
                    { "property2", "<value>" },
                } },
            },
        },
    },
};

var res = await sdk.LoanWriteback.Suppliers.CreateAsync(req);

// handle response
```
### Example Usage: Sage Intacct

<!-- UsageSnippet language="csharp" operationID="create-supplier" method="post" path="/companies/{companyId}/connections/{connectionId}/push/suppliers" example="Sage Intacct" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateSupplierRequest req = new CreateSupplierRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    AccountingSupplier = new AccountingSupplier() {
        Id = "73593",
        SupplierName = "test 20230420 1004",
        ContactName = "Joe Bloggs",
        Status = SupplierStatus.Active,
    },
};

var res = await sdk.LoanWriteback.Suppliers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateSupplierRequest](../../Models/Requests/CreateSupplierRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[CreateSupplierResponse](../../Models/Requests/CreateSupplierResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |