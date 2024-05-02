
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Shared
{
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using System;
    
    /// <summary>
    /// The source of the banking data that determines its format
    /// </summary>
    public enum Source
    {
        [JsonProperty("codat")]
        Codat,
    }

    public static class SourceExtension
    {
        public static string Value(this Source value)
        {
            return ((JsonPropertyAttribute)value.GetType().GetMember(value.ToString())[0].GetCustomAttributes(typeof(JsonPropertyAttribute), false)[0]).PropertyName ?? value.ToString();
        }

        public static Source ToEnum(this string value)
        {
            foreach(var field in typeof(Source).GetFields())
            {
                var attributes = field.GetCustomAttributes(typeof(JsonPropertyAttribute), false);
                if (attributes.Length == 0)
                {
                    continue;
                }

                var attribute = attributes[0] as JsonPropertyAttribute;
                if (attribute != null && attribute.PropertyName == value)
                {
                    var enumVal = field.GetValue(null);

                    if (enumVal is Source)
                    {
                        return (Source)enumVal;
                    }
                }
            }

            throw new Exception($"Unknown value {value} for enum Source");
        }
    }

}