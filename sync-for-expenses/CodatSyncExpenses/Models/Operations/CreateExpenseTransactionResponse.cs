
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
    
    
    public class CreateExpenseTransactionResponse
    {
        
        public string? ContentType { get; set; }
        
        /// <summary>
        /// OK
        /// </summary>
        
        public CreateExpenseResponse? CreateExpenseResponse { get; set; }
        
        /// <summary>
        /// The request made is not valid.
        /// </summary>
        
        public ErrorMessage? ErrorMessage { get; set; }
        
        
        public int StatusCode { get; set; }
        
        
        public HttpResponseMessage? RawResponse { get; set; }
        
    }
    
}