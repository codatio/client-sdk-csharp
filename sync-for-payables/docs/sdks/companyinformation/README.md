# CompanyInformation
(*CompanyInformation*)

## Overview

View company profile from the source platform.

### Available Operations

* [Get](#get) - Get company information

## Get

Use the *Get company information* endpoint to return information about the company available from the underlying accounting software.



### Example Usage

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Models.Components;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyInformationRequest req = new GetCompanyInformationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.CompanyInformation.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCompanyInformationRequest](../../Models/Requests/GetCompanyInformationRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetCompanyInformationResponse](../../Models/Requests/GetCompanyInformationResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Payables.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503                | application/json                               |
| Codat.Sync.Payables.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
