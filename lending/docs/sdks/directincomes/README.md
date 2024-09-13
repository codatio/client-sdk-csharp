# DirectIncomes
(*AccountsReceivable.DirectIncomes*)

## Overview

### Available Operations

* [List](#list) - List direct incomes
* [Get](#get) - Get direct income
* [GetAttachment](#getattachment) - Get direct income attachment
* [DownloadAttachment](#downloadattachment) - Download direct income attachment
* [ListAttachments](#listattachments) - List direct income attachments

## List

The *List direct incomes* endpoint returns a list of [direct incomes](https://docs.codat.io/lending-api#/schemas/DirectIncome) for a given company's connection.

[Direct incomes](https://docs.codat.io/lending-api#/schemas/DirectIncome) are sales of items directly to a customer where payment is received at the point of the sale.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).
    

### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingDirectIncomesRequest req = new ListAccountingDirectIncomesRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.AccountsReceivable.DirectIncomes.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                         | Type                                                                                              | Required                                                                                          | Description                                                                                       |
| ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------- |
| `request`                                                                                         | [ListAccountingDirectIncomesRequest](../../Models/Requests/ListAccountingDirectIncomesRequest.md) | :heavy_check_mark:                                                                                | The request object to use for the request.                                                        |

### Response

**[ListAccountingDirectIncomesResponse](../../Models/Requests/ListAccountingDirectIncomesResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 400,401,402,403,404,409,429,500,503      | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## Get

The *Get direct income* endpoint returns a single direct income for a given directIncomeId.

[Direct incomes](https://docs.codat.io/lending-api#/schemas/DirectIncome) are sales of items directly to a customer where payment is received at the point of the sale.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directIncomes) for integrations that support getting a specific direct income.

Before using this endpoint, you must have [retrieved data for the company](https://docs.codat.io/lending-api#/operations/refresh-company-data).


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingDirectIncomeRequest req = new GetAccountingDirectIncomeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectIncomeId = "<value>",
};

var res = await sdk.AccountsReceivable.DirectIncomes.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [GetAccountingDirectIncomeRequest](../../Models/Requests/GetAccountingDirectIncomeRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[GetAccountingDirectIncomeResponse](../../Models/Requests/GetAccountingDirectIncomeResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## GetAttachment

The *Get direct income attachment* endpoint returns a specific attachment for a given `directIncomeId` and `attachmentId`.

[Direct incomes](https://docs.codat.io/lending-api#/schemas/DirectIncome) are sales of items directly to a customer where payment is received at the point of the sale.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directIncomes) for integrations that support getting a direct income attachment.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetAccountingDirectIncomeAttachmentRequest req = new GetAccountingDirectIncomeAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectIncomeId = "<value>",
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsReceivable.DirectIncomes.GetAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetAccountingDirectIncomeAttachmentRequest](../../Models/Requests/GetAccountingDirectIncomeAttachmentRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |

### Response

**[GetAccountingDirectIncomeAttachmentResponse](../../Models/Requests/GetAccountingDirectIncomeAttachmentResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503              | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## DownloadAttachment

The *Download direct income attachment* endpoint downloads a specific attachment for a given `directIncomeId` and `attachmentId`.

[Direct incomes](https://docs.codat.io/lending-api#/schemas/DirectIncome) are sales of items directly to a customer where payment is received at the point of the sale.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directIncomes) for integrations that support downloading a direct income attachment.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DownloadAccountingDirectIncomeAttachmentRequest req = new DownloadAccountingDirectIncomeAttachmentRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectIncomeId = "<value>",
    AttachmentId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.AccountsReceivable.DirectIncomes.DownloadAttachmentAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                                   | Type                                                                                                                        | Required                                                                                                                    | Description                                                                                                                 |
| --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                                   | [DownloadAccountingDirectIncomeAttachmentRequest](../../Models/Requests/DownloadAccountingDirectIncomeAttachmentRequest.md) | :heavy_check_mark:                                                                                                          | The request object to use for the request.                                                                                  |

### Response

**[DownloadAccountingDirectIncomeAttachmentResponse](../../Models/Requests/DownloadAccountingDirectIncomeAttachmentResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503              | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |


## ListAttachments

The *List direct income attachments* endpoint returns a list of attachments available to download for given `directIncomeId`.

[Direct incomes](https://docs.codat.io/lending-api#/schemas/DirectIncome) are sales of items directly to a customer where payment is received at the point of the sale.

Check out our [coverage explorer](https://knowledge.codat.io/supported-features/accounting?view=tab-by-data-type&dataType=directIncomes) for integrations that support listing direct income attachments.


### Example Usage

```csharp
using Codat.Lending;
using Codat.Lending.Models.Requests;
using Codat.Lending.Models.Components;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListAccountingDirectIncomeAttachmentsRequest req = new ListAccountingDirectIncomeAttachmentsRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DirectIncomeId = "<value>",
};

var res = await sdk.AccountsReceivable.DirectIncomes.ListAttachmentsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [ListAccountingDirectIncomeAttachmentsRequest](../../Models/Requests/ListAccountingDirectIncomeAttachmentsRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |

### Response

**[ListAccountingDirectIncomeAttachmentsResponse](../../Models/Requests/ListAccountingDirectIncomeAttachmentsResponse.md)**

### Errors

| Error Object                             | Status Code                              | Content Type                             |
| ---------------------------------------- | ---------------------------------------- | ---------------------------------------- |
| Codat.Lending.Models.Errors.ErrorMessage | 401,402,403,404,409,429,500,503          | application/json                         |
| Codat.Lending.Models.Errors.SDKException | 4xx-5xx                                  | */*                                      |
