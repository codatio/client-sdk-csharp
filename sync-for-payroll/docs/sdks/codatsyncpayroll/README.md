# CodatSyncPayroll SDK

## Overview

Sync for Payroll: The API for Sync for Payroll. 

Sync for Payroll is an API and a set of supporting tools built to help integrate your customers' payroll data from their HR and payroll platforms into their accounting platforms and to support its reconciliation.

[Read More...](https://docs.codat.io/payroll/overview)

### Available Operations

* [GetAccountingProfile](#getaccountingprofile) - Get company accounting profile

## GetAccountingProfile

Gets the latest basic info for a company.

### Example Usage

```csharp
using CodatSyncPayroll;
using CodatSyncPayroll.Models.Shared;
using CodatSyncPayroll.Models.Operations;

var sdk = new CodatSyncPayrollSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Codat.Sync.Payroll.GetAccountingProfileAsync(new GetAccountingProfileRequest() {
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

