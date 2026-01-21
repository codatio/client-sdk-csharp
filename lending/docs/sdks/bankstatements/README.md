# BankStatements

## Overview

Retrieve banking data from linked bank accounts.

### Available Operations

* [GetUploadConfiguration](#getuploadconfiguration) - Get upload configuration
* [SetUploadConfiguration](#setuploadconfiguration) - Set upload configuration
* [StartUploadSession](#startuploadsession) - Start upload session
* [UploadBankStatementData](#uploadbankstatementdata) - Upload data
* [EndUploadSession](#enduploadsession) - End upload session

## GetUploadConfiguration

Use the *Get upload configuration* endpoint to view the existing bank statement upload configuration for the specified data connection.

With this configuration, you set the source of the data you plan to upload, the ID of the account in third-party banking platform, and a provider ID, if required. This lets us determine the expected format of the data and any source-specific requirements.

When you use the [*Upload data*](https://docs.codat.io/lending-api#/operations/upload-bank-statement-data) endpoint next, you must upload the data for the account you configured. 

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-bank-statement-upload-configuration" method="get" path="/companies/{companyId}/connections/{connectionId}/bankStatements/upload/configuration" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetBankStatementUploadConfigurationRequest req = new GetBankStatementUploadConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankStatements.GetUploadConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetBankStatementUploadConfigurationRequest](../../Models/Requests/GetBankStatementUploadConfigurationRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[GetBankStatementUploadConfigurationResponse](../../Models/Requests/GetBankStatementUploadConfigurationResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## SetUploadConfiguration

Use the *Set upload configuration* endpoint to create bank statement upload configuration for the specified data connection. 

With this configuration, you set the source of the data you plan to upload, the ID of the account in third-party banking platform, and a provider ID, if required. This lets us determine the expected format of the data and any source-specific requirements.

Each data connection can only have one configuration for each company and external account ID combination. You will receive a Bad Request response if you try to set it again. 

### Example Usage

<!-- UsageSnippet language="csharp" operationID="set-bank-statement-upload-configuration" method="post" path="/companies/{companyId}/connections/{connectionId}/bankStatements/upload/configuration" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

SetBankStatementUploadConfigurationRequest req = new SetBankStatementUploadConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BankStatementUploadConfiguration = new BankStatementUploadConfiguration() {
        Source = Source.Codat,
        AccountId = "abc123-ABC",
    },
};

var res = await sdk.BankStatements.SetUploadConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [SetBankStatementUploadConfigurationRequest](../../Models/Requests/SetBankStatementUploadConfigurationRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[SetBankStatementUploadConfigurationResponse](../../Models/Requests/SetBankStatementUploadConfigurationResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## StartUploadSession

Use the *Start upload session* endpoint to initiate a bank statement upload session for a given company.

A session is a one-time process that enables you to upload bank statements to Codat. It will time out after 90 minutes if no data is uploaded. 

You can only have one active session per data type at a time. You can complete or cancel a session using the [*End upload session*](https://docs.codat.io/lending-api#/operations/end-bank-statement-upload-session) endpoint.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="start-bank-statement-upload-session" method="post" path="/companies/{companyId}/connections/{connectionId}/bankStatements/upload/startSession" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

StartBankStatementUploadSessionRequest req = new StartBankStatementUploadSessionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.BankStatements.StartUploadSessionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                 | Type                                                                                                      | Required                                                                                                  | Description                                                                                               |
| --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                 | [StartBankStatementUploadSessionRequest](../../Models/Requests/StartBankStatementUploadSessionRequest.md) | :heavy_check_mark:                                                                                        | The request object to use for the request.                                                                |

### Response

**[StartBankStatementUploadSessionResponse](../../Models/Requests/StartBankStatementUploadSessionResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## UploadBankStatementData

During an active session, use the **Upload data* endpoint to uploads a page of bank accounts or bank transactions data to the session.

Make sure you created configuration for the account using the [*Set upload configuration*](https://docs.codat.io/lending-api#/operations/set-bank-statement-upload-configuration) endpoint before attempting an upload. 

### Example Usage

<!-- UsageSnippet language="csharp" operationID="upload-bank-statement-data" method="post" path="/companies/{companyId}/connections/{connectionId}/bankStatements/upload/dataset/{datasetId}/upload" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UploadBankStatementDataRequest req = new UploadBankStatementDataRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DatasetId = "f0095e43-88a7-4395-9f2c-1d5226e1c9e5",
    RequestBody = UploadBankStatementDataRequestBody.CreateAny(
        new Dictionary<string, object>() {
            { "results", new List<object>() {
                new Dictionary<string, object>() {
                    { "institution", new Dictionary<string, object>() {
                        { "name", "Lloyds Bank" },
                        { "id", "lloyds-bank" },
                    } },
                    { "modifiedDate", "2022-05-23T16:32:50Z" },
                    { "sourceModifiedDate", "2021-08-14T05:04:12" },
                    { "informalName", "Codat" },
                    { "balance", new Dictionary<string, object>() {
                        { "limit", 5000 },
                        { "available", -459987.97D },
                        { "current", -459964.9D },
                    } },
                    { "currency", "GBP" },
                    { "id", "1703194f-7805-4da8-bac0-2ba5da4a4216" },
                    { "name", "Business Current Account" },
                    { "holder", "Codat Ltd" },
                    { "type", "Debit" },
                    { "identifiers", new Dictionary<string, object>() {
                        { "bic", "LOYDGB21006" },
                        { "maskedAccountNumber", "LOYDGB21006" },
                        { "type", "Depository" },
                        { "subtype", "checking" },
                        { "number", "46762629" },
                        { "bankCode", 9911 },
                        { "iban", "GB29 LOYD 4773 2346 7626 29" },
                    } },
                },
            } },
        }
    ),
};

var res = await sdk.BankStatements.UploadBankStatementDataAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [UploadBankStatementDataRequest](../../Models/Requests/UploadBankStatementDataRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |

### Response

**[UploadBankStatementDataResponse](../../Models/Requests/UploadBankStatementDataResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## EndUploadSession

Use the *End upload session* endpoint to finalize a bank statement upload session. Include a `status` in the request body to indicate if you want to cancel the processing of the dataset or trigger the ingestion and enrichment of the data.

A session is a one-time process that enables you to upload bank statements to Codat. It will time out after 90 minutes if no data is uploaded.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="end-bank-statement-upload-session" method="post" path="/companies/{companyId}/connections/{connectionId}/bankStatements/upload/dataset/{datasetId}/endSession" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

EndBankStatementUploadSessionRequest req = new EndBankStatementUploadSessionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DatasetId = "79c714cf-8643-4bc6-9b4e-8d1a971222b7",
};

var res = await sdk.BankStatements.EndUploadSessionAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [EndBankStatementUploadSessionRequest](../../Models/Requests/EndBankStatementUploadSessionRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[EndBankStatementUploadSessionResponse](../../Models/Requests/EndBankStatementUploadSessionResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |