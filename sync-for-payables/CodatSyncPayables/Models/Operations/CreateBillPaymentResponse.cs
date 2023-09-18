
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Operations
{
    using CodatSyncPayables.Models.Shared;
    using System.Net.Http;
    using System;
    
    public class CreateBillPaymentResponse
    {

        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// Success
        /// </summary>
        public Models.Shared.CreateBillPaymentResponse? CreateBillPaymentResponseValue { get; set; }

        /// <summary>
        /// The request made is not valid.
        /// </summary>
        public ErrorMessage? ErrorMessage { get; set; }

        public int StatusCode { get; set; } = default!;

        public HttpResponseMessage? RawResponse { get; set; }
    }
}