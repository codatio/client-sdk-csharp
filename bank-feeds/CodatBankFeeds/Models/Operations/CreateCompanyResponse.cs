
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatBankFeeds.Models.Operations
{
    using CodatBankFeeds.Models.Shared;
    using System.Net.Http;
    using System;
    
    
    public class CreateCompanyResponse
    {
        /// <summary>
        /// OK
        /// </summary>
        
        public Company? Company { get; set; }
        
        
        public string? ContentType { get; set; } = default!;
        
        /// <summary>
        /// The request made is not valid.
        /// </summary>
        
        public ErrorMessage? ErrorMessage { get; set; }
        
        
        public int StatusCode { get; set; } = default!;
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
    
}