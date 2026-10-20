# Bank Feeds

Bank Feeds solution enables your SMB users to set up bank feeds from accounts in your application to supported accounting software.

## Summary

Bank Feeds: Bank Feeds solution enables your SMB users to set up bank feeds from accounts in your application to supported accounting software.

A bank feed is a connection between a source bank account in your application and a target bank account in a supported accounting software.

[Explore solution](https://docs.codat.io/bank-feeds-api/overview) | [See OpenAPI spec](https://github.com/codatio/oas)

## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Source accounts | Provide and manage lists of source bank accounts. |
| Account mapping | Extra functionality for building an account management UI. |
| Company information | Get detailed information about a company from the underlying platform. |
| Transactions | Create new bank account transactions for a company's connections, and see previous operations. |

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
dotnet add package Codat.BankFeeds
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/BankFeeds/Codat.BankFeeds.csproj
```

## SDK Example Usage

### Example

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Technicalium",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```

## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [AccountMapping](docs/sdks/accountmapping/README.md)

* [Get](docs/sdks/accountmapping/README.md#get) - List bank feed accounts
* [Create](docs/sdks/accountmapping/README.md#create) - Create bank feed account mapping

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [List](docs/sdks/bankaccounts/README.md#list) - List bank accounts
* [GetCreateModel](docs/sdks/bankaccounts/README.md#getcreatemodel) - Get create/update bank account model
* [Create](docs/sdks/bankaccounts/README.md#create) - Create bank account

### [Companies](docs/sdks/companies/README.md)

* [Create](docs/sdks/companies/README.md#create) - Create company
* [List](docs/sdks/companies/README.md#list) - List companies
* [Get](docs/sdks/companies/README.md#get) - Get company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Replace](docs/sdks/companies/README.md#replace) - Replace company
* [Update](docs/sdks/companies/README.md#update) - Update company
* [GetAccessToken](docs/sdks/companies/README.md#getaccesstoken) - Get company access token

### [CompanyInformation](docs/sdks/companyinformation/README.md)

* [Get](docs/sdks/companyinformation/README.md#get) - Get company information

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection

### [ManagedBankFeeds](docs/sdks/managedbankfeeds/README.md)

* [GetSync](docs/sdks/managedbankfeeds/README.md#getsync) - Get sync
* [GetLatestSync](docs/sdks/managedbankfeeds/README.md#getlatestsync) - Get latest sync
* [RunAdHocSync](docs/sdks/managedbankfeeds/README.md#runadhocsync) - Run ad-hoc sync

### [SourceAccounts](docs/sdks/sourceaccounts/README.md)

* [CreateBatch](docs/sdks/sourceaccounts/README.md#createbatch) - Create source accounts
* [Create](docs/sdks/sourceaccounts/README.md#create) - Create single source account
* [List](docs/sdks/sourceaccounts/README.md#list) - List source accounts
* [Update](docs/sdks/sourceaccounts/README.md#update) - Update source account
* [Delete](docs/sdks/sourceaccounts/README.md#delete) - Delete source account
* [GenerateCredentials](docs/sdks/sourceaccounts/README.md#generatecredentials) - Generate source account credentials
* [DeleteCredentials](docs/sdks/sourceaccounts/README.md#deletecredentials) - Delete all source account credentials
* [GenerateOtp](docs/sdks/sourceaccounts/README.md#generateotp) - Generate one-time password

### [Transactions](docs/sdks/transactions/README.md)

* [Create](docs/sdks/transactions/README.md#create) - Create bank transactions
* [GetCreateModel](docs/sdks/transactions/README.md#getcreatemodel) - Get create bank transactions model
* [GetCreateOperation](docs/sdks/transactions/README.md#getcreateoperation) - Get create operation
* [ListCreateOperations](docs/sdks/transactions/README.md#listcreateoperations) - List create operations

</details>

## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(
    serverUrl: "https://api.codat.io",
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Technicalium",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```

## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type   | Scheme  |
| ------------ | ------ | ------- |
| `AuthHeader` | apiKey | API key |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Technicalium",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```

## Error Handling

[`CodatBankFeedsException`](./Codat/BankFeeds/Models/Errors/CodatBankFeedsException.cs) is the base exception class for all HTTP error responses. It has the following properties:

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
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Errors;
using Codat.BankFeeds.Models.Shared;
using System;
using System.Net.Http;
using System.Net.Http.Headers;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

try
{
    CompanyRequestBody req = new CompanyRequestBody() {
        Name = "Technicalium",
    };

    var res = await sdk.Companies.CreateAsync(req);

    // handle response
}
catch (CodatBankFeedsException ex)  // all SDK exceptions inherit from CodatBankFeedsException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpResponseMessage rawResponse = ex.RawResponse;
    HttpResponseHeaders headers = ex.Headers;
    int statusCode = ex.StatusCode;
    string? contentType = ex.ContentType;
    var responseBody = ex.Body;

    if (ex is Codat.BankFeeds.Models.Errors.ErrorMessage errorMessage) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        Codat.BankFeeds.Models.Errors.ErrorMessagePayload payload = errorMessage.Payload;
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
* [`CodatBankFeedsException`](./Codat/BankFeeds/Models/Errors/CodatBankFeedsException.cs): The base class for HTTP error responses.
  * [`ErrorMessage`](./Codat/BankFeeds/Models/Errors/ErrorMessage.cs): A Codat API error response. Its structured fields are on `Payload`.

<details><summary>Less common exceptions (3)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`CodatBankFeedsException`](./Codat/BankFeeds/Models/Errors/CodatBankFeedsException.cs):
  * [`SDKException`](./Codat/BankFeeds/Models/Errors/SDKException.cs): The fallback exception if no more specific exception is matched.
  * [`ResponseValidationException`](./Codat/BankFeeds/Models/Errors/ResponseValidationException.cs): Thrown when the response data could not be deserialized into the expected type.
</details>

## Retries

Every operation in this SDK retries failed requests with a default backoff strategy. By default it retries connection errors and responses with status 408, 429 or 5XX, starting at 500 ms and backing off by a factor of 1.5 up to 60 s between attempts, for at most an hour. You can override the retry strategy for a single call, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Utils.Retries;

var sdk = new CodatBankFeeds(security: new Security() {
    AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
});

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Technicalium",
};

var res = await sdk.Companies.CreateAsync(
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
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Utils.Retries;

var sdk = new CodatBankFeeds(
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
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
);

CompanyRequestBody req = new CompanyRequestBody() {
    Name = "Technicalium",
};

var res = await sdk.Companies.CreateAsync(req);

// handle response
```

## Custom HTTP Client

The C# SDK makes API calls through an `ICodatHttpClient`. The default implementation, `CodatHttpClient`, wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient).

You can extend `CodatHttpClient`, or provide your own `ICodatHttpClient` implementation with customized configuration
such as custom message handlers, timeouts, connection pooling, and other HTTP client settings.

The following example shows how to extend the default client to modify each request and handle errors:

```csharp
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatBankFeeds(
    client: new CustomHttpClient(),
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
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
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatBankFeeds(
    client: new AdvancedHttpClient(),
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
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
using Codat.BankFeeds;
using Codat.BankFeeds.Models.Shared;
using Codat.BankFeeds.Utils;
using System;
using System.Net.Http;
using System.Threading.Tasks;

var sdk = new CodatBankFeeds(
    client: new LoggingHttpClient(),
    security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    }
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

The SDK also runs hooks before each request and after each response or error. Register your own on `sdk.SDKConfiguration.Hooks` with `RegisterBeforeRequestHook`, `RegisterAfterSuccessHook` or `RegisterAfterErrorHook`, passing an implementation of the matching interface from `Codat.BankFeeds.Hooks`.

## Support

If you encounter any challenges while utilizing our SDKs, please don't hesitate to reach out for assistance.
You can raise any issues by contacting your dedicated Codat representative or reaching out to our [support team](mailto:support@codat.io).
We're here to help ensure a smooth experience for you.
