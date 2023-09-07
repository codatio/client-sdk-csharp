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