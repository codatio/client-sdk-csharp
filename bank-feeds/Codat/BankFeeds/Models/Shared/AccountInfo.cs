//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json;
    
    public class AccountInfo
    {

        /// <summary>
        /// Description of the account.
        /// </summary>
        [JsonProperty("description")]
        public string? Description { get; set; } = null;

        /// <summary>
        /// Name given to the account by the user. Used in UIs to assist in account selection.
        /// </summary>
        [JsonProperty("nickname")]
        public string? Nickname { get; set; } = null;

        /// <summary>
        /// In Codat&apos;s data model, dates are represented using the &lt;a class=&quot;external&quot; href=&quot;https://en.wikipedia.org/wiki/ISO_8601&quot; target=&quot;_blank&quot;&gt;ISO 8601 standard&lt;/a&gt;. Date fields are formatted as strings; for example:<br/>
        /// 
        /// <remarks>
        /// ```<br/>
        /// 2020-10-08<br/>
        /// ```
        /// </remarks>
        /// </summary>
        [JsonProperty("accountOpenDate")]
        public string? AccountOpenDate { get; set; } = null;

        /// <summary>
        /// Balance of funds available for use. This includes pending activity.
        /// </summary>
        [JsonProperty("availableBalance")]
        public decimal? AvailableBalance { get; set; } = null;
    }
}