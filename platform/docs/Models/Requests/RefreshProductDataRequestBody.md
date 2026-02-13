# RefreshProductDataRequestBody

Optionally specify one or more data types to refresh for the given custom product. If omitted, the product's scheduled refresh is triggered as usual. When provided, each data type must be valid for the specified product.


## Fields

| Field                                              | Type                                               | Required                                           | Description                                        |
| -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- | -------------------------------------------------- |
| `DataTypes`                                        | List<*string*>                                     | :heavy_minus_sign:                                 | One or more data types to refresh for the product. |