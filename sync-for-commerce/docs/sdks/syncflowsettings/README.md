# SyncFlowSettings
(*SyncFlowSettings*)

## Overview

Control text and visibility settings for the Sync Flow.

### Available Operations

* [GetConfigTextSyncFlow](#getconfigtextsyncflow) - Get preferences for text fields
* [UpdateConfigTextSyncFlow](#updateconfigtextsyncflow) - Update preferences for text fields
* [GetVisibleAccounts](#getvisibleaccounts) - List visible accounts
* [UpdateVisibleAccountsSyncFlow](#updatevisibleaccountssyncflow) - Update visible accounts

## GetConfigTextSyncFlow

Return preferences set for the text fields on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetConfigTextSyncFlowRequest req = new GetConfigTextSyncFlowRequest() {
    Locale = Codat.Sync.Commerce.Models.Components.Locale.EnUs,
};

var res = await sdk.SyncFlowSettings.GetConfigTextSyncFlowAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [GetConfigTextSyncFlowRequest](../../Models/Requests/GetConfigTextSyncFlowRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[GetConfigTextSyncFlowResponse](../../Models/Requests/GetConfigTextSyncFlowResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 429, 500, 503                   | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## UpdateConfigTextSyncFlow

Set preferences for the text fields on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateConfigTextSyncFlowRequest req = new UpdateConfigTextSyncFlowRequest() {
    Locale = Codat.Sync.Commerce.Models.Components.Locale.EnUs,
};

var res = await sdk.SyncFlowSettings.UpdateConfigTextSyncFlowAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                   | Type                                                                                        | Required                                                                                    | Description                                                                                 |
| ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------- |
| `request`                                                                                   | [UpdateConfigTextSyncFlowRequest](../../Models/Requests/UpdateConfigTextSyncFlowRequest.md) | :heavy_check_mark:                                                                          | The request object to use for the request.                                                  |

### Response

**[UpdateConfigTextSyncFlowResponse](../../Models/Requests/UpdateConfigTextSyncFlowResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400, 401, 402, 403, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## GetVisibleAccounts

Return accounts which are visible on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetVisibleAccountsRequest req = new GetVisibleAccountsRequest() {
    ClientId = "8f9478fc-e6cf-445e-b122-74136f8fd7ab",
    PlatformKey = "gbol",
};

var res = await sdk.SyncFlowSettings.GetVisibleAccountsAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [GetVisibleAccountsRequest](../../Models/Requests/GetVisibleAccountsRequest.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[GetVisibleAccountsResponse](../../Models/Requests/GetVisibleAccountsResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503              | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |

## UpdateVisibleAccountsSyncFlow

Update which accounts are visible on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;
using System.Collections.Generic;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

UpdateVisibleAccountsSyncFlowRequest req = new UpdateVisibleAccountsSyncFlowRequest() {
    PlatformKey = "gbol",
};

var res = await sdk.SyncFlowSettings.UpdateVisibleAccountsSyncFlowAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                             | Type                                                                                                  | Required                                                                                              | Description                                                                                           |
| ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------- |
| `request`                                                                                             | [UpdateVisibleAccountsSyncFlowRequest](../../Models/Requests/UpdateVisibleAccountsSyncFlowRequest.md) | :heavy_check_mark:                                                                                    | The request object to use for the request.                                                            |

### Response

**[UpdateVisibleAccountsSyncFlowResponse](../../Models/Requests/UpdateVisibleAccountsSyncFlowResponse.md)**

### Errors

| Error Type                                     | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503         | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                                       | \*/\*                                          |