# CompanyInfo

## Overview

View the company information of your customers' linked accounting software.

### Available Operations

* [Get](#get) - Get company info

## Get

Gets the latest basic info for a company.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-company-info" method="get" path="/companies/{companyId}/data/info" example="Example 1" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyInfoRequest req = new GetCompanyInfoRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.CompanyInfo.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [GetCompanyInfoRequest](../../Models/Requests/GetCompanyInfoRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |

### Response

**[GetCompanyInfoResponse](../../Models/Requests/GetCompanyInfoResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |