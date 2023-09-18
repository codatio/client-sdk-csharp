# Customers

## Overview

Customers

### Available Operations

* [Create](#create) - Create customer
* [Get](#get) - Get customer
* [List](#list) - List customers
* [Update](#update) - Update customer

## Create

The *Create customer* endpoint creates a new [customer](https://docs.codat.io/accounting-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/accounting-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/accounting-api#/operations/get-create-update-customers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support creating an account.


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

var res = await sdk.Customers.CreateAsync(new CreateCustomerRequest() {
    Customer = new Customer() {
        Addresses = new List<Items>() {
            new Items() {
                City = "New Humberto",
                Country = "Trinidad and Tobago",
                Line1 = "quidem",
                Line2 = "architecto",
                PostalCode = "96661",
                Region = "dolorem",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "explicabo",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "Halvorsonstead",
                    Country = "Guinea",
                    Line1 = "minima",
                    Line2 = "excepturi",
                    PostalCode = "46991",
                    Region = "mollitia",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Unknown,
                },
                Email = "Caroline_Ziemann@yahoo.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "Claudia Krajcik",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "+44 25691 154789",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Landline,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
            },
        },
        CustomerName = "laborum",
        DefaultCurrency = "USD",
        EmailAddress = "enim",
        Id = "2c3f5ad0-19da-41ff-a78f-097b0074f154",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "(738) 590-2655",
        RegistrationNumber = "pariatur",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Active,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "rem", new Dictionary<string, object>() {
                    { "voluptates", "quasi" },
                } },
            },
        },
        TaxNumber = "repudiandae",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 575947,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [CreateCustomerRequest](../../models/operations/CreateCustomerRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.CreateCustomerResponse](../../models/operations/CreateCustomerResponse.md)**


## Get

The *Get customer* endpoint returns a single customer for a given customerId.

[Customers](https://docs.codat.io/accounting-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support getting a specific customer.

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

var res = await sdk.Customers.GetAsync(new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "veritatis",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [GetCustomerRequest](../../models/operations/GetCustomerRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[GetCustomerResponse](../../models/operations/GetCustomerResponse.md)**


## List

The *List customers* endpoint returns a list of [customers](https://docs.codat.io/accounting-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/accounting-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

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

var res = await sdk.Customers.ListAsync(new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "itaque",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [ListCustomersRequest](../../models/operations/ListCustomersRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[ListCustomersResponse](../../models/operations/ListCustomersResponse.md)**


## Update

The *Update customer* endpoint updates an existing [customer](https://docs.codat.io/accounting-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/accounting-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/accounting-api#/operations/get-create-update-customers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support creating an account.


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

var res = await sdk.Customers.UpdateAsync(new UpdateCustomerRequest() {
    Customer = new Customer() {
        Addresses = new List<Items>() {
            new Items() {
                City = "West Adele",
                Country = "Norway",
                Line1 = "quibusdam",
                Line2 = "explicabo",
                PostalCode = "78221-3550",
                Region = "magni",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Delivery,
            },
        },
        ContactName = "ipsam",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "East Marianostead",
                    Country = "Estonia",
                    Line1 = "facilis",
                    Line2 = "tempore",
                    PostalCode = "94275",
                    Region = "aliquid",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
                },
                Email = "Kianna89@hotmail.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "Arnold Kirlin",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "01224 658 999",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Primary,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
            },
        },
        CustomerName = "cumque",
        DefaultCurrency = "EUR",
        EmailAddress = "ea",
        Id = "6ae395ef-b9ba-488f-ba66-997074ba4469",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "1-911-405-3555 x069",
        RegistrationNumber = "mollitia",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Active,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "dolor", new Dictionary<string, object>() {
                    { "necessitatibus", "odit" },
                } },
            },
        },
        TaxNumber = "nemo",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "quasi",
    ForceUpdate = false,
    TimeoutInMinutes = 435865,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateCustomerRequest](../../models/operations/UpdateCustomerRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.UpdateCustomerResponse](../../models/operations/UpdateCustomerResponse.md)**

