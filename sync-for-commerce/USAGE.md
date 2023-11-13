<!-- Start SDK Example Usage -->
```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.GetConfigTextSyncFlowAsync();

// handle response
```
<!-- End SDK Example Usage -->