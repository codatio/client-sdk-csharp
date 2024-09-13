# GetSupplementalDataConfigurationRequest


## Fields

| Field                                                              | Type                                                               | Required                                                           | Description                                                        | Example                                                            |
| ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ | ------------------------------------------------------------------ |
| `PlatformKey`                                                      | *string*                                                           | :heavy_check_mark:                                                 | A unique 4-letter key to represent a platform in each integration. | gbol                                                               |
| `DataType`                                                         | [PathParamDataType](../../Models/Requests/PathParamDataType.md)    | :heavy_check_mark:                                                 | Supported supplemental data data type.                             | invoices                                                           |