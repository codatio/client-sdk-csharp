
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncCommerce.Models.Operations
{
    using Newtonsoft.Json;
    
    public class CreateConnectionRequestBody
    {

        /// <summary>
        /// A unique 4-letter key to represent a platform in each integration. View <a href="https://docs.codat.io/integrations/accounting/overview#platform-keys">accounting</a>, <a href="https://docs.codat.io/integrations/banking/overview#platform-keys">banking</a>, and <a href="https://docs.codat.io/integrations/commerce/overview#platform-keys">commerce</a> platform keys.
        /// </summary>
        [JsonProperty("platformKey")]
        public string? PlatformKey { get; set; }
    }
}