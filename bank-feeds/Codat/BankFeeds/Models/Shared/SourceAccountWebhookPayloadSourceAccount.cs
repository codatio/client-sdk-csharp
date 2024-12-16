//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.BankFeeds.Models.Shared
{
    using Codat.BankFeeds.Models.Shared;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using System;
    

    public class SourceAccountWebhookPayloadSourceAccountType
    {
        private SourceAccountWebhookPayloadSourceAccountType(string value) { Value = value; }

        public string Value { get; private set; }
        public static SourceAccountWebhookPayloadSourceAccountType SourceAccountV2 { get { return new SourceAccountWebhookPayloadSourceAccountType("SourceAccountV2"); } }
        
        public static SourceAccountWebhookPayloadSourceAccountType SourceAccount { get { return new SourceAccountWebhookPayloadSourceAccountType("SourceAccount"); } }
        
        public static SourceAccountWebhookPayloadSourceAccountType Null { get { return new SourceAccountWebhookPayloadSourceAccountType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(SourceAccountWebhookPayloadSourceAccountType v) { return v.Value; }
        public static SourceAccountWebhookPayloadSourceAccountType FromString(string v) {
            switch(v) {
                case "SourceAccountV2": return SourceAccountV2;
                case "SourceAccount": return SourceAccount;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for SourceAccountWebhookPayloadSourceAccountType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((SourceAccountWebhookPayloadSourceAccountType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(SourceAccountWebhookPayloadSourceAccount.SourceAccountWebhookPayloadSourceAccountConverter))]
    public class SourceAccountWebhookPayloadSourceAccount {
        public SourceAccountWebhookPayloadSourceAccount(SourceAccountWebhookPayloadSourceAccountType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccountV2? SourceAccountV2 { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public SourceAccount? SourceAccount { get; set; }

        public SourceAccountWebhookPayloadSourceAccountType Type { get; set; }


        public static SourceAccountWebhookPayloadSourceAccount CreateSourceAccountV2(SourceAccountV2 sourceAccountV2) {
            SourceAccountWebhookPayloadSourceAccountType typ = SourceAccountWebhookPayloadSourceAccountType.SourceAccountV2;

            SourceAccountWebhookPayloadSourceAccount res = new SourceAccountWebhookPayloadSourceAccount(typ);
            res.SourceAccountV2 = sourceAccountV2;
            return res;
        }

        public static SourceAccountWebhookPayloadSourceAccount CreateSourceAccount(SourceAccount sourceAccount) {
            SourceAccountWebhookPayloadSourceAccountType typ = SourceAccountWebhookPayloadSourceAccountType.SourceAccount;

            SourceAccountWebhookPayloadSourceAccount res = new SourceAccountWebhookPayloadSourceAccount(typ);
            res.SourceAccount = sourceAccount;
            return res;
        }

        public static SourceAccountWebhookPayloadSourceAccount CreateNull() {
            SourceAccountWebhookPayloadSourceAccountType typ = SourceAccountWebhookPayloadSourceAccountType.Null;
            return new SourceAccountWebhookPayloadSourceAccount(typ);
        }

        public class SourceAccountWebhookPayloadSourceAccountConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(SourceAccountWebhookPayloadSourceAccount);

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
                    return new SourceAccountWebhookPayloadSourceAccount(SourceAccountWebhookPayloadSourceAccountType.SourceAccount)
                    {
                        SourceAccount = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccount>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccount), new SourceAccountWebhookPayloadSourceAccount(SourceAccountWebhookPayloadSourceAccountType.SourceAccount), "SourceAccount"));
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
                    return new SourceAccountWebhookPayloadSourceAccount(SourceAccountWebhookPayloadSourceAccountType.SourceAccountV2)
                    {
                        SourceAccountV2 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<SourceAccountV2>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(SourceAccountV2), new SourceAccountWebhookPayloadSourceAccount(SourceAccountWebhookPayloadSourceAccountType.SourceAccountV2), "SourceAccountV2"));
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
                SourceAccountWebhookPayloadSourceAccount res = (SourceAccountWebhookPayloadSourceAccount)value;
                if (SourceAccountWebhookPayloadSourceAccountType.FromString(res.Type).Equals(SourceAccountWebhookPayloadSourceAccountType.Null))
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