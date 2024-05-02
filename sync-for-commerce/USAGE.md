<!-- Start SDK Example Usage [usage] -->
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