# CashFlow
(*FinancialStatements.CashFlow*)

### Available Operations

* [Get](#get) - Get cash flow statement

## Get

Gets the latest cash flow statement for a company.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

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

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [GetAccountingCashFlowStatementRequest](../../Models/Operations/GetAccountingCashFlowStatementRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |


### Response

**[GetAccountingCashFlowStatementResponse](../../Models/Operations/GetAccountingCashFlowStatementResponse.md)**

