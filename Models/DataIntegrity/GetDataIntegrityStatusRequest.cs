
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Codat.Models.DataIntegrity
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
    
public class GetDataIntegrityStatusRequest
{
    [JsonProperty("companyId")]
    public string CompanyId { get; set; }
    
    [JsonProperty("dataType")]
    public DataIntegrityDataType DataType { get; set; }
    
    internal static HttpRequestMessage BuildHttpRequestMessage(string operationId, GetDataIntegrityStatusRequest value, string baseUrl)
    {
        if("get-data-integrity-status" == operationId)
        {
            
            var companyId = PathParamSerializer.Serialize("simple", false, value.CompanyId);
            
            var dataType = PathParamSerializer.Serialize("simple", false, value.DataType);
            var message = new HttpRequestMessage(HttpMethod.Get, baseUrl + $"/data/companies/{companyId}/assess/dataTypes/{dataType}/dataIntegrity/status");
            return message;
        }
        throw new ArgumentException($"Attempt to build HttpRequestMessage for invalid operationId [{operationId}] for request type [GetDataIntegrityStatusRequest]");
    }
}
}