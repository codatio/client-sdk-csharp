# LiabilitiesSDK
(*Liabilities*)

## Overview

Debt and other liabilities.

### Available Operations

* [GetLoanSummary](#getloansummary) - Get loan summaries
* [ListLoanTransactions](#listloantransactions) - List loan transactions

## GetLoanSummary

The *Get loan summaries* endpoint returns a summary by integration type of all loans identified in each integration.

The endpoint returns a list of a company's [loan summaries](https://docs.codat.io/lending-api#/schemas/LoanSummary) for each valid data connection.

Make sure you have [synced a company](https://docs.codat.io/lending-api#/operations/refresh-company-data) recently before calling the endpoint.


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

var res = await sdk.Liabilities.GetLoanSummaryAsync(new GetLoanSummaryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetLoanSummaryRequest](../../models/operations/GetLoanSummaryRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetLoanSummaryResponse](../../models/operations/GetLoanSummaryResponse.md)**


## ListLoanTransactions

The *List loan transactions* endpoint returns all [loan transactions](https://docs.codat.io/lending-api#/schemas/LoanTransactions) identified from a company's accounting, banking, and commerce integrations.

This detail gives analysts a better idea of the loan obligations a company may have.

Make sure you have [synced a company](https://docs.codat.io/lending-api#/operations/refresh-company-data) recently before calling the endpoint.


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

var res = await sdk.Liabilities.ListLoanTransactionsAsync(new ListLoanTransactionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SourceType = CodatLending.Models.Operations.ListLoanTransactionsSourceType.Commerce,
});

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListLoanTransactionsRequest](../../models/operations/ListLoanTransactionsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListLoanTransactionsResponse](../../models/operations/ListLoanTransactionsResponse.md)**

