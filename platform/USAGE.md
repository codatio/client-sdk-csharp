<!-- Start SDK Example Usage -->


```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Companies.CreateAsync(new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Name = "Bank of Dave",
});

// handle response
```
<!-- End SDK Example Usage -->