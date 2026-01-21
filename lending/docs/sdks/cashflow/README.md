# FinancialStatements.CashFlow

## Overview

### Available Operations

* [Get](#get) - Get cash flow statement

## Get

Gets the latest cash flow statement for a company.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-accounting-cash-flow-statement" method="get" path="/companies/{companyId}/data/financials/cashFlowStatement" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingCashFlowStatementRequest req = new GetAccountingCashFlowStatementRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.CashFlow.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [GetAccountingCashFlowStatementRequest](../../Models/Requests/GetAccountingCashFlowStatementRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |

### Response

**[GetAccountingCashFlowStatementResponse](../../Models/Requests/GetAccountingCashFlowStatementResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |