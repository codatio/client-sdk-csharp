# Sync for Commerce

<!-- Start Codat Library Description -->
﻿Embedded accounting integrations for POS and eCommerce platforms.
<!-- End Codat Library Description -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Codat.Sync.Commerce
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetConfigTextSyncFlowRequest req = new GetConfigTextSyncFlowRequest() {
    Locale = Codat.Sync.Commerce.Models.Shared.Locale.EnUs,
};

var res = await sdk.SyncFlowSettings.GetConfigTextSyncFlowAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [SyncFlowSettings](docs/sdks/syncflowsettings/README.md)

* [GetConfigTextSyncFlow](docs/sdks/syncflowsettings/README.md#getconfigtextsyncflow) - Get preferences for text fields
* [GetVisibleAccounts](docs/sdks/syncflowsettings/README.md#getvisibleaccounts) - List visible accounts
* [UpdateConfigTextSyncFlow](docs/sdks/syncflowsettings/README.md#updateconfigtextsyncflow) - Update preferences for text fields
* [UpdateVisibleAccountsSyncFlow](docs/sdks/syncflowsettings/README.md#updatevisibleaccountssyncflow) - Update visible accounts

### [AdvancedControls](docs/sdks/advancedcontrols/README.md)

* [CreateCompany](docs/sdks/advancedcontrols/README.md#createcompany) - Create company
* [GetConfiguration](docs/sdks/advancedcontrols/README.md#getconfiguration) - Get company configuration
* [ListCompanies](docs/sdks/advancedcontrols/README.md#listcompanies) - List companies
* [SetConfiguration](docs/sdks/advancedcontrols/README.md#setconfiguration) - Set configuration

### [Connections](docs/sdks/connections/README.md)

* [Create](docs/sdks/connections/README.md#create) - Create connection
* [GetSyncFlowUrl](docs/sdks/connections/README.md#getsyncflowurl) - Start new sync flow
* [List](docs/sdks/connections/README.md#list) - List connections
* [UpdateAuthorization](docs/sdks/connections/README.md#updateauthorization) - Update authorization
* [UpdateConnection](docs/sdks/connections/README.md#updateconnection) - Update connection

### [Sync](docs/sdks/sync/README.md)

* [Get](docs/sdks/sync/README.md#get) - Get sync status
* [GetLastSuccessfulSync](docs/sdks/sync/README.md#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](docs/sdks/sync/README.md#getlatestsync) - Latest sync status
* [GetStatus](docs/sdks/sync/README.md#getstatus) - Get sync status
* [List](docs/sdks/sync/README.md#list) - List sync statuses
* [Request](docs/sdks/sync/README.md#request) - Initiate new sync
* [RequestForDateRange](docs/sdks/sync/README.md#requestfordaterange) - Initiate sync for specific range

### [Integrations](docs/sdks/integrations/README.md)

* [GetBranding](docs/sdks/integrations/README.md#getbranding) - Get branding for an integration
* [List](docs/sdks/integrations/README.md#list) - List integrations
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
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetConfigTextSyncFlowRequest req = new GetConfigTextSyncFlowRequest() {
    Locale = Codat.Sync.Commerce.Models.Shared.Locale.EnUs,
};

var res = await sdk.SyncFlowSettings.GetConfigTextSyncFlowAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401,402,403,429,500,503                        | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |

### Example

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using System;
using Codat.Sync.Commerce.Models.Errors;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetConfigTextSyncFlowRequest req = new GetConfigTextSyncFlowRequest() {
    Locale = Codat.Sync.Commerce.Models.Shared.Locale.EnUs,
};

try
{
    var res = await sdk.SyncFlowSettings.GetConfigTextSyncFlowAsync(req);
    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorMessage)
    {
        // handle exception
    }
    else if (ex is Codat.Sync.Commerce.Models.Errors.SDKException)
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