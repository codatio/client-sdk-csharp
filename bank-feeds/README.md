# Bank Feeds

<!-- Start Codat Library Description -->
﻿Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting platforms.
<!-- End Codat Library Description -->

<!-- Start Summary [summary] -->
## Summary

Bank Feeds API: Bank Feeds API enables your SMB users to set up bank feeds from accounts in your application to supported accounting software.

A bank feed is a connection between a source bank account in your application and a target bank account in a supported accounting software.

[Explore product](https://docs.codat.io/bank-feeds-api/overview) | [See OpenAPI spec](https://github.com/codatio/oas)

---
<!-- Start Codat Tags Table -->
## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Source accounts | Provide and manage lists of source bank accounts. |
| Account mapping | Extra functionality for building an account management UI. |
| Company information | Get detailed information about a company from the underlying platform. |
| Transactions | Create new bank account transactions for a company's connections, and see previous operations. |
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
dotnet add package Codat.BankFeeds
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/BankFeeds/Codat.BankFeeds.csproj
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupReference>() {
        new GroupReference() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AccountMapping](docs/sdks/accountmapping/README.md)

* [Get](docs/sdks/accountmapping/README.md#get) - List bank feed account mappings
* [Create](docs/sdks/accountmapping/README.md#create) - Create bank feed account mapping

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [List](docs/sdks/bankaccounts/README.md#list) - List bank accounts
* [GetCreateModel](docs/sdks/bankaccounts/README.md#getcreatemodel) - Get create/update bank account model
* [Create](docs/sdks/bankaccounts/README.md#create) - Create bank account


### [Companies](docs/sdks/companies/README.md)

* [Create](docs/sdks/companies/README.md#create) - Create company
* [List](docs/sdks/companies/README.md#list) - List companies
* [Get](docs/sdks/companies/README.md#get) - Get company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Update](docs/sdks/companies/README.md#update) - Update company

### [CompanyInformation](docs/sdks/companyinformation/README.md)

* [Get](docs/sdks/companyinformation/README.md#get) - Get company information

### [Configuration](docs/sdks/configuration/README.md)

* [Get](docs/sdks/configuration/README.md#get) - Get configuration
* [Set](docs/sdks/configuration/README.md#set) - Set configuration

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection

### [SourceAccounts](docs/sdks/sourceaccounts/README.md)

* [Create](docs/sdks/sourceaccounts/README.md#create) - Create source account
* [List](docs/sdks/sourceaccounts/README.md#list) - List source accounts
* [Update](docs/sdks/sourceaccounts/README.md#update) - Update source account
* [Delete](docs/sdks/sourceaccounts/README.md#delete) - Delete source account
* [GenerateCredentials](docs/sdks/sourceaccounts/README.md#generatecredentials) - Generate source account credentials
* [DeleteCredentials](docs/sdks/sourceaccounts/README.md#deletecredentials) - Delete all source account credentials

### [Sync](docs/sdks/sync/README.md)

* [GetLastSuccessfulSync](docs/sdks/sync/README.md#getlastsuccessfulsync) - Get last successful sync

### [Transactions](docs/sdks/transactions/README.md)

* [Create](docs/sdks/transactions/README.md#create) - Create bank transactions
* [GetCreateOperation](docs/sdks/transactions/README.md#getcreateoperation) - Get create operation
* [ListCreateOperations](docs/sdks/transactions/README.md#listcreateoperations) - List create operations

</details>
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
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupReference>() {
        new GroupReference() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                               | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503                | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4xx-5xx                                    | */*                                        |

### Example

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;
using System;
using Codat.BankFeeds.Models.Errors;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

try
{
    CompanyRequestBody req = new CompanyRequestBody() {
        Name = "Bank of Dave",
        Description = "Requested early access to the new financing scheme.",
        Groups = new List<GroupReference>() {
            new GroupReference() {
                Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
            },
        },
    };

    var res = await sdk.Companies.CreateAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorMessage)
    {
        // handle exception
    }
    else if (ex is Codat.BankFeeds.Models.Errors.SDKException)
    {
        // handle exception
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupReference>() {
        new GroupReference() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
};

var res = await sdk.Companies.CreateAsync(
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
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(
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
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupReference>() {
        new GroupReference() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End Retries [retries] -->

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