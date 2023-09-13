
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
    
    
    /// <summary>
    /// Information about the total inventory as well as the locations inventory is in.
    /// </summary>
    public class ProductInventory
    {
        [JsonProperty("locations")]
        public List<ProductInventoryLocation>? Locations { get; set; }
        
        [JsonProperty("totalQuantity")]
        public float? TotalQuantity { get; set; }
        
    }
    
}