# NewTaxRates


## Fields

| Field                                                         | Type                                                          | Required                                                      | Description                                                   |
| ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- | ------------------------------------------------------------- |
| `accountingTaxRateOptions`                                    | List<[Option](../../models/shared/Option.md)>                 | :heavy_minus_sign:                                            | Array of accounting tax rate options.                         |
| `commerceTaxRateOptions`                                      | List<[Option](../../models/shared/Option.md)>                 | :heavy_minus_sign:                                            | Array of tax component options.                               |
| `defaultZeroTaxRateOptions`                                   | List<[Option](../../models/shared/Option.md)>                 | :heavy_minus_sign:                                            | Default zero tax rate selected for sync.                      |
| `selectedDefaultZeroTaxRateId`                                | *string*                                                      | :heavy_minus_sign:                                            | Default tax rate selected for sync.                           |
| `taxRateMappings`                                             | List<[TaxRateMapping](../../models/shared/TaxRateMapping.md)> | :heavy_minus_sign:                                            | Array of tax component to rate mapppings.                     |