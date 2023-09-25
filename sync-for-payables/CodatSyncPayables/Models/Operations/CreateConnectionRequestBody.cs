
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncPayables.Models.Operations
{
    using Newtonsoft.Json;
    
    public class CreateConnectionRequestBody
    {

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration. View &lt;a href=&quot;https://docs.codat.io/integrations/accounting/overview#platform-keys&quot;&gt;accounting&lt;/a&gt;, &lt;a href=&quot;https://docs.codat.io/integrations/banking/overview#platform-keys&quot;&gt;banking&lt;/a&gt;, and &lt;a href=&quot;https://docs.codat.io/integrations/commerce/overview#platform-keys&quot;&gt;commerce&lt;/a&gt; platform keys.
        /// </summary>
        [JsonProperty("platformKey")]
        public string? PlatformKey { get; set; }
    }
}