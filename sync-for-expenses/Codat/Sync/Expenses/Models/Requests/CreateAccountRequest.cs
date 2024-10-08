//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Expenses.Models.Requests
{
    using Codat.Sync.Expenses.Models.Components;
    using Codat.Sync.Expenses.Utils;
    
    public class CreateAccountRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for a connection.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// Time limit for the push operation to complete before it is timed out.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=timeoutInMinutes")]
        public int? TimeoutInMinutes { get; set; }

        /// <summary>
        /// Allow a sync upon push completion.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=allowSyncOnPushComplete")]
        public bool? AllowSyncOnPushComplete { get; set; } = true;

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public AccountPrototype? AccountPrototype { get; set; }
    }
}