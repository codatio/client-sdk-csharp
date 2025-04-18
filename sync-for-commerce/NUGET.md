# Codat.Sync.Commerce


<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    CommerceKey = "<value>",
    AccountingKey = "<value>",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    CommerceKey = "<value>",
    AccountingKey = "<value>",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    req
);

// handle response
```

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(
    retryConfig: new RetryConfig(
        strategy: RetryConfig.RetryStrategy.BACKOFF,
        backoff: new BackoffStrategy(
            initialIntervalMs: 1L,
            maxIntervalMs: 50L,
            maxElapsedTimeMs: 100L,
            exponent: 1.1
        ),
        retryConnectionErrors: false
    ),
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    CommerceKey = "<value>",
    AccountingKey = "<value>",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

// handle response
```
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations. All operations return a response object or throw an exception.

By default, an API error will raise a `Codat.Sync.Commerce.Models.Errors.SDKException` exception, which has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | The error message     |
| `StatusCode`  | *int*                 | The HTTP status code  |
| `RawResponse` | *HttpResponseMessage* | The raw HTTP response |
| `Body`        | *string*              | The response content  |

When custom error responses are specified for an operation, the SDK may also throw their associated exceptions. You can refer to respective *Errors* tables in SDK docs for more details on possible exception types for each operation. For example, the `GetSyncFlowUrlAsync` method throws the following exceptions:

| Error Type                                     | Status Code                            | Content Type     |
| ---------------------------------------------- | -------------------------------------- | ---------------- |
| Codat.Sync.Commerce.Models.Errors.ErrorMessage | 400, 401, 402, 403, 404, 429, 500, 503 | application/json |
| Codat.Sync.Commerce.Models.Errors.SDKException | 4XX, 5XX                               | \*/\*            |

### Example

```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;
using System;
using Codat.Sync.Commerce.Models.Errors;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

try
{
    GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
        CommerceKey = "<value>",
        AccountingKey = "<value>",
    };

    var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorMessage)
    {
        // Handle exception data
        throw;
    }
    else if (ex is Codat.Sync.Commerce.Models.Errors.SDKException)
    {
        // Handle default exception
        throw;
    }
}
```
<!-- End Error Handling [errors] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(
    serverUrl: "https://api.codat.io",
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    CommerceKey = "<value>",
    AccountingKey = "<value>",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

// handle response
```
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type   | Scheme  |
| ------------ | ------ | ------- |
| `AuthHeader` | apiKey | API key |

To authenticate with the API the `AuthHeader` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Codat.Sync.Commerce;
using Codat.Sync.Commerce.Models.Requests;
using Codat.Sync.Commerce.Models.Components;

var sdk = new CodatSyncCommerce(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

GetSyncFlowUrlRequest req = new GetSyncFlowUrlRequest() {
    CommerceKey = "<value>",
    AccountingKey = "<value>",
};

var res = await sdk.Connections.GetSyncFlowUrlAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->