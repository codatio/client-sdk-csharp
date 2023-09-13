# GetCommerceRefundsReportRequest


## Fields

| Field                                                                                                                                        | Type                                                                                                                                         | Required                                                                                                                                     | Description                                                                                                                                  | Example                                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- | -------------------------------------------------------------------------------------------------------------------------------------------- |
| `companyId`                                                                                                                                  | *string*                                                                                                                                     | :heavy_check_mark:                                                                                                                           | N/A                                                                                                                                          | 8a210b68-6988-11ed-a1eb-0242ac120002                                                                                                         |
| `connectionId`                                                                                                                               | *string*                                                                                                                                     | :heavy_check_mark:                                                                                                                           | N/A                                                                                                                                          | 2e9d2c44-f675-40ba-8049-353bfcb5e171                                                                                                         |
| `includeDisplayNames`                                                                                                                        | *bool*                                                                                                                                       | :heavy_minus_sign:                                                                                                                           | Shows the dimensionDisplayName and itemDisplayName in measures to make the report data human-readable.                                       |                                                                                                                                              |
| `numberOfPeriods`                                                                                                                            | *long*                                                                                                                                       | :heavy_check_mark:                                                                                                                           | The number of periods to return. There will be no pagination as a query parameter.                                                           |                                                                                                                                              |
| `periodLength`                                                                                                                               | *long*                                                                                                                                       | :heavy_check_mark:                                                                                                                           | The number of months per period. E.g. 2 = 2 months per period.                                                                               |                                                                                                                                              |
| `periodUnit`                                                                                                                                 | [PeriodUnit](../../models/shared/PeriodUnit.md)                                                                                              | :heavy_check_mark:                                                                                                                           | The period unit of time returned.                                                                                                            |                                                                                                                                              |
| `reportDate`                                                                                                                                 | *string*                                                                                                                                     | :heavy_check_mark:                                                                                                                           | The date in which the report is created up to. Users must specify a specific date, however the response will be provided for the full month. | 29-09-2020                                                                                                                                   |