# BillStatus

Current state of the bill. If creating a bill the status must be `Open`.

## Example Usage

```csharp
using Codat.Sync.Payables.Models.Components;

var value = BillStatus.Unknown;
```


## Values

| Name            | Value           |
| --------------- | --------------- |
| `Unknown`       | Unknown         |
| `Open`          | Open            |
| `PartiallyPaid` | PartiallyPaid   |
| `Paid`          | Paid            |
| `Void`          | Void            |
| `Draft`         | Draft           |