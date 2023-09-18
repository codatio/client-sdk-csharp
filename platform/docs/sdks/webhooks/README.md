# Webhooks

## Overview

Manage webhooks, rules, and events.

### Available Operations

* [Create](#create) - Create webhook
* [Get](#get) - Get webhook
* [List](#list) - List webhooks

## Create

Create a new webhook configuration

### Example Usage

```csharp
using CodatPlatform;
using CodatPlatform.Models.Shared;

var sdk = new CodatPlatformSDK(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Webhooks.CreateAsync(new CreateRule() {
    CompanyId = "39b73b17-cc2e-429e-915d-71654e9dcd1e",
    Notifiers = new CreateRuleNotifiers() {
        Emails = new List<string>() {
            "info@client.com",
        },
        Webhook = "https://webhook.client.com",
    },
    Type = "iste",
});

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `request`                                       | [CreateRule](../../models/shared/CreateRule.md) | :heavy_check_mark:                              | The request object to use for the request.      |


### Response

**[CreateRuleResponse](../../models/operations/CreateRuleResponse.md)**


## Get

Get a single webhook

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

var res = await sdk.Webhooks.GetAsync(new GetWebhookRequest() {
    RuleId = "7318949f-c008-4936-a8ff-10d7ab563fa6",
});

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetWebhookRequest](../../models/operations/GetWebhookRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetWebhookResponse](../../models/operations/GetWebhookResponse.md)**


## List

List webhooks that you are subscribed to.

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

var res = await sdk.Webhooks.ListAsync(new ListRulesRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "iure",
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListRulesRequest](../../models/operations/ListRulesRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListRulesResponse](../../models/operations/ListRulesResponse.md)**

