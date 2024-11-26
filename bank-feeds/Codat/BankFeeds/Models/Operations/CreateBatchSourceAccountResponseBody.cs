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
    

    public class CreateBatchSourceAccountResponseBodyType
    {
        private CreateBatchSourceAccountResponseBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CreateBatchSourceAccountResponseBodyType SourceAccountV2BatchCreateResponse { get { return new CreateBatchSourceAccountResponseBodyType("SourceAccountV2BatchCreateResponse"); } }
        
        public static CreateBatchSourceAccountResponseBodyType SourceAccountBatchCreateResponse { get { return new CreateBatchSourceAccountResponseBodyType("SourceAccountBatchCreateResponse"); } }
        
        public static CreateBatchSourceAccountResponseBodyType SourceAccountBatchErrorResponse { get { return new CreateBatchSourceAccountResponseBodyType("SourceAccountBatchErrorResponse"); } }
        
        public static CreateBatchSourceAccountResponseBodyType Null { get { return new CreateBatchSourceAccountResponseBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CreateBatchSourceAccountResponseBodyType v) { return v.Value; }
        public static CreateBatchSourceAccountResponseBodyType FromString(string v) {
            switch(v) {
                case "SourceAccountV2BatchCreateResponse": return SourceAccountV2BatchCreateResponse;
                case "SourceAccountBatchCreateResponse": return SourceAccountBatchCreateResponse;
                case "SourceAccountBatchErrorResponse": return SourceAccountBatchErrorResponse;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CreateBatchSourceAccountResponseBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CreateBatchSourceAccountResponseBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(CreateBatchSourceAccountResponseBody.CreateBatchSourceAccountResponseBodyConverter))]
    public class CreateBatchSourceAccountResponseBody {
        public CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountV2BatchCreateResponse? SourceAccountV2BatchCreateResponse { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountBatchCreateResponse? SourceAccountBatchCreateResponse { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountBatchErrorResponse? SourceAccountBatchErrorResponse { get; set; }

        public CreateBatchSourceAccountResponseBodyType Type { get; set; }


        public static CreateBatchSourceAccountResponseBody CreateSourceAccountV2BatchCreateResponse(SourceAccountV2BatchCreateResponse sourceAccountV2BatchCreateResponse) {
            CreateBatchSourceAccountResponseBodyType typ = CreateBatchSourceAccountResponseBodyType.SourceAccountV2BatchCreateResponse;

            CreateBatchSourceAccountResponseBody res = new CreateBatchSourceAccountResponseBody(typ);
            res.SourceAccountV2BatchCreateResponse = sourceAccountV2BatchCreateResponse;
            return res;
        }

        public static CreateBatchSourceAccountResponseBody CreateSourceAccountBatchCreateResponse(SourceAccountBatchCreateResponse sourceAccountBatchCreateResponse) {
            CreateBatchSourceAccountResponseBodyType typ = CreateBatchSourceAccountResponseBodyType.SourceAccountBatchCreateResponse;

            CreateBatchSourceAccountResponseBody res = new CreateBatchSourceAccountResponseBody(typ);
            res.SourceAccountBatchCreateResponse = sourceAccountBatchCreateResponse;
            return res;
        }

        public static CreateBatchSourceAccountResponseBody CreateSourceAccountBatchErrorResponse(SourceAccountBatchErrorResponse sourceAccountBatchErrorResponse) {
            CreateBatchSourceAccountResponseBodyType typ = CreateBatchSourceAccountResponseBodyType.SourceAccountBatchErrorResponse;

            CreateBatchSourceAccountResponseBody res = new CreateBatchSourceAccountResponseBody(typ);
            res.SourceAccountBatchErrorResponse = sourceAccountBatchErrorResponse;
            return res;
        }

        public static CreateBatchSourceAccountResponseBody CreateNull() {
            CreateBatchSourceAccountResponseBodyType typ = CreateBatchSourceAccountResponseBodyType.Null;
            return new CreateBatchSourceAccountResponseBody(typ);
        }

        public class CreateBatchSourceAccountResponseBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CreateBatchSourceAccountResponseBody);

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
                    return new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.SourceAccountV2BatchCreateResponse)
                    {
                        SourceAccountV2BatchCreateResponse = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountV2BatchCreateResponse>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountV2BatchCreateResponse), new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.SourceAccountV2BatchCreateResponse), "SourceAccountV2BatchCreateResponse"));
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
                    return new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.SourceAccountBatchCreateResponse)
                    {
                        SourceAccountBatchCreateResponse = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountBatchCreateResponse>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountBatchCreateResponse), new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.SourceAccountBatchCreateResponse), "SourceAccountBatchCreateResponse"));
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
                    return new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.SourceAccountBatchErrorResponse)
                    {
                        SourceAccountBatchErrorResponse = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountBatchErrorResponse>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountBatchErrorResponse), new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.SourceAccountBatchErrorResponse), "SourceAccountBatchErrorResponse"));
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
                CreateBatchSourceAccountResponseBody res = (CreateBatchSourceAccountResponseBody)value;
                if (CreateBatchSourceAccountResponseBodyType.FromString(res.Type).Equals(CreateBatchSourceAccountResponseBodyType.Null))
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