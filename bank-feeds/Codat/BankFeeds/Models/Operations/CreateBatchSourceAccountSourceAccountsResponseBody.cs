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
    using Codat.BankFeeds.Models.Operations;
    using Codat.BankFeeds.Utils;
    using Newtonsoft.Json.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System.Numerics;
    using System.Reflection;
    using System;
    

    public class CreateBatchSourceAccountSourceAccountsResponseBodyType
    {
        private CreateBatchSourceAccountSourceAccountsResponseBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CreateBatchSourceAccountSourceAccountsResponseBodyType ArrayOfResponseBody1 { get { return new CreateBatchSourceAccountSourceAccountsResponseBodyType("arrayOfResponseBody1"); } }
        
        public static CreateBatchSourceAccountSourceAccountsResponseBodyType Null { get { return new CreateBatchSourceAccountSourceAccountsResponseBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CreateBatchSourceAccountSourceAccountsResponseBodyType v) { return v.Value; }
        public static CreateBatchSourceAccountSourceAccountsResponseBodyType FromString(string v) {
            switch(v) {
                case "arrayOfResponseBody1": return ArrayOfResponseBody1;
                case "null": return Null;
                default: throw new ArgumentException("Invalid value for CreateBatchSourceAccountSourceAccountsResponseBodyType");
            }
        }
        public override bool Equals(object? obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            return Value.Equals(((CreateBatchSourceAccountSourceAccountsResponseBodyType)obj).Value);
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }
    }


    /// <summary>
    /// Multi-Status
    /// </summary>
    [JsonConverter(typeof(CreateBatchSourceAccountSourceAccountsResponseBody.CreateBatchSourceAccountSourceAccountsResponseBodyConverter))]
    public class CreateBatchSourceAccountSourceAccountsResponseBody {
        public CreateBatchSourceAccountSourceAccountsResponseBody(CreateBatchSourceAccountSourceAccountsResponseBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public List<ResponseBody1>? ArrayOfResponseBody1 { get; set; }

        public CreateBatchSourceAccountSourceAccountsResponseBodyType Type { get; set; }


        public static CreateBatchSourceAccountSourceAccountsResponseBody CreateArrayOfResponseBody1(List<ResponseBody1> arrayOfResponseBody1) {
            CreateBatchSourceAccountSourceAccountsResponseBodyType typ = CreateBatchSourceAccountSourceAccountsResponseBodyType.ArrayOfResponseBody1;

            CreateBatchSourceAccountSourceAccountsResponseBody res = new CreateBatchSourceAccountSourceAccountsResponseBody(typ);
            res.ArrayOfResponseBody1 = arrayOfResponseBody1;
            return res;
        }

        public static CreateBatchSourceAccountSourceAccountsResponseBody CreateNull() {
            CreateBatchSourceAccountSourceAccountsResponseBodyType typ = CreateBatchSourceAccountSourceAccountsResponseBodyType.Null;
            return new CreateBatchSourceAccountSourceAccountsResponseBody(typ);
        }

        public class CreateBatchSourceAccountSourceAccountsResponseBodyConverter : JsonConverter
        {

            public override bool CanConvert(System.Type objectType) => objectType == typeof(CreateBatchSourceAccountSourceAccountsResponseBody);

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
                    return new CreateBatchSourceAccountSourceAccountsResponseBody(CreateBatchSourceAccountSourceAccountsResponseBodyType.ArrayOfResponseBody1)
                    {
                        ArrayOfResponseBody1 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<ResponseBody1>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<ResponseBody1>), new CreateBatchSourceAccountSourceAccountsResponseBody(CreateBatchSourceAccountSourceAccountsResponseBodyType.ArrayOfResponseBody1), "ArrayOfResponseBody1"));
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
                CreateBatchSourceAccountSourceAccountsResponseBody res = (CreateBatchSourceAccountSourceAccountsResponseBody)value;
                if (CreateBatchSourceAccountSourceAccountsResponseBodyType.FromString(res.Type).Equals(CreateBatchSourceAccountSourceAccountsResponseBodyType.Null))
                {
                    writer.WriteRawValue("null");
                    return;
                }
                if (res.ArrayOfResponseBody1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOfResponseBody1));
                    return;
                }

            }

        }

    }
}