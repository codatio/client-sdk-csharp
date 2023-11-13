<!-- Start SDK Example Usage -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Settings.CreateApiKeyAsync(new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
});

// handle response
```
<!-- End SDK Example Usage -->