# SupplementalData

## Overview

Configure and pull additional data you can include in Codat's standard data types.

### Available Operations

* [Configure](#configure) - Configure
* [GetConfiguration](#getconfiguration) - Get configuration

## Configure

The *Configure* endpoint allows you to maintain or change configuration required to return supplemental data for each integration and data type combination.

[Supplemental data](https://docs.codat.io/using-the-api/supplemental-data/overview) is additional data you can include in Codat's standard data types.

**Integration-specific behavior**
See the *examples* for integration-specific frequently requested properties.

### Example Usage: QBO - Customers

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="QBO - Customers" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {},
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```
### Example Usage: QBO - Invoices

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="QBO - Invoices" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {},
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```
### Example Usage: Unauthorized

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="Unauthorized" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
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
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```
### Example Usage: Xero - Accounts

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="Xero - Accounts" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {},
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```
### Example Usage: Xero - Contacts

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="Xero - Contacts" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {},
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```
### Example Usage: Xero - Invoices

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="Xero - Invoices" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {},
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```
### Example Usage: Xero - Items

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="Xero - Items" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {},
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```
### Example Usage: Xero - Tax rates

<!-- UsageSnippet language="csharp" operationID="configure-supplemental-data" method="put" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" example="Xero - Tax rates" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ConfigureSupplementalDataRequest req = new ConfigureSupplementalDataRequest() {
    PlatformKey = "gbol",
    DataType = Codat.Platform.Models.Requests.DataType.Invoices,
    SupplementalDataConfiguration = new SupplementalDataConfiguration() {},
};

var res = await sdk.SupplementalData.ConfigureAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                     | Type                                                                                          | Required                                                                                      | Description                                                                                   |
| --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------------- |
| `request`                                                                                     | [ConfigureSupplementalDataRequest](../../Models/Requests/ConfigureSupplementalDataRequest.md) | :heavy_check_mark:                                                                            | The request object to use for the request.                                                    |

### Response

**[ConfigureSupplementalDataResponse](../../Models/Requests/ConfigureSupplementalDataResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## GetConfiguration

The *Get configuration* endpoint returns supplemental data configuration previously created for each integration and data type combination.

[Supplemental data](https://docs.codat.io/using-the-api/supplemental-data/overview) is additional data you can include in Codat's standard data types.

### Example Usage

<!-- UsageSnippet language="csharp" operationID="get-supplemental-data-configuration" method="get" path="/integrations/{platformKey}/dataTypes/{dataType}/supplementalDataConfig" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSupplementalDataConfigurationRequest req = new GetSupplementalDataConfigurationRequest() {
    PlatformKey = "gbol",
    DataType = PathParamDataType.Invoices,
};

var res = await sdk.SupplementalData.GetConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                                                   | Type                                                                                                        | Required                                                                                                    | Description                                                                                                 |
| ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------------------- |
| `request`                                                                                                   | [GetSupplementalDataConfigurationRequest](../../Models/Requests/GetSupplementalDataConfigurationRequest.md) | :heavy_check_mark:                                                                                          | The request object to use for the request.                                                                  |

### Response

**[GetSupplementalDataConfigurationResponse](../../Models/Requests/GetSupplementalDataConfigurationResponse.md)**

### Errors

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |