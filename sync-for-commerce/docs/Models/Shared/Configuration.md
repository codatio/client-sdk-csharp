# Configuration


## Fields

| Field                                                                 | Type                                                                  | Required                                                              | Description                                                           |
| --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- | --------------------------------------------------------------------- |
| `AccountingSoftwareCompanyName`                                       | *string*                                                              | :heavy_minus_sign:                                                    | The company name defined in the accounting platform.                  |
| `CompanyId`                                                           | *object*                                                              | :heavy_minus_sign:                                                    | Unique identifier for a company.                                      |
| `Configuration`                                                       | [CommerceConfiguration](../../Models/Shared/CommerceConfiguration.md) | :heavy_minus_sign:                                                    | N/A                                                                   |
| `Configured`                                                          | *bool*                                                                | :heavy_minus_sign:                                                    | True if Sync for Commerce has been configured for the company.        |
| `Enable`                                                              | *bool*                                                                | :heavy_minus_sign:                                                    | True if Sync for Commerce is enabled for the company.                 |
| `Schedule`                                                            | [SyncSchedule](../../Models/Shared/SyncSchedule.md)                   | :heavy_minus_sign:                                                    | N/A                                                                   |