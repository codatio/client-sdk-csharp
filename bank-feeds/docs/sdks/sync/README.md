# Sync
(*Sync*)

## Overview

Monitor the status of data syncs.

### Available Operations

* [GetLastSuccessfulSync](#getlastsuccessfulsync) - Get last successful sync

## GetLastSuccessfulSync

Use the _Get last successful sync_ endpoint to obtain the status information for the company's [most recent successful sync](https://docs.codat.io/bank-feeds-api#/schemas/CompanySyncStatus). 

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Operations;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetLastSuccessfulRequest req = new GetLastSuccessfulRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Sync.GetLastSuccessfulSyncAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetLastSuccessfulRequest](../../Models/Operations/GetLastSuccessfulRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetLastSuccessfulResponse](../../Models/Operations/GetLastSuccessfulResponse.md)**

### Errors

| Error Type                                 | Status Code                                | Content Type                               |
| ------------------------------------------ | ------------------------------------------ | ------------------------------------------ |
| Codat.BankFeeds.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503          | application/json                           |
| Codat.BankFeeds.Models.Errors.SDKException | 4XX, 5XX                                   | \*/\*                                      |