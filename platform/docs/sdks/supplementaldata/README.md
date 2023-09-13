# supplementalData

## Overview

View and configure supplemental data for supported data types.

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
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.SupplementalData.ConfigureAsync(new ConfigureSupplementalDataRequest() {
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {
        SupplementalDataConfig = new Dictionary<string, SupplementalDataConfigurationSupplementalDataSourceConfiguration>() {
            { "dolor", new SupplementalDataConfigurationSupplementalDataSourceConfiguration() {
                DataSource = "natus",
                PullData = new Dictionary<string, string>() {
                    { "laboriosam", "hic" },
                },
                PushData = new Dictionary<string, string>() {
                    { "saepe", "fuga" },
                },
            } },
        },
    },
    DataType = CodatPlatform.Models.Operations.ConfigureSupplementalDataDataType.Invoices,
    PlatformKey = "in",
});

// handle response
```

### Parameters

| Parameter                                                                                       | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `request`                                                                                       | [ConfigureSupplementalDataRequest](../../models/operations/ConfigureSupplementalDataRequest.md) | :heavy_check_mark:                                                                              | The request object to use for the request.                                                      |


### Response

**[ConfigureSupplementalDataResponse](../../models/operations/ConfigureSupplementalDataResponse.md)**


## GetConfiguration

The *Get configuration* endpoint returns supplemental data configuration previously created for each integration and data type combination.

[Supplemental data](https://docs.codat.io/using-the-api/additional-data) is additional data you can include in Codat's standard data types.

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;
using CodatPlatform.Models.Operations;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.SupplementalData.GetConfigurationAsync(new GetSupplementalDataConfigurationRequest() {
    DataType = CodatPlatform.Models.Operations.GetSupplementalDataConfigurationDataType.Invoices,
    PlatformKey = "corporis",
});

// handle response
```

### Parameters

| Parameter                                                                                                     | Type                                                                                                          | Required                                                                                                      | Description                                                                                                   |
| ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                     | [GetSupplementalDataConfigurationRequest](../../models/operations/GetSupplementalDataConfigurationRequest.md) | :heavy_check_mark:                                                                                            | The request object to use for the request.                                                                    |


### Response

**[GetSupplementalDataConfigurationResponse](../../models/operations/GetSupplementalDataConfigurationResponse.md)**

