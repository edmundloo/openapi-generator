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
    /// Apple
    /// </summary>
    public partial class Apple : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Apple" /> class.
        /// </summary>
        /// <param name="colorCode">colorCode</param>
        /// <param name="cultivar">cultivar</param>
        /// <param name="origin">origin</param>
        [JsonConstructor]
        public Apple(Option<string> colorCode = default, Option<string> cultivar = default, Option<string> origin = default)
        {
            ColorCode = colorCode;
            Cultivar = cultivar;
            Origin = origin;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets ColorCode
        /// </summary>
        [JsonPropertyName("color_code")]
        public Option<string> ColorCode { get; set; }

        /// <summary>
        /// Gets or Sets Cultivar
        /// </summary>
        [JsonPropertyName("cultivar")]
        public Option<string> Cultivar { get; set; }

        /// <summary>
        /// Gets or Sets Origin
        /// </summary>
        [JsonPropertyName("origin")]
        public Option<string> Origin { get; set; }

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
            sb.Append("class Apple {\n");
            sb.Append("  ColorCode: ").Append(ColorCode).Append("\n");
            sb.Append("  Cultivar: ").Append(Cultivar).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
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
            if (this.ColorCode.Value != null) {
                // ColorCode (string) pattern
                Regex regexColorCode = new Regex(@"^#(([0-9a-fA-F]{2}){3}|([0-9a-fA-F]){3})$", RegexOptions.CultureInvariant);
                if (!regexColorCode.Match(this.ColorCode.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ColorCode, must match a pattern of " + regexColorCode, new [] { "ColorCode" });
                }
            }

            if (this.Cultivar.Value != null) {
                // Cultivar (string) pattern
                Regex regexCultivar = new Regex(@"^[a-zA-Z\s]*$", RegexOptions.CultureInvariant);
                if (!regexCultivar.Match(this.Cultivar.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Cultivar, must match a pattern of " + regexCultivar, new [] { "Cultivar" });
                }
            }

            if (this.Origin.Value != null) {
                // Origin (string) pattern
                Regex regexOrigin = new Regex(@"^[A-Z\s]*$", RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);
                if (!regexOrigin.Match(this.Origin.Value).Success)
                {
                    yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Origin, must match a pattern of " + regexOrigin, new [] { "Origin" });
                }
            }

            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Apple" />
    /// </summary>
    public class AppleJsonConverter : JsonConverter<Apple>
    {
        /// <summary>
        /// Deserializes json to <see cref="Apple" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Apple Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<string?> colorCode = default;
            Option<string?> cultivar = default;
            Option<string?> origin = default;

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
                        case "color_code":
                            colorCode = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "cultivar":
                            cultivar = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        case "origin":
                            origin = new Option<string?>(utf8JsonReader.GetString()!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (colorCode.Value == null)
                throw new ArgumentNullException(nameof(colorCode), "Property is not nullable for class Apple.");

            if (cultivar.Value == null)
                throw new ArgumentNullException(nameof(cultivar), "Property is not nullable for class Apple.");

            if (origin.Value == null)
                throw new ArgumentNullException(nameof(origin), "Property is not nullable for class Apple.");

            Option<string> colorCodeParsedValue = new Option<string>(colorCode.Value);
            Option<string> cultivarParsedValue = new Option<string>(cultivar.Value);
            Option<string> originParsedValue = new Option<string>(origin.Value);

            return new Apple(colorCodeParsedValue, cultivarParsedValue, originParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="Apple" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apple"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Apple apple, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, apple, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Apple" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="apple"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Apple apple, JsonSerializerOptions jsonSerializerOptions)
        {
            if (apple.ColorCode.IsSet)
                writer.WriteString("color_code", apple.ColorCode.Value);
            if (apple.Cultivar.IsSet)
                writer.WriteString("cultivar", apple.Cultivar.Value);
            if (apple.Origin.IsSet)
                writer.WriteString("origin", apple.Origin.Value);
        }
    }
}
