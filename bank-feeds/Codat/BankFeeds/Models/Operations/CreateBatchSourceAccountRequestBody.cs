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
    

    public class CreateBatchSourceAccountRequestBodyType
    {
        private CreateBatchSourceAccountRequestBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CreateBatchSourceAccountRequestBodyType ArrayOfSourceAccountV2 { get { return new CreateBatchSourceAccountRequestBodyType("arrayOfSourceAccountV2"); } }
        
        public static CreateBatchSourceAccountRequestBodyType ArrayOfSourceAccount { get { return new CreateBatchSourceAccountRequestBodyType("arrayOfSourceAccount"); } }
        
        public static CreateBatchSourceAccountRequestBodyType Null { get { return new CreateBatchSourceAccountRequestBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CreateBatchSourceAccountRequestBodyType v) { return v.Value; }
        public static CreateBatchSourceAccountRequestBodyType FromString(string v) {
            switch(v) {
                case "arrayOfSourceAccountV2": return ArrayOfSourceAccountV2;
                case "arrayOfSourceAccount": return ArrayOfSourceAccount;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CreateBatchSourceAccountRequestBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CreateBatchSourceAccountRequestBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(CreateBatchSourceAccountRequestBody.CreateBatchSourceAccountRequestBodyConverter))]
    public class CreateBatchSourceAccountRequestBody {
        public CreateBatchSourceAccountRequestBody(CreateBatchSourceAccountRequestBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public List<SourceAccountV2>? ArrayOfSourceAccountV2 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public List<SourceAccount>? ArrayOfSourceAccount { get; set; }

        public CreateBatchSourceAccountRequestBodyType Type { get; set; }


        public static CreateBatchSourceAccountRequestBody CreateArrayOfSourceAccountV2(List<SourceAccountV2> arrayOfSourceAccountV2) {
            CreateBatchSourceAccountRequestBodyType typ = CreateBatchSourceAccountRequestBodyType.ArrayOfSourceAccountV2;

            CreateBatchSourceAccountRequestBody res = new CreateBatchSourceAccountRequestBody(typ);
            res.ArrayOfSourceAccountV2 = arrayOfSourceAccountV2;
            return res;
        }

        public static CreateBatchSourceAccountRequestBody CreateArrayOfSourceAccount(List<SourceAccount> arrayOfSourceAccount) {
            CreateBatchSourceAccountRequestBodyType typ = CreateBatchSourceAccountRequestBodyType.ArrayOfSourceAccount;

            CreateBatchSourceAccountRequestBody res = new CreateBatchSourceAccountRequestBody(typ);
            res.ArrayOfSourceAccount = arrayOfSourceAccount;
            return res;
        }

        public static CreateBatchSourceAccountRequestBody CreateNull() {
            CreateBatchSourceAccountRequestBodyType typ = CreateBatchSourceAccountRequestBodyType.Null;
            return new CreateBatchSourceAccountRequestBody(typ);
        }

        public class CreateBatchSourceAccountRequestBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CreateBatchSourceAccountRequestBody);

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
                    return new CreateBatchSourceAccountRequestBody(CreateBatchSourceAccountRequestBodyType.ArrayOfSourceAccountV2)
                    {
                        ArrayOfSourceAccountV2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<SourceAccountV2>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<SourceAccountV2>), new CreateBatchSourceAccountRequestBody(CreateBatchSourceAccountRequestBodyType.ArrayOfSourceAccountV2), "ArrayOfSourceAccountV2"));
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
                    return new CreateBatchSourceAccountRequestBody(CreateBatchSourceAccountRequestBodyType.ArrayOfSourceAccount)
                    {
                        ArrayOfSourceAccount = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<SourceAccount>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<SourceAccount>), new CreateBatchSourceAccountRequestBody(CreateBatchSourceAccountRequestBodyType.ArrayOfSourceAccount), "ArrayOfSourceAccount"));
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
                CreateBatchSourceAccountRequestBody res = (CreateBatchSourceAccountRequestBody)value;
                if (CreateBatchSourceAccountRequestBodyType.FromString(res.Type).Equals(CreateBatchSourceAccountRequestBodyType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfSourceAccountV2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfSourceAccountV2));
                    return;
                }
                if (res.ArrayOfSourceAccount != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfSourceAccount));
                    return;
                }

            }

        }

    }
}