
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#nullable enable
namespace CodatSyncExpenses.Utils
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Net;
    using System.Reflection;

    internal static class URLBuilder
    {
        public static string Build(string baseUrl, string path, object? request)
        {
            var url = baseUrl;

            if (url.EndsWith("/"))
            {
                url = url.Substring(0, url.Length - 1);
            }

            url += path;

            var parameters = GetPathParameters(request);

            url = ReplaceParameters(url, parameters);

            var queryParams = SerializeQueryParams(TrySerializeQueryParams(request));

            if (queryParams != "")
            {
                url += $"?{queryParams}";
            }

            return url;
        }

        public static string ReplaceParameters(string url, Dictionary<string, string> parameters)
        {
            foreach (var key in parameters.Keys)
            {
                url = url.Replace($"{{{key}}}", parameters[key]);
            }

            return url;
        }

        public static string SerializeQueryParams(Dictionary<string, List<string>> queryParams) {
            var queries = new List<string>();

            foreach (var key in queryParams.Keys)
            {
                foreach (var value in queryParams[key])
                {
                    queries.Add($"{key}={value}");
                }
            }

            return string.Join("&", queries);
        }

        private static Dictionary<string, string> GetPathParameters(object? request)
        {
            var parameters = new Dictionary<string, string>();

            if (request == null)
            {
                return parameters;
            }

            var props = request.GetType().GetProperties();

            foreach (var prop in props)
            {
                var val = prop.GetValue(request);

                if (val == null)
                {
                    continue;
                }

                if (prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetRequestMetadata() != null)
                {
                    continue;
                }

                var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetPathParamMetadata();

                if (metadata == null)
                {
                    continue;
                }

                if (metadata.Serialization != null)
                {
                    switch (metadata.Serialization)
                    {
                        case "json":
                            parameters.Add(
                                metadata.Name ?? prop.Name,
                                WebUtility.UrlEncode(Utilities.SerializeJSON(val))
                            );
                            break;
                        default:
                            throw new Exception(
                                $"Unknown serialization type: {metadata.Serialization}"
                            );
                    }
                }
                else
                {
                    switch (metadata.Style)
                    {
                        case "simple":
                            var simpleParams = SerializeSimplePathParams(
                                metadata.Name ?? prop.Name,
                                val,
                                metadata.Explode
                            );
                            foreach (var key in simpleParams.Keys)
                            {
                                parameters.Add(key, simpleParams[key]);
                            }
                            break;
                        default:
                            throw new Exception($"Unsupported path param style: {metadata.Style}");
                    }
                }
            }

            return parameters;
        }

        private static Dictionary<string, List<string>> TrySerializeQueryParams(object? request)
        {
            var parameters = new Dictionary<string, List<string>>();

            if (request == null)
            {
                return parameters;
            }

            var props = request.GetType().GetProperties();

            foreach (var prop in props)
            {
                var val = prop.GetValue(request);

                if (val == null)
                {
                    continue;
                }

                if (prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetRequestMetadata() != null)
                {
                    continue;
                }

                var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetQueryParamMetadata();
                if (metadata == null)
                {
                    continue;
                }

                if (metadata.Serialization != null)
                {
                    switch (metadata.Serialization)
                    {
                        case "json":
                            if (!parameters.ContainsKey(metadata.Name ?? prop.Name))
                            {
                                parameters.Add(metadata.Name ?? prop.Name, new List<string>());
                            }

                            parameters[metadata.Name ?? prop.Name].Add(
                                Utilities.SerializeJSON(val)
                            );
                            break;
                        default:
                            throw new Exception(
                                $"Unknown serialization type: {metadata.Serialization}"
                            );
                    }
                }
                else
                {
                    switch (metadata.Style)
                    {
                        case "form":
                            var formParams = SerializeFormQueryParams(
                                metadata.Name ?? prop.Name,
                                val,
                                metadata.Explode,
                                ","
                            );
                            foreach (var key in formParams.Keys)
                            {
                                if (!parameters.ContainsKey(key))
                                {
                                    parameters.Add(key, new List<string>());
                                }

                                foreach (var v in formParams[key])
                                {
                                    parameters[key].Add(v);
                                }
                            }
                            break;
                        case "deepObject":
                            var deepObjParams = SerializeDeepObjectQueryParams(
                                metadata.Name ?? prop.Name,
                                val
                            );
                            foreach (var key in deepObjParams.Keys)
                            {
                                if (!parameters.ContainsKey(key))
                                {
                                    parameters.Add(key, new List<string>());
                                }

                                foreach (var v in deepObjParams[key])
                                {
                                    parameters[key].Add(v);
                                }
                            }
                            break;
                        case "pipeDelimited":
                            var pipeParams = SerializeFormQueryParams(
                                metadata.Name ?? prop.Name,
                                val,
                                metadata.Explode,
                                "|"
                            );
                            foreach (var key in pipeParams.Keys)
                            {
                                if (!parameters.ContainsKey(key))
                                {
                                    parameters.Add(key, new List<string>());
                                }

                                foreach (var v in pipeParams[key])
                                {
                                    parameters[key].Add(v);
                                }
                            }
                            break;
                        default:
                            throw new Exception($"Unsupported query param style: {metadata.Style}");
                    }
                }
            }

            return parameters;
        }

        private static Dictionary<string, string> SerializeSimplePathParams(
            string parentName,
            object value,
            bool explode
        )
        {
            var parameters = new Dictionary<string, string>();

            if (Utilities.IsClass(value))
            {
                var vals = new List<string>();

                var props = value.GetType().GetProperties();

                foreach (var prop in props)
                {
                    var val = prop.GetValue(value);

                    if (val == null)
                    {
                        continue;
                    }

                    var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetPathParamMetadata();
                    if (metadata == null)
                    {
                        continue;
                    }

                    if (explode)
                    {
                        vals.Add($"{metadata.Name}={Utilities.ToString(val)}");
                    }
                    else
                    {
                        vals.Add($"{metadata.Name},{Utilities.ToString(val)}");
                    }
                }

                parameters.Add(parentName, string.Join(",", vals));
            }
            else if (Utilities.IsDictionary(value))
            {
                var vals = new List<string>();

                foreach (var key in ((IDictionary)value).Keys)
                {
                    if (key == null)
                    {
                        continue;
                    }

                    var val = ((IDictionary)value)[key];

                    if (explode)
                    {
                        vals.Add($"{key}={Utilities.ToString(val)}");
                    }
                    else
                    {
                        vals.Add($"{key},{Utilities.ToString(val)}");
                    }
                }

                parameters.Add(parentName, string.Join(",", vals));
            }
            else if (Utilities.IsList(value))
            {
                var vals = new List<string>();

                foreach (var val in (IEnumerable)value)
                {
                    vals.Add(Utilities.ToString(val));
                }

                parameters.Add(parentName, string.Join(",", vals));
            }
            else
            {
                parameters.Add(parentName, Utilities.ToString(value));
            }

            return parameters;
        }

        private static Dictionary<string, List<string>> SerializeFormQueryParams(
            string parentName,
            object value,
            bool explode,
            string delimiter
        )
        {
            var parameters = new Dictionary<string, List<string>>();

            if (Utilities.IsClass(value) && !Utilities.IsDate(value))
            {
                var props = value.GetType().GetProperties();

                var items = new List<string>();

                foreach (var prop in props)
                {
                    var val = prop.GetValue(value);
                    if (val == null)
                    {
                        continue;
                    }

                    var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetQueryParamMetadata();
                    if (metadata == null || metadata.Name == null)
                    {
                        continue;
                    }

                    if (explode)
                    {
                        if (!parameters.ContainsKey(metadata.Name))
                        {
                            parameters.Add(metadata.Name, new List<string>());
                        }

                        parameters[metadata.Name].Add(
                            Utilities.ToString(val)
                        );
                    }
                    else
                    {
                        items.Add(
                            $"{metadata.Name}{delimiter}{Utilities.ValueToString(val)}"
                        );
                    }
                }

                if (items.Count > 0)
                {
                    if (!parameters.ContainsKey(parentName))
                    {
                        parameters.Add(parentName, new List<string>());
                    }

                    parameters[parentName].Add(string.Join(delimiter, items));
                }
            }
            else if (Utilities.IsDictionary(value))
            {
                var items = new List<string>();

                foreach (var k in ((IDictionary)value).Keys)
                {
                    var key = k?.ToString();

                    if (key == null)
                    {
                        continue;
                    }

                    if (explode)
                    {
                        if (!parameters.ContainsKey(key))
                        {
                            parameters.Add(key, new List<string>());
                        }

                        parameters[key].Add(
                            Utilities.ValueToString(((IDictionary)value)[key])
                        );
                    }
                    else
                    {
                        items.Add(
                            $"{key}{delimiter}{Utilities.ValueToString(((IDictionary)value)[key])}"
                        );
                    }
                }

                if (items.Count > 0)
                {
                    if (!parameters.ContainsKey(parentName))
                    {
                        parameters.Add(parentName, new List<string>());
                    }

                    parameters[parentName].Add(string.Join(delimiter, items));
                }
            }
            else if (Utilities.IsList(value))
            {
                var values = new List<string>();
                var items = new List<string>();

                foreach (var item in (IList)value)
                {
                    if (explode)
                    {
                        values.Add(Utilities.ValueToString(item));
                    }
                    else
                    {
                        items.Add(Utilities.ValueToString(item));
                    }
                }

                if (items.Count > 0)
                {
                    values.Add(string.Join(delimiter, items));
                }

                foreach (var val in values)
                {
                    if (!parameters.ContainsKey(parentName))
                    {
                        parameters.Add(parentName, new List<string>());
                    }

                    parameters[parentName].Add(val);
                }
            }
            else
            {
                if (!parameters.ContainsKey(parentName))
                {
                    parameters.Add(parentName, new List<string>());
                }

                parameters[parentName].Add(Utilities.ValueToString(value));
            }

            return parameters;
        }

        private static Dictionary<string, List<string>> SerializeDeepObjectQueryParams(
            string parentName,
            object value
        )
        {
            var parameters = new Dictionary<string, List<string>>();

            if (Utilities.IsClass(value))
            {
                var props = value.GetType().GetProperties();

                foreach (var prop in props)
                {
                    var val = prop.GetValue(value);

                    if (val == null)
                    {
                        continue;
                    }

                    var metadata = prop.GetCustomAttribute<SpeakeasyMetadata>()?.GetQueryParamMetadata();
                    if (metadata == null || metadata.Name == null)
                    {
                        continue;
                    }

                    var keyName = $"{parentName}[{metadata.Name}]";

                    if (val != null && Utilities.IsList(val))
                    {
                        foreach (var v in (IList)val)
                        {
                            if (!parameters.ContainsKey(keyName))
                            {
                                parameters.Add(keyName, new List<string>());
                            }

                            parameters[keyName].Add(
                                Utilities.ValueToString(v)
                            );
                        }
                    }
                    else
                    {
                        if (!parameters.ContainsKey(keyName))
                        {
                            parameters.Add(keyName, new List<string>());
                        }

                        parameters[keyName].Add(Utilities.ValueToString(val));
                    }
                }
            }
            else if (Utilities.IsDictionary(value))
            {
                foreach (var key in ((IDictionary)value).Keys)
                {
                    if (key == null)
                    {
                        continue;
                    }

                    var val = ((IDictionary)value)[key];

                    var keyName = $"{parentName}[{key}]";

                    if (val != null && Utilities.IsList(val))
                    {
                        foreach (var v in (IList)val)
                        {
                            if (!parameters.ContainsKey(keyName))
                            {
                                parameters.Add(keyName, new List<string>());
                            }

                            parameters[keyName].Add(
                                Utilities.ValueToString(v)
                            );
                        }
                    }
                    else
                    {
                        if (!parameters.ContainsKey(keyName))
                        {
                            parameters.Add(keyName, new List<string>());
                        }

                        parameters[keyName].Add(Utilities.ValueToString(val));
                    }
                }
            }

            return parameters;
        }
    }
}
