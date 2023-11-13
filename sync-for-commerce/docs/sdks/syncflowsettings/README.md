# SyncFlowSettings
(*SyncFlowSettings*)

## Overview

Configure preferences for any given Sync for Commerce company using sync flow.

### Available Operations

* [GetConfigTextSyncFlow](#getconfigtextsyncflow) - Get preferences for text fields
* [GetVisibleAccounts](#getvisibleaccounts) - List visible accounts
* [UpdateConfigTextSyncFlow](#updateconfigtextsyncflow) - Update preferences for text fields
* [UpdateVisibleAccountsSyncFlow](#updatevisibleaccountssyncflow) - Update visible accounts

## GetConfigTextSyncFlow

Return preferences set for the text fields on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.GetConfigTextSyncFlowAsync();

// handle response
```


### Response

**[GetConfigTextSyncFlowResponse](../../Models/Operations/GetConfigTextSyncFlowResponse.md)**


## GetVisibleAccounts

Return accounts which are visible on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.GetVisibleAccountsAsync(new GetVisibleAccountsRequest() {
    ClientId = "86fe9741-738d-4f2c-8e96-9c3f84156e91",
    PlatformKey = "gbol",
});

// handle response
```

### Parameters

| Parameter                                                                         | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `request`                                                                         | [GetVisibleAccountsRequest](../../Models/Operations/GetVisibleAccountsRequest.md) | :heavy_check_mark:                                                                | The request object to use for the request.                                        |


### Response

**[GetVisibleAccountsResponse](../../Models/Operations/GetVisibleAccountsResponse.md)**


## UpdateConfigTextSyncFlow

Set preferences for the text fields on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.UpdateConfigTextSyncFlowAsync(new Dictionary<string, Localization>() {
    { "key", new Localization() {} },
});

// handle response
```

### Parameters

| Parameter                                                               | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `request`                                                               | Dictionary<String, [Localization](../../Models/Shared/Localization.md)> | :heavy_check_mark:                                                      | The request object to use for the request.                              |


### Response

**[UpdateConfigTextSyncFlowResponse](../../Models/Operations/UpdateConfigTextSyncFlowResponse.md)**


## UpdateVisibleAccountsSyncFlow

Update which accounts are visible on sync flow.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Shared;
using Codat.Sync.Commerce.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatSyncCommerce(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

var res = await sdk.SyncFlowSettings.UpdateVisibleAccountsSyncFlowAsync(new UpdateVisibleAccountsSyncFlowRequest() {
    VisibleAccounts = new VisibleAccounts() {
        VisibleAccounts = new List<string>() {
            "string",
        },
    },
    PlatformKey = "gbol",
});

// handle response
```

### Parameters

| Parameter                                                                                               | Type                                                                                                    | Required                                                                                                | Description                                                                                             |
| ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------- |
| `request`                                                                                               | [UpdateVisibleAccountsSyncFlowRequest](../../Models/Operations/UpdateVisibleAccountsSyncFlowRequest.md) | :heavy_check_mark:                                                                                      | The request object to use for the request.                                                              |


### Response

**[UpdateVisibleAccountsSyncFlowResponse](../../Models/Operations/UpdateVisibleAccountsSyncFlowResponse.md)**

