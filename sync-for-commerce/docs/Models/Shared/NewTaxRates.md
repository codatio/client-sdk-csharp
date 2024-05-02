# NewTaxRates


## Fields

| Field                                                                   | Type                                                                    | Required                                                                | Description                                                             |
| ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- | ----------------------------------------------------------------------- |
| `AccountingTaxRateOptions`                                              | List<[ConfigurationOption](../../Models/Shared/ConfigurationOption.md)> | :heavy_minus_sign:                                                      | Array of accounting tax rate options.                                   |
| `CommerceTaxRateOptions`                                                | List<[ConfigurationOption](../../Models/Shared/ConfigurationOption.md)> | :heavy_minus_sign:                                                      | Array of tax component options.                                         |
| `DefaultZeroTaxRateOptions`                                             | List<[ConfigurationOption](../../Models/Shared/ConfigurationOption.md)> | :heavy_minus_sign:                                                      | Default zero tax rate selected for sync.                                |
| `SelectedDefaultZeroTaxRateId`                                          | *string*                                                                | :heavy_minus_sign:                                                      | Default tax rate selected for sync.                                     |
| `TaxRateMappings`                                                       | List<[TaxRateMapping](../../Models/Shared/TaxRateMapping.md)>           | :heavy_minus_sign:                                                      | Array of tax component to rate mappings.                                |