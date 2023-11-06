// <auto-generated>
/*
 * OpenAPI Petstore
 *
 * This spec is mainly for testing Petstore server and contains fake endpoints, models. Please do not use this for any other purpose. Special characters: \" \\
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using OpenAPIClientUtils = Org.OpenAPITools.Client.ClientUtils;
using Org.OpenAPITools.Client;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// Defines ZeroBasedEnum
    /// </summary>
    public enum ZeroBasedEnum
    {
        /// <summary>
        /// Enum Unknown for value: unknown
        /// </summary>
        Unknown,

        /// <summary>
        /// Enum NotUnknown for value: notUnknown
        /// </summary>
        NotUnknown
    }

    /// <summary>
    /// Converts <see cref="ZeroBasedEnum"/> to and from the JSON value
    /// </summary>
    public static class ZeroBasedEnumValueConverter
    {
        /// <summary>
        /// Parses a given value to <see cref="ZeroBasedEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ZeroBasedEnum FromString(string value)
        {
            if (value.Equals("unknown"))
                return ZeroBasedEnum.Unknown;

            if (value.Equals("notUnknown"))
                return ZeroBasedEnum.NotUnknown;

            throw new NotImplementedException($"Could not convert value to type ZeroBasedEnum: '{value}'");
        }

        /// <summary>
        /// Parses a given value to <see cref="ZeroBasedEnum"/>
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static ZeroBasedEnum? FromStringOrDefault(string value)
        {
            if (value.Equals("unknown"))
                return ZeroBasedEnum.Unknown;

            if (value.Equals("notUnknown"))
                return ZeroBasedEnum.NotUnknown;

            return null;
        }

        /// <summary>
        /// Converts the <see cref="ZeroBasedEnum"/> to the json value
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public static string ToJsonValue(ZeroBasedEnum value)
        {
            if (value == ZeroBasedEnum.Unknown)
                return "unknown";

            if (value == ZeroBasedEnum.NotUnknown)
                return "notUnknown";

            throw new NotImplementedException($"Value could not be handled: '{value}'");
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ZeroBasedEnum"/>
    /// </summary>
    /// <exception cref="NotImplementedException"></exception>
    public class ZeroBasedEnumJsonConverter : JsonConverter<ZeroBasedEnum>
    {
        /// <summary>
        /// Returns a  from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ZeroBasedEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ZeroBasedEnum? result = rawValue == null
                ? null
                : ZeroBasedEnumValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the ZeroBasedEnum to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="zeroBasedEnum"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ZeroBasedEnum zeroBasedEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(zeroBasedEnum.ToString());
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="ZeroBasedEnum"/>
    /// </summary>
    public class ZeroBasedEnumNullableJsonConverter : JsonConverter<ZeroBasedEnum?>
    {
        /// <summary>
        /// Returns a ZeroBasedEnum from the Json object
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public override ZeroBasedEnum? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? rawValue = reader.GetString();

            ZeroBasedEnum? result = rawValue == null
                ? null
                : ZeroBasedEnumValueConverter.FromStringOrDefault(rawValue);

            if (result != null)
                return result.Value;

            throw new JsonException();
        }

        /// <summary>
        /// Writes the DateTime to the json writer
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="zeroBasedEnum"></param>
        /// <param name="options"></param>
        public override void Write(Utf8JsonWriter writer, ZeroBasedEnum? zeroBasedEnum, JsonSerializerOptions options)
        {
            writer.WriteStringValue(zeroBasedEnum?.ToString() ?? "null");
        }
    }
}
