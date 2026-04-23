# WriteStatus

The current status of the write request, which is the same as the push operation status.

## Example Usage

```csharp
using Codat.Platform.Models.Components;

var value = WriteStatus.Pending;
```


## Values

| Name       | Value      |
| ---------- | ---------- |
| `Pending`  | Pending    |
| `Failed`   | Failed     |
| `Success`  | Success    |
| `TimedOut` | TimedOut   |