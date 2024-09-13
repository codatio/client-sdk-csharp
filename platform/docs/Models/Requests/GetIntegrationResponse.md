# GetIntegrationResponse


## Fields

| Field                                                                                                                                                                                                                                                                                                                                                                                                                                  | Type                                                                                                                                                                                                                                                                                                                                                                                                                                   | Required                                                                                                                                                                                                                                                                                                                                                                                                                               | Description                                                                                                                                                                                                                                                                                                                                                                                                                            | Example                                                                                                                                                                                                                                                                                                                                                                                                                                |
| -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| `ContentType`                                                                                                                                                                                                                                                                                                                                                                                                                          | *string*                                                                                                                                                                                                                                                                                                                                                                                                                               | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                     | HTTP response content type for this operation                                                                                                                                                                                                                                                                                                                                                                                          |                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| `StatusCode`                                                                                                                                                                                                                                                                                                                                                                                                                           | *int*                                                                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                     | HTTP response status code for this operation                                                                                                                                                                                                                                                                                                                                                                                           |                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| `RawResponse`                                                                                                                                                                                                                                                                                                                                                                                                                          | [HttpResponseMessage](https://learn.microsoft.com/en-us/dotnet/api/system.net.http.httpresponsemessage?view=net-5.0)                                                                                                                                                                                                                                                                                                                   | :heavy_check_mark:                                                                                                                                                                                                                                                                                                                                                                                                                     | Raw HTTP response; suitable for custom response parsing                                                                                                                                                                                                                                                                                                                                                                                |                                                                                                                                                                                                                                                                                                                                                                                                                                        |
| `Integration`                                                                                                                                                                                                                                                                                                                                                                                                                          | [Integration](../../Models/Components/Integration.md)                                                                                                                                                                                                                                                                                                                                                                                  | :heavy_minus_sign:                                                                                                                                                                                                                                                                                                                                                                                                                     | OK                                                                                                                                                                                                                                                                                                                                                                                                                                     | {<br/>"key": "gbol",<br/>"logoUrl": "http://example.com",<br/>"name": "Xero",<br/>"enabled": true,<br/>"sourceId": "accounting",<br/>"sourceType": "8193a927-ab7a-45a3-9dc2-d357a4932dfe",<br/>"integrationId": "497a18ca-284e-40c0-985d-f72be35d468e",<br/>"isOfflineConnector": true,<br/>"isBeta": true,<br/>"dataProvidedBy": "string",<br/>"datatypeFeatures": [<br/>{<br/>"datatype": "invoices",<br/>"supportedFeatures": [<br/>{<br/>"featureType": "get",<br/>"featureState": "release"<br/>}<br/>]<br/>}<br/>]<br/>} |