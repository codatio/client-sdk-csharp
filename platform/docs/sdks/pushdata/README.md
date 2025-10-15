# PushData
(*PushData*)

## Overview

Initiate and monitor Create, Update, and Delete operations.

### Available Operations

* [GetModelOptions](#getmodeloptions) - Get push options
* [ListOperations](#listoperations) - List push operations
* [GetOperation](#getoperation) - Get push operation

## GetModelOptions

This is the generic documentation for creation and updating of data. See the equivalent endpoint for a given data type for more specific information. 

Before pushing data into accounting software, it is often necessary to collect some details from the user as to how they would like the data to be inserted. This includes names and amounts on transactional entities, but also factors such as categorisation of entities, which is often handled differently between different accounting software. A good example of this is specifying where on the balance sheet/profit and loss reports the user would like a newly-created nominal account to appear.

Codat tries not to limit users to pushing to a very limited number of standard categories, so we have implemented "options" endpoints, which allow us to expose to our clients the fields which are required to be pushed for a specific linked company, and the options which may be selected for each field.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-create-update-model-options-by-data-type" method="get" path="/companies/{companyId}/connections/{connectionId}/options/{dataType}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCreateUpdateModelOptionsByDataTypeRequest req = new GetCreateUpdateModelOptionsByDataTypeRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
    DataType = Codat.Platform.Models.Components.DataType.Invoices,
};

var res = await sdk.PushData.GetModelOptionsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                             | Type                                                                                                                  | Required                                                                                                              | Description                                                                                                           |
| --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                             | [GetCreateUpdateModelOptionsByDataTypeRequest](../../Models/Requests/GetCreateUpdateModelOptionsByDataTypeRequest.md) | :heavy_check_mark:                                                                                                    | The request object to use for the request.                                                                            |

### Response

**[GetCreateUpdateModelOptionsByDataTypeResponse](../../Models/Requests/GetCreateUpdateModelOptionsByDataTypeResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## ListOperations

The **List push operations** endpoint returns a list of [push operations](/using-the-api/push) performed on the company.

Write operations are actions that send requests to Codat, enabling the creation, updating, deletion of records, or uploading attachments in the connected accounting software.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-company-push-history" method="get" path="/companies/{companyId}/push" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetCompanyPushHistoryRequest req = new GetCompanyPushHistoryRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.PushData.ListOperationsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetCompanyPushHistoryRequest](../../Models/Requests/GetCompanyPushHistoryRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetCompanyPushHistoryResponse](../../Models/Requests/GetCompanyPushHistoryResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429              | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## GetOperation

The **Get push operation** endpoint returns a specific [push operation](/using-the-api/push) identified by the `pushOperationKey` that was performed on the company.

Write operations are actions that send requests to Codat, enabling the creation, updating, deletion of records, or uploading attachments in the connected accounting software.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-push-operation" method="get" path="/companies/{companyId}/push/{pushOperationKey}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetPushOperationRequest req = new GetPushOperationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    PushOperationKey = "660e8684-c0fb-4468-9e2a-b2e3b115d747",
};

var res = await sdk.PushData.GetOperationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [GetPushOperationRequest](../../Models/Requests/GetPushOperationRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[GetPushOperationResponse](../../Models/Requests/GetPushOperationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |