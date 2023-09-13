
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Models.Shared
{
    using Newtonsoft.Json;
    using System;
    
    
    /// <summary>
    /// The status of the push operation.
    /// </summary>
    public enum PushOperationStatus
    {
    	[JsonProperty("Pending")]
		Pending,
		[JsonProperty("Failed")]
		Failed,
		[JsonProperty("Success")]
		Success,
		[JsonProperty("TimedOut")]
		TimedOut,
    }
    
    public static class PushOperationStatusExtension
    {
        public static string Value(this PushOperationStatus value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static PushOperationStatus ToEnum(this string value)
        {
            foreach(var field in typeof(PushOperationStatus).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is PushOperationStatus)
                    {
                        return (PushOperationStatus)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum PushOperationStatus");
        }
    }
    
}