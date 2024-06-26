# CompanyInfo
(*CompanyInfo*)

## Overview

View company profile from the source platform.

### Available Operations

* [GetAccountingProfile](#getaccountingprofile) - Get company accounting profile

## GetAccountingProfile

Gets the latest basic info for a company.

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Shared;
using Codat.Sync.Payroll.Models.Operations;

var sdk = new CodatSyncPayroll(security: new Security() {
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
### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |
