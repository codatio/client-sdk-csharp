# ~~Cors~~

> [!WARNING]
> This SDK is **DEPRECATED**

## Overview

### Available Operations

* [~~Get~~](#get) - Get CORS settings (old) :warning: **Deprecated** Use [Get](docs/sdks/settings/README.md#get) instead.
* [~~Set~~](#set) - Set CORS settings (old) :warning: **Deprecated** Use [Set](docs/sdks/settings/README.md#set) instead.

## ~~Get~~

﻿The *Get CORS settings* endpoint returns the allowed origins (i.e. your domains) you want to allow cross-origin resource sharing ([CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)) with Codat. 

Enabling CORS with Codat is required by our embeddable UIs (such as [Connections SDK](https://docs.codat.io/auth-flow/optimize/connection-management) and [Link SDK](https://docs.codat.io/auth-flow/authorize-embedded-link)) to access Codat's API endpoints.

> :warning: **DEPRECATED**: The new [Get CORS settings](https://docs.codat.io/platform-api#/operations/get-cors-settings) endpoint replaces this endpoint and includes additional functionality.
Update your integrations to use the new path `/corsSettings` as the existing route will be removed in a future release.
. Use `Get` instead.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-connection-management-cors-settings" method="get" path="/connectionManagement/corsSettings" example="Allowed origins" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Cors.GetAsync();

// handle response
```

### Response

**[GetConnectionManagementCorsSettingsResponse](../../Models/Requests/GetConnectionManagementCorsSettingsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## ~~Set~~

﻿The *Set CORS settings* endpoint allows you to register allowed origins (i.e. your domains) for use in cross-origin resource sharing ([CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)).
 
Enabling CORS with Codat is required by our embeddable UIs (such as [Connections SDK](https://docs.codat.io/auth-flow/optimize/connection-management) and [Link SDK](https://docs.codat.io/auth-flow/authorize-embedded-link)) to access Codat's API endpoints. 

> :warning: **DEPRECATED**: The new [Set CORS settings](https://docs.codat.io/platform-api#/operations/set-cors-settings) endpoint replaces this endpoint and includes additional functionality.
Update your integrations to use the new path `/corsSettings` as the existing route will be removed in a future release.
. Use `Set` instead.

### Example Usage: Allowed origins

<!-- UsageSnippet language="csharp" operationID="set-connection-management-cors-settings" method="post" path="/connectionManagement/corsSettings" example="Allowed origins" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConnectionManagementAllowedOrigins req = new ConnectionManagementAllowedOrigins() {
    AllowedOrigins = new List<string>() {
        "https://www.bank-of-dave.com",
    },
};

var res = await sdk.Cors.SetAsync(req);

// handle response
```
### Example Usage: Unauthorized

<!-- UsageSnippet language="csharp" operationID="set-connection-management-cors-settings" method="post" path="/connectionManagement/corsSettings" example="Unauthorized" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConnectionManagementAllowedOrigins req = new ConnectionManagementAllowedOrigins() {
    AllowedOrigins = new List<string>() {
        "https://www.bank-of-dave.com",
    },
};

var res = await sdk.Cors.SetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                           | Type                                                                                                | Required                                                                                            | Description                                                                                         |
| --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------- |
| `request`                                                                                           | [ConnectionManagementAllowedOrigins](../../Models/Components/ConnectionManagementAllowedOrigins.md) | :heavy_check_mark:                                                                                  | The request object to use for the request.                                                          |

### Response

**[SetConnectionManagementCorsSettingsResponse](../../Models/Requests/SetConnectionManagementCorsSettingsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |