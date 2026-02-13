# Webhooks

## Overview

Create and manage webhooks that listen to Codat's events.

### Available Operations

* [ListConsumers](#listconsumers) - List webhook consumers
* [CreateConsumer](#createconsumer) - Create webhook consumer
* [DeleteConsumer](#deleteconsumer) - Delete webhook consumer

## ListConsumers

﻿Use the *List webhook consumers* endpoint to return a list of all webhook consumers that currently exist for your client.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="list-webhook-consumers" method="get" path="/webhooks" example="Webhook consumers" -->
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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## CreateConsumer

﻿Use the *Create webhook consumer* endpoint to create a new webhook consumer that will listen to messages we send you.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Tips and traps
- The number of webhook consumers you can create is limited to 50. If you have reached the maximum number of consumers, use the [*Delete webhook consumer*](https://docs.codat.io/platform-api#/operations/delete-webhook-consumer) endpoint to delete an unused consumer first.

### Example Usage: Subscribe consumer to one or more event types

<!-- UsageSnippet language="csharp" operationID="create-webhook-consumer" method="post" path="/webhooks" example="Subscribe consumer to one or more event types" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

WebhookConsumerPrototype req = new WebhookConsumerPrototype() {
    Url = "https://example.com/webhoook-consumer",
    EventTypes = new List<string>() {
        "DataSyncCompleted",
        "Dataset data changed",
    },
};

var res = await sdk.Webhooks.CreateConsumerAsync(req);

// handle response
```
### Example Usage: Subscribe consumer with disabled endpoint

<!-- UsageSnippet language="csharp" operationID="create-webhook-consumer" method="post" path="/webhooks" example="Subscribe consumer with disabled endpoint" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using System.Collections.Generic;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

WebhookConsumerPrototype req = new WebhookConsumerPrototype() {
    Url = "https://example.com/webhoook-consumer",
    Disabled = true,
    EventTypes = new List<string>() {
        "DataSyncCompleted",
    },
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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400, 401, 402, 403, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |

## DeleteConsumer

﻿Use the *Delete webhook consumer* endpoint to delete an existing webhoook consumer, providing its valid `id` as a parameter.

[Webhook consumer](https://docs.codat.io/platform-api#/schemas/WebhookConsumer) is an HTTP endpoint that you configure to subscribe to specific events. See our documentation for more details on [Codat's webhook service](https://docs.codat.io/using-the-api/webhooks/overview).

### Example Usage

<!-- UsageSnippet language="csharp" operationID="delete-webhook-consumer" method="delete" path="/webhooks/{webhookId}" -->
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

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

| Error Type                                | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 401, 402, 403, 404, 429                   | application/json                          |
| Codat.Platform.Models.Errors.ErrorMessage | 500, 503                                  | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4XX, 5XX                                  | \*/\*                                     |