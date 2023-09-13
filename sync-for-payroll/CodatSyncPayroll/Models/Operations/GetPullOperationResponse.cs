
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
    using System.Net.Http;
    using System;
    
    
    public class GetPullOperationResponse
    {
        
        public string? ContentType { get; set; } = default!;
        
        /// <summary>
        /// Your API request was not properly authorized.
        /// </summary>
        
        public ErrorMessage? ErrorMessage { get; set; }
        
        /// <summary>
        /// OK
        /// </summary>
        
        public PullOperation? PullOperation { get; set; }
        
        
        public int StatusCode { get; set; } = default!;
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
    
}