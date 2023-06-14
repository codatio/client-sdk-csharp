
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.Categories
{
    using Codat.Utils;
    using Codat.Models.Shared;
    using NodaTime;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http;
    using System.Text;
    
public class UpdateAccountCategoryRequest
{
    [JsonProperty("ConfirmCategory")]
    public ConfirmCategory? ConfirmCategory { get; set; }
    
    [JsonProperty("accountId")]
    public string AccountId { get; set; }
    
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("connectionId")]
    public string ConnectionId { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, UpdateAccountCategoryRequest value, string baseUrl)
    {
        if("update-account-category" == operationId)
        {
            // add path params
            
            
            var accountId = PathParamSerializer.Serialize("simple", false, value.AccountId);
            
            var companyId = PathParamSerializer.Serialize("simple", false, value.CompanyId);
            
            var connectionId = PathParamSerializer.Serialize("simple", false, value.ConnectionId);
            var message = new HttpRequestMessage(HttpMethod.Patch, baseUrl + $"/data/companies/{companyId}/connections/{connectionId}/assess/accounts/{accountId}/categories");

            string json = JsonConvert.SerializeObject(value.ConfirmCategory);
            message.Content = new StringContent(json, Encoding.UTF8, "application/json");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [UpdateAccountCategoryRequest]");
    }
}
}