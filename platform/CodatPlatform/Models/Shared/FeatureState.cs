
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
    using System;
    
    
    public enum FeatureState
    {
    	[JsonProperty("Release")]
		Release,
		[JsonProperty("Alpha")]
		Alpha,
		[JsonProperty("Beta")]
		Beta,
		[JsonProperty("Deprecated")]
		Deprecated,
		[JsonProperty("NotSupported")]
		NotSupported,
		[JsonProperty("NotImplemented")]
		NotImplemented,
    }
    
    public static class FeatureStateExtension
    {
        public static string Value(this FeatureState value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static FeatureState ToEnum(this string value)
        {
            foreach(var field in typeof(FeatureState).GetFields())
            {
                var attribute = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is FeatureState)
                    {
                        return (FeatureState)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum FeatureState");
        }
    }
    
}