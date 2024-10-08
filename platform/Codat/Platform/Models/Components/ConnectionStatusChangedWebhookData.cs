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
    using Codat.Platform.Models.Components;
    using Codat.Platform.Utils;
    using Newtonsoft.Json;
    
    public class ConnectionStatusChangedWebhookData
    {

        /// <summary>
        /// Unique identifier for a company&apos;s data connection.
        /// </summary>
        [JsonProperty("dataConnectionId")]
        public string? DataConnectionId { get; set; }

        /// <summary>
        /// The current authorization status of the data connection.
        /// </summary>
        [JsonProperty("newStatus")]
        public DataConnectionStatus? NewStatus { get; set; }

        /// <summary>
        /// The current authorization status of the data connection.
        /// </summary>
        [JsonProperty("oldStatus")]
        public DataConnectionStatus? OldStatus { get; set; }

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration. View <a href="https://docs.codat.io/integrations/accounting/overview#platform-keys">accounting</a>, <a href="https://docs.codat.io/integrations/banking/overview#platform-keys">banking</a>, and <a href="https://docs.codat.io/integrations/commerce/overview#platform-keys">commerce</a> platform keys.
        /// </summary>
        [JsonProperty("platformKey")]
        public string? PlatformKey { get; set; }
    }
}