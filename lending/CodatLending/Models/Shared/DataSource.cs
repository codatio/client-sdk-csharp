
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
    using System.Collections.Generic;
    
    public class DataSource
    {

        /// <summary>
        /// An array containing bank account data for each connected banking data source that have the following data types enabled: `banking-accounts`, `banking-transactions`.
        /// </summary>
        [JsonProperty("accounts")]
        public List<Accounts>? Accounts { get; set; }
    }
}