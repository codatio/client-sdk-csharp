
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Commerce.Models.Operations
{
    using Codat.Sync.Commerce.Models.Shared;
    using Codat.Sync.Commerce.Utils;
    
    public class GetConfigTextSyncFlowRequest
    {

        /// <summary>
        /// Localization identifier for English (US) or French.
        /// </summary>
        [SpeakeasyMetadata("queryParam:style=form,explode=true,name=locale")]
        public Locale Locale { get; set; } = default!;
    }
}