<!-- Start SDK Example Usage -->
```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;

var sdk = new CodatSyncPayroll(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Companies.CreateAsync(new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
});

// handle response
```
<!-- End SDK Example Usage -->