# IntegrationsSDK
(*Integrations*)

## Overview

View useful information about codat's integrations.

### Available Operations

* [GetBranding](#getbranding) - Get branding for an integration
* [List](#list) - List integrations

## GetBranding

Retrieve Integration branding assets.

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

var res = await sdk.Integrations.GetBrandingAsync(new GetIntegrationBrandingRequest() {
    PlatformKey = "gbol",
});

// handle response
```

### Parameters

| Parameter                                                                                 | Type                                                                                      | Required                                                                                  | Description                                                                               |
| ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------- |
| `request`                                                                                 | [GetIntegrationBrandingRequest](../../models/operations/GetIntegrationBrandingRequest.md) | :heavy_check_mark:                                                                        | The request object to use for the request.                                                |


### Response

**[GetIntegrationBrandingResponse](../../models/operations/GetIntegrationBrandingResponse.md)**


## List

Retrieve a list of available integrations support by data type and state of release.

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

var res = await sdk.Integrations.ListAsync(new ListIntegrationsRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "vel",
});

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [ListIntegrationsRequest](../../models/operations/ListIntegrationsRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[ListIntegrationsResponse](../../models/operations/ListIntegrationsResponse.md)**

