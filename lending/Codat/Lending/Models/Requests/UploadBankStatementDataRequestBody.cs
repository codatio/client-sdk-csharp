//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasy.com). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace Codat.Lending.Models.Requests
{
    using Codat.Lending.Models.Components;
    using Codat.Lending.Utils;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    

    public class UploadBankStatementDataRequestBodyType
    {
        private UploadBankStatementDataRequestBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static UploadBankStatementDataRequestBodyType BankingAccount { get { return new UploadBankStatementDataRequestBodyType("BankingAccount"); } }
        
        public static UploadBankStatementDataRequestBodyType BankingTransactions { get { return new UploadBankStatementDataRequestBodyType("BankingTransactions"); } }
        
        public static UploadBankStatementDataRequestBodyType Any { get { return new UploadBankStatementDataRequestBodyType("any"); } }
        
        public static UploadBankStatementDataRequestBodyType Null { get { return new UploadBankStatementDataRequestBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(UploadBankStatementDataRequestBodyType v) { return v.Value; }
        public static UploadBankStatementDataRequestBodyType FromString(string v) {
            switch(v) {
                case "BankingAccount": return BankingAccount;
                case "BankingTransactions": return BankingTransactions;
                case "any": return Any;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for UploadBankStatementDataRequestBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((UploadBankStatementDataRequestBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    [JsonConverter(typeof(UploadBankStatementDataRequestBody.UploadBankStatementDataRequestBodyConverter))]
    public class UploadBankStatementDataRequestBody {
        public UploadBankStatementDataRequestBody(UploadBankStatementDataRequestBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public BankingAccount? BankingAccount { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public BankingTransactions? BankingTransactions { get; set; }

        [SpeakeasyMetadata("form:explode=true")]
        public object? Any { get; set; }

        public UploadBankStatementDataRequestBodyType Type { get; set; }


        public static UploadBankStatementDataRequestBody CreateBankingAccount(BankingAccount bankingAccount) {
            UploadBankStatementDataRequestBodyType typ = UploadBankStatementDataRequestBodyType.BankingAccount;

            UploadBankStatementDataRequestBody res = new UploadBankStatementDataRequestBody(typ);
            res.BankingAccount = bankingAccount;
            return res;
        }

        public static UploadBankStatementDataRequestBody CreateBankingTransactions(BankingTransactions bankingTransactions) {
            UploadBankStatementDataRequestBodyType typ = UploadBankStatementDataRequestBodyType.BankingTransactions;

            UploadBankStatementDataRequestBody res = new UploadBankStatementDataRequestBody(typ);
            res.BankingTransactions = bankingTransactions;
            return res;
        }

        public static UploadBankStatementDataRequestBody CreateAny(object any) {
            UploadBankStatementDataRequestBodyType typ = UploadBankStatementDataRequestBodyType.Any;

            UploadBankStatementDataRequestBody res = new UploadBankStatementDataRequestBody(typ);
            res.Any = any;
            return res;
        }

        public static UploadBankStatementDataRequestBody CreateNull() {
            UploadBankStatementDataRequestBodyType typ = UploadBankStatementDataRequestBodyType.Null;
            return new UploadBankStatementDataRequestBody(typ);
        }

        public class UploadBankStatementDataRequestBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(UploadBankStatementDataRequestBody);

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
                    return new UploadBankStatementDataRequestBody(UploadBankStatementDataRequestBodyType.BankingTransactions)
                    {
                        BankingTransactions = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<BankingTransactions>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(BankingTransactions), new UploadBankStatementDataRequestBody(UploadBankStatementDataRequestBodyType.BankingTransactions), "BankingTransactions"));
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
                    return new UploadBankStatementDataRequestBody(UploadBankStatementDataRequestBodyType.BankingAccount)
                    {
                        BankingAccount = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<BankingAccount>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(BankingAccount), new UploadBankStatementDataRequestBody(UploadBankStatementDataRequestBodyType.BankingAccount), "BankingAccount"));
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
                    return new UploadBankStatementDataRequestBody(UploadBankStatementDataRequestBodyType.Any)
                    {
                        Any = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<object>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(object), new UploadBankStatementDataRequestBody(UploadBankStatementDataRequestBodyType.Any), "Any"));
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
                UploadBankStatementDataRequestBody res = (UploadBankStatementDataRequestBody)value;
                if (UploadBankStatementDataRequestBodyType.FromString(res.Type).Equals(UploadBankStatementDataRequestBodyType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.BankingAccount != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.BankingAccount));
                    return;
                }
                if (res.BankingTransactions != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.BankingTransactions));
                    return;
                }
                if (res.Any != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.Any));
                    return;
                }

            }

        }

    }
}