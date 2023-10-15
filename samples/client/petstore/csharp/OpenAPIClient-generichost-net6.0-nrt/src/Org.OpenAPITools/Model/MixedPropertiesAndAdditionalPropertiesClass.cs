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
    /// MixedPropertiesAndAdditionalPropertiesClass
    /// </summary>
    public partial class MixedPropertiesAndAdditionalPropertiesClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MixedPropertiesAndAdditionalPropertiesClass" /> class.
        /// </summary>
        /// <param name="dateTime">dateTime</param>
        /// <param name="map">map</param>
        /// <param name="uuid">uuid</param>
        /// <param name="uuidWithPattern">uuidWithPattern</param>
        [JsonConstructor]
        public MixedPropertiesAndAdditionalPropertiesClass(Option<DateTime> dateTime = default, Option<Dictionary<string, Animal>> map = default, Option<Guid> uuid = default, Option<Guid> uuidWithPattern = default)
        {
            DateTime = dateTime;
            Map = map;
            Uuid = uuid;
            UuidWithPattern = uuidWithPattern;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets DateTime
        /// </summary>
        [JsonPropertyName("dateTime")]
        public Option<DateTime> DateTime { get; set; }

        /// <summary>
        /// Gets or Sets Map
        /// </summary>
        [JsonPropertyName("map")]
        public Option<Dictionary<string, Animal>> Map { get; set; }

        /// <summary>
        /// Gets or Sets Uuid
        /// </summary>
        [JsonPropertyName("uuid")]
        public Option<Guid> Uuid { get; set; }

        /// <summary>
        /// Gets or Sets UuidWithPattern
        /// </summary>
        [JsonPropertyName("uuid_with_pattern")]
        public Option<Guid> UuidWithPattern { get; set; }

        /// <summary>
        /// Gets or Sets additional properties
        /// </summary>
        [JsonExtensionData]
        public Dictionary<string, JsonElement> AdditionalProperties { get; } = new Dictionary<string, JsonElement>();

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MixedPropertiesAndAdditionalPropertiesClass {\n");
            sb.Append("  DateTime: ").Append(DateTime).Append("\n");
            sb.Append("  Map: ").Append(Map).Append("\n");
            sb.Append("  Uuid: ").Append(Uuid).Append("\n");
            sb.Append("  UuidWithPattern: ").Append(UuidWithPattern).Append("\n");
            sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // UuidWithPattern (Guid) pattern
            Regex regexUuidWithPattern = new Regex(@"[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}", RegexOptions.CultureInvariant);
            if (!regexUuidWithPattern.Match(this.UuidWithPattern.Value.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UuidWithPattern, must match a pattern of " + regexUuidWithPattern, new [] { "UuidWithPattern" });
            }
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="MixedPropertiesAndAdditionalPropertiesClass" />
    /// </summary>
    public class MixedPropertiesAndAdditionalPropertiesClassJsonConverter : JsonConverter<MixedPropertiesAndAdditionalPropertiesClass>
    {
        /// <summary>
        /// The format to use to serialize DateTime
        /// </summary>
        public static string DateTimeFormat { get; set; } = "yyyy'-'MM'-'dd'T'HH':'mm':'ss'.'fffffffK";

        /// <summary>
        /// Deserializes json to <see cref="MixedPropertiesAndAdditionalPropertiesClass" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override MixedPropertiesAndAdditionalPropertiesClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<DateTime?> dateTime = default;
            Option<Dictionary<string, Animal>?> map = default;
            Option<Guid?> uuid = default;
            Option<Guid?> uuidWithPattern = default;

            while (utf8JsonReader.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReader.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReader.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReader.CurrentDepth)
                    break;

                if (utf8JsonReader.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReader.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReader.GetString();
                    utf8JsonReader.Read();

                    switch (localVarJsonPropertyName)
                    {
                        case "dateTime":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                dateTime = new Option<DateTime?>(JsonSerializer.Deserialize<DateTime>(ref utf8JsonReader, jsonSerializerOptions));
                            break;
                        case "map":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                map = new Option<Dictionary<string, Animal>?>(JsonSerializer.Deserialize<Dictionary<string, Animal>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "uuid":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                uuid = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        case "uuid_with_pattern":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                uuidWithPattern = new Option<Guid?>(utf8JsonReader.GetGuid());
                            break;
                        default:
                            break;
                    }
                }
            }

            if (dateTime.Value == null)
                throw new ArgumentNullException(nameof(dateTime), "Property is not nullable for class MixedPropertiesAndAdditionalPropertiesClass.");

            if (map.Value == null)
                throw new ArgumentNullException(nameof(map), "Property is not nullable for class MixedPropertiesAndAdditionalPropertiesClass.");

            if (uuid.Value == null)
                throw new ArgumentNullException(nameof(uuid), "Property is not nullable for class MixedPropertiesAndAdditionalPropertiesClass.");

            if (uuidWithPattern.Value == null)
                throw new ArgumentNullException(nameof(uuidWithPattern), "Property is not nullable for class MixedPropertiesAndAdditionalPropertiesClass.");

            Option<DateTime> dateTimeParsedValue = new Option<DateTime>(dateTime.Value.Value);
            Option<Dictionary<string, Animal>> mapParsedValue = new Option<Dictionary<string, Animal>>(map.Value);
            Option<Guid> uuidParsedValue = new Option<Guid>(uuid.Value.Value);
            Option<Guid> uuidWithPatternParsedValue = new Option<Guid>(uuidWithPattern.Value.Value);

            return new MixedPropertiesAndAdditionalPropertiesClass(dateTimeParsedValue, mapParsedValue, uuidParsedValue, uuidWithPatternParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="MixedPropertiesAndAdditionalPropertiesClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedPropertiesAndAdditionalPropertiesClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, MixedPropertiesAndAdditionalPropertiesClass mixedPropertiesAndAdditionalPropertiesClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, mixedPropertiesAndAdditionalPropertiesClass, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="MixedPropertiesAndAdditionalPropertiesClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="mixedPropertiesAndAdditionalPropertiesClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, MixedPropertiesAndAdditionalPropertiesClass mixedPropertiesAndAdditionalPropertiesClass, JsonSerializerOptions jsonSerializerOptions)
        {
            if (mixedPropertiesAndAdditionalPropertiesClass.DateTime.IsSet)
                writer.WriteString("dateTime", mixedPropertiesAndAdditionalPropertiesClass.DateTime.Value.ToString(DateTimeFormat));
            if (mixedPropertiesAndAdditionalPropertiesClass.Map.IsSet)
                writer.WritePropertyName("map");
                JsonSerializer.Serialize(writer, mixedPropertiesAndAdditionalPropertiesClass.Map, jsonSerializerOptions);
            if (mixedPropertiesAndAdditionalPropertiesClass.Uuid.IsSet)
                writer.WriteString("uuid", mixedPropertiesAndAdditionalPropertiesClass.Uuid.Value);
            if (mixedPropertiesAndAdditionalPropertiesClass.UuidWithPattern.IsSet)
                writer.WriteString("uuid_with_pattern", mixedPropertiesAndAdditionalPropertiesClass.UuidWithPattern.Value);
        }
    }
}
