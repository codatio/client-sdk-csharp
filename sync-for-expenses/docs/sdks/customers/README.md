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
                City = "Fort Manuelachester",
                Country = "Oman",
                Line1 = "dolores",
                Line2 = "dolorem",
                PostalCode = "17363",
                Region = "minima",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
            },
        },
        ContactName = "accusantium",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "Lorenzaworth",
                    Country = "Uzbekistan",
                    Line1 = "architecto",
                    Line2 = "mollitia",
                    PostalCode = "61965",
                    Region = "numquam",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Billing,
                },
                Email = "Jarred.Frami@yahoo.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "Kayla O'Kon",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "01224 658 999",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Primary,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Archived,
            },
        },
        CustomerName = "ipsam",
        DefaultCurrency = "USD",
        EmailAddress = "possimus",
        Id = "019da1ff-e78f-4097-b007-4f15471b5e6e",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "755.825.5909",
        RegistrationNumber = "sint",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Archived,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "incidunt", new Dictionary<string, object>() {
                    { "enim", "consequatur" },
                } },
            },
        },
        TaxNumber = "est",
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TimeoutInMinutes = 842342,
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
    CustomerId = "explicabo",
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
    Query = "deserunt",
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
                City = "Spencerboro",
                Country = "Eritrea",
                Line1 = "qui",
                Line2 = "aliquid",
                PostalCode = "50183-0165",
                Region = "tempora",
                Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Delivery,
            },
        },
        ContactName = "tempore",
        Contacts = new List<Contact>() {
            new Contact() {
                Address = new Items() {
                    City = "Fort Horacio",
                    Country = "Ecuador",
                    Line1 = "eligendi",
                    Line2 = "sint",
                    PostalCode = "58562",
                    Region = "debitis",
                    Type = CodatSyncExpenses.Models.Shared.AccountingAddressType.Delivery,
                },
                Email = "Isadore_Kirlin69@hotmail.com",
                ModifiedDate = "2022-10-23T00:00:00.000Z",
                Name = "Blanca Schulist",
                Phone = new List<ContactPhone>() {
                    new ContactPhone() {
                        Number = "01224 658 999",
                        Type = CodatSyncExpenses.Models.Shared.PhoneNumberType.Unknown,
                    },
                },
                Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Unknown,
            },
        },
        CustomerName = "occaecati",
        DefaultCurrency = "GBP",
        EmailAddress = "accusamus",
        Id = "fb9ba88f-3a66-4997-874b-a4469b6e2141",
        Metadata = new Metadata() {
            IsDeleted = false,
        },
        ModifiedDate = "2022-10-23T00:00:00.000Z",
        Phone = "(655) 269-6342 x813",
        RegistrationNumber = "quasi",
        SourceModifiedDate = "2022-10-23T00:00:00.000Z",
        Status = CodatSyncExpenses.Models.Shared.CustomerStatus.Archived,
        SupplementalData = new SupplementalData() {
            Content = new Dictionary<string, Dictionary<string, object>>() {
                { "debitis", new Dictionary<string, object>() {
                    { "eius", "maxime" },
                } },
            },
        },
        TaxNumber = "deleniti",
    },
    AllowSyncOnPushComplete = false,
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "facilis",
    ForceUpdate = false,
    TimeoutInMinutes = 447926,
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [UpdateCustomerRequest](../../models/operations/UpdateCustomerRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[Models.Operations.UpdateCustomerResponse](../../models/operations/UpdateCustomerResponse.md)**

