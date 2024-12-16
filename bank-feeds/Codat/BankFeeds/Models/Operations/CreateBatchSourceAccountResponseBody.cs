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
    

    public class CreateBatchSourceAccountResponseBodyType
    {
        private CreateBatchSourceAccountResponseBodyType(string value) { Value = value; }

        public string Value { get; private set; }
        public static CreateBatchSourceAccountResponseBodyType ArrayOf1 { get { return new CreateBatchSourceAccountResponseBodyType("arrayOf1"); } }
        
        public static CreateBatchSourceAccountResponseBodyType Null { get { return new CreateBatchSourceAccountResponseBodyType("null"); } }

        public override string ToString() { return Value; }
        public static implicit operator String(CreateBatchSourceAccountResponseBodyType v) { return v.Value; }
        public static CreateBatchSourceAccountResponseBodyType FromString(string v) {
            switch(v) {
                case "arrayOf1": return ArrayOf1;
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


    /// <summary>
    /// Success
    /// </summary>
    [JsonConverter(typeof(CreateBatchSourceAccountResponseBody.CreateBatchSourceAccountResponseBodyConverter))]
    public class CreateBatchSourceAccountResponseBody {
        public CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType type) {
            Type = type;
        }

        [SpeakeasyMetadata("form:explode=true")]
        public List<One>? ArrayOf1 { get; set; }

        public CreateBatchSourceAccountResponseBodyType Type { get; set; }


        public static CreateBatchSourceAccountResponseBody CreateArrayOf1(List<One> arrayOf1) {
            CreateBatchSourceAccountResponseBodyType typ = CreateBatchSourceAccountResponseBodyType.ArrayOf1;

            CreateBatchSourceAccountResponseBody res = new CreateBatchSourceAccountResponseBody(typ);
            res.ArrayOf1 = arrayOf1;
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
                    return new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.ArrayOf1)
                    {
                        ArrayOf1 = ResponseBodyDeserializer.DeserializeUndiscriminatedUnionMember<List<One>>(json)
                    };
                }
                catch (ResponseBodyDeserializer.MissingMemberException)
                {
                    fallbackCandidates.Add((typeof(List<One>), new CreateBatchSourceAccountResponseBody(CreateBatchSourceAccountResponseBodyType.ArrayOf1), "ArrayOf1"));
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
                if (res.ArrayOf1 != null)
                {
                    writer.WriteRawValue(Utilities.SerializeJSON(res.ArrayOf1));
                    return;
                }

            }

        }

    }
}