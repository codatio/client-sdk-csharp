# AccountBalances
(*Banking.AccountBalances*)

## Overview

### Available Operations

* [List](#list) - List account balances

## List

The *List account balances* endpoint returns a list of [account balances](https://docs.codat.io/lending-api#/schemas/AccountBalance) for a given company's connection.

[Account balances](https://docs.codat.io/lending-api#/schemas/AccountBalance) are balances for a bank account, including end-of-day batch balance or running balances per transaction.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListBankingAccountBalancesRequest req = new ListBankingAccountBalancesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Banking.AccountBalances.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListBankingAccountBalancesRequest](../../Models/Requests/ListBankingAccountBalancesRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |

### Response

**[ListBankingAccountBalancesResponse](../../Models/Requests/ListBankingAccountBalancesResponse.md)**

### Errors

| Error Type                                  | Status Code                                 | Content Type                                |
| ------------------------------------------- | ------------------------------------------- | ------------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage    | 400, 401, 402, 403, 404, 409, 429, 500, 503 | application/json                            |
| Codat.Lending.Models.Errors.SDKException    | 4XX, 5XX                                    | \*/\*                                       |