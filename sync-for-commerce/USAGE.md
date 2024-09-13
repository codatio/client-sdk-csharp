<!-- Start SDK Example Usage [usage] -->
```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    CommerceKey = "<value>",
    AccountingKey = "<value>",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->