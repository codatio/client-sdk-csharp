# Journals
(*Transactions.Journals*)

### Available Operations

* [Get](#get) - Get journal
* [List](#list) - List journals

## Get

The *Get journal* endpoint returns a single journal for a given journalId.

[Journals](https://docs.codat.io/lending-api#/schemas/Journal) are used to record all the financial transactions of a company.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journals) for integrations that support getting a specific journal.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingJournalRequest req = new GetAccountingJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "<value>",
};

var res = await sdk.Transactions.Journals.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetAccountingJournalRequest](../../Models/Operations/GetAccountingJournalRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |


### Response

**[GetAccountingJournalResponse](../../Models/Operations/GetAccountingJournalResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |

## List

The *List journals* endpoint returns a list of [journals](https://docs.codat.io/lending-api#/schemas/Journal) for a given company's connection.

[Journals](https://docs.codat.io/lending-api#/schemas/Journal) are used to record all the financial transactions of a company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingJournalsRequest req = new ListAccountingJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Transactions.Journals.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [ListAccountingJournalsRequest](../../Models/Operations/ListAccountingJournalsRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[ListAccountingJournalsResponse](../../Models/Operations/ListAccountingJournalsResponse.md)**
### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503      | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
