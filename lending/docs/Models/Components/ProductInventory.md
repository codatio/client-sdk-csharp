# ProductInventory

Information about the total inventory as well as the locations inventory is in.


## Fields

| Field                                                                                 | Type                                                                                  | Required                                                                              | Description                                                                           |
| ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- | ------------------------------------------------------------------------------------- |
| `TotalQuantity`                                                                       | *decimal*                                                                             | :heavy_minus_sign:                                                                    | The total quantity of stock remaining across locations.                               |
| `Locations`                                                                           | List<[ProductInventoryLocation](../../Models/Components/ProductInventoryLocation.md)> | :heavy_minus_sign:                                                                    | N/A                                                                                   |