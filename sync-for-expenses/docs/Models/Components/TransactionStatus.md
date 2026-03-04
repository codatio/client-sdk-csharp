# TransactionStatus

Status of the transaction.

## Example Usage

```csharp
using Codat.Sync.Expenses.Models.Components;

var value = TransactionStatus.Unknown;
```


## Values

| Name              | Value             |
| ----------------- | ----------------- |
| `Unknown`         | Unknown           |
| `Pending`         | Pending           |
| `ValidationError` | ValidationError   |
| `Completed`       | Completed         |
| `PushError`       | PushError         |