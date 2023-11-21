<!-- Start SDK Example Usage -->
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(
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