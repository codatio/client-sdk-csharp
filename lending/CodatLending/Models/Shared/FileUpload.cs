
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
    
    public class FileUpload
    {

        /// <summary>
        /// The file to be uploaded as an attachment.
        /// </summary>
        [SpeakeasyMetadata("multipartForm:file")]
        public CodatFile File { get; set; } = default!;
    }
}