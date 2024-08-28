//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Openapi.Models.Components
{
    using Newtonsoft.Json;
    using Openapi.Models.Components;
    using Openapi.Utils;
    using System.Collections.Generic;
    
    /// <summary>
    /// A human-readable object describing validation decisions Codat has made. If an operation has failed because of validation errors, they will be detailed here.
    /// </summary>
    public class ErrorValidation
    {

        [JsonProperty("errors")]
        public List<ErrorValidationItem>? Errors { get; set; } = null;

        [JsonProperty("warnings")]
        public List<ErrorValidationItem>? Warnings { get; set; } = null;
    }
}