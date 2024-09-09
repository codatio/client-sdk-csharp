# Webhooks
(*Webhooks*)

## Overview

Create and manage webhooks that listen to Codat's events.

### Available Operations

* [~~Create~~](#create) - Create webhook :warning: **Deprecated**
* [CreateConsumer](#createconsumer) - Create webhook consumer
* [DeleteConsumer](#deleteconsumer) - Delete webhook consumer
* [~~Get~~](#get) - Get webhook :warning: **Deprecated**
* [~~List~~](#list) - List webhooks :warning: **Deprecated**
* [ListConsumers](#listconsumers) - List webhook consumers

## ~~Create~~

Create a new webhook configuration

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CreateRule req = new CreateRule() {
    CompanyId = "39b73b17-cc2e-429e-915d-71654e9dcd1e",
    Notifiers = new WebhookNotifier() {
        Emails = new List<string>() {
            "info@client.com",
        },
        Webhook = "https://webhook.client.com",
    },
    Type = "DataConnectionStatusChanged",
};

var res = await sdk.Webhooks.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                       | Type                                            | Required                                        | Description                                     |
| ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- | ----------------------------------------------- |
| `request`                                       | [CreateRule](../../Models/Shared/CreateRule.md) | :heavy_check_mark:                              | The request object to use for the request.      |

### Response

**[CreateRuleResponse](../../Models/Operations/CreateRuleResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## CreateConsumer

﻿Use the *Create webhook consumer* endpoint to create a new webhook consumer that will listen to messages we send you.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Tips and traps
- The number of webhook consumers you can create is limited to 50. If you have reached the maximum number of consumers, use the [*Delete webhook consumer*](https://docs.codat.io/platform-api#/operations/delete-webhook-consumer) endpoint to delete an unused consumer first.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using System.Collections.Generic;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

WebhookConsumerPrototype req = new WebhookConsumerPrototype() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Webhooks.CreateConsumerAsync(req);

// handle response
```

### Parameters

| Parameter                                                                   | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `request`                                                                   | [WebhookConsumerPrototype](../../Models/Shared/WebhookConsumerPrototype.md) | :heavy_check_mark:                                                          | The request object to use for the request.                                  |

### Response

**[CreateWebhookConsumerResponse](../../Models/Operations/CreateWebhookConsumerResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## DeleteConsumer

﻿Use the *Delete webhook consumer* endpoint to delete an existing webhoook consumer, providing its valid `id` as a parameter.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

DeleteWebhookConsumerRequest req = new DeleteWebhookConsumerRequest() {
    WebhookId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Webhooks.DeleteConsumerAsync(req);

// handle response
```

### Parameters

| Parameter                                                                               | Type                                                                                    | Required                                                                                | Description                                                                             |
| --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- | --------------------------------------------------------------------------------------- |
| `request`                                                                               | [DeleteWebhookConsumerRequest](../../Models/Operations/DeleteWebhookConsumerRequest.md) | :heavy_check_mark:                                                                      | The request object to use for the request.                                              |

### Response

**[DeleteWebhookConsumerResponse](../../Models/Operations/DeleteWebhookConsumerResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ~~Get~~

Get a single webhook

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

GetWebhookRequest req = new GetWebhookRequest() {
    RuleId = "7318949f-c008-4936-a8ff-10d7ab563fa6",
};

var res = await sdk.Webhooks.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                         | Type                                                              | Required                                                          | Description                                                       |
| ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- | ----------------------------------------------------------------- |
| `request`                                                         | [GetWebhookRequest](../../Models/Operations/GetWebhookRequest.md) | :heavy_check_mark:                                                | The request object to use for the request.                        |

### Response

**[GetWebhookResponse](../../Models/Operations/GetWebhookResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ~~List~~

List webhooks that you are subscribed to.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Operations;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

ListRulesRequest req = new ListRulesRequest() {
    OrderBy = "-modifiedDate",
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
};

var res = await sdk.Webhooks.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [ListRulesRequest](../../Models/Operations/ListRulesRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[ListRulesResponse](../../Models/Operations/ListRulesResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503           | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ListConsumers

﻿Use the *List webhook consumers* endpoint to return a list of all webhook consumers that currently exist for your client.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

var res = await sdk.Webhooks.ListConsumersAsync();

// handle response
```

### Response

**[ListWebhookConsumersResponse](../../Models/Operations/ListWebhookConsumersResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
