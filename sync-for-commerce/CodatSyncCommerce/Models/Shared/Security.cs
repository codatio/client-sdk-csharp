
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Shared
{
    using CodatSyncCommerce.Utils;
    
    public class Security
    {

        [SpeakeasyMetadata("security:scheme=true,type=apiKey,subType=header,name=Authorization")]
        public string AuthHeader { get; set; } = default!;
    }
}