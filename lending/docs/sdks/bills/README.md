# AccountsPayable.Bills

## Overview

### Available Operations

* [List](#list) - List bills
* [Get](#get) - Get bill
* [ListAttachments](#listattachments) - List bill attachments
* [GetAttachment](#getattachment) - Get bill attachment
* [DownloadAttachment](#downloadattachment) - Download bill attachment

## List

The *List bills* endpoint returns a list of [bills](https://docs.codat.io/lending-api#/schemas/Bill) for a given company's connection.

[Bills](https://docs.codat.io/lending-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Tips and traps

To access the `paymentAllocations` property, ensure that the `billPayments` data type is queued and cached in Codat before retrieving `bills` from Codat's cache.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-accounting-bills" method="get" path="/companies/{companyId}/data/bills" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillsRequest req = new ListAccountingBillsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsPayable.Bills.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [ListAccountingBillsRequest](../../Models/Requests/ListAccountingBillsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |

### Response

**[ListAccountingBillsResponse](../../Models/Requests/ListAccountingBillsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 409, 429        | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## Get

The *Get bill* endpoint returns a single bill for a given billId.

[Bills](https://docs.codat.io/lending-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).

### Tips and traps

To access the `paymentAllocations` property, ensure that the `billPayments` data type is queued and cached in Codat before retrieving `bills` from Codat's cache.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill" method="get" path="/companies/{companyId}/data/bills/{billId}" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillRequest req = new GetAccountingBillRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.Bills.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetAccountingBillRequest](../../Models/Requests/GetAccountingBillRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |

### Response

**[GetAccountingBillResponse](../../Models/Requests/GetAccountingBillResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## ListAttachments

The *List bill attachments* endpoint returns a list of attachments available to download for a given `billId`.

[Bills](https://docs.codat.io/lending-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.


### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-accounting-bill-attachments" method="get" path="/companies/{companyId}/connections/{connectionId}/data/bills/{billId}/attachments" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingBillAttachmentsRequest req = new ListAccountingBillAttachmentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
};

var res = await sdk.AccountsPayable.Bills.ListAttachmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [ListAccountingBillAttachmentsRequest](../../Models/Requests/ListAccountingBillAttachmentsRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[ListAccountingBillAttachmentsResponse](../../Models/Requests/ListAccountingBillAttachmentsResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 409, 429             | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## GetAttachment

The *Get bill attachment* endpoint returns a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/lending-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-accounting-bill-attachment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/bills/{billId}/attachments/{attachmentId}" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingBillAttachmentRequest req = new GetAccountingBillAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsPayable.Bills.GetAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [GetAccountingBillAttachmentRequest](../../Models/Requests/GetAccountingBillAttachmentRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[GetAccountingBillAttachmentResponse](../../Models/Requests/GetAccountingBillAttachmentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |

## DownloadAttachment

The *Download bill attachment* endpoint downloads a specific attachment for a given `billId` and `attachmentId`.

[Bills](https://docs.codat.io/lending-api#/schemas/Bill) are invoices that represent the SMB's financial obligations to their supplier for a purchase of goods or services.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="download-accounting-bill-attachment" method="get" path="/companies/{companyId}/connections/{connectionId}/data/bills/{billId}/attachments/{attachmentId}/download" -->
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DownloadAccountingBillAttachmentRequest req = new DownloadAccountingBillAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    BillId = "13d946f0-c5d5-42bc-b092-97ece17923ab",
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsPayable.Bills.DownloadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [DownloadAccountingBillAttachmentRequest](../../Models/Requests/DownloadAccountingBillAttachmentRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[DownloadAccountingBillAttachmentResponse](../../Models/Requests/DownloadAccountingBillAttachmentResponse.md)**

### Errors

| Error Type                               | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                  | application/json                         |
| Codat.Lending.Models.Errors.ErrorMessage | 500, 503                                 | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4XX, 5XX                                 | \*/\*                                    |