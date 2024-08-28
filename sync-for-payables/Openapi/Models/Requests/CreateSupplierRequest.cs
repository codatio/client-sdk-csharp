//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi.Models.Requests
{
    using Openapi.Models.Components;
    using Openapi.Utils;
    
    public class CreateSupplierRequest
    {

        /// <summary>
        /// Unique identifier for a company.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=companyId")]
        public string CompanyId { get; set; } = default!;

        /// <summary>
        /// Unique identifier for a connection.
        /// </summary>
        [SpeakeasyMetadata("pathParam:style=simple,explode=false,name=connectionId")]
        public string ConnectionId { get; set; } = default!;

        /// <summary>
        /// A unique identifier to ensure idempotent behaviour for subsequent requests.
        /// </summary>
        [SpeakeasyMetadata("header:style=simple,explode=false,name=Idempotency-Key")]
        public string? IdempotencyKey { get; set; }

        [SpeakeasyMetadata("request:mediaType=application/json")]
        public SupplierPrototype? SupplierPrototype { get; set; }
    }
}