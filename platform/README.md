# Platform

<!-- Start Codat Library Description -->
Manage the building blocks of Codat, including companies, connections, and more.
<!-- End Codat Library Description -->

<!-- Start Summary [summary] -->
## Summary

Platform API: Platform API

An API for the common components of all of Codat's products.

These end points cover creating and managing your companies, data connections, and integrations.

[Read about the building blocks of Codat...](https://docs.codat.io/core-concepts/companies) | [See our OpenAPI spec](https://github.com/codatio/oas) 

---
<!-- Start Codat Tags Table -->
## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Connection management | Configure connection management UI and retrieve access tokens for authentication. |
| Groups | Define and manage sets of companies based on a chosen characteristic. |
| Webhooks | Create and manage webhooks that listen to Codat's events. |
| Integrations | Get a list of integrations supported by Codat and their logos. |
| Refresh data | Initiate data refreshes, view pull status and history. |
| Settings | Manage company profile configuration, sync settings, and API keys. |
| Push data | Initiate and monitor Create, Update, and Delete operations. |
| Supplemental data | Configure and pull additional data you can include in Codat's standard data types. |
| Custom data type | Configure and pull additional data types that are not included in Codat's standardized data model. |
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
dotnet add package Codat.Platform
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/Platform/Codat.Platform.csproj
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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


### [Companies](docs/sdks/companies/README.md)

* [List](docs/sdks/companies/README.md#list) - List companies
* [Create](docs/sdks/companies/README.md#create) - Create company
* [Get](docs/sdks/companies/README.md#get) - Get company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Update](docs/sdks/companies/README.md#update) - Update company

### [ConnectionManagement](docs/sdks/connectionmanagement/README.md)

* [GetAccessToken](docs/sdks/connectionmanagement/README.md#getaccesstoken) - Get access token

#### [ConnectionManagement.CorsSettings](docs/sdks/corssettings/README.md)

* [Get](docs/sdks/corssettings/README.md#get) - Get CORS settings
* [Set](docs/sdks/corssettings/README.md#set) - Set CORS settings

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection
* [UpdateAuthorization](docs/sdks/connections/README.md#updateauthorization) - Update authorization

### [CustomDataType](docs/sdks/customdatatype/README.md)

* [Configure](docs/sdks/customdatatype/README.md#configure) - Configure custom data type
* [GetConfiguration](docs/sdks/customdatatype/README.md#getconfiguration) - Get custom data configuration
* [Refresh](docs/sdks/customdatatype/README.md#refresh) - Refresh custom data type
* [List](docs/sdks/customdatatype/README.md#list) - List custom data type records

### [Groups](docs/sdks/groups/README.md)

* [AddCompany](docs/sdks/groups/README.md#addcompany) - Add company
* [RemoveCompany](docs/sdks/groups/README.md#removecompany) - Remove company
* [List](docs/sdks/groups/README.md#list) - List groups
* [Create](docs/sdks/groups/README.md#create) - Create group

### [Integrations](docs/sdks/integrations/README.md)

* [List](docs/sdks/integrations/README.md#list) - List integrations
* [Get](docs/sdks/integrations/README.md#get) - Get integration
* [GetBranding](docs/sdks/integrations/README.md#getbranding) - Get branding

### [PushData](docs/sdks/pushdata/README.md)

* [GetModelOptions](docs/sdks/pushdata/README.md#getmodeloptions) - Get push options
* [ListOperations](docs/sdks/pushdata/README.md#listoperations) - List push operations
* [GetOperation](docs/sdks/pushdata/README.md#getoperation) - Get push operation

### [RefreshData](docs/sdks/refreshdata/README.md)

* [All](docs/sdks/refreshdata/README.md#all) - Refresh all data
* [ByDataType](docs/sdks/refreshdata/README.md#bydatatype) - Refresh data type
* [Get](docs/sdks/refreshdata/README.md#get) - Get data status
* [ListPullOperations](docs/sdks/refreshdata/README.md#listpulloperations) - List pull operations
* [GetPullOperation](docs/sdks/refreshdata/README.md#getpulloperation) - Get pull operation

### [Settings](docs/sdks/settings/README.md)

* [GetProfile](docs/sdks/settings/README.md#getprofile) - Get profile
* [UpdateProfile](docs/sdks/settings/README.md#updateprofile) - Update profile
* [GetSyncSettings](docs/sdks/settings/README.md#getsyncsettings) - Get sync settings
* [UpdateSyncSettings](docs/sdks/settings/README.md#updatesyncsettings) - Update all sync settings
* [ListApiKeys](docs/sdks/settings/README.md#listapikeys) - List API keys
* [CreateApiKey](docs/sdks/settings/README.md#createapikey) - Create API key
* [DeleteApiKey](docs/sdks/settings/README.md#deleteapikey) - Delete API key

### [SupplementalData](docs/sdks/supplementaldata/README.md)

* [Configure](docs/sdks/supplementaldata/README.md#configure) - Configure
* [GetConfiguration](docs/sdks/supplementaldata/README.md#getconfiguration) - Get configuration

### [Webhooks](docs/sdks/webhooks/README.md)

* [~~List~~](docs/sdks/webhooks/README.md#list) - List webhooks :warning: **Deprecated**
* [~~Create~~](docs/sdks/webhooks/README.md#create) - Create webhook :warning: **Deprecated**
* [~~Get~~](docs/sdks/webhooks/README.md#get) - Get webhook :warning: **Deprecated**
* [ListConsumers](docs/sdks/webhooks/README.md#listconsumers) - List webhook consumers
* [CreateConsumer](docs/sdks/webhooks/README.md#createconsumer) - Create webhook consumer
* [DeleteConsumer](docs/sdks/webhooks/README.md#deleteconsumer) - Delete webhook consumer

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

To authenticate with the API the `AuthHeader` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503           | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

### Example

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;
using System;
using Codat.Platform.Models.Errors;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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
    else if (ex is Codat.Platform.Models.Errors.SDKException)
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
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(
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