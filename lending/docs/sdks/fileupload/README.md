# FileUploadSDK
(*FileUpload*)

## Overview

Endpoints to manage uploaded files.

### Available Operations

* [Download](#download) - Download all files for a company
* [ListUploaded](#listuploaded) - List all files uploaded by a company
* [Upload](#upload) - Upload files for a company

## Download

The *Download files* endpoint downloads all files that have  been uploaded by to SMB to Codat. A `date` may be specified to download any files uploaded on the date provided.

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

var res = await sdk.FileUpload.DownloadAsync(new DownloadFilesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Date = "2022-10-23T00:00:00.000Z",
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [DownloadFilesRequest](../../models/operations/DownloadFilesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[DownloadFilesResponse](../../models/operations/DownloadFilesResponse.md)**


## ListUploaded

﻿The *List files* endpoint returns a list of all files uploaded to Codat by the SMB. 

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

var res = await sdk.FileUpload.ListUploadedAsync(new ListFilesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListFilesRequest](../../models/operations/ListFilesRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListFilesResponse](../../models/operations/ListFilesResponse.md)**


## Upload

The *Upload files* endpoint uploads multiple files provided by the SMB to Codat. This may include personal identity documents, pitch decks, contracts, or files with accounting and banking data.

Uploaded files must meet the following requirements:

- Up to 20 files can be uploaded at a time.
- PDF, XLS, XLSX, XLSB, CSV, DOC, DOCX, PPT, PPTX, JPEG, JPG, and PNG files can be uploaded.
- Each file can be up to 10MB in size.

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

var res = await sdk.FileUpload.UploadAsync(new UploadFilesRequest() {
    RequestBody = new UploadFilesRequestBody() {
        Content = "F?SRSKG@^n as bytes <<<>>>",
        RequestBody = "string",
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [UploadFilesRequest](../../models/operations/UploadFilesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[UploadFilesResponse](../../models/operations/UploadFilesResponse.md)**

