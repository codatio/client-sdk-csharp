
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Operations
{
    using CodatLending.Models.Shared;
    using System.Net.Http;
    using System;
    
    
    public class ListCommerceProductsResponse
    {
        /// <summary>
        /// OK
        /// </summary>
        
        public CommerceProducts? CommerceProducts { get; set; }
        
        
        public string? ContentType { get; set; }
        
        /// <summary>
        /// Your `query` parameter was not correctly formed
        /// </summary>
        
        public ErrorMessage? ErrorMessage { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
    
}