# companies

## Overview

Create new and manage existing Sync for Commerce companies using the Sync flow UI.

### Available Operations

* [GetSyncFlowUrl](#getsyncflowurl) - Start new sync flow
* [UpdateAuthorization](#updateauthorization) - Update authorization
* [UpdateConnection](#updateconnection) - Update connection

## GetSyncFlowUrl

Create a new company and connections. Get a URL for Sync Flow, including a one time passcode.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Companies.GetSyncFlowUrlAsync(new GetSyncFlowUrlRequest() {
    AccountingKey = "provident",
    CommerceKey = "distinctio",
    MerchantIdentifier = "quibusdam",
});

// handle response
```

### Parameters

| Parameter                                                                 | Type                                                                      | Required                                                                  | Description                                                               |
| ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- | ------------------------------------------------------------------------- |
| `request`                                                                 | [GetSyncFlowUrlRequest](../../models/operations/GetSyncFlowUrlRequest.md) | :heavy_check_mark:                                                        | The request object to use for the request.                                |


### Response

**[GetSyncFlowUrlResponse](../../models/operations/GetSyncFlowUrlResponse.md)**


## UpdateAuthorization

Update data connection's authorization.

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Companies.UpdateAuthorizationAsync(new UpdateConnectionAuthorizationRequest() {
    RequestBody = new Dictionary<string, string>() {
        { "unde", "nulla" },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateConnectionAuthorizationRequest](../../models/operations/UpdateConnectionAuthorizationRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateConnectionAuthorizationResponse](../../models/operations/UpdateConnectionAuthorizationResponse.md)**


## UpdateConnection

Update a data connection

### Example Usage

```csharp
using CodatSyncCommerce;
using CodatSyncCommerce.Models.Shared;
using CodatSyncCommerce.Models.Operations;

var sdk = new CodatSyncCommerceSDK(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.Companies.UpdateConnectionAsync(new UpdateConnectionRequest() {
    UpdateConnection = new UpdateConnection() {
        Status = CodatSyncCommerce.Models.Shared.DataConnectionStatus.Unlinked,
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    ConnectionId = "2e9d2c44-f675-40ba-8049-353bfcb5e171",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [UpdateConnectionRequest](../../models/operations/UpdateConnectionRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[UpdateConnectionResponse](../../models/operations/UpdateConnectionResponse.md)**

