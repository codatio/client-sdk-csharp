
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Utils
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Reflection;
    using System.Text;
    using Newtonsoft.Json;


    internal class ResponseBodyDeserializer
    {

        public static T? Deserialize<T>(string json, NullValueHandling nullValueHandling=NullValueHandling.Ignore, MissingMemberHandling missingMemberHandling=MissingMemberHandling.Ignore)
        {
            return JsonConvert.DeserializeObject<T>(json, new JsonSerializerSettings(){ NullValueHandling = nullValueHandling, MissingMemberHandling = missingMemberHandling, Converters = Utilities.GetJsonDeserializers(typeof(T))});
        }
    }
}