# Customers
(*Customers*)

## Overview

Get, create, and update customers.

### Available Operations

* [List](#list) - List customers
* [Get](#get) - Get customer
* [Create](#create) - Create customer
* [Update](#update) - Update customer

## List

The *List customers* endpoint returns a list of [customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Requests;
using Codat.Sync.Expenses.Models.Components;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCustomersRequest req = new ListCustomersRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Customers.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [ListCustomersRequest](../../Models/Requests/ListCustomersRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[ListCustomersResponse](../../Models/Requests/ListCustomersResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503            | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |


## Get

The *Get customer* endpoint returns a single customer for a given customerId.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support getting a specific customer.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-expenses-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Requests;
using Codat.Sync.Expenses.Models.Components;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCustomerRequest req = new GetCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CustomerId = "<value>",
};

var res = await sdk.Customers.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetCustomerRequest](../../Models/Requests/GetCustomerRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetCustomerResponse](../../Models/Requests/GetCustomerResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |


## Create

The *Create customer* endpoint creates a new [customer](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Requests;
using Codat.Sync.Expenses.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateCustomerRequest req = new CreateCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Customer = new Customer() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        DefaultCurrency = "GBP",
        Contacts = new List<Contact>() {
            new Contact() {
                Phone = new List<Phone>() {
                    new Phone() {
                        Number = "01224 658 999",
                        Type = Codat.Sync.Expenses.Models.Components.PhoneNumberType.Primary,
                    },
                },
                Status = Codat.Sync.Expenses.Models.Components.CustomerStatus.Archived,
                ModifiedDate = "2022-10-23T00:00:00Z",
            },
        },
        Status = Codat.Sync.Expenses.Models.Components.CustomerStatus.Archived,
    },
};

var res = await sdk.Customers.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [CreateCustomerRequest](../../Models/Requests/CreateCustomerRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[Models.Requests.CreateCustomerResponse](../../Models/Requests/CreateCustomerResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |


## Update

The *Update customer* endpoint updates an existing [customer](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) for a given company's connection.

[Customers](https://docs.codat.io/sync-for-expenses-api#/schemas/Customer) are people or organizations that buy goods or services from the SMB.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create/update customer model](https://docs.codat.io/sync-for-expenses-api#/operations/get-create-update-customers-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=customers) for integrations that support creating an account.


### Example Usage

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Requests;
using Codat.Sync.Expenses.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateCustomerRequest req = new UpdateCustomerRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    CustomerId = "<value>",
    Customer = new Customer() {
        ModifiedDate = "2022-10-23T00:00:00Z",
        SourceModifiedDate = "2022-10-23T00:00:00Z",
        DefaultCurrency = "EUR",
        Contacts = new List<Contact>() {
            new Contact() {
                Phone = new List<Phone>() {
                    new Phone() {
                        Number = "+44 25691 154789",
                        Type = Codat.Sync.Expenses.Models.Components.PhoneNumberType.Fax,
                    },
                },
                Status = Codat.Sync.Expenses.Models.Components.CustomerStatus.Archived,
                ModifiedDate = "2022-10-23T00:00:00Z",
            },
        },
        Status = Codat.Sync.Expenses.Models.Components.CustomerStatus.Archived,
    },
};

var res = await sdk.Customers.UpdateAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [UpdateCustomerRequest](../../Models/Requests/UpdateCustomerRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[Models.Requests.UpdateCustomerResponse](../../Models/Requests/UpdateCustomerResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
