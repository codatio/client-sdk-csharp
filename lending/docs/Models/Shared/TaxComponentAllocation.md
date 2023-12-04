# TaxComponentAllocation


## Fields

| Field                                                                                           | Type                                                                                            | Required                                                                                        | Description                                                                                     |
| ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------------------- |
| `Rate`                                                                                          | *decimal*                                                                                       | :heavy_minus_sign:                                                                              | Tax amount on order line sale as available from source commerce platform.                       |
| `TaxComponentRef`                                                                               | [TaxComponentRef](../../Models/Shared/TaxComponentRef.md)                                       | :heavy_minus_sign:                                                                              | Taxes rates reference object depending on the rates being available on source commerce package. |