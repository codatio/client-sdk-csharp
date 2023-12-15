<!-- Start SDK Example Usage [usage] -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "<YOUR_API_KEY_HERE>",
    });

CreateApiKey req = new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
};

var res = await sdk.Settings.CreateApiKeyAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->