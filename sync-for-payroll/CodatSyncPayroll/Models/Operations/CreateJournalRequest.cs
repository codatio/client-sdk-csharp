
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Operations
{
    using CodatSyncPayroll.Models.Shared;
    using CodatSyncPayroll.Utils;
    
    public class CreateJournalRequest
    {

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public Journal? Journal { get; set; }

        /// <summary>
        /// Allow a sync upon push completion.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=allowSyncOnPushComplete")]
        public bool? AllowSyncOnPushComplete { get; set; }

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
    }
}