# FinancialStatementsProfitAndLossSDK
(*FinancialStatements.ProfitAndLoss*)

### Available Operations

* [Get](#get) - Get profit and loss
* [GetCategorizedAccounts](#getcategorizedaccounts) - Get categorized profit and loss statement

## Get

Gets the latest profit and loss for a company.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00.000Z",
});

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetAccountingProfitAndLossRequest](../../models/operations/GetAccountingProfitAndLossRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[GetAccountingProfitAndLossResponse](../../models/operations/GetAccountingProfitAndLossResponse.md)**


## GetCategorizedAccounts

The *Get categorized profit and loss statement* endpoint returns a list of categorized accounts that appear on a company’s Profit and Loss statement. It also includes a balance as of the financial statement date.

Codat suggests a category for each account automatically, but you can [change it](https://docs.codat.io/lending/enhanced-financials/overview#categorize-accounts) to a more suitable one.

### Example Usage

```csharp
using CodatLending;
using CodatLending.Models.Shared;
using CodatLending.Models.Operations;

var sdk = new CodatLendingSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.FinancialStatements.ProfitAndLoss.GetCategorizedAccountsAsync(new GetCategorizedProfitAndLossStatementRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    NumberOfPeriods = 222321,
    ReportDate = "29-09-2020",
});

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [GetCategorizedProfitAndLossStatementRequest](../../models/operations/GetCategorizedProfitAndLossStatementRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |


### Response

**[GetCategorizedProfitAndLossStatementResponse](../../models/operations/GetCategorizedProfitAndLossStatementResponse.md)**

