
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Codat.Lending.Utils;
    
    public class CodatFile
    {

        [SpeakeasyMetadata("multipartForm:content")]
        public byte[] Content { get; set; } = default!;

        [SpeakeasyMetadata("multipartForm:name=fileName")]
        public string FileName { get; set; } = default!;
    }
}