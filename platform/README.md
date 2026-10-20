# Platform

Manage the building blocks of Codat, including companies, connections, and more.

## Summary

Platform API: An API for the common components of all of Codat's products.

These end points cover creating and managing your companies, data connections, and integrations.

[Explore solution](https://docs.codat.io/core-concepts/companies) | [See OpenAPI spec](https://github.com/codatio/oas)

## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Connection management | Configure connection management UI and retrieve access tokens for authentication. |
| Webhooks | Create and manage webhooks that listen to Codat's events. |
| Integrations | Get a list of integrations supported by Codat and their logos. |
| Refresh data | Initiate data refreshes, view pull status and history. |
| Settings | Manage company profile configuration, sync settings, and API keys. |
| Push data | Initiate and monitor Create, Update, and Delete operations. |
| Supplemental data | Configure and pull additional data you can include in Codat's standard data types. |
| Custom data type | Configure and pull additional data types that are not included in Codat's standardized data model. |

## Table of Contents

* [Summary](#summary)
* [Endpoints](#endpoints)
* [SDK Installation](#sdk-installation)
* [SDK Example Usage](#sdk-example-usage)
* [Available Resources and Operations](#available-resources-and-operations)
* [Server Selection](#server-selection)
* [Authentication](#authentication)
* [Error Handling](#error-handling)
* [Retries](#retries)
* [Custom HTTP Client](#custom-http-client)
* [Support](#support)

## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package Codat.Platform
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/Platform/Codat.Platform.csproj
```

## SDK Example Usage

### Example

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Companies](docs/sdks/companies/README.md)

* [List](docs/sdks/companies/README.md#list) - List companies
* [Create](docs/sdks/companies/README.md#create) - Create company
* [Get](docs/sdks/companies/README.md#get) - Get company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Replace](docs/sdks/companies/README.md#replace) - Replace company
* [Update](docs/sdks/companies/README.md#update) - Update company
* [AddProduct](docs/sdks/companies/README.md#addproduct) - Add product
* [RemoveProduct](docs/sdks/companies/README.md#removeproduct) - Remove product
* [RefreshProductData](docs/sdks/companies/README.md#refreshproductdata) - Refresh product data
* [GetAccessToken](docs/sdks/companies/README.md#getaccesstoken) - Get company access token
* [GetCompanySyncSettings](docs/sdks/companies/README.md#getcompanysyncsettings) - Get company sync settings
* [SetCompanySyncSettings](docs/sdks/companies/README.md#setcompanysyncsettings) - Set company sync settings

### [~~ConnectionManagement~~](docs/sdks/connectionmanagement/README.md)

* [~~Get~~](docs/sdks/connectionmanagement/README.md#get) - Get access token (old) :warning: **Deprecated** Use [GetAccessToken](docs/sdks/companies/README.md#getaccesstoken) instead.

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection
* [UpdateAuthorization](docs/sdks/connections/README.md#updateauthorization) - Update authorization

### [~~Cors~~](docs/sdks/cors/README.md)

* [~~Get~~](docs/sdks/cors/README.md#get) - Get CORS settings (old) :warning: **Deprecated** Use [Get](docs/sdks/settings/README.md#get) instead.
* [~~Set~~](docs/sdks/cors/README.md#set) - Set CORS settings (old) :warning: **Deprecated** Use [Set](docs/sdks/settings/README.md#set) instead.

### [CustomDataType](docs/sdks/customdatatype/README.md)

* [Configure](docs/sdks/customdatatype/README.md#configure) - Configure custom data type
* [GetConfiguration](docs/sdks/customdatatype/README.md#getconfiguration) - Get custom data configuration
* [Refresh](docs/sdks/customdatatype/README.md#refresh) - Refresh custom data type
* [List](docs/sdks/customdatatype/README.md#list) - List custom data type records

### [Integrations](docs/sdks/integrations/README.md)

* [List](docs/sdks/integrations/README.md#list) - List integrations
* [Get](docs/sdks/integrations/README.md#get) - Get integration
* [GetBranding](docs/sdks/integrations/README.md#getbranding) - Get branding

### [PushData](docs/sdks/pushdata/README.md)

* [GetModelOptions](docs/sdks/pushdata/README.md#getmodeloptions) - Get push options
* [ListOperations](docs/sdks/pushdata/README.md#listoperations) - List push operations
* [GetOperation](docs/sdks/pushdata/README.md#getoperation) - Get push operation

### [ReadData](docs/sdks/readdata/README.md)

* [GetValidationResults](docs/sdks/readdata/README.md#getvalidationresults) - Get validation results

### [RefreshData](docs/sdks/refreshdata/README.md)

* [All](docs/sdks/refreshdata/README.md#all) - Refresh all data
* [ByDataType](docs/sdks/refreshdata/README.md#bydatatype) - Refresh data type
* [Get](docs/sdks/refreshdata/README.md#get) - Get data status
* [ListPullOperations](docs/sdks/refreshdata/README.md#listpulloperations) - List pull operations
* [GetPullOperation](docs/sdks/refreshdata/README.md#getpulloperation) - Get pull operation

### [Settings](docs/sdks/settings/README.md)

* [Get](docs/sdks/settings/README.md#get) - Get CORS settings
* [Set](docs/sdks/settings/README.md#set) - Set CORS settings
* [GetProfile](docs/sdks/settings/README.md#getprofile) - Get profile
* [UpdateProfile](docs/sdks/settings/README.md#updateprofile) - Update profile
* [GetSyncSettings](docs/sdks/settings/README.md#getsyncsettings) - Get sync settings
* [UpdateSyncSettings](docs/sdks/settings/README.md#updatesyncsettings) - Update all sync settings
* [ListApiKeys](docs/sdks/settings/README.md#listapikeys) - List API keys
* [CreateApiKey](docs/sdks/settings/README.md#createapikey) - Create API key
* [DeleteApiKey](docs/sdks/settings/README.md#deleteapikey) - Delete API key

### [SupplementalData](docs/sdks/supplementaldata/README.md)

* [Configure](docs/sdks/supplementaldata/README.md#configure) - Configure
* [GetConfiguration](docs/sdks/supplementaldata/README.md#getconfiguration) - Get configuration

### [Webhooks](docs/sdks/webhooks/README.md)

* [ListConsumers](docs/sdks/webhooks/README.md#listconsumers) - List webhook consumers
* [CreateConsumer](docs/sdks/webhooks/README.md#createconsumer) - Create webhook consumer
* [DeleteConsumer](docs/sdks/webhooks/README.md#deleteconsumer) - Delete webhook consumer

</details>

## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(
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
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

## Error Handling

[`CodatPlatformException`](./Codat/Platform/Models/Errors/CodatPlatformException.cs) is the base exception class for all HTTP error responses. It has the following properties:

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
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Errors;
using Codat.Platform.Models.Requests;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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
catch (CodatPlatformException ex)  // all SDK exceptions inherit from CodatPlatformException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpResponseMessage rawResponse = ex.RawResponse;
    HttpResponseHeaders headers = ex.Headers;
    int statusCode = ex.StatusCode;
    string? contentType = ex.ContentType;
    var responseBody = ex.Body;

    if (ex is Codat.Platform.Models.Errors.ErrorMessage errorMessage) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        Codat.Platform.Models.Errors.ErrorMessagePayload payload = errorMessage.Payload;
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
* [`CodatPlatformException`](./Codat/Platform/Models/Errors/CodatPlatformException.cs): The base class for HTTP error responses.
  * [`ErrorMessage`](./Codat/Platform/Models/Errors/ErrorMessage.cs): A Codat API error response. Its structured fields are on `Payload`.

<details><summary>Less common exceptions (3)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`CodatPlatformException`](./Codat/Platform/Models/Errors/CodatPlatformException.cs):
  * [`SDKException`](./Codat/Platform/Models/Errors/SDKException.cs): The fallback exception if no more specific exception is matched.
  * [`ResponseValidationException`](./Codat/Platform/Models/Errors/ResponseValidationException.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

## Retries

Every operation in this SDK retries failed requests with a default backoff strategy. By default it retries connection errors and responses with status 408, 429 or 5XX, starting at 500 ms and backing off by a factor of 1.5 up to 60 s between attempts, for at most an hour. You can override the retry strategy for a single call, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;
using Codat.Platform.Utils.Retries;

var sdk = new CodatPlatform(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;
using Codat.Platform.Utils.Retries;

var sdk = new CodatPlatform(
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
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;
using Codat.Platform.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatPlatform(
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

<details>
<summary>You can also provide a completely custom HTTP client with your own configuration:</summary>

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;
using Codat.Platform.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatPlatform(
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
</details>

<details>
<summary>For simple debugging, you can enable request/response logging by wrapping another client:</summary>

```csharp
using Codat.Platform;
using Codat.Platform.Models.Components;
using Codat.Platform.Models.Requests;
using Codat.Platform.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatPlatform(
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
</details>

The SDK also runs hooks before each request and after each response or error. Register your own on `sdk.SDKConfiguration.Hooks` with `RegisterBeforeRequestHook`, `RegisterAfterSuccessHook` or `RegisterAfterErrorHook`, passing an implementation of the matching interface from `Codat.Platform.Hooks`.

## Support

If you encounter any challenges while utilizing our SDKs, please don't hesitate to reach out for assistance.
You can raise any issues by contacting your dedicated Codat representative or reaching out to our [support team](mailto:support@codat.io).
We're here to help ensure a smooth experience for you.
