# CompanyInfoSDK
(*CompanyInfo*)

## Overview

View company information fetched from the source platform.

### Available Operations

* [GetAccountingProfile](#getaccountingprofile) - Get company accounting profile

## GetAccountingProfile

Gets the latest basic info for a company.

### Example Usage

```csharp
using CodatSyncPayables;
using CodatSyncPayables.Models.Shared;
using CodatSyncPayables.Models.Operations;

var sdk = new CodatSyncPayablesSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.CompanyInfo.GetAccountingProfileAsync(new GetAccountingProfileRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetAccountingProfileRequest](../../models/operations/GetAccountingProfileRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GetAccountingProfileResponse](../../models/operations/GetAccountingProfileResponse.md)**

