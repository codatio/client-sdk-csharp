# Sync for Expenses
    
<!-- Start Codat Library Description -->
﻿Embedded accounting integrations for corporate card providers.
<!-- End Codat Library Description -->

<!-- Start Summary [summary] -->
## Summary

Expenses: The API for Codat's Expenses solution.

Expenses is an API and a set of supporting tools. It has been built to
enable corporate card and expense management platforms to provide high-quality
integrations with multiple accounting software through a standardized API.

[Explore solution](https://docs.codat.io/sync-for-expenses/overview) | [See our OpenAPI spec](https://github.com/codatio/oas)

Not seeing the endpoints you're expecting? We've [reorganized our solutions](https://docs.codat.io/updates/230901-new-products), and you may be using a [different version of Expenses](https://docs.codat.io/sync-for-expenses-v1-api#/).

---
<!-- Start Codat Tags Table -->
## Endpoints

| Endpoints | Description |
| :- |:- |
| Companies | Create and manage your SMB users' companies. |
| Connections | Create new and manage existing data connections for a company. |
| Configuration | View and manage mapping configuration and defaults for expense transactions. |
| Sync | Monitor the status of data syncs. |
| Expenses | Create and update transactions that represent your customers' spend. |
| Transfers | Create and update transactions that represent the movement of your customers' money. |
| Reimbursements | Create and update transactions that represent your customers' repayable spend. |
| Attachments | Attach receipts to a transaction for a complete audit trail. |
| Transaction status | Monitor the status of individual transactions in data syncs. |
| Manage data | Control and monitor the retrieval of data from an integration. |
| Push operations | View historic push operations. |
| Accounts | Create accounts and view account schemas. |
| Customers | Get, create, and update customers. |
| Suppliers | Get, create, and update suppliers. |
<!-- End Codat Tags Table -->
<!-- End Summary [summary] -->

<!-- Start Table of Contents [toc] -->
## Table of Contents
<!-- $toc-max-depth=2 -->
* [Sync for Expenses](#sync-for-expenses)
  * [Endpoints](#endpoints)
  * [SDK Installation](#sdk-installation)
  * [Example Usage](#example-usage)
  * [SDK Example Usage](#sdk-example-usage)
  * [Available Resources and Operations](#available-resources-and-operations)
  * [Server Selection](#server-selection)
  * [Authentication](#authentication)
  * [Retries](#retries)
  * [Error Handling](#error-handling)
  * [Custom HTTP Client](#custom-http-client)

<!-- End Table of Contents [toc] -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### NuGet

To add the [NuGet](https://www.nuget.org/) package to a .NET project:
```bash
dotnet add package Codat.Sync.Expenses
```

### Locally

To add a reference to a local instance of the SDK in a .NET project:
```bash
dotnet add reference Codat/Sync/Expenses/Codat.Sync.Expenses.csproj
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

<details open>
<summary>Available methods</summary>

### [Accounts](docs/sdks/accounts/README.md)

* [Create](docs/sdks/accounts/README.md#create) - Create account
* [GetCreateModel](docs/sdks/accounts/README.md#getcreatemodel) - Get create account model

### [Adjustments](docs/sdks/adjustments/README.md)

* [Create](docs/sdks/adjustments/README.md#create) - Create adjustment transaction

### [Attachments](docs/sdks/attachments/README.md)

* [Upload](docs/sdks/attachments/README.md#upload) - Upload attachment

### [BankAccounts](docs/sdks/bankaccounts/README.md)

* [Create](docs/sdks/bankaccounts/README.md#create) - Create bank account
* [GetCreateModel](docs/sdks/bankaccounts/README.md#getcreatemodel) - Get create bank account model

### [Companies](docs/sdks/companies/README.md)

* [List](docs/sdks/companies/README.md#list) - List companies
* [Create](docs/sdks/companies/README.md#create) - Create company
* [Replace](docs/sdks/companies/README.md#replace) - Replace company
* [Update](docs/sdks/companies/README.md#update) - Update company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company

### [CompanyInfo](docs/sdks/companyinfo/README.md)

* [Get](docs/sdks/companyinfo/README.md#get) - Get company info

### [Configuration](docs/sdks/configuration/README.md)

* [Get](docs/sdks/configuration/README.md#get) - Get company configuration
* [Set](docs/sdks/configuration/README.md#set) - Set company configuration

### [Connections](docs/sdks/connections/README.md)

* [List](docs/sdks/connections/README.md#list) - List connections
* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection
* [CreatePartnerExpenseConnection](docs/sdks/connections/README.md#createpartnerexpenseconnection) - Create partner expense connection

### [Customers](docs/sdks/customers/README.md)

* [List](docs/sdks/customers/README.md#list) - List customers
* [Get](docs/sdks/customers/README.md#get) - Get customer
* [Create](docs/sdks/customers/README.md#create) - Create customer
* [Update](docs/sdks/customers/README.md#update) - Update customer

### [Expenses](docs/sdks/expenses/README.md)

* [Create](docs/sdks/expenses/README.md#create) - Create expense transaction
* [Update](docs/sdks/expenses/README.md#update) - Update expense transactions

### [ManageData](docs/sdks/managedata/README.md)

* [RefreshAllDataTypes](docs/sdks/managedata/README.md#refreshalldatatypes) - Refresh all data
* [Get](docs/sdks/managedata/README.md#get) - Get data status
* [RefreshDataType](docs/sdks/managedata/README.md#refreshdatatype) - Refresh data type
* [ListPullOperations](docs/sdks/managedata/README.md#listpulloperations) - List pull operations
* [GetPullOperation](docs/sdks/managedata/README.md#getpulloperation) - Get pull operation

### [MappingOptions](docs/sdks/mappingoptions/README.md)

* [GetMappingOptions](docs/sdks/mappingoptions/README.md#getmappingoptions) - Mapping options

### [PushOperations](docs/sdks/pushoperations/README.md)

* [List](docs/sdks/pushoperations/README.md#list) - List push operations
* [Get](docs/sdks/pushoperations/README.md#get) - Get push operation

### [Reimbursements](docs/sdks/reimbursements/README.md)

* [Create](docs/sdks/reimbursements/README.md#create) - Create reimbursable expense transaction
* [Update](docs/sdks/reimbursements/README.md#update) - Update reimbursable expense transaction

### [Suppliers](docs/sdks/suppliers/README.md)

* [List](docs/sdks/suppliers/README.md#list) - List suppliers
* [Get](docs/sdks/suppliers/README.md#get) - Get supplier
* [Create](docs/sdks/suppliers/README.md#create) - Create supplier
* [Update](docs/sdks/suppliers/README.md#update) - Update supplier

### [Sync](docs/sdks/sync/README.md)

* [GetLastSuccessfulSync](docs/sdks/sync/README.md#getlastsuccessfulsync) - Last successful sync
* [GetLatestSync](docs/sdks/sync/README.md#getlatestsync) - Latest sync status
* [List](docs/sdks/sync/README.md#list) - List sync statuses
* [Get](docs/sdks/sync/README.md#get) - Get sync status

### [TransactionStatus](docs/sdks/transactionstatus/README.md)

* [List](docs/sdks/transactionstatus/README.md#list) - List sync transactions
* [Get](docs/sdks/transactionstatus/README.md#get) - Get sync transaction

### [Transfers](docs/sdks/transfers/README.md)

* [Create](docs/sdks/transfers/README.md#create) - Create transfer transaction

</details>
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Override Server URL Per-Client

The default server can be overridden globally by passing a URL to the `serverUrl: string` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(
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
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

ListCompaniesRequest req = new ListCompaniesRequest() {
    Query = "id=e3334455-1aed-4e71-ab43-6bccf12092ee",
    OrderBy = "-modifiedDate",
    Tags = "region=uk && team=invoice-finance",
};

var res = await sdk.Companies.ListAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Retries [retries] -->
## Retries

Some of the endpoints in this SDK support retries. If you use the SDK without any configuration, it will fall back to the default retry strategy provided by the API. However, the default retry strategy can be overridden on a per-operation basis, or across the entire SDK.

To change the default retry strategy for a single API call, simply pass a `RetryConfig` to the call:
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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

If you'd like to override the default retry strategy for all operations that support retries, you can use the `RetryConfig` optional parameter when intitializing the SDK:
```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(
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
<!-- End Retries [retries] -->

<!-- Start Error Handling [errors] -->
## Error Handling

[`CodatSyncExpensesException`](./Codat/Sync/Expenses/Models/Errors/CodatSyncExpensesException.cs) is the base exception class for all HTTP error responses. It has the following properties:

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
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Models.Components;
using Codat.Sync.Expenses.Models.Errors;
using Codat.Sync.Expenses.Models.Requests;

var sdk = new CodatSyncExpenses(authHeader: "Basic BASE_64_ENCODED(API_KEY)");

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
catch (CodatSyncExpensesException ex)  // all SDK exceptions inherit from CodatSyncExpensesException
{
    // ex.ToString() provides a detailed error message
    System.Console.WriteLine(ex);

    // Base exception fields
    HttpResponseMessage rawResponse = ex.RawResponse;
    HttpResponseHeaders headers = ex.Headers;
    int statusCode = ex.StatusCode;
    string? contentType = ex.ContentType;
    var responseBody = ex.Body;

    if (ex is ErrorMessage) // different exceptions may be thrown depending on the method
    {
        // Check error data fields
        ErrorMessagePayload payload = ex.Payload;
        long StatusCode = payload.StatusCode;
        string Service = payload.Service;
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
    // Check ex.InnerException for Network connectivity errors
}
```

### Error Classes

**Primary exceptions:**
* [`CodatSyncExpensesException`](./Codat/Sync/Expenses/Models/Errors/CodatSyncExpensesException.cs): The base class for HTTP error responses.
  * [`ErrorMessage`](./Codat/Sync/Expenses/Models/Errors/ErrorMessage.cs): Your `query` parameter was not correctly formed.

<details><summary>Less common exceptions (2)</summary>

* [`System.Net.Http.HttpRequestException`](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httprequestexception): Network connectivity error. For more details about the underlying cause, inspect the `ex.InnerException`.

* Inheriting from [`CodatSyncExpensesException`](./Codat/Sync/Expenses/Models/Errors/CodatSyncExpensesException.cs):
  * [`ResponseValidationError`](./Codat/Sync/Expenses/Models/Errors/ResponseValidationError.cs): Thrown when the response data could not be deserialized into the expected type.
</details>
<!-- End Error Handling [errors] -->

<!-- Start Custom HTTP Client [http-client] -->
## Custom HTTP Client

The C# SDK makes API calls using an `ISpeakeasyHttpClient` that wraps the native
[HttpClient](https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclient). This
client provides the ability to attach hooks around the request lifecycle that can be used to modify the request or handle
errors and response.

The `ISpeakeasyHttpClient` interface allows you to either use the default `SpeakeasyHttpClient` that comes with the SDK,
or provide your own custom implementation with customized configuration such as custom message handlers, timeouts,
connection pooling, and other HTTP client settings.

The following example shows how to create a custom HTTP client with request modification and error handling:

```csharp
using Codat.Sync.Expenses;
using Codat.Sync.Expenses.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Create a custom HTTP client
public class CustomHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _defaultClient;

    public CustomHttpClient()
    {
        _defaultClient = new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Add custom header and timeout
        request.Headers.Add("x-custom-header", "custom value");
        request.Headers.Add("x-request-timeout", "30");
        
        try
        {
            var response = await _defaultClient.SendAsync(request, cancellationToken);
            // Log successful response
            Console.WriteLine($"Request successful: {response.StatusCode}");
            return response;
        }
        catch (Exception error)
        {
            // Log error
            Console.WriteLine($"Request failed: {error.Message}");
            throw;
        }
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
        _defaultClient?.Dispose();
    }
}

// Use the custom HTTP client with the SDK
var customHttpClient = new CustomHttpClient();
var sdk = new CodatSyncExpenses(client: customHttpClient);
```

<details>
<summary>You can also provide a completely custom HTTP client with your own configuration:</summary>

```csharp
using Codat.Sync.Expenses.Utils;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

// Custom HTTP client with custom configuration
public class AdvancedHttpClient : ISpeakeasyHttpClient
{
    private readonly HttpClient _httpClient;

    public AdvancedHttpClient()
    {
        var handler = new HttpClientHandler()
        {
            MaxConnectionsPerServer = 10,
            // ServerCertificateCustomValidationCallback = customCertValidation, // Custom SSL validation if needed
        };

        _httpClient = new HttpClient(handler)
        {
            Timeout = TimeSpan.FromSeconds(30)
        };
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        return await _httpClient.SendAsync(request, cancellationToken ?? CancellationToken.None);
    }

    public void Dispose()
    {
        _httpClient?.Dispose();
    }
}

var sdk = CodatSyncExpenses.Builder()
    .WithClient(new AdvancedHttpClient())
    .Build();
```
</details>

<details>
<summary>For simple debugging, you can enable request/response logging by implementing a custom client:</summary>

```csharp
public class LoggingHttpClient : ISpeakeasyHttpClient
{
    private readonly ISpeakeasyHttpClient _innerClient;

    public LoggingHttpClient(ISpeakeasyHttpClient innerClient = null)
    {
        _innerClient = innerClient ?? new SpeakeasyHttpClient();
    }

    public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken? cancellationToken = null)
    {
        // Log request
        Console.WriteLine($"Sending {request.Method} request to {request.RequestUri}");
        
        var response = await _innerClient.SendAsync(request, cancellationToken);
        
        // Log response
        Console.WriteLine($"Received {response.StatusCode} response");
        
        return response;
    }

    public void Dispose() => _innerClient?.Dispose();
}

var sdk = new CodatSyncExpenses(client: new LoggingHttpClient());
```
</details>

The SDK also provides built-in hook support through the `SDKConfiguration.Hooks` system, which automatically handles
`BeforeRequestAsync`, `AfterSuccessAsync`, and `AfterErrorAsync` hooks for advanced request lifecycle management.
<!-- End Custom HTTP Client [http-client] -->

<!-- Placeholder for Future Speakeasy SDK Sections -->

<!-- Start Codat Support Notes -->
### Support

If you encounter any challenges while utilizing our SDKs, please don't hesitate to reach out for assistance. 
You can raise any issues by contacting your dedicated Codat representative or reaching out to our [support team](mailto:support@codat.io).
We're here to help ensure a smooth experience for you.
<!-- End Codat Support Notes -->

<!-- Start Codat Generated By -->
### Library generated by [Speakeasy](https://docs.speakeasyapi.dev/docs/using-speakeasy/client-sdks)
<!-- End Codat Generated By -->