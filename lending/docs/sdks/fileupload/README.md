# FileUpload
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
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

DownloadFilesRequest req = new DownloadFilesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Date = "2022-10-23T00:00:00Z",
};

var res = await sdk.FileUpload.DownloadAsync(req);

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | [DownloadFilesRequest](../../Models/Operations/DownloadFilesRequest.md) | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[DownloadFilesResponse](../../Models/Operations/DownloadFilesResponse.md)**


## ListUploaded

﻿The *List files* endpoint returns a list of all files uploaded to Codat by the SMB. 

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListFilesRequest req = new ListFilesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.FileUpload.ListUploadedAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListFilesRequest](../../Models/Operations/ListFilesRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListFilesResponse](../../Models/Operations/ListFilesResponse.md)**


## Upload

The *Upload files* endpoint uploads multiple files provided by the SMB to Codat. This may include personal identity documents, pitch decks, contracts, or files with accounting and banking data.

Uploaded files must meet the following requirements:

- Up to 20 files can be uploaded at a time.
- PDF, XLS, XLSX, XLSB, CSV, DOC, DOCX, PPT, PPTX, JPEG, JPG, and PNG files can be uploaded.
- Each file can be up to 10MB in size.

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

UploadFilesRequest req = new UploadFilesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
};

var res = await sdk.FileUpload.UploadAsync(req);

// handle response
```

### Parameters

| Parameter                                                           | Type                                                                | Required                                                            | Description                                                         |
| ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- | ------------------------------------------------------------------- |
| `request`                                                           | [UploadFilesRequest](../../Models/Operations/UploadFilesRequest.md) | :heavy_check_mark:                                                  | The request object to use for the request.                          |


### Response

**[UploadFilesResponse](../../Models/Operations/UploadFilesResponse.md)**

