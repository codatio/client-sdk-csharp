
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Operations
{
    using CodatSyncExpenses.Models.Shared;
    using System.Net.Http;
    using System;
    
    
    public class InitiateSyncResponse
    {
        
        public string? ContentType { get; set; } = default!;
        
        /// <summary>
        /// If model is incorrect
        /// </summary>
        
        public ErrorMessage? ErrorMessage { get; set; }
        
        
        public int StatusCode { get; set; } = default!;
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
        /// <summary>
        /// Returns the newly created SyncId
        /// </summary>
        
        public SyncInitiated? SyncInitiated { get; set; }
        
    }
    
}