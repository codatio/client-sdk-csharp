# CorsSettings
(*ConnectionManagement.CorsSettings*)

## Overview

### Available Operations

* [Get](#get) - Get CORS settings
* [Set](#set) - Set CORS settings

## Get

﻿The *Get CORS settings* endpoint returns the allowed origins (i.e. your domains) you want to allow cross-origin resource sharing ([CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)) with Codat. 

Enabling CORS with Codat is required by our embeddable [Connections SDK](https://docs.codat.io/auth-flow/optimize/connection-management) to access Codat's API endpoints.

The embeddable [Connections SDK](https://docs.codat.io/auth-flow/optimize/connection-management) lets your customers control access to their data by allowing them to manage their existing connections.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.ConnectionManagement.CorsSettings.GetAsync();

// handle response
```

### Response

**[GetConnectionManagementCorsSettingsResponse](../../Models/Requests/GetConnectionManagementCorsSettingsResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503         | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## Set

﻿The *Set CORS settings* endpoint allows you to register allowed origins (i.e. your domains) for use in cross-origin resource sharing ([CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)).
 
Enabling CORS with Codat is required by our embeddable [Connections SDK](https://docs.codat.io/auth-flow/optimize/connection-management) to access Codat's API endpoints. 

The embeddable [Connections SDK](https://docs.codat.io/auth-flow/optimize/connection-management) lets your customers control access to their data by allowing them to manage their existing connections.

### Example Usage

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

var res = await sdk.ConnectionManagement.CorsSettings.SetAsync(req);

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
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429, 500, 503         | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |