# Codat.Lending

Lending helps you make smarter credit decisions on small businesses by enabling you to pull your customers' latest data from the operating systems they are already using. You can use that data for automating decisioning and surfacing new insights on the customer, all via one API.

## SDK Example Usage

### Example

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(
    serverUrl: "https://api.codat.io",
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type   | Scheme  |
| ------------ | ------ | ------- |
| `AuthHeader` | apiKey | API key |

To authenticate with the API the `authHeader` parameter must be set when initializing the SDK client instance. For example:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

## Error Handling

[`CodatLendingException`](https://github.com/codatio/client-sdk-csharp/blob/main/lending/Codat/Lending/Models/Errors/CodatLendingException.cs) is the base exception class for all HTTP error responses. It has the following properties:

| Property      | Type                  | Description           |
|---------------|-----------------------|-----------------------|
| `Message`     | *string*              | Error message         |
| `StatusCode`  | *int*                 | HTTP status code      |
| `Headers`     | *HttpResponseHeaders* | HTTP headers          |
| `ContentType` | *string?*             | HTTP content type     |
| `RawResponse` | *HttpResponseMessage* | HTTP response object  |
| `Body`        | *string*              | HTTP response body    |

Some exceptions in this SDK include an additional `Payload` field, which will contain deserialized custom error data when present. Possible exceptions are listed in the [Error Classes](#error-classes) section.

### Example

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Errors;
using Codat.Lending.Models.Requests;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

try
{
    ListCompaniesRequest req = new ListCompaniesRequest() {
        Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
        OrderBy = "-modifiedDate",
        Tags = "region=uk && team=invoice-finance",
    };

    var res = await sdk.Companies.ListAsync(req);

    // handle response
}
catch (CodatLendingException ex)  // all SDK exceptions inherit from CodatLendingException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpResponseMessage rawResponse = ex.RawResponse;
    HttpResponseHeaders headers = ex.Headers;
    int statusCode = ex.StatusCode;
    string? contentType = ex.ContentType;
    var responseBody = ex.Body;

    if (ex is Codat.Lending.Models.Errors.ErrorMessage errorMessage) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        Codat.Lending.Models.Errors.ErrorMessagePayload payload = errorMessage.Payload;
        var errorStatusCode = payload.StatusCode;
        var service = payload.Service;
        // ...
    }

    // An underlying cause may be provided
    if (ex.InnerException != null)
    {
        Exception cause = ex.InnerException;
    }
}
catch (System.Net.Http.HttpRequestException ex)
{
    // Check ex.InnerException for network connectivity errors
    System.Console.WriteLine(ex.InnerException);
}
```

### Error Classes

**Primary exceptions:**
* [`CodatLendingException`](https://github.com/codatio/client-sdk-csharp/blob/main/lending/Codat/Lending/Models/Errors/CodatLendingException.cs): The base class for HTTP error responses.
  * [`ErrorMessage`](https://github.com/codatio/client-sdk-csharp/blob/main/lending/Codat/Lending/Models/Errors/ErrorMessage.cs): A Codat API error response. Its structured fields are on `Payload`.

**Less common exceptions (3)**

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`CodatLendingException`](https://github.com/codatio/client-sdk-csharp/blob/main/lending/Codat/Lending/Models/Errors/CodatLendingException.cs):
  * [`SDKException`](https://github.com/codatio/client-sdk-csharp/blob/main/lending/Codat/Lending/Models/Errors/SDKException.cs): The fallback exception if no more specific exception is matched.
  * [`ResponseValidationException`](https://github.com/codatio/client-sdk-csharp/blob/main/lending/Codat/Lending/Models/Errors/ResponseValidationException.cs): Thrown when the response data could not be deserialized into the expected type.

## Retries

Every operation in this SDK retries failed requests with a default backoff strategy. By default it retries connection errors and responses with status 408, 429 or 5XX, starting at 500 ms and backing off by a factor of 1.5 up to 60 s between attempts, for at most an hour. You can override the retry strategy for a single call, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using Codat.Lending.Utils.Retries;

var sdk = new CodatLending(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(
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
    request: req
);

// handle response
```

If you'd like to override the default retry strategy for all operations, you can use the `RetryConfig` optional parameter when initializing the SDK:
```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using Codat.Lending.Utils.Retries;

var sdk = new CodatLending(
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

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

## Custom HTTP Client

The C# SDK makes API calls through an `ICodatHttpClient`. The default implementation, `CodatHttpClient`, wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient).

You can extend `CodatHttpClient`, or provide your own `ICodatHttpClient` implementation with customized configuration
such as custom message handlers, timeouts, connection pooling, and other HTTP client settings.

The following example shows how to extend the default client to modify each request and handle errors:

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using Codat.Lending.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatLending(
    client: new CustomHttpClient(),
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

public class CustomHttpClient : CodatHttpClient
{
    public override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        request.Headers.Add("x-custom-header", "custom value");

        try
        {
            var response = await base.SendAsync(request);
            Console.WriteLine($"Request successful: {response.StatusCode}");
            return response;
        }
        catch (Exception error)
        {
            Console.WriteLine($"Request failed: {error.Message}");
            throw;
        }
    }
}
```

**You can also provide a completely custom HTTP client with your own configuration:**

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using Codat.Lending.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatLending(
    client: new AdvancedHttpClient(),
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

public class AdvancedHttpClient : ICodatHttpClient
{
    private readonly HttpClient _httpClient;
    private readonly CodatHttpClient _defaultClient = new CodatHttpClient();

    public AdvancedHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            MaxConnectionsPerServer = 10,
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        return await _httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);
    }

    public Task<HttpRequestMessage> CloneAsync(HttpRequestMessage request)
    {
        return _defaultClient.CloneAsync(request);
    }
}
```

**For simple debugging, you can enable request/response logging by wrapping another client:**

```csharp
using Codat.Lending;
using Codat.Lending.Models.Components;
using Codat.Lending.Models.Requests;
using Codat.Lending.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatLending(
    client: new LoggingHttpClient(),
    authHeader: "Basic BASE_64_ENCODED(API_KEY)"
);

public class LoggingHttpClient : ICodatHttpClient
{
    private readonly ICodatHttpClient _innerClient;

    public LoggingHttpClient(ICodatHttpClient? innerClient = null)
    {
        _innerClient = innerClient ?? new CodatHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request)
    {
        Console.WriteLine($"Sending {request.Method} request to {request.RequestUri}");

        var response = await _innerClient.SendAsync(request);

        Console.WriteLine($"Received {response.StatusCode} response");

        return response;
    }

    public Task<HttpRequestMessage> CloneAsync(HttpRequestMessage request)
    {
        return _innerClient.CloneAsync(request);
    }
}
```

The SDK also runs hooks before each request and after each response or error. Register your own on `sdk.SDKConfiguration.Hooks` with `RegisterBeforeRequestHook`, `RegisterAfterSuccessHook` or `RegisterAfterErrorHook`, passing an implementation of the matching interface from `Codat.Lending.Hooks`.

## Support

If you encounter any challenges while utilizing our SDKs, please don't hesitate to reach out for assistance.
You can raise any issues by contacting your dedicated Codat representative or reaching out to our [support team](mailto:support@codat.io).
We're here to help ensure a smooth experience for you.
