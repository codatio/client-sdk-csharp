//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Components
{
    using Codat.Sync.Payables.Models.Components;
    using Codat.Sync.Payables.Utils;
    
    public class AttachmentUpload
    {

        /// <summary>
        /// The file to be uploaded as an attachment.
        /// </summary>
        [SpeakeasyMetadata("multipartForm:file")]
        public CodatFile File { get; set; } = default!;
    }
}