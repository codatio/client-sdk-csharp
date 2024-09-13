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
    

    public class CreateSourceAccountResponseBodyType
    {
        private CreateSourceAccountResponseBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CreateSourceAccountResponseBodyType SourceAccountV2 { get { return new CreateSourceAccountResponseBodyType("SourceAccountV2"); } }
        
        public static CreateSourceAccountResponseBodyType SourceAccount { get { return new CreateSourceAccountResponseBodyType("SourceAccount"); } }
        
        public static CreateSourceAccountResponseBodyType Null { get { return new CreateSourceAccountResponseBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CreateSourceAccountResponseBodyType v) { return v.Value; }
        public static CreateSourceAccountResponseBodyType FromString(string v) {
            switch(v) {
                case "SourceAccountV2": return SourceAccountV2;
                case "SourceAccount": return SourceAccount;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CreateSourceAccountResponseBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CreateSourceAccountResponseBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// Success
    /// </summary>
    [JsonConverter(typeof(CreateSourceAccountResponseBody.CreateSourceAccountResponseBodyConverter))]
    public class CreateSourceAccountResponseBody {
        public CreateSourceAccountResponseBody(CreateSourceAccountResponseBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountV2? SourceAccountV2 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccount? SourceAccount { get; set; }

        public CreateSourceAccountResponseBodyType Type { get; set; }


        public static CreateSourceAccountResponseBody CreateSourceAccountV2(SourceAccountV2 sourceAccountV2) {
            CreateSourceAccountResponseBodyType typ = CreateSourceAccountResponseBodyType.SourceAccountV2;

            CreateSourceAccountResponseBody res = new CreateSourceAccountResponseBody(typ);
            res.SourceAccountV2 = sourceAccountV2;
            return res;
        }

        public static CreateSourceAccountResponseBody CreateSourceAccount(SourceAccount sourceAccount) {
            CreateSourceAccountResponseBodyType typ = CreateSourceAccountResponseBodyType.SourceAccount;

            CreateSourceAccountResponseBody res = new CreateSourceAccountResponseBody(typ);
            res.SourceAccount = sourceAccount;
            return res;
        }

        public static CreateSourceAccountResponseBody CreateNull() {
            CreateSourceAccountResponseBodyType typ = CreateSourceAccountResponseBodyType.Null;
            return new CreateSourceAccountResponseBody(typ);
        }

        public class CreateSourceAccountResponseBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CreateSourceAccountResponseBody);

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
                    return new CreateSourceAccountResponseBody(CreateSourceAccountResponseBodyType.SourceAccount)
                    {
                        SourceAccount = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccount>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccount), new CreateSourceAccountResponseBody(CreateSourceAccountResponseBodyType.SourceAccount), "SourceAccount"));
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
                    return new CreateSourceAccountResponseBody(CreateSourceAccountResponseBodyType.SourceAccountV2)
                    {
                        SourceAccountV2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountV2>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountV2), new CreateSourceAccountResponseBody(CreateSourceAccountResponseBodyType.SourceAccountV2), "SourceAccountV2"));
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
                CreateSourceAccountResponseBody res = (CreateSourceAccountResponseBody)value;
                if (CreateSourceAccountResponseBodyType.FromString(res.Type).Equals(CreateSourceAccountResponseBodyType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.SourceAccountV2 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SourceAccountV2));
                    return;
                }
                if (res.SourceAccount != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.SourceAccount));
                    return;
                }

            }

        }

    }
}