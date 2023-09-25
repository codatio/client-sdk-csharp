
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
    
    public class UpdateCustomerResponse
    {

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// The request made is not valid.
        /// </summary>
        public ErrorMessage? ErrorMessage { get; set; }

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        public HttpResponseMessage? RawResponse { get; set; }

        /// <summary>
        /// Success
        /// </summary>
        public Models.Shared.UpdateCustomerResponse? UpdateCustomerResponseValue { get; set; }
    }
}