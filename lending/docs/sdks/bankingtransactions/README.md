# Banking.Transactions

### Available Operations

* [Get](#get) - Get bank transaction
* [List](#list) - List transactions

## Get

The *Get transaction* endpoint returns a single transaction for a given transactionId.

[Transactions](https://docs.codat.io/banking-api#/schemas/Transaction) provide an immutable source of up-to-date information on income and expenditure.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/banking?view=tab-by-data-type&dataType=banking-transactions) for integrations that support getting a specific transaction.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


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

var res = await sdk.Banking.Transactions.GetAsync(new GetBankingTransactionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    TransactionId = "qui",
});

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetBankingTransactionRequest](../../models/operations/GetBankingTransactionRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |


### Response

**[GetBankingTransactionResponse](../../models/operations/GetBankingTransactionResponse.md)**


## List

The *List transactions* endpoint returns a list of [transactions](https://docs.codat.io/banking-api#/schemas/Transaction) for a given company's connection.

[Transactions](https://docs.codat.io/banking-api#/schemas/Transaction) provide an immutable source of up-to-date information on income and expenditure.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

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

var res = await sdk.Banking.Transactions.ListAsync(new ListBankingTransactionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "impedit",
});

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [ListBankingTransactionsRequest](../../models/operations/ListBankingTransactionsRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[ListBankingTransactionsResponse](../../models/operations/ListBankingTransactionsResponse.md)**

