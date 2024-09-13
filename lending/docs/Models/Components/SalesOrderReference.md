# SalesOrderReference


## Fields

| Field                                                                             | Type                                                                              | Required                                                                          | Description                                                                       |
| --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- | --------------------------------------------------------------------------------- |
| `Id`                                                                              | *string*                                                                          | :heavy_minus_sign:                                                                | Unique identifier to a record in `dataType`.                                      |
| `DataType`                                                                        | [AccountingInvoiceDataType](../../Models/Components/AccountingInvoiceDataType.md) | :heavy_minus_sign:                                                                | The underlying data type associated to the reference `id`.                        |