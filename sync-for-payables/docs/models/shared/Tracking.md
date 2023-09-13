# Tracking

Categories, and a project and customer, against which the item is tracked.


## Fields

| Field                                                                       | Type                                                                        | Required                                                                    | Description                                                                 |
| --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- | --------------------------------------------------------------------------- |
| `categoryRefs`                                                              | List<[TrackingCategoryRef](../../models/shared/TrackingCategoryRef.md)>     | :heavy_check_mark:                                                          | N/A                                                                         |
| `customerRef`                                                               | [TrackingCustomerRef](../../models/shared/TrackingCustomerRef.md)           | :heavy_minus_sign:                                                          | N/A                                                                         |
| `isBilledTo`                                                                | [BilledToType](../../models/shared/BilledToType.md)                         | :heavy_check_mark:                                                          | N/A                                                                         |
| `isRebilledTo`                                                              | [BilledToType](../../models/shared/BilledToType.md)                         | :heavy_check_mark:                                                          | N/A                                                                         |
| `projectRef`                                                                | [TrackingProjectReference](../../models/shared/TrackingProjectReference.md) | :heavy_minus_sign:                                                          | N/A                                                                         |