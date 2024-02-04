# Customers
(*Customers*)

## Overview

Customers

### Available Operations

* [Create](#create) - Create customer
* [Get](#get) - Get customer
* [List](#list) - List customers
* [Update](#update) - Update customer

## Create

The *Create customer* endpoint creates a new [customer](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateCustomerRequest req = new CreateCustomerRequest() {
    Customer = new Customer() {
        Addresses = new List<AccountingAddress>() {
            new AccountingAddress() {
                Type = AccountingAddressType.Billing,
            },
        },
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    Type = AccountingAddressType.Billing,
                },
                ModifiedDate = "2022-10-23T00:00:00Z",
                Phone = new List<Phone>() {
                    new Phone() {
                        Number = "01224 658 999",
                        Type = PhoneNumberType.Mobile,
                    },
                },
                Status = CustomerStatus.Unknown,
            },
        },
        DefaultCurrency = "GBP",
        Metadata = new Metadata() {},
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Status = CustomerStatus.Archived,
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

var res = await sdk.Customers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateCustomerRequest](../../Models/Operations/CreateCustomerRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.CreateCustomerResponse](../../Models/Operations/CreateCustomerResponse.md)**


## Get

The *Get customer* endpoint returns a single customer for a given customerId.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support getting a specific customer.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "string",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetCustomerRequest](../../Models/Operations/GetCustomerRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[GetCustomerResponse](../../Models/Operations/GetCustomerResponse.md)**


## List

The *List customers* endpoint returns a list of [customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListCustomersRequest](../../Models/Operations/ListCustomersRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListCustomersResponse](../../Models/Operations/ListCustomersResponse.md)**


## Update

The *Update customer* endpoint updates an existing [customer](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using Codat.Sync.Expenses.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UpdateCustomerRequest req = new UpdateCustomerRequest() {
    Customer = new Customer() {
        Addresses = new List<AccountingAddress>() {
            new AccountingAddress() {
                Type = AccountingAddressType.Delivery,
            },
        },
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    Type = AccountingAddressType.Unknown,
                },
                ModifiedDate = "2022-10-23T00:00:00Z",
                Phone = new List<Phone>() {
                    new Phone() {
                        Number = "+44 25691 154789",
                        Type = PhoneNumberType.Landline,
                    },
                },
                Status = CustomerStatus.Archived,
            },
        },
        DefaultCurrency = "EUR",
        Metadata = new Metadata() {},
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        Status = CustomerStatus.Archived,
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
    CustomerId = "string",
};

var res = await sdk.Customers.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateCustomerRequest](../../Models/Operations/UpdateCustomerRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.UpdateCustomerResponse](../../Models/Operations/UpdateCustomerResponse.md)**

