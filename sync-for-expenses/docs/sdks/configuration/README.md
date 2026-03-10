# Configuration

## Overview

View and manage mapping configuration and defaults for expense transactions.

### Available Operations

* [Get](#get) - Get company configuration
* [Set](#set) - Set company configuration

## Get

Gets a company's expense sync configuration

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-company-configuration" method="get" path="/companies/{companyId}/sync/expenses/config" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyConfigurationRequest req = new GetCompanyConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Configuration.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetCompanyConfigurationRequest](../../Models/Requests/GetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[GetCompanyConfigurationResponse](../../Models/Requests/GetCompanyConfigurationResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                        | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## Set

Sets a company's expense sync configuration

### Example Usage

<!-- UsageSnippet language="csharp" operationID="set-company-configuration" method="post" path="/companies/{companyId}/sync/expenses/config" example="Malformed query" -->
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

SetCompanyConfigurationRequest req = new SetCompanyConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyConfiguration = new CompanyConfiguration() {
        BankAccount = new BankAccountDetails() {
            Id = "32",
        },
        Supplier = new SupplierDetails() {},
        Customer = new CustomerDetails() {},
    },
};

var res = await sdk.Configuration.SetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [SetCompanyConfigurationRequest](../../Models/Requests/SetCompanyConfigurationRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[SetCompanyConfigurationResponse](../../Models/Requests/SetCompanyConfigurationResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429                   | application/json                               |
| Codat.Sync.Expenses.Models.Errors.ErrorMessage | 500, 503                                       | application/json                               |
| Codat.Sync.Expenses.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |