
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayroll.Models.Webhooks
{
    using System.Net.Http;
    using System;
    
    public class ClientRateLimitResetResponse
    {

        public string? ContentType { get; set; } = default!;

        public int StatusCode { get; set; } = default!;

        public HttpResponseMessage? RawResponse { get; set; }
    }
}