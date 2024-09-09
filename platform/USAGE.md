<!-- Start SDK Example Usage [usage] -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CreateApiKey req = new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
};

var res = await sdk.Settings.CreateApiKeyAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->