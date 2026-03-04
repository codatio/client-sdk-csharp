# MappingOptions

## Overview

Get accounts, trackingCategories and taxRates that can be used in your create and update requests.

### Available Operations

* [GetMappingOptions](#getmappingoptions) - Mapping options

## GetMappingOptions

Gets the mapping options (accounts, trackingCategories and taxRates) for a company's accounting software

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-mapping-options" method="get" path="/companies/{companyId}/sync/expenses/mappingOptions" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetMappingOptionsRequest req = new GetMappingOptionsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.MappingOptions.GetMappingOptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetMappingOptionsRequest](../../Models/Requests/GetMappingOptionsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetMappingOptionsResponse](../../Models/Requests/GetMappingOptionsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |