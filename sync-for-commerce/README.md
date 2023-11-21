# Sync for Commerce

<!-- Start Codat Library Description -->
﻿Embedded accounting integrations for POS and eCommerce platforms.
<!-- End Codat Library Description -->

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add package Codat.Sync.Commerce
```
<!-- End SDK Installation -->

## Example Usage
<!-- Start SDK Example Usage -->
```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AdvancedControls.CreateCompanyAsync(new CreateCompany() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
});

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


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

### [Integrations](docs/sdks/integrations/README.md)

* [GetBranding](docs/sdks/integrations/README.md#getbranding) - Get branding for an integration
* [List](docs/sdks/integrations/README.md#list) - List integrations

### [Sync](docs/sdks/sync/README.md)

* [Get](docs/sdks/sync/README.md#get) - Get sync status
* [GetLastSuccessfulSync](docs/sdks/sync/README.md#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](docs/sdks/sync/README.md#getlatestsync) - Latest sync status
* [GetStatus](docs/sdks/sync/README.md#getstatus) - Get sync status
* [List](docs/sdks/sync/README.md#list) - List sync statuses
* [Request](docs/sdks/sync/README.md#request) - Initiate new sync
* [RequestForDateRange](docs/sdks/sync/README.md#requestfordaterange) - Initiate sync for specific range

### [SyncFlowSettings](docs/sdks/syncflowsettings/README.md)

* [GetConfigTextSyncFlow](docs/sdks/syncflowsettings/README.md#getconfigtextsyncflow) - Get preferences for text fields
* [GetVisibleAccounts](docs/sdks/syncflowsettings/README.md#getvisibleaccounts) - List visible accounts
* [UpdateConfigTextSyncFlow](docs/sdks/syncflowsettings/README.md#updateconfigtextsyncflow) - Update preferences for text fields
* [UpdateVisibleAccountsSyncFlow](docs/sdks/syncflowsettings/README.md#updatevisibleaccountssyncflow) - Update visible accounts
<!-- End SDK Available Operations -->

<!-- Start Dev Containers -->

<!-- End Dev Containers -->

<!-- Placeholder for Future Speakeasy SDK Sections -->