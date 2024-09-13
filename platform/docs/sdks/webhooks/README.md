# Webhooks
(*Webhooks*)

## Overview

Create and manage webhooks that listen to Codat's events.

### Available Operations

* [~~List~~](#list) - List webhooks :warning: **Deprecated**
* [~~Create~~](#create) - Create webhook :warning: **Deprecated**
* [~~Get~~](#get) - Get webhook :warning: **Deprecated**
* [ListConsumers](#listconsumers) - List webhook consumers
* [CreateConsumer](#createconsumer) - Create webhook consumer
* [DeleteConsumer](#deleteconsumer) - Delete webhook consumer

## ~~List~~

List webhooks that you are subscribed to.

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListRulesRequest req = new ListRulesRequest() {
    Page = 1,
    PageSize = 100,
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
};

var res = await sdk.Webhooks.ListAsync(req);

// handle response
```

### Parameters

| Parameter                                                     | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `request`                                                     | [ListRulesRequest](../../Models/Requests/ListRulesRequest.md) | :heavy_check_mark:                                            | The request object to use for the request.                    |

### Response

**[ListRulesResponse](../../Models/Requests/ListRulesResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,404,429,500,503           | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ~~Create~~

Create a new webhook configuration

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

CreateRule req = new CreateRule() {
    Type = "DataConnectionStatusChanged",
    CompanyId = "39b73b17-cc2e-429e-915d-71654e9dcd1e",
    Notifiers = new WebhookNotifier() {
        Emails = new List<string>() {
            "info@client.com",
        },
        Webhook = "https://webhook.client.com",
    },
};

var res = await sdk.Webhooks.CreateAsync(req);

// handle response
```

### Parameters

| Parameter                                           | Type                                                | Required                                            | Description                                         |
| --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- | --------------------------------------------------- |
| `request`                                           | [CreateRule](../../Models/Components/CreateRule.md) | :heavy_check_mark:                                  | The request object to use for the request.          |

### Response

**[CreateRuleResponse](../../Models/Requests/CreateRuleResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,429,500,503                   | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ~~Get~~

Get a single webhook

> :warning: **DEPRECATED**: This will be removed in a future release, please migrate away from it as soon as possible.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetWebhookRequest req = new GetWebhookRequest() {
    RuleId = "7318949f-c008-4936-a8ff-10d7ab563fa6",
};

var res = await sdk.Webhooks.GetAsync(req);

// handle response
```

### Parameters

| Parameter                                                       | Type                                                            | Required                                                        | Description                                                     |
| --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- | --------------------------------------------------------------- |
| `request`                                                       | [GetWebhookRequest](../../Models/Requests/GetWebhookRequest.md) | :heavy_check_mark:                                              | The request object to use for the request.                      |

### Response

**[GetWebhookResponse](../../Models/Requests/GetWebhookResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## ListConsumers

﻿Use the *List webhook consumers* endpoint to return a list of all webhook consumers that currently exist for your client.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

var res = await sdk.Webhooks.ListConsumersAsync();

// handle response
```

### Response

**[ListWebhookConsumersResponse](../../Models/Requests/ListWebhookConsumersResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |


## CreateConsumer

﻿Use the *Create webhook consumer* endpoint to create a new webhook consumer that will listen to messages we send you.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Tips and traps
- The number of webhook consumers you can create is limited to 50. If you have reached the maximum number of consumers, use the [*Delete webhook consumer*](https://docs.codat.io/platform-api#/operations/delete-webhook-consumer) endpoint to delete an unused consumer first.

### Example Usage

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

WebhookConsumerPrototype req = new WebhookConsumerPrototype() {
    CompanyId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Webhooks.CreateConsumerAsync(req);

// handle response
```

### Parameters

| Parameter                                                                       | Type                                                                            | Required                                                                        | Description                                                                     |
| ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- | ------------------------------------------------------------------------------- |
| `request`                                                                       | [WebhookConsumerPrototype](../../Models/Components/WebhookConsumerPrototype.md) | :heavy_check_mark:                                                              | The request object to use for the request.                                      |

### Response

**[CreateWebhookConsumerResponse](../../Models/Requests/CreateWebhookConsumerResponse.md)**

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
using Codat.Platform.Models.Requests;
using Codat.Platform.Models.Components;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

DeleteWebhookConsumerRequest req = new DeleteWebhookConsumerRequest() {
    WebhookId = "8a210b68-6988-11ed-a1eb-0242ac120002",
};

var res = await sdk.Webhooks.DeleteConsumerAsync(req);

// handle response
```

### Parameters

| Parameter                                                                             | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `request`                                                                             | [DeleteWebhookConsumerRequest](../../Models/Requests/DeleteWebhookConsumerRequest.md) | :heavy_check_mark:                                                                    | The request object to use for the request.                                            |

### Response

**[DeleteWebhookConsumerResponse](../../Models/Requests/DeleteWebhookConsumerResponse.md)**

### Errors

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401,402,403,404,429,500,503               | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |
