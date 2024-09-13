# CompanyInformation
(*CompanyInformation*)

## Overview

Get detailed information about a company from the underlying accounting software.

### Available Operations

* [Get](#get) - Get company information

## Get

Use the *Get company information* endpoint to return information about the company available from the underlying accounting software.



### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetCompanyInformationRequest req = new GetCompanyInformationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.CompanyInformation.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetCompanyInformationRequest](../../Models/Operations/GetCompanyInformationRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[GetCompanyInformationResponse](../../Models/Operations/GetCompanyInformationResponse.md)**

### Errors

| Error Object                               | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503            | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4xx-5xx                                    | */*                                        |
