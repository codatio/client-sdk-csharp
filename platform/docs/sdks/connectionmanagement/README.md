# ConnectionManagement
(*ConnectionManagement*)

## Overview

Configure connection management UI and retrieve access tokens for authentication.

### Available Operations

* [GetAccessToken](#getaccesstoken) - Get access token

## GetAccessToken

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

var res = await sdk.ConnectionManagement.GetAccessTokenAsync(req);

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
