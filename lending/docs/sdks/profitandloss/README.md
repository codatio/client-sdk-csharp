# ProfitAndLoss
(*FinancialStatements.ProfitAndLoss*)

### Available Operations

* [Get](#get) - Get profit and loss
* [GetCategorizedAccounts](#getcategorizedaccounts) - Get categorized profit and loss statement

## Get

Gets the latest profit and loss for a company.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingProfitAndLossRequest req = new GetAccountingProfitAndLossRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PeriodLength = 4,
    PeriodsToCompare = 20,
    StartMonth = "2022-10-23T00:00:00Z",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetAccountingProfitAndLossRequest](../../Models/Operations/GetAccountingProfitAndLossRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |


### Response

**[GetAccountingProfitAndLossResponse](../../Models/Operations/GetAccountingProfitAndLossResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## GetCategorizedAccounts

The *Get categorized profit and loss statement* endpoint returns a list of categorized accounts that appear on a company’s Profit and Loss statement. It also includes a balance as of the financial statement date.

Codat suggests a category for each account automatically, but you can [change it](https://docs.codat.io/lending/enhanced-financials/overview#categorize-accounts) to a more suitable one.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetCategorizedProfitAndLossStatementRequest req = new GetCategorizedProfitAndLossStatementRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ReportDate = "29-09-2020",
};

var res = await sdk.FinancialStatements.ProfitAndLoss.GetCategorizedAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [GetCategorizedProfitAndLossStatementRequest](../../Models/Operations/GetCategorizedProfitAndLossStatementRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |


### Response

**[GetCategorizedProfitAndLossStatementResponse](../../Models/Operations/GetCategorizedProfitAndLossStatementResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
