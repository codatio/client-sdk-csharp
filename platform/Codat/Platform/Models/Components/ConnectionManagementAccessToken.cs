//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Platform.Models.Components
{
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    
    public class ConnectionManagementAccessToken
    {

        /// <summary>
        /// Access token that allows SMBs to manage connections that have access to their data.
        /// </summary>
        [JsonProperty("accessToken")]
        public string? AccessToken { get; set; }
    }
}