//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Sync.Payables.Models.Requests
{
    using Codat.Sync.Payables.Models.Components;
    using Codat.Sync.Payables.Utils;
    using Newtonsoft.Json;
    
    public class UnlinkConnectionUpdateConnection
    {

        /// <summary>
        /// The current authorization status of the data connection.
        /// </summary>
        [JsonProperty("status")]
        public DataConnectionStatus? Status { get; set; }
    }
}