## Csharp SDK Changes:
* `Codat.sync.expenses.Connections.Create()`:  `response.connectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Companies.List()`: 
  *  `request.Tags` **Added**
  *  `response.results[].DataConnections[].ConnectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Companies.Create()`:  `response.dataConnections[].ConnectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Companies.Update()`: 
  * `request` **Changed** (Breaking ⚠️)
    - `companyRequestBody` **Removed** (Breaking ⚠️)
    - `companyUpdateRequest` **Added**
  *  `response.dataConnections[].ConnectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Companies.Get()`:  `response.dataConnections[].ConnectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Connections.List()`:  `response.results[].ConnectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Connections.Get()`:  `response.connectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Connections.Unlink()`:  `response.connectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Connections.CreatePartnerExpenseConnection()`:  `response.connectionInfo.Map<any>` **Changed** (Breaking ⚠️)
* `Codat.sync.expenses.Companies.Replace()`: **Added**
* `Codat.sync.expenses.ManageData.RefreshAllDataTypes()`:  `error.status[400]` **Added**
* `Codat.sync.expenses.ManageData.Get()`:  `response.accountTransactions.LastSuccessfulSync` **Changed**
* `Codat.sync.expenses.ManageData.RefreshDataType()`:  `error.status[400]` **Added**
