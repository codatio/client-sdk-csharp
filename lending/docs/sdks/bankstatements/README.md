# BankStatements
(*BankStatements*)

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

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

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

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## SetUploadConfiguration

Use the *Set upload configuration* endpoint to create bank statement upload configuration for the specified data connection. 

With this configuration, you set the source of the data you plan to upload, the ID of the account in third-party banking platform, and a provider ID, if required. This lets us determine the expected format of the data and any source-specific requirements.

Each data connection can only have one configuration for each company and external account ID combination. You will receive a Bad Request response if you try to set it again. 

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

SetBankStatementUploadConfigurationRequest req = new SetBankStatementUploadConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
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

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## StartUploadSession

Use the *Start upload session* endpoint to initiate a bank statement upload session for a given company.

A session is a one-time process that enables you to upload bank statements to Codat. It will time out after 90 minutes if no data is uploaded. 

You can only have one active session per data type at a time. You can complete or cancel a session using the [*End upload session*](https://docs.codat.io/lending-api#/operations/end-bank-statement-upload-session) endpoint.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

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

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## UploadBankStatementData

During an active session, use the **Upload data* endpoint to uploads a page of bank accounts or bank transactions data to the session.

Make sure you created configuration for the account using the [*Set upload configuration*](https://docs.codat.io/lending-api#/operations/set-bank-statement-upload-configuration) endpoint before attempting an upload. 

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;
using System.Collections.Generic;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UploadBankStatementDataRequest req = new UploadBankStatementDataRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DatasetId = "10afb615-fc5a-4e43-99bd-eeba7c3a2259",
    RequestBody = UploadBankStatementDataRequestBody.CreateBankingTransactions(
        new BankingTransactions() {
            Results = new List<BankingTransaction>() {
                new BankingTransaction() {
                    ModifiedDate = "2022-05-23T16:32:50Z",
                    SourceModifiedDate = "2021-06-28T10:48:12",
                    Id = "0130b5bb-1419-40f6-8a27-7362d0381229",
                    AccountId = "1703194f-7805-4da8-bac0-2ba5da4a4216",
                    Description = "Payments for direct income ce149943-c157-43fc-aac7-42a716b655b6",
                    Amount = 5062.39M,
                    Currency = "GBP",
                    PostedDate = "2021-07-06T00:00:00",
                    AuthorizedDate = "2021-07-06T00:00:00",
                    MerchantName = "New Look",
                    TransactionCategoryRef = new TransactionCategoryRef() {
                        Id = "health-and-fitness-sports",
                    },
                },
            },
            PageNumber = 1,
            PageSize = 10,
            TotalResults = 1,
            Links = new Links() {
                Self = new HalRef() {
                    Href = "/companies/{id}/data/{dataType}",
                },
                Current = new HalRef() {
                    Href = "/companies/{id}/data/{dataType}?page=1&pageSize=10",
                },
            },
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

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## EndUploadSession

Use the *End upload session* endpoint to finalize a bank statement upload session. Include a `status` in the request body to indicate if you want to cancel the processing of the dataset or trigger the ingestion and enrichment of the data.

A session is a one-time process that enables you to upload bank statements to Codat. It will time out after 90 minutes if no data is uploaded.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

EndBankStatementUploadSessionRequest req = new EndBankStatementUploadSessionRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DatasetId = "d58db2ab-edef-4881-8b6b-a7e79d33244c",
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

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
