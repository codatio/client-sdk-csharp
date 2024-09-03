<!-- Start SDK Example Usage [usage] -->
```csharp
using Openapi;
using Openapi.Models.Requests;
using Openapi.Models.Components;

var sdk = new SDK(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Companies.ListAsync(
    page: 1,
    pageSize: 100,
    query: "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    orderBy: "-modifiedDate"
);

// handle response
```
<!-- End SDK Example Usage [usage] -->