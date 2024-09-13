# Journals
(*Journals*)

## Overview

Get, create, and update Journals.

### Available Operations

* [List](#list) - List journals
* [Get](#get) - Get journal
* [GetCreateModel](#getcreatemodel) - Get create journal model
* [Create](#create) - Create journal

## List

The *List journals* endpoint returns a list of [journals](https://docs.codat.io/sync-for-payroll-api#/schemas/Journal) for a given company's connection.

[Journals](https://docs.codat.io/sync-for-payroll-api#/schemas/Journal) are used to record all the financial transactions of a company.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListJournalsRequest req = new ListJournalsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Journals.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [ListJournalsRequest](../../Models/Requests/ListJournalsRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |

### Response

**[ListJournalsResponse](../../Models/Requests/ListJournalsResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503           | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |


## Get

The *Get journal* endpoint returns a single journal for a given `journalId`.

[Journals](https://docs.codat.io/sync-for-payroll-api#/schemas/Journal) are used to record all the financial transactions of a company.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journals) for integrations that support getting a specific journal.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/sync-for-payroll-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetJournalRequest req = new GetJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    JournalId = "<value>",
};

var res = await sdk.Journals.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetJournalRequest](../../Models/Requests/GetJournalRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetJournalResponse](../../Models/Requests/GetJournalResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |


## GetCreateModel

The *Get create journal model* endpoint returns the expected data for the request payload when creating a [journal](https://docs.codat.io/sync-for-payroll-api#/schemas/Journal) for a given company and integration.

[Journals](https://docs.codat.io/sync-for-payroll-api#/schemas/Journal) are used to record all the financial transactions of a company.

**Integration-specific behaviour**

See the *response examples* for integration-specific indicative models.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journals) for integrations that support creating a journal.


### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateJournalModelRequest req = new GetCreateJournalModelRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.Journals.GetCreateModelAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCreateJournalModelRequest](../../Models/Requests/GetCreateJournalModelRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetCreateJournalModelResponse](../../Models/Requests/GetCreateJournalModelResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                   | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |


## Create

The *Create journal* endpoint creates a new [journal](https://docs.codat.io/sync-for-payroll-api#/schemas/Journal) for a given company's connection.

[Journals](https://docs.codat.io/sync-for-payroll-api#/schemas/Journal) are used to record all the financial transactions of a company.

**Integration-specific behaviour**

Required data may vary by integration. To see what data to post, first call [Get create journal model](https://docs.codat.io/sync-for-payroll-api#/operations/get-create-journals-model).

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=journals) for integrations that support creating a journal.


### Example Usage

```csharp
using Codat.Sync.Payroll;
using Codat.Sync.Payroll.Models.Requests;
using Codat.Sync.Payroll.Models.Components;

var sdk = new CodatSyncPayroll(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateJournalRequest req = new CreateJournalRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    JournalPrototype = new JournalPrototype() {
        CreatedOn = "2022-10-23T00:00:00Z",
    },
};

var res = await sdk.Journals.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                                             | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `request`                                                             | [CreateJournalRequest](../../Models/Requests/CreateJournalRequest.md) | :heavy_check_mark:                                                    | The request object to use for the request.                            |

### Response

**[Models.Requests.CreateJournalResponse](../../Models/Requests/CreateJournalResponse.md)**

### Errors

| Error Object                                  | Status Code                                   | Content Type                                  |
| --------------------------------------------- | --------------------------------------------- | --------------------------------------------- |
| Codat.Sync.Payroll.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503               | application/json                              |
| Codat.Sync.Payroll.Models.Errors.SDKException | 4xx-5xx                                       | */*                                           |
