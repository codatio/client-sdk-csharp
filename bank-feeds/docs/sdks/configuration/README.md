# Configuration
(*Configuration*)

## Overview

Configure bank feeds for a company.

### Available Operations

* [Get](#get) - Get configuration
* [SetConfiguration](#setconfiguration) - Set configuration

## Get

﻿The *Get configuration* endpoint returns the current configuration for a given company ID.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

GetConfigurationRequest req = new GetConfigurationRequest() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Configuration.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [GetConfigurationRequest](../../Models/Operations/GetConfigurationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[GetConfigurationResponse](../../Models/Operations/GetConfigurationResponse.md)**


## SetConfiguration

﻿Use *Set configuration* endpoint to configure a given company ID.

### Example Usage

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Models.Operations;
using System.Collections.Generic;

var sdk = new CodatBankFeeds(
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

SetConfigurationRequest req = new SetConfigurationRequest() {
    Configuration = new Models.Shared.Configuration() {
        CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
        Configuration = new SyncConfiguration() {
            SyncAsBankFeeds = new SyncAsBankFeeds() {
                BankAccountOptions = new List<BankAccountOption>() {
                    new BankAccountOption() {},
                },
            },
            SyncAsExpenses = new SyncAsExpenses() {
                BankAccountOptions = new List<BankAccountOption>() {
                    new BankAccountOption() {},
                },
                Customer = new ConfigurationCustomer() {
                    CustomerOptions = new List<ConfigurationContactRef>() {
                        new ConfigurationContactRef() {},
                    },
                },
                Supplier = new ConfigurationSupplier() {
                    SupplierOptions = new List<ConfigurationContactRef>() {
                        new ConfigurationContactRef() {},
                    },
                },
            },
        },
        Schedule = new ConfigurationSchedule() {
            FrequencyOptions = new List<string>() {
                "string",
            },
        },
    },
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Configuration.SetConfigurationAsync(req);

// handle response
```

### Parameters

| Parameter                                                                     | Type                                                                          | Required                                                                      | Description                                                                   |
| ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- | ----------------------------------------------------------------------------- |
| `request`                                                                     | [SetConfigurationRequest](../../Models/Operations/SetConfigurationRequest.md) | :heavy_check_mark:                                                            | The request object to use for the request.                                    |


### Response

**[SetConfigurationResponse](../../Models/Operations/SetConfigurationResponse.md)**

