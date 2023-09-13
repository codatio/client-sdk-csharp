# SupplementalDataConfigurationSupplementalDataSourceConfiguration

The client's defined name for the object.


## Fields

| Field                                                                               | Type                                                                                | Required                                                                            | Description                                                                         |
| ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- | ----------------------------------------------------------------------------------- |
| `dataSource`                                                                        | *string*                                                                            | :heavy_minus_sign:                                                                  | The underlying endpoint of the source system which the configuration is targeting.  |
| `pullData`                                                                          | Dictionary<String, *string*>                                                        | :heavy_minus_sign:                                                                  | The additional properties that are required when pulling records.                   |
| `pushData`                                                                          | Dictionary<String, *string*>                                                        | :heavy_minus_sign:                                                                  | The additional properties that are required to create and/or update records.        |