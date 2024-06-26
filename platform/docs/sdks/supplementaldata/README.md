# SupplementalData
(*SupplementalData*)

## Overview

Configure and pull additional data you can include in Codat's standard data types.

### Available Operations

* [Configure](#configure) - Configure
* [GetConfiguration](#getconfiguration) - Get configuration

## Configure

The *Configure* endpoint allows you to maintain or change configuration required to return supplemental data for each integration and data type combination.

[Supplemental data](https://docs.codat.io/using-the-api/additional-data) is additional data you can include in Codat's standard data types.

**Integration-specific behaviour**
See the *examples* for integration-specific frequently requested properties.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {
        SupplementalDataConfig = new Dictionary<string, SupplementalDataSourceConfiguration>() {
            { "orders-supplemental-data", new SupplementalDataSourceConfiguration() {
                DataSource = "/orders",
                PullData = new Dictionary<string, string>() {
                    { "orderNumber", "order_num" },
                },
                PushData = new Dictionary<string, string>() {
                    { "orderNumber", "order_num" },
                },
            } },
        },
    },
    DataType = Codat.Platform.Models.Operations.DataType.Invoices,
    PlatformKey = "gbol",
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ConfigureSupplementalDataRequest](../../Models/Operations/ConfigureSupplementalDataRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ConfigureSupplementalDataResponse](../../Models/Operations/ConfigureSupplementalDataResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

## GetConfiguration

The *Get configuration* endpoint returns supplemental data configuration previously created for each integration and data type combination.

[Supplemental data](https://docs.codat.io/using-the-api/additional-data) is additional data you can include in Codat's standard data types.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetSupplementalDataConfigurationRequest req = new GetSupplementalDataConfigurationRequest() {
    DataType = Codat.Platform.Models.Operations.PathParamDataType.Invoices,
    PlatformKey = "gbol",
};

var res = await sdk.SupplementalData.GetConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetSupplementalDataConfigurationRequest](../../Models/Operations/GetSupplementalDataConfigurationRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GetSupplementalDataConfigurationResponse](../../Models/Operations/GetSupplementalDataConfigurationResponse.md)**
### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
