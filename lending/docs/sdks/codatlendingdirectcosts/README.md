# CodatLendingDirectCosts
(*Transactions.DirectCosts*)

### Available Operations

* [DownloadAttachment](#downloadattachment) - Download direct cost attachment
* [Get](#get) - Get direct cost
* [GetAttachment](#getattachment) - Get direct cost attachment
* [List](#list) - List direct costs
* [ListAttachments](#listattachments) - List direct cost attachments

## DownloadAttachment

The *Download direct cost attachment* endpoint downloads a specific attachment for a given `directCostId` and `attachmentId`.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directCosts) for integrations that support downloading a direct cost attachment.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

DownloadAccountingDirectCostAttachmentRequest req = new DownloadAccountingDirectCostAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostId = "string",
};

var res = await sdk.Transactions.DirectCosts.DownloadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                 | Type                                                                                                                      | Required                                                                                                                  | Description                                                                                                               |
| ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                 | [DownloadAccountingDirectCostAttachmentRequest](../../Models/Operations/DownloadAccountingDirectCostAttachmentRequest.md) | :heavy_check_mark:                                                                                                        | The request object to use for the request.                                                                                |


### Response

**[DownloadAccountingDirectCostAttachmentResponse](../../Models/Operations/DownloadAccountingDirectCostAttachmentResponse.md)**


## Get

The *Get direct cost* endpoint returns a single direct cost for a given directCostId.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directCosts) for integrations that support getting a specific direct cost.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingDirectCostRequest req = new GetAccountingDirectCostRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostId = "string",
};

var res = await sdk.Transactions.DirectCosts.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [GetAccountingDirectCostRequest](../../Models/Operations/GetAccountingDirectCostRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |


### Response

**[GetAccountingDirectCostResponse](../../Models/Operations/GetAccountingDirectCostResponse.md)**


## GetAttachment

The *Get direct cost attachment* endpoint returns a specific attachment for a given `directCostId` and `attachmentId`.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directCosts) for integrations that support getting a direct cost attachment.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetAccountingDirectCostAttachmentRequest req = new GetAccountingDirectCostAttachmentRequest() {
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostId = "string",
};

var res = await sdk.Transactions.DirectCosts.GetAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [GetAccountingDirectCostAttachmentRequest](../../Models/Operations/GetAccountingDirectCostAttachmentRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |


### Response

**[GetAccountingDirectCostAttachmentResponse](../../Models/Operations/GetAccountingDirectCostAttachmentResponse.md)**


## List

The *List direct costs* endpoint returns a list of [direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) for a given company's connection.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingDirectCostsRequest req = new ListAccountingDirectCostsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
};

var res = await sdk.Transactions.DirectCosts.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ListAccountingDirectCostsRequest](../../Models/Operations/ListAccountingDirectCostsRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ListAccountingDirectCostsResponse](../../Models/Operations/ListAccountingDirectCostsResponse.md)**


## ListAttachments

The *List direct cost attachments* endpoint returns a list of attachments available to download for given `directCostId`.

[Direct costs](https://docs.codat.io/lending-api#/schemas/DirectCost) are purchases of items that are paid off at the point of the purchase.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directCosts) for integrations that support listing direct cost attachments.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Shared;
using Codat.Lending.Models.Operations;

var sdk = new CodatLending(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ListAccountingDirectCostAttachmentsRequest req = new ListAccountingDirectCostAttachmentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectCostId = "string",
};

var res = await sdk.Transactions.DirectCosts.ListAttachmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                           | Type                                                                                                                | Required                                                                                                            | Description                                                                                                         |
| ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                           | [ListAccountingDirectCostAttachmentsRequest](../../Models/Operations/ListAccountingDirectCostAttachmentsRequest.md) | :heavy_check_mark:                                                                                                  | The request object to use for the request.                                                                          |


### Response

**[ListAccountingDirectCostAttachmentsResponse](../../Models/Operations/ListAccountingDirectCostAttachmentsResponse.md)**

