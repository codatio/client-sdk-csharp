# ConnectionManagement
(*ConnectionManagement*)

## Overview

Configure connection management UI and retrieve access tokens for authentication.

### Available Operations

* [ConnectionManagementCorsSettingsGet](#connectionmanagementcorssettingsget) - Get CORS settings
* [ConnectionManagementCorsSettingsSet](#connectionmanagementcorssettingsset) - Set CORS settings
* [Get](#get) - Get access token

## ConnectionManagementCorsSettingsGet

﻿The *Get CORS settings* endpoint returns the allowed origins (i.e. your domains) you want to allow cross-origin resource sharing ([CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)) with Codat. 

Enabling CORS with Codat is required by our embedded [connection management UI](https://docs.codat.io/auth-flow/optimize/connection-management) to access Codat's API endpoints.

The embedded [connection management UI](https://docs.codat.io/auth-flow/optimize/connection-management) lets your customers control access to their data by allowing them to manage their existing connections.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

var res = await sdk.ConnectionManagement.ConnectionManagementCorsSettingsGetAsync();

// handle response
```


### Response

**[GetConnectionManagementCorsSettingsResponse](../../Models/Operations/GetConnectionManagementCorsSettingsResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

## ConnectionManagementCorsSettingsSet

﻿The *Set CORS settings* endpoint allows you to register allowed origins (i.e. your domains) for use in cross-origin resource sharing ([CORS](https://en.wikipedia.org/wiki/Cross-origin_resource_sharing)).
 
Enabling CORS with Codat is required by our embedded [connection management UI](https://docs.codat.io/auth-flow/optimize/connection-management) to access Codat's API endpoints. 

The embedded [connection management UI](https://docs.codat.io/auth-flow/optimize/connection-management) lets your customers control access to their data by allowing them to manage their existing connections.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ConnectionManagementAllowedOrigins req = new ConnectionManagementAllowedOrigins() {
    AllowedOrigins = new List<string>() {
        "https://www.bank-of-dave.com",
    },
};

var res = await sdk.ConnectionManagement.ConnectionManagementCorsSettingsSetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ConnectionManagementAllowedOrigins](../../Models/Shared/ConnectionManagementAllowedOrigins.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[SetConnectionManagementCorsSettingsResponse](../../Models/Operations/SetConnectionManagementCorsSettingsResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

## Get

﻿Use the *Get access token* endpoint to retrieve a new access token for use by the [connection management UI](https://docs.codat.io/auth-flow/optimize/connection-management).

The embedded [connection management UI](https://docs.codat.io/auth-flow/optimize/connection-management) lets your customers control access to their data by allowing them to manage their existing connections.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetConnectionManagementAccessTokenRequest req = new GetConnectionManagementAccessTokenRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.ConnectionManagement.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                         | Type                                                                                                              | Required                                                                                                          | Description                                                                                                       |
| ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                         | [GetConnectionManagementAccessTokenRequest](../../Models/Operations/GetConnectionManagementAccessTokenRequest.md) | :heavy_check_mark:                                                                                                | The request object to use for the request.                                                                        |


### Response

**[GetConnectionManagementAccessTokenResponse](../../Models/Operations/GetConnectionManagementAccessTokenResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
