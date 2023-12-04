<!-- Start SDK Example Usage [usage] -->
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CompanyRequestBody req = new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->