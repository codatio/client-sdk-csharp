//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Operations
{
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using System;
    

    public class ResponseBody1Type
    {
        private ResponseBody1Type(string value) { Value = value; }

        public string Value { get; private set; }
        public static ResponseBody1Type SourceAccountV2BatchCreateResponse { get { return new ResponseBody1Type("SourceAccountV2BatchCreateResponse"); } }
        
        public static ResponseBody1Type SourceAccountBatchCreateResponse { get { return new ResponseBody1Type("SourceAccountBatchCreateResponse"); } }
        
        public static ResponseBody1Type SourceAccountBatchErrorResponse { get { return new ResponseBody1Type("SourceAccountBatchErrorResponse"); } }
        
        public static ResponseBody1Type Null { get { return new ResponseBody1Type("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(ResponseBody1Type v) { return v.Value; }
        public static ResponseBody1Type FromString(string v) {
            switch(v) {
                case "SourceAccountV2BatchCreateResponse": return SourceAccountV2BatchCreateResponse;
                case "SourceAccountBatchCreateResponse": return SourceAccountBatchCreateResponse;
                case "SourceAccountBatchErrorResponse": return SourceAccountBatchErrorResponse;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for ResponseBody1Type");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((ResponseBody1Type)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(ResponseBody1.ResponseBody1Converter))]
    public class ResponseBody1 {
        public ResponseBody1(ResponseBody1Type type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountV2BatchCreateResponse? SourceAccountV2BatchCreateResponse { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountBatchCreateResponse? SourceAccountBatchCreateResponse { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountBatchErrorResponse? SourceAccountBatchErrorResponse { get; set; }

        public ResponseBody1Type Type { get; set; }


        public static ResponseBody1 CreateSourceAccountV2BatchCreateResponse(SourceAccountV2BatchCreateResponse sourceAccountV2BatchCreateResponse) {
            ResponseBody1Type typ = ResponseBody1Type.SourceAccountV2BatchCreateResponse;

            ResponseBody1 res = new ResponseBody1(typ);
            res.SourceAccountV2BatchCreateResponse = sourceAccountV2BatchCreateResponse;
            return res;
        }

        public static ResponseBody1 CreateSourceAccountBatchCreateResponse(SourceAccountBatchCreateResponse sourceAccountBatchCreateResponse) {
            ResponseBody1Type typ = ResponseBody1Type.SourceAccountBatchCreateResponse;

            ResponseBody1 res = new ResponseBody1(typ);
            res.SourceAccountBatchCreateResponse = sourceAccountBatchCreateResponse;
            return res;
        }

        public static ResponseBody1 CreateSourceAccountBatchErrorResponse(SourceAccountBatchErrorResponse sourceAccountBatchErrorResponse) {
            ResponseBody1Type typ = ResponseBody1Type.SourceAccountBatchErrorResponse;

            ResponseBody1 res = new ResponseBody1(typ);
            res.SourceAccountBatchErrorResponse = sourceAccountBatchErrorResponse;
            return res;
        }

        public static ResponseBody1 CreateNull() {
            ResponseBody1Type typ = ResponseBody1Type.Null;
            return new ResponseBody1(typ);
        }

        public class ResponseBody1Converter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(ResponseBody1);

            public override bool CanRead => true;

            public override object? ReadJson(JsonReader reader, System.Type objectType, object? existingValue, JsonSerializer serializer)
            {
                var json = JRaw.Create(reader).ToString();
                if (json == "null")
                {
                    return null;
                }

                var fallbackCandidates = new List<(System.Type, object, string)>();

                try
                {
                    return new ResponseBody1(ResponseBody1Type.SourceAccountV2BatchCreateResponse)
                    {
                        SourceAccountV2BatchCreateResponse = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountV2BatchCreateResponse>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountV2BatchCreateResponse), new ResponseBody1(ResponseBody1Type.SourceAccountV2BatchCreateResponse), "SourceAccountV2BatchCreateResponse"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new ResponseBody1(ResponseBody1Type.SourceAccountBatchCreateResponse)
                    {
                        SourceAccountBatchCreateResponse = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountBatchCreateResponse>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountBatchCreateResponse), new ResponseBody1(ResponseBody1Type.SourceAccountBatchCreateResponse), "SourceAccountBatchCreateResponse"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                try
                {
                    return new ResponseBody1(ResponseBody1Type.SourceAccountBatchErrorResponse)
                    {
                        SourceAccountBatchErrorResponse = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountBatchErrorResponse>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountBatchErrorResponse), new ResponseBody1(ResponseBody1Type.SourceAccountBatchErrorResponse), "SourceAccountBatchErrorResponse"));
                }
                catch (ResponseBodyDeserializer.DeserializationException)
                {
                    // try next option
                }
                catch (Exception)
                {
                    throw;
                }

                if (fallbackCandidates.Count > 0)
                {
                    fallbackCandidates.Sort((a, b) => ResponseBodyDeserializer.CompareFallbackCandidates(a.Item1, b.Item1, json));
                    foreach(var (deserializationType, returnObject, propertyName) in fallbackCandidates)
                    {
                        try
                        {
                            return ResponseBodyDeserializer.DeserializeUndiscriminatedUnionFallback(deserializationType, returnObject, propertyName, json);
                        }
                        catch (ResponseBodyDeserializer.DeserializationException)
                        {
                            // try next fallback option
                        }
                        catch (Exception)
                        {
                            throw;
                        }
                    }
                }

                throw new InvalidOperationException("Could not deserialize into any supported types.");
            }

            public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
            {
                if (value == null) {
                    writer.WriteRawValue("null");
                    return;
                }
                ResponseBody1 res = (ResponseBody1)value;
                if (ResponseBody1Type.FromString(res.Type).Equals(ResponseBody1Type.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.SourceAccountV2BatchCreateResponse != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SourceAccountV2BatchCreateResponse));
                    return;
                }
                if (res.SourceAccountBatchCreateResponse != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SourceAccountBatchCreateResponse));
                    return;
                }
                if (res.SourceAccountBatchErrorResponse != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SourceAccountBatchErrorResponse));
                    return;
                }

            }

        }

    }
}