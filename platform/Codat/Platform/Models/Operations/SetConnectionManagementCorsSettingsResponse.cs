//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Operations
{
    using Codat.Platform.Models.Shared;
    using Codat.Platform.Utils;
    using System.Net.Http;
    using System;
    
    public class SetConnectionManagementCorsSettingsResponse
    {

        /// <summary>
        /// Success
        /// </summary>
        public ConnectionManagementAllowedOrigins? ConnectionManagementAllowedOrigins { get; set; }

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
    }
}