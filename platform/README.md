# Platform

<!-- Start Codat Library Description -->
Manage the building blocks of Codat, including companies, connections, and more.
<!-- End Codat Library Description -->

<!-- Start SDK Installation [installation] -->
## SDK Installation

### Nuget

```bash
dotnet add package Codat.Platform
```
<!-- End SDK Installation [installation] -->

## Example Usage
<!-- Start SDK Example Usage [usage] -->
## SDK Example Usage

### Example

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateApiKey req = new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
};

var res = await sdk.Settings.CreateApiKeyAsync(req);

// handle response
```
<!-- End SDK Example Usage [usage] -->

<!-- Start Available Resources and Operations [operations] -->
## Available Resources and Operations

### [Settings](docs/sdks/settings/README.md)

* [CreateApiKey](docs/sdks/settings/README.md#createapikey) - Create API key
* [DeleteApiKey](docs/sdks/settings/README.md#deleteapikey) - Delete API key
* [GetProfile](docs/sdks/settings/README.md#getprofile) - Get profile
* [GetSyncSettings](docs/sdks/settings/README.md#getsyncsettings) - Get sync settings
* [ListApiKeys](docs/sdks/settings/README.md#listapikeys) - List API keys
* [UpdateProfile](docs/sdks/settings/README.md#updateprofile) - Update profile
* [UpdateSyncSettings](docs/sdks/settings/README.md#updatesyncsettings) - Update all sync settings

### [Companies](docs/sdks/companies/README.md)

* [Create](docs/sdks/companies/README.md#create) - Create company
* [Delete](docs/sdks/companies/README.md#delete) - Delete a company
* [Get](docs/sdks/companies/README.md#get) - Get company
* [List](docs/sdks/companies/README.md#list) - List companies
* [Update](docs/sdks/companies/README.md#update) - Update company

### [ConnectionManagement](docs/sdks/connectionmanagement/README.md)

* [GetAccessToken](docs/sdks/connectionmanagement/README.md#getaccesstoken) - Get access token

### [ConnectionManagement.CorsSettings](docs/sdks/corssettings/README.md)

* [Get](docs/sdks/corssettings/README.md#get) - Get CORS settings
* [Set](docs/sdks/corssettings/README.md#set) - Set CORS settings

### [Connections](docs/sdks/connections/README.md)

* [Create](docs/sdks/connections/README.md#create) - Create connection
* [Delete](docs/sdks/connections/README.md#delete) - Delete connection
* [Get](docs/sdks/connections/README.md#get) - Get connection
* [List](docs/sdks/connections/README.md#list) - List connections
* [Unlink](docs/sdks/connections/README.md#unlink) - Unlink connection
* [UpdateAuthorization](docs/sdks/connections/README.md#updateauthorization) - Update authorization

### [CustomDataType](docs/sdks/customdatatype/README.md)

* [Configure](docs/sdks/customdatatype/README.md#configure) - Configure custom data type
* [GetConfiguration](docs/sdks/customdatatype/README.md#getconfiguration) - Get custom data configuration
* [List](docs/sdks/customdatatype/README.md#list) - List custom data type records
* [Refresh](docs/sdks/customdatatype/README.md#refresh) - Refresh custom data type

### [PushData](docs/sdks/pushdata/README.md)

* [GetModelOptions](docs/sdks/pushdata/README.md#getmodeloptions) - Get push options
* [GetOperation](docs/sdks/pushdata/README.md#getoperation) - Get push operation
* [ListOperations](docs/sdks/pushdata/README.md#listoperations) - List push operations

### [RefreshData](docs/sdks/refreshdata/README.md)

* [All](docs/sdks/refreshdata/README.md#all) - Refresh all data
* [ByDataType](docs/sdks/refreshdata/README.md#bydatatype) - Refresh data type
* [Get](docs/sdks/refreshdata/README.md#get) - Get data status
* [GetPullOperation](docs/sdks/refreshdata/README.md#getpulloperation) - Get pull operation
* [ListPullOperations](docs/sdks/refreshdata/README.md#listpulloperations) - List pull operations

### [Groups](docs/sdks/groups/README.md)

* [AddCompany](docs/sdks/groups/README.md#addcompany) - Add company
* [Create](docs/sdks/groups/README.md#create) - Create group
* [List](docs/sdks/groups/README.md#list) - List groups
* [RemoveCompany](docs/sdks/groups/README.md#removecompany) - Remove company

### [Integrations](docs/sdks/integrations/README.md)

* [Get](docs/sdks/integrations/README.md#get) - Get integration
* [GetBranding](docs/sdks/integrations/README.md#getbranding) - Get branding
* [List](docs/sdks/integrations/README.md#list) - List integrations

### [SupplementalData](docs/sdks/supplementaldata/README.md)

* [Configure](docs/sdks/supplementaldata/README.md#configure) - Configure
* [GetConfiguration](docs/sdks/supplementaldata/README.md#getconfiguration) - Get configuration

### [Webhooks](docs/sdks/webhooks/README.md)

* [~~Create~~](docs/sdks/webhooks/README.md#create) - Create webhook :warning: **Deprecated**
* [CreateConsumer](docs/sdks/webhooks/README.md#createconsumer) - Create webhook consumer
* [DeleteConsumer](docs/sdks/webhooks/README.md#deleteconsumer) - Delete webhook consumer
* [~~Get~~](docs/sdks/webhooks/README.md#get) - Get webhook :warning: **Deprecated**
* [~~List~~](docs/sdks/webhooks/README.md#list) - List webhooks :warning: **Deprecated**
* [ListConsumers](docs/sdks/webhooks/README.md#listconsumers) - List webhook consumers
<!-- End Available Resources and Operations [operations] -->

<!-- Start Server Selection [server] -->
## Server Selection

### Select Server by Index

You can override the default server globally by passing a server index to the `serverIndex: number` optional parameter when initializing the SDK client instance. The selected server will then be used as the default on the operations that use it. This table lists the indexes associated with the available servers:

| # | Server | Variables |
| - | ------ | --------- |
| 0 | `https://api.codat.io` | None |




### Override Server URL Per-Client

The default server can also be overridden globally by passing a URL to the `serverUrl: str` optional parameter when initializing the SDK client instance. For example:
<!-- End Server Selection [server] -->

<!-- Start Authentication [security] -->
## Authentication

### Per-Client Security Schemes

This SDK supports the following security scheme globally:

| Name         | Type         | Scheme       |
| ------------ | ------------ | ------------ |
| `AuthHeader` | apiKey       | API key      |

You can set the security parameters through the `security` optional parameter when initializing the SDK client instance. For example:
```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateApiKey req = new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
};

var res = await sdk.Settings.CreateApiKeyAsync(req);

// handle response
```
<!-- End Authentication [security] -->

<!-- Start Error Handling [errors] -->
## Error Handling

Handling errors in this SDK should largely match your expectations.  All operations return a response object or thow an exception.  If Error objects are specified in your OpenAPI Spec, the SDK will raise the appropriate type.

| Error Object                              | Status Code                               | Content Type                              |
| ----------------------------------------- | ----------------------------------------- | ----------------------------------------- |
| Codat.Platform.Models.Errors.ErrorMessage | 400,401,402,403,409,429,500,503           | application/json                          |
| Codat.Platform.Models.Errors.SDKException | 4xx-5xx                                   | */*                                       |

### Example

```csharp
using Codat.Platform;
using Codat.Platform.Models.Shared;
using System;
using Codat.Platform.Models.Errors;

var sdk = new CodatPlatform(security: new Security() {
        AuthHeader = "Basic BASE_64_ENCODED(API_KEY)",
    });

CreateApiKey req = new CreateApiKey() {
    Name = "azure-invoice-finance-processor",
};

try
{
    var res = await sdk.Settings.CreateApiKeyAsync(req);
    // handle response
}
catch (Exception ex)
{
    if (ex is ErrorMessage)
    {
        // handle exception
    }
    else if (ex is Codat.Platform.Models.Errors.SDKException)
    {
        // handle exception
    }
}

```
<!-- End Error Handling [errors] -->

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