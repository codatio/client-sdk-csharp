# CodatLendingAccountingBankData
(*AccountingBankData*)

## Overview

Access bank transactions from an accounting platform.

### Available Operations

* [ListTransactions](#listtransactions) - List bank account transactions

## ListTransactions

The *List account bank transactions* endpoint returns a list of [bank account transactions](https://docs.codat.io/lending-api#/schemas/BankTransactions) for a given company's connection.

[Bank account transactions](https://docs.codat.io/lending-api#/schemas/BankTransactions) are records of money that has moved in and out of an SMB's bank account.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=bankTransactions) for integrations that support listing bank transactions.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingBankAccountTransactionsRequest req = new ListAccountingBankAccountTransactionsRequest() {
    AccountId = "<value>",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.AccountingBankData.ListTransactionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                               | Type                                                                                                                    | Required                                                                                                                | Description                                                                                                             |
| ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                               | [ListAccountingBankAccountTransactionsRequest](../../Models/Operations/ListAccountingBankAccountTransactionsRequest.md) | :heavy_check_mark:                                                                                                      | The request object to use for the request.                                                                              |


### Response

**[ListAccountingBankAccountTransactionsResponse](../../Models/Operations/ListAccountingBankAccountTransactionsResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503      | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
