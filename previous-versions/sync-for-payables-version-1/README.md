# Sync for Payables

<!-- Start Codat Library Description -->
Streamline your customers' accounts payable workflow.
<!-- End Codat Library Description -->

<!-- Start Summary [summary] -->
## Summary

Sync for Payables: The API for Sync for Payables. 

Sync for Payables is an API and a set of supporting tools built to help integrate with your customers' accounting software, and keep their supplier information, invoices, and payments in sync.

[Explore product](https://docs.codat.io/payables/overview) | [See OpenAPI spec](https://github.com/codatio/oas)

---
<!-- Start Codat Tags Table -->
## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Accounts | Get, create, and update Accounts. |
| Bank accounts | Get, create, and update Bank accounts. |
| Bills | Get, create, and update Bills. |
| Bill credit notes | Get, create, and update Bill credit notes. |
| Bill payments | Get, create, and update Bill payments. |
| Journals | Get, create, and update Journals. |
| Journal entries | Get, create, and update Journal entries. |
| Payment methods | Get, create, and update Payment methods. |
| Suppliers | Get, create, and update Suppliers. |
| Tax rates | Get, create, and update Tax rates. |
| Tracking categories | Get, create, and update Tracking categories. |
| Company info | View company profile from the source platform. |
| Push operations | View historic push operations. |
| Manage data | Control how data is retrieved from an integration. |
<!-- End Codat Tags Table -->
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents

* [SDK Installation](#sdk-installation)
* [SDK Example Usage](#sdk-example-usage)
* [Available Resources and Operations](#available-resources-and-operations)
* [Retries](#retries)
* [Error Handling](#error-handling)
* [Server Selection](#server-selection)
* [Authentication](#authentication)
<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package Codat.Sync.Payables.V1
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/Sync/Payables/V1/Codat.Sync.Payables.V1.csproj
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Accounts](docs/sdks/accounts/README.md)

* [List](docs/sdks/accounts/README.md#list) - List accounts
* [Get](docs/sdks/accounts/README.md#get) - Get account
* [GetCreateModel](docs/sdks/accounts/README.md#getcreatemodel) - Get create account model
* [Create](docs/sdks/accounts/README.md#create) - Create account

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [GetCreateModel](docs/sdks/bankaccounts/README.md#getcreatemodel) - Get create/update bank account model
* [Create](docs/sdks/bankaccounts/README.md#create) - Create bank account

### [BillCreditNotes](docs/sdks/billcreditnotes/README.md)

* [List](docs/sdks/billcreditnotes/README.md#list) - List bill credit notes
* [Get](docs/sdks/billcreditnotes/README.md#get) - Get bill credit note
* [GetCreateUpdateModel](docs/sdks/billcreditnotes/README.md#getcreateupdatemodel) - Get create/update bill credit note model
* [Create](docs/sdks/billcreditnotes/README.md#create) - Create bill credit note
* [Update](docs/sdks/billcreditnotes/README.md#update) - Update bill credit note

### [BillPayments](docs/sdks/billpayments/README.md)

* [List](docs/sdks/billpayments/README.md#list) - List bill payments
* [Get](docs/sdks/billpayments/README.md#get) - Get bill payment
* [Delete](docs/sdks/billpayments/README.md#delete) - Delete bill payment
* [GetCreateModel](docs/sdks/billpayments/README.md#getcreatemodel) - Get create bill payment model
* [Create](docs/sdks/billpayments/README.md#create) - Create bill payments

### [Bills](docs/sdks/bills/README.md)

* [List](docs/sdks/bills/README.md#list) - List bills
* [Get](docs/sdks/bills/README.md#get) - Get bill
* [GetCreateUpdateModel](docs/sdks/bills/README.md#getcreateupdatemodel) - Get create/update bill model
* [Create](docs/sdks/bills/README.md#create) - Create bill
* [Update](docs/sdks/bills/README.md#update) - Update bill
* [Delete](docs/sdks/bills/README.md#delete) - Delete bill
* [ListAttachments](docs/sdks/bills/README.md#listattachments) - List bill attachments
* [GetAttachment](docs/sdks/bills/README.md#getattachment) - Get bill attachment
* [DeleteAttachment](docs/sdks/bills/README.md#deleteattachment) - Delete bill attachment
* [DownloadAttachment](docs/sdks/bills/README.md#downloadattachment) - Download bill attachment
* [UploadAttachment](docs/sdks/bills/README.md#uploadattachment) - Upload bill attachment


### [Companies](docs/sdks/companies/README.md)

* [List](docs/sdks/companies/README.md#list) - List companies
* [Create](docs/sdks/companies/README.md#create) - Create company
* [Update](docs/sdks/companies/README.md#update) - Update company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company

### [CompanyInfo](docs/sdks/companyinfo/README.md)

* [GetAccountingProfile](docs/sdks/companyinfo/README.md#getaccountingprofile) - Get company accounting profile

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection

### [JournalEntries](docs/sdks/journalentries/README.md)

* [GetCreateModel](docs/sdks/journalentries/README.md#getcreatemodel) - Get create journal entry model
* [Create](docs/sdks/journalentries/README.md#create) - Create journal entry

### [Journals](docs/sdks/journals/README.md)

* [List](docs/sdks/journals/README.md#list) - List journals
* [Get](docs/sdks/journals/README.md#get) - Get journal
* [GetCreateModel](docs/sdks/journals/README.md#getcreatemodel) - Get create journal model
* [Create](docs/sdks/journals/README.md#create) - Create journal

### [ManageData](docs/sdks/managedata/README.md)

* [RefreshAllDataTypes](docs/sdks/managedata/README.md#refreshalldatatypes) - Refresh all data
* [Get](docs/sdks/managedata/README.md#get) - Get data status
* [RefreshDataType](docs/sdks/managedata/README.md#refreshdatatype) - Refresh data type
* [ListPullOperations](docs/sdks/managedata/README.md#listpulloperations) - List pull operations
* [GetPullOperation](docs/sdks/managedata/README.md#getpulloperation) - Get pull operation

### [PaymentMethods](docs/sdks/paymentmethods/README.md)

* [List](docs/sdks/paymentmethods/README.md#list) - List payment methods
* [Get](docs/sdks/paymentmethods/README.md#get) - Get payment method

### [PushOperations](docs/sdks/pushoperations/README.md)

* [List](docs/sdks/pushoperations/README.md#list) - List push operations
* [Get](docs/sdks/pushoperations/README.md#get) - Get push operation

### [Suppliers](docs/sdks/suppliers/README.md)

* [List](docs/sdks/suppliers/README.md#list) - List suppliers
* [Get](docs/sdks/suppliers/README.md#get) - Get supplier
* [GetCreateUpdateModel](docs/sdks/suppliers/README.md#getcreateupdatemodel) - Get create/update supplier model
* [Create](docs/sdks/suppliers/README.md#create) - Create supplier
* [Update](docs/sdks/suppliers/README.md#update) - Update supplier

### [TaxRates](docs/sdks/taxrates/README.md)

* [List](docs/sdks/taxrates/README.md#list) - List all tax rates
* [Get](docs/sdks/taxrates/README.md#get) - Get tax rate

### [TrackingCategories](docs/sdks/trackingcategories/README.md)

* [List](docs/sdks/trackingcategories/README.md#list) - List tracking categories
* [Get](docs/sdks/trackingcategories/README.md#get) - Get tracking categories

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),req);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                                      | Status Code                                       | Content Type                                      |
| ------------------------------------------------- | ------------------------------------------------- | ------------------------------------------------- |
| Codat.Sync.Payables.V1.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                   | application/json                                  |
| Codat.Sync.Payables.V1.Models.Errors.SDKException | 4xx-5xx                                           | */*                                               |

### Example

```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;
using System;
using Codat.Sync.Payables.V1.Models.Errors;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

try
{
    ListCompaniesRequest req = new ListCompaniesRequest() {
        Page = 1,
        PageSize = 100,
        Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
        OrderBy = "-modifiedDate",
    };

    var res = await sdk.Companies.ListAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorMessage)
    {
        // handle exception
    }
    else if (ex is Codat.Sync.Payables.V1.Models.Errors.SDKException)
    {
        // handle exception
    }
}
```
<!-- End Error Handling [errors] -->

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

To authenticate with the API the `AuthHeader` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Codat.Sync.Payables.V1;
using Codat.Sync.Payables.V1.Models.Requests;
using Codat.Sync.Payables.V1.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End Authentication [security] -->

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