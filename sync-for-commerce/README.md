# Sync for Commerce

<div align="left">
    <a href="https://speakeasyapi.dev/"><img src="https://custom-icon-badges.demolab.com/badge/-Built%20By%20Speakeasy-212015?style=for-the-badge&logoColor=FBE331&logo=speakeasy&labelColor=545454" /></a>
</div>

Embedded accounting integrations for POS and eCommerce platforms.

<!-- Start SDK Installation -->
## SDK Installation

### Nuget

```bash
dotnet add reference path/to/CodatSyncCommerce.csproj
```
<!-- End SDK Installation -->

## SDK Example Usage
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
    Name = "Bob's Burgers",
});

// handle response
```
<!-- End SDK Example Usage -->

<!-- Start SDK Available Operations -->
## Available Resources and Operations


### [advancedControls](docs/sdks/advancedcontrols/README.md)

* [CreateCompany](docs/sdks/advancedcontrols/README.md#createcompany) - Create company
* [GetConfiguration](docs/sdks/advancedcontrols/README.md#getconfiguration) - Get company configuration
* [ListCompanies](docs/sdks/advancedcontrols/README.md#listcompanies) - List companies
* [SetConfiguration](docs/sdks/advancedcontrols/README.md#setconfiguration) - Set configuration

### [connections](docs/sdks/connections/README.md)

* [Create](docs/sdks/connections/README.md#create) - Create connection
* [GetSyncFlowUrl](docs/sdks/connections/README.md#getsyncflowurl) - Retrieve sync flow url
* [List](docs/sdks/connections/README.md#list) - List connections
* [UpdateAuthorization](docs/sdks/connections/README.md#updateauthorization) - Update authorization
* [UpdateConnection](docs/sdks/connections/README.md#updateconnection) - Update connection

### [integrations](docs/sdks/integrations/README.md)

* [GetBranding](docs/sdks/integrations/README.md#getbranding) - Get branding for an integration
* [List](docs/sdks/integrations/README.md#list) - List integrations

### [sync](docs/sdks/sync/README.md)

* [Get](docs/sdks/sync/README.md#get) - Get Sync status
* [GetLastSuccessfulSync](docs/sdks/sync/README.md#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](docs/sdks/sync/README.md#getlatestsync) - Latest sync status
* [GetStatus](docs/sdks/sync/README.md#getstatus) - Get sync status
* [List](docs/sdks/sync/README.md#list) - List sync statuses
* [Request](docs/sdks/sync/README.md#request) - Initiate new sync
* [RequestForDateRange](docs/sdks/sync/README.md#requestfordaterange) - Initiate sync for specific range

### [syncFlowPreferences](docs/sdks/syncflowpreferences/README.md)

* [GetConfigTextSyncFlow](docs/sdks/syncflowpreferences/README.md#getconfigtextsyncflow) - Get preferences for text fields
* [GetVisibleAccounts](docs/sdks/syncflowpreferences/README.md#getvisibleaccounts) - List visible accounts
* [UpdateConfigTextSyncFlow](docs/sdks/syncflowpreferences/README.md#updateconfigtextsyncflow) - Update preferences for text fields
* [UpdateVisibleAccountsSyncFlow](docs/sdks/syncflowpreferences/README.md#updatevisibleaccountssyncflow) - Update visible accounts
<!-- End SDK Available Operations -->

### Maturity

This SDK is in beta, and there may be breaking changes between versions without a major version update. Therefore, we recommend pinning usage
to a specific package version. This way, you can install the same version each time without breaking changes unless you are intentionally
looking for the latest version.

### Contributions

While we value open-source contributions to this SDK, this library is generated programmatically.
Feel free to open a PR or a Github issue as a proof of concept and we'll do our best to include it in a future release!

### SDK Created by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
