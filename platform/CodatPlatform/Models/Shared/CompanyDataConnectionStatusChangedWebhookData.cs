
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatPlatform.Models.Shared
{
    using Newtonsoft.Json;
    
    public class CompanyDataConnectionStatusChangedWebhookData
    {

        /// <summary>
        /// Unique identifier for a company&amp;apos;s data connection.
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
        /// A unique 4-letter key to represent a platform in each integration. View &lt;a href=&quot;https://docs.codat.io/integrations/accounting/accounting-platform-keys&quot;&gt;accounting&lt;/a&gt;, &lt;a href=&quot;https://docs.codat.io/integrations/banking/banking-platform-keys&quot;&gt;banking&lt;/a&gt;, and &lt;a href=&quot;https://docs.codat.io/integrations/commerce/commerce-platform-keys&quot;&gt;commerce&lt;/a&gt; platform keys. 
        /// </summary>
        [JsonProperty("platformKey")]
        public string? PlatformKey { get; set; }
    }
}