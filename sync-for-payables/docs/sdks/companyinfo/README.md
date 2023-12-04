# CompanyInfo
(*CompanyInfo*)

## Overview

View company information fetched from the source platform.

### Available Operations

* [GetAccountingProfile](#getaccountingprofile) - Get company accounting profile

## GetAccountingProfile

Gets the latest basic info for a company.

### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Shared;
using Codat.Sync.Payables.Models.Operations;

var sdk = new CodatSyncPayables(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingProfileRequest req = new GetAccountingProfileRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.CompanyInfo.GetAccountingProfileAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetAccountingProfileRequest](../../Models/Operations/GetAccountingProfileRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GetAccountingProfileResponse](../../Models/Operations/GetAccountingProfileResponse.md)**

