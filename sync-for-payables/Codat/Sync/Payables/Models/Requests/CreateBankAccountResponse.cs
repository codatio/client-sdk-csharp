//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Requests
{
    using Codat.Sync.Payables.Models.Components;
    using Codat.Sync.Payables.Utils;
    using System.Net.Http;
    using System;
    
    public class CreateBankAccountResponse
    {

        /// <summary>
        /// HTTP response content type for this operation
        /// </summary>
        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// HTTP response status code for this operation
        /// </summary>
        public int StatusCode { get; set; } = default!;

        /// <summary>
        /// Raw HTTP response; suitable for custom response parsing
        /// </summary>
        public HttpResponseMessage RawResponse { get; set; } = default!;

        /// <summary>
        /// Success
        /// </summary>
        public BankAccount? BankAccount { get; set; } = null;
    }
}