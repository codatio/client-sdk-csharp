# Webhooks
(*Webhooks*)

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
using Codat.Platform;
using Codat.Platform.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Webhooks.CreateAsync(new CreateRule() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
    Notifiers = new WebhookNotifier() {
        Emails = new List<string>() {
            "i",
            "n",
            "f",
            "o",
            "@",
            "c",
            "l",
            "i",
            "e",
            "n",
            "t",
            ".",
            "c",
            "o",
            "m",
        },
        Webhook = "https://webhook.client.com",
    },
    Type = "string",
});

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `request`                                       | [CreateRule](../../Models/Shared/CreateRule.md) | :heavy_check_mark:                              | The request object to use for the request.      |


### Response

**[CreateRuleResponse](../../Models/Operations/CreateRuleResponse.md)**


## Get

Get a single webhook

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(
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
| `request`                                                         | [GetWebhookRequest](../../Models/Operations/GetWebhookRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |


### Response

**[GetWebhookResponse](../../Models/Operations/GetWebhookResponse.md)**


## List

List webhooks that you are subscribed to.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using Codat.Platform.Models.Operations;

var sdk = new CodatPlatform(
    security: new Security() {
        AuthHeader = "",
    }
);

var res = await sdk.Webhooks.ListAsync(new ListRulesRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
});

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListRulesRequest](../../Models/Operations/ListRulesRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |


### Response

**[ListRulesResponse](../../Models/Operations/ListRulesResponse.md)**

