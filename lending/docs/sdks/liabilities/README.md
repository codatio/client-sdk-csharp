# Liabilities
(*Liabilities*)

## Overview

Debt and other liabilities.

### Available Operations

* [GenerateLoanSummary](#generateloansummary) - Generate loan summaries report
* [GenerateLoanTransactions](#generateloantransactions) - Generate loan transactions report
* [GetLoanSummary](#getloansummary) - Get loan summaries
* [ListLoanTransactions](#listloantransactions) - List loan transactions

## GenerateLoanSummary

The _Generate loan summaries_ endpoint requests the generation of the Loan Summaries report.

Learn more about Codat's liabilities feature [here](https://docs.codat.io/lending/features/liabilities-overview).

Make sure you have [synced a company](https://docs.codat.io/lending-api#/operations/refresh-company-data) recently before calling the endpoint.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GenerateLoanSummaryRequest req = new GenerateLoanSummaryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SourceType = Models.Operations.SourceType.Accounting,
};

var res = await sdk.Liabilities.GenerateLoanSummaryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                           | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `request`                                                                           | [GenerateLoanSummaryRequest](../../Models/Operations/GenerateLoanSummaryRequest.md) | :heavy_check_mark:                                                                  | The request object to use for the request.                                          |


### Response

**[GenerateLoanSummaryResponse](../../Models/Operations/GenerateLoanSummaryResponse.md)**


## GenerateLoanTransactions

The _Generate loan transactions_ endpoint requests the generation of the Loan Transactions report.

Learn more about Codat's liabilities feature [here](https://docs.codat.io/lending/features/liabilities-overview).

Make sure you have [synced a company](https://docs.codat.io/lending-api#/operations/refresh-company-data) recently before calling the endpoint.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GenerateLoanTransactionsRequest req = new GenerateLoanTransactionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SourceType = QueryParamSourceType.Accounting,
};

var res = await sdk.Liabilities.GenerateLoanTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GenerateLoanTransactionsRequest](../../Models/Operations/GenerateLoanTransactionsRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |


### Response

**[GenerateLoanTransactionsResponse](../../Models/Operations/GenerateLoanTransactionsResponse.md)**


## GetLoanSummary

The *Get loan summaries* endpoint returns a summary by integration type of all loans identified from a company's accounting, banking, and commerce integrations.

The endpoint returns a list of a company's [loan summaries](https://docs.codat.io/lending-api#/schemas/LoanSummary) for each valid data connection.

Make sure you have [synced a company](https://docs.codat.io/lending-api#/operations/refresh-company-data) recently before calling the endpoint.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetLoanSummaryRequest req = new GetLoanSummaryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SourceType = GetLoanSummaryQueryParamSourceType.Banking,
};

var res = await sdk.Liabilities.GetLoanSummaryAsync(req);

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetLoanSummaryRequest](../../Models/Operations/GetLoanSummaryRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetLoanSummaryResponse](../../Models/Operations/GetLoanSummaryResponse.md)**


## ListLoanTransactions

The *List loan transactions* endpoint returns all [loan transactions](https://docs.codat.io/lending-api#/schemas/LoanTransactions) identified from a company's accounting, banking, and commerce integrations.

This detail gives analysts a better idea of the loan obligations a company may have.

Make sure you have [synced a company](https://docs.codat.io/lending-api#/operations/refresh-company-data) recently before calling the endpoint.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListLoanTransactionsRequest req = new ListLoanTransactionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    SourceType = ListLoanTransactionsQueryParamSourceType.Commerce,
};

var res = await sdk.Liabilities.ListLoanTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [ListLoanTransactionsRequest](../../Models/Operations/ListLoanTransactionsRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[ListLoanTransactionsResponse](../../Models/Operations/ListLoanTransactionsResponse.md)**

