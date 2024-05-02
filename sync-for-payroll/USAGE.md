<!-- Start SDK Example Usage [usage] -->
```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatSyncPayroll(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CompanyRequestBody req = new CompanyRequestBody() {
    Description = "Requested early access to the new financing scheme.",
    Groups = new List<Items>() {
        new Items() {
            Id = "60d2fa12-8a04-11ee-b9d1-0242ac120002",
        },
    },
    Name = "Bank of Dave",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->