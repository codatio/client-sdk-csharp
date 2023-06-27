<!-- Start SDK Example Usage -->
```csharp
using Codat;
using Codat.Models.Security;
using Codat.Models.Categories;

var sdk = new CodatSDK(
    security: new Security() {
        authHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Categories.GetAccountCategory(request);
```
<!-- End SDK Example Usage -->