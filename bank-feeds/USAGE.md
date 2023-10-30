<!-- Start SDK Example Usage -->


```csharp
using CodatBankFeeds;
using CodatBankFeeds.Models.Shared;
using CodatBankFeeds.Models.Operations;

var sdk = new CodatBankFeedsSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.AccountMapping.CreateAsync(new CreateBankAccountMappingRequest() {
    Zero = new Zero() {
        FeedStartDate = "2022-10-23T00:00:00.000Z",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```
<!-- End SDK Example Usage -->