# customers

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
                City = "West Christa",
                Country = "Iceland",
                Line1 = "cupiditate",
                Line2 = "quos",
                PostalCode = "18301",
                Region = "dolorum",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "tempora",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "Riceboro",
                    Country = "Vanuatu",
                    Line1 = "eum",
                    Line2 = "non",
                    PostalCode = "53585-6289",
                    Region = "dolorum",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
                },
                Email = "Rose.Wolff29@yahoo.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "Nathaniel Hyatt",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "+44 25691 154789",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Mobile,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
            },
        },
        CustomerName = "accusamus",
        DefaultCurrency = "EUR",
        EmailAddress = "quidem",
        Id = "9ba88f3a-6699-4707-8ba4-469b6e214195",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "606-963-4281 x3049",
        RegistrationNumber = "debitis",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Archived,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "deleniti", new Dictionary<string, object>() {
                    { "facilis", "in" },
                } },
            },
        },
        TaxNumber = "architecto",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 99569,
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
    CustomerId = "repudiandae",
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
    Query = "ullam",
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
                City = "Kossworth",
                Country = "Sudan",
                Line1 = "sed",
                Line2 = "saepe",
                PostalCode = "01561-1788",
                Region = "maxime",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "excepturi",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "South Alexanneton",
                    Country = "Wallis and Futuna",
                    Line1 = "quidem",
                    Line2 = "ipsam",
                    PostalCode = "47083",
                    Region = "voluptatibus",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Unknown,
                },
                Email = "Darian.Anderson94@hotmail.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "Ernest Hayes",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "+44 25691 154789",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Landline,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
            },
        },
        CustomerName = "eos",
        DefaultCurrency = "GBP",
        EmailAddress = "dolores",
        Id = "c73d5fe9-b90c-4289-89b3-fe49a8d9cbf4",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "1-322-329-5744 x926",
        RegistrationNumber = "numquam",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "ipsa", new Dictionary<string, object>() {
                    { "iure", "odio" },
                } },
            },
        },
        TaxNumber = "quaerat",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "accusamus",
    ForceUpdate = false,
    TimeoutInMinutes = 696344,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateCustomerRequest](../../models/operations/UpdateCustomerRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.UpdateCustomerResponse](../../models/operations/UpdateCustomerResponse.md)**

