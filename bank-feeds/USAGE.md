<!-- Start SDK Example Usage [usage] -->
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Bank of Dave",
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<GroupReference>() {
        new GroupReference() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->