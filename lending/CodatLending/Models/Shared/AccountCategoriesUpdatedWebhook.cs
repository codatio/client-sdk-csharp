
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatLending.Models.Shared
{
    using Newtonsoft.Json;
    
    /// <summary>
    /// Webhook request body for account categories updated.
    /// </summary>
    public class AccountCategoriesUpdatedWebhook
    {

        /// <summary>
        /// Unique identifier of the webhook event.
        /// </summary>
        [JsonProperty("AlertId")]
        public string? AlertId { get; set; }

        /// <summary>
        /// Unique identifier for your client in Codat.
        /// </summary>
        [JsonProperty("ClientId")]
        public string? ClientId { get; set; }

        /// <summary>
        /// Name of your client in Codat.
        /// </summary>
        [JsonProperty("ClientName")]
        public string? ClientName { get; set; }

        /// <summary>
        /// Unique identifier for your SMB in Codat.
        /// </summary>
        [JsonProperty("CompanyId")]
        public string? CompanyId { get; set; }

        [JsonProperty("Data")]
        public AccountCategoriesUpdatedWebhookData? Data { get; set; }

        /// <summary>
        /// Unique identifier for a company&apos;s data connection.
        /// </summary>
        [JsonProperty("DataConnectionId")]
        public string? DataConnectionId { get; set; }

        /// <summary>
        /// A human readable message about the webhook.
        /// </summary>
        [JsonProperty("Message")]
        public string? Message { get; set; }

        /// <summary>
        /// Unique identifier for the rule.
        /// </summary>
        [JsonProperty("RuleId")]
        public string? RuleId { get; set; }

        /// <summary>
        /// The type of rule.
        /// </summary>
        [JsonProperty("RuleType")]
        public string? RuleType { get; set; }
    }
}