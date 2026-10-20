# Sync for Payables

Streamline your customers' accounts payable workflow.

## Summary

Bill pay (synchronous solution): The API reference for the synchronous Bill Pay solution.

The synchronous Bill Pay solution is an API and a set of supporting tools designed to integrate a bill pay flow into your app as quickly as possible. It's ideal for facilitating essential bill payment processes within your SMB's accounting software.

[Explore solution](https://docs.codat.io/payables/overview) | [See OpenAPI spec](https://github.com/codatio/oas)

## Supported Integrations

| Integration       | Supported |
|-------------------|-----------|
| FreeAgent         | Yes       |
| QuickBooks Online | Yes       |
| Oracle NetSuite   | Yes       |
| Sage Intacct      | Yes       |
| Xero              | Yes       |
| Zoho Books        | Yes       |

## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Company information | View company profile from the source platform. |
| Bills | Get, create, and update Bills. |
| Bill payments | Get, create, and update Bill payments. |
| Suppliers | Get, create, and update Suppliers. |
| Bank accounts | Create a bank account for a given company's connection. |

## Table of Contents

* [Summary](#summary)
* [Supported Integrations](#supported-integrations)
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
dotnet add package Codat.Sync.Payables
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/Sync/Payables/Codat.Sync.Payables.csproj
```

## SDK Example Usage

### Example

```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [Create](docs/sdks/bankaccounts/README.md#create) - Create bank account

### [BillPayments](docs/sdks/billpayments/README.md)

* [GetPaymentOptions](docs/sdks/billpayments/README.md#getpaymentoptions) - Get payment mapping options
* [Create](docs/sdks/billpayments/README.md#create) - Create bill payment

### [Bills](docs/sdks/bills/README.md)

* [GetBillOptions](docs/sdks/bills/README.md#getbilloptions) - Get bill mapping options
* [List](docs/sdks/bills/README.md#list) - List bills
* [Create](docs/sdks/bills/README.md#create) - Create bill
* [Update](docs/sdks/bills/README.md#update) - Update bill
* [UploadAttachment](docs/sdks/bills/README.md#uploadattachment) - Upload bill attachment
* [ListAttachments](docs/sdks/bills/README.md#listattachments) - List bill attachments
* [DownloadAttachment](docs/sdks/bills/README.md#downloadattachment) - Download bill attachment

### [Companies](docs/sdks/companies/README.md)

* [List](docs/sdks/companies/README.md#list) - List companies
* [Create](docs/sdks/companies/README.md#create) - Create company
* [Replace](docs/sdks/companies/README.md#replace) - Replace company
* [Update](docs/sdks/companies/README.md#update) - Update company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company

### [CompanyInformation](docs/sdks/companyinformation/README.md)

* [Get](docs/sdks/companyinformation/README.md#get) - Get company information

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection

### [Suppliers](docs/sdks/suppliers/README.md)

* [List](docs/sdks/suppliers/README.md#list) - List suppliers
* [Create](docs/sdks/suppliers/README.md#create) - Create supplier
* [Update](docs/sdks/suppliers/README.md#update) - Update supplier

</details>

## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(
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
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```

## Error Handling

[`CodatSyncPayablesException`](./Codat/Sync/Payables/Models/Errors/CodatSyncPayablesException.cs) is the base exception class for all HTTP error responses. It has the following properties:

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
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Errors;
using Codat.Sync.Payables.Models.Requests;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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
catch (CodatSyncPayablesException ex)  // all SDK exceptions inherit from CodatSyncPayablesException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpResponseMessage rawResponse = ex.RawResponse;
    HttpResponseHeaders headers = ex.Headers;
    int statusCode = ex.StatusCode;
    string? contentType = ex.ContentType;
    var responseBody = ex.Body;

    if (ex is Codat.Sync.Payables.Models.Errors.ErrorMessage errorMessage) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        Codat.Sync.Payables.Models.Errors.ErrorMessagePayload payload = errorMessage.Payload;
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
* [`CodatSyncPayablesException`](./Codat/Sync/Payables/Models/Errors/CodatSyncPayablesException.cs): The base class for HTTP error responses.
  * [`ErrorMessage`](./Codat/Sync/Payables/Models/Errors/ErrorMessage.cs): A Codat API error response. Its structured fields are on `Payload`.

<details><summary>Less common exceptions (3)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`CodatSyncPayablesException`](./Codat/Sync/Payables/Models/Errors/CodatSyncPayablesException.cs):
  * [`SDKException`](./Codat/Sync/Payables/Models/Errors/SDKException.cs): The fallback exception if no more specific exception is matched.
  * [`ResponseValidationException`](./Codat/Sync/Payables/Models/Errors/ResponseValidationException.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

## Retries

Every operation in this SDK retries failed requests with a default backoff strategy. By default it retries connection errors and responses with status 408, 429 or 5XX, starting at 500 ms and backing off by a factor of 1.5 up to 60 s between attempts, for at most an hour. You can override the retry strategy for a single call, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Utils.Retries;

var sdk = new CodatSyncPayables(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Utils.Retries;

var sdk = new CodatSyncPayables(
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
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatSyncPayables(
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
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatSyncPayables(
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
using Codat.Sync.Payables;
using Codat.Sync.Payables.Models.Components;
using Codat.Sync.Payables.Models.Requests;
using Codat.Sync.Payables.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatSyncPayables(
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

The SDK also runs hooks before each request and after each response or error. Register your own on `sdk.SDKConfiguration.Hooks` with `RegisterBeforeRequestHook`, `RegisterAfterSuccessHook` or `RegisterAfterErrorHook`, passing an implementation of the matching interface from `Codat.Sync.Payables.Hooks`.

## Support

If you encounter any challenges while utilizing our SDKs, please don't hesitate to reach out for assistance.
You can raise any issues by contacting your dedicated Codat representative or reaching out to our [support team](mailto:support@codat.io).
We're here to help ensure a smooth experience for you.
