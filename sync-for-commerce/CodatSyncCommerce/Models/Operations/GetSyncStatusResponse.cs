
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Operations
{
    using CodatSyncCommerce.Models.Shared;
    using System.Net.Http;
    using System;
    
    
    public class GetSyncStatusResponse
    {
        /// <summary>
        /// Bad Request
        /// </summary>
        
        public object? BadRequest { get; set; }
        
        
        public string? ContentType { get; set; } = default!;
        
        /// <summary>
        /// Not Found
        /// </summary>
        
        public object? NotFound { get; set; }
        
        
        public int StatusCode { get; set; } = default!;
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
        /// <summary>
        /// Success
        /// </summary>
        
        public SyncStatus? SyncStatus { get; set; }
        
    }
    
}