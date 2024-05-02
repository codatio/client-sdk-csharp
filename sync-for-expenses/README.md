# Sync for Expenses
    
<!-- Start Codat Library Description -->
﻿Embedded accounting integrations for corporate card providers.
<!-- End Codat Library Description -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Codat.Sync.Expenses
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CompanyRequestBody req = new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupItems>() {
        new GroupItems() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
    Name = "Bank of Dave",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Companies](docs/sdks/companies/README.md)

* [Create](docs/sdks/companies/README.md#create) - Create company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company
* [List](docs/sdks/companies/README.md#list) - List companies
* [Update](docs/sdks/companies/README.md#update) - Update company

### [Connections](docs/sdks/connections/README.md)

* [Create](docs/sdks/connections/README.md#create) - Create connection
* [CreatePartnerExpenseConnection](docs/sdks/connections/README.md#createpartnerexpenseconnection) - Create partner expense connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [List](docs/sdks/connections/README.md#list) - List connections
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection

### [Accounts](docs/sdks/accounts/README.md)

* [Create](docs/sdks/accounts/README.md#create) - Create account
* [GetCreateModel](docs/sdks/accounts/README.md#getcreatemodel) - Get create account model

### [Customers](docs/sdks/customers/README.md)

* [Create](docs/sdks/customers/README.md#create) - Create customer
* [Get](docs/sdks/customers/README.md#get) - Get customer
* [List](docs/sdks/customers/README.md#list) - List customers
* [Update](docs/sdks/customers/README.md#update) - Update customer

### [Suppliers](docs/sdks/suppliers/README.md)

* [Create](docs/sdks/suppliers/README.md#create) - Create supplier
* [Get](docs/sdks/suppliers/README.md#get) - Get supplier
* [List](docs/sdks/suppliers/README.md#list) - List suppliers
* [Update](docs/sdks/suppliers/README.md#update) - Update supplier

### [ManageData](docs/sdks/managedata/README.md)

* [Get](docs/sdks/managedata/README.md#get) - Get data status
* [GetPullOperation](docs/sdks/managedata/README.md#getpulloperation) - Get pull operation
* [ListPullOperations](docs/sdks/managedata/README.md#listpulloperations) - List pull operations
* [RefreshAllDataTypes](docs/sdks/managedata/README.md#refreshalldatatypes) - Refresh all data
* [RefreshDataType](docs/sdks/managedata/README.md#refreshdatatype) - Refresh data type

### [PushOperations](docs/sdks/pushoperations/README.md)

* [Get](docs/sdks/pushoperations/README.md#get) - Get push operation
* [List](docs/sdks/pushoperations/README.md#list) - List push operations

### [Configuration](docs/sdks/configuration/README.md)

* [Get](docs/sdks/configuration/README.md#get) - Get company configuration
* [GetMappingOptions](docs/sdks/configuration/README.md#getmappingoptions) - Mapping options
* [Set](docs/sdks/configuration/README.md#set) - Set company configuration

### [Expenses](docs/sdks/expenses/README.md)

* [Create](docs/sdks/expenses/README.md#create) - Create expense transaction
* [Update](docs/sdks/expenses/README.md#update) - Update expense transactions

### [Reimbursements](docs/sdks/reimbursements/README.md)

* [Create](docs/sdks/reimbursements/README.md#create) - Create reimbursable expense transaction
* [Update](docs/sdks/reimbursements/README.md#update) - Update reimbursable expense transaction

### [Sync](docs/sdks/sync/README.md)

* [Get](docs/sdks/sync/README.md#get) - Get sync status
* [GetLastSuccessfulSync](docs/sdks/sync/README.md#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](docs/sdks/sync/README.md#getlatestsync) - Latest sync status
* [List](docs/sdks/sync/README.md#list) - List sync statuses

### [TransactionStatus](docs/sdks/transactionstatus/README.md)

* [Get](docs/sdks/transactionstatus/README.md#get) - Get sync transaction
* [List](docs/sdks/transactionstatus/README.md#list) - List sync transactions

### [Attachments](docs/sdks/attachments/README.md)

* [Upload](docs/sdks/attachments/README.md#upload) - Upload attachment

### [Transfers](docs/sdks/transfers/README.md)

* [Create](docs/sdks/transfers/README.md#create) - Create transfer transaction
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.codat.io` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type         | Scheme       |
| ------------ | ------------ | ------------ |
| `AuthHeader` | apiKey       | API key      |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CompanyRequestBody req = new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupItems>() {
        new GroupItems() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
    Name = "Bank of Dave",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503                    | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

### Example

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Shared;
using System;
using Codat.Sync.Expenses.Models.Errors;
using System.Collections.Generic;

var sdk = new CodatSyncExpenses(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CompanyRequestBody req = new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupItems>() {
        new GroupItems() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
    Name = "Bank of Dave",
};

try
{
    var res = await sdk.Companies.CreateAsync(req);
    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorMessage)
    {
        // handle exception
    }
    else if (ex is Codat.Sync.Expenses.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

<!-- Start Codat Support Notes -->
### Support

If you encounter any challenges while utilizing our SDKs, please don't hesitate to reach out for assistance. 
You can raise any issues by contacting your dedicated Codat representative or reaching out to our [support team](mailto:support@codat.io).
We're here to help ensure a smooth experience for you.
<!-- End Codat Support Notes -->

<!-- Start Codat Generated By -->
### Library generated by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
<!-- End Codat Generated By -->