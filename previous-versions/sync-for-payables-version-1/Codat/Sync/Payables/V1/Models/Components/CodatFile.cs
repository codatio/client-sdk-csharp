//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.V1.Models.Components
{
    using Codat.Sync.Payables.V1.Utils;
    
    public class CodatFile
    {

        [SpeakeasyMetadata("multipartForm:name=fileName")]
        public string FileName { get; set; } = default!;

        [SpeakeasyMetadata("multipartForm:content")]
        public byte[] Content { get; set; } = default!;
    }
}