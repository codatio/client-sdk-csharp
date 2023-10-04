# CustomersSDK
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
                City = "Jenafurt",
                Country = "Sweden",
                Line1 = "innovative blue",
                Line2 = "grey technology East",
                PostalCode = "30778",
                Region = "quantify Polestar mobile",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "Durham after",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "Darenberg",
                    Country = "Cote d'Ivoire",
                    Line1 = "Buckinghamshire functionalities Grocery",
                    Line2 = "Metal",
                    PostalCode = "61380",
                    Region = "Interactions Senior Mouse",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Unknown,
                },
                Email = "Judd27@hotmail.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "transmit likewise",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "(877) 492-8687",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Fax,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Active,
            },
        },
        CustomerName = "Rubber silver Indiana",
        DefaultCurrency = "EUR",
        EmailAddress = "Thea_Ritchie76@hotmail.com",
        Id = "<ID>",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "948.595.2034",
        RegistrationNumber = "digital",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "recusandae", new Dictionary<string, object>() {
                    { "maiores", "Mongolia" },
                } },
            },
        },
        TaxNumber = "discrete",
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 522311,
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

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

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
    CustomerId = "Northeast Hatchback Kia",
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

The *List customers* endpoint returns a list of [customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

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
    Query = "Northeast Metal Canada",
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

The *Update customer* endpoint updates an existing [customer](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model).

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
                City = "Ann Arbor",
                Country = "Montserrat",
                Line1 = "Reactive",
                Line2 = "Metal cheater Islands",
                PostalCode = "43372",
                Region = "Carolina syndicate",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "East",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "Olenfurt",
                    Country = "Paraguay",
                    Line1 = "Home users Sharable",
                    Line2 = "Lev Wooden",
                    PostalCode = "36848",
                    Region = "brightly",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Delivery,
                },
                Email = "Josie49@yahoo.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "possimus navigating Diesel",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "+44 25691 154789",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Primary,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
            },
        },
        CustomerName = "Reactive Global Northeast",
        DefaultCurrency = "USD",
        EmailAddress = "Abe.Bogan@hotmail.com",
        Id = "<ID>",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "(883) 732-4217 x6499",
        RegistrationNumber = "redundant ew",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Active,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "asperiores", new Dictionary<string, object>() {
                    { "quibusdam", "Omnigender" },
                } },
            },
        },
        TaxNumber = "Volkswagen Specialist Bacon",
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "Copper port East",
    ForceUpdate = false,
    TimeoutInMinutes = 373959,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateCustomerRequest](../../models/operations/UpdateCustomerRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.UpdateCustomerResponse](../../models/operations/UpdateCustomerResponse.md)**

