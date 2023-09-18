
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
    
    public class ListSuppliersResponse
    {

        public string? ContentType { get; set; } = default!;

        /// <summary>
        /// Your `query` parameter was not correctly formed
        /// </summary>
        public ErrorMessage? ErrorMessage { get; set; }

        public int StatusCode { get; set; } = default!;

        public HttpResponseMessage? RawResponse { get; set; }

        /// <summary>
        /// Success
        /// </summary>
        public Suppliers? Suppliers { get; set; }
    }
}