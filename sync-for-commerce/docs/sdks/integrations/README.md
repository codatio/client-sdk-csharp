# Integrations
(*Integrations*)

## Overview

Get a list of integrations supported by Sync for Commerce and their logos.

### Available Operations

* [List](#list) - List integrations
* [GetBranding](#getbranding) - Get branding for an integration

## List

Retrieve a list of available integrations support by data type and state of release.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListIntegrationsRequest req = new ListIntegrationsRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Integrations.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [ListIntegrationsRequest](../../Models/Requests/ListIntegrationsRequest.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[ListIntegrationsResponse](../../Models/Requests/ListIntegrationsResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503                    | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |


## GetBranding

Retrieve Integration branding assets.

### Example Usage

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetIntegrationBrandingRequest req = new GetIntegrationBrandingRequest() {
    PlatformKey = "gbol",
};

var res = await sdk.Integrations.GetBrandingAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [GetIntegrationBrandingRequest](../../Models/Requests/GetIntegrationBrandingRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[GetIntegrationBrandingResponse](../../Models/Requests/GetIntegrationBrandingResponse.md)**

### Errors

| Error Object                                   | Status Code                                    | Content Type                                   |
| ---------------------------------------------- | ---------------------------------------------- | ---------------------------------------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503                    | application/json                               |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4xx-5xx                                        | */*                                            |
