# TaxRateComponent

A tax rate can be made up of multiple sub taxes, often called components of the tax.


## Fields

| Field                                                                              | Type                                                                               | Required                                                                           | Description                                                                        |
| ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- | ---------------------------------------------------------------------------------- |
| `Name`                                                                             | *string*                                                                           | :heavy_minus_sign:                                                                 | Name of the tax rate component.                                                    |
| `Rate`                                                                             | *decimal*                                                                          | :heavy_minus_sign:                                                                 | The rate of the tax rate component, usually a percentage.                          |
| `IsCompound`                                                                       | *bool*                                                                             | :heavy_check_mark:                                                                 | A flag to indicate with the tax is calculated using the principle of compounding.  |