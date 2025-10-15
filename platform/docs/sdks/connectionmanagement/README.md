# ConnectionManagement
(*ConnectionManagement*)

## Overview

Configure UI and retrieve access tokens for authentication used by **Connections SDK**.

### Available Operations

* [~~Get~~](#get) - Get access token (old) :warning: **Deprecated** Use [GetAccessToken](docs/sdks/companies/README.md#getaccesstoken) instead.

## ~~Get~~

﻿The new [Get company access token](https://docs.codat.io/platform-api#/operations/get-company-access-token) endpoint replaces this endpoint and includes additional functionality.

> :warning: **DEPRECATED**: The endpoint for generating company-specific connection management access tokens has been deprecated.
Codat now supports a global company access token, providing seamless access across multiple products.
Update your integration to use the global token for improved efficiency and consistency.
. Use `GetAccessToken` instead.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-connection-management-access-token" method="get" path="/companies/{companyId}/connectionManagement/accessToken" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetConnectionManagementAccessTokenRequest req = new GetConnectionManagementAccessTokenRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.ConnectionManagement.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                       | Type                                                                                                            | Required                                                                                                        | Description                                                                                                     |
| --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                       | [GetConnectionManagementAccessTokenRequest](../../Models/Requests/GetConnectionManagementAccessTokenRequest.md) | :heavy_check_mark:                                                                                              | The request object to use for the request.                                                                      |

### Response

**[GetConnectionManagementAccessTokenResponse](../../Models/Requests/GetConnectionManagementAccessTokenResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |