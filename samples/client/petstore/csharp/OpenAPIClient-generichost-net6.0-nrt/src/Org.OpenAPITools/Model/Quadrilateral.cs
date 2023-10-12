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
    /// Quadrilateral
    /// </summary>
    public partial class Quadrilateral : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quadrilateral" /> class.
        /// </summary>
        /// <param name="simpleQuadrilateral"></param>
        /// <param name="quadrilateralType">quadrilateralType</param>
        public Quadrilateral(SimpleQuadrilateral simpleQuadrilateral, string quadrilateralType)
        {
            SimpleQuadrilateral = simpleQuadrilateral;
            QuadrilateralType = quadrilateralType;
            OnCreated();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Quadrilateral" /> class.
        /// </summary>
        /// <param name="complexQuadrilateral"></param>
        /// <param name="quadrilateralType">quadrilateralType</param>
        public Quadrilateral(ComplexQuadrilateral complexQuadrilateral, string quadrilateralType)
        {
            ComplexQuadrilateral = complexQuadrilateral;
            QuadrilateralType = quadrilateralType;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets SimpleQuadrilateral
        /// </summary>
        public SimpleQuadrilateral? SimpleQuadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets ComplexQuadrilateral
        /// </summary>
        public ComplexQuadrilateral? ComplexQuadrilateral { get; set; }

        /// <summary>
        /// Gets or Sets QuadrilateralType
        /// </summary>
        [JsonPropertyName("quadrilateralType")]
        public string QuadrilateralType { get; set; }

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
            sb.Append("class Quadrilateral {\n");
            sb.Append("  QuadrilateralType: ").Append(QuadrilateralType).Append("\n");
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
            return this.BaseValidate(validationContext);
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        protected IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> BaseValidate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="Quadrilateral" />
    /// </summary>
    public class QuadrilateralJsonConverter : JsonConverter<Quadrilateral>
    {
        /// <summary>
        /// Deserializes json to <see cref="Quadrilateral" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override Quadrilateral Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            string quadrilateralType = default;

            ComplexQuadrilateral? complexQuadrilateral = null;
            SimpleQuadrilateral? simpleQuadrilateral = null;

            Utf8JsonReader utf8JsonReaderDiscriminator = utf8JsonReader;
            while (utf8JsonReaderDiscriminator.Read())
            {
                if (startingTokenType == JsonTokenType.StartObject && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndObject && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (startingTokenType == JsonTokenType.StartArray && utf8JsonReaderDiscriminator.TokenType == JsonTokenType.EndArray && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth)
                    break;

                if (utf8JsonReaderDiscriminator.TokenType == JsonTokenType.PropertyName && currentDepth == utf8JsonReaderDiscriminator.CurrentDepth - 1)
                {
                    string? localVarJsonPropertyName = utf8JsonReaderDiscriminator.GetString();
                    utf8JsonReaderDiscriminator.Read();
                    if (localVarJsonPropertyName?.Equals("quadrilateralType") ?? false)
                    {
                        string? discriminator = utf8JsonReaderDiscriminator.GetString();
                        if (discriminator?.Equals("ComplexQuadrilateral") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderComplexQuadrilateral = utf8JsonReader;
                            complexQuadrilateral = JsonSerializer.Deserialize<ComplexQuadrilateral>(ref utf8JsonReaderComplexQuadrilateral, jsonSerializerOptions);
                        }
                        if (discriminator?.Equals("SimpleQuadrilateral") ?? false)
                        {
                            Utf8JsonReader utf8JsonReaderSimpleQuadrilateral = utf8JsonReader;
                            simpleQuadrilateral = JsonSerializer.Deserialize<SimpleQuadrilateral>(ref utf8JsonReaderSimpleQuadrilateral, jsonSerializerOptions);
                        }
                    }
                }
            }

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
                        case "quadrilateralType":
                            quadrilateralType = utf8JsonReader.GetString()!;
                            break;
                        default:
                            break;
                    }
                }
            }

            if (quadrilateralType == null)
                throw new ArgumentNullException(nameof(quadrilateralType), "Property is required for class Quadrilateral.");

            if (complexQuadrilateral != null)
                return new Quadrilateral(complexQuadrilateral, quadrilateralType);

            if (simpleQuadrilateral != null)
                return new Quadrilateral(simpleQuadrilateral, quadrilateralType);

            throw new JsonException();
        }

        /// <summary>
        /// Serializes a <see cref="Quadrilateral" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="quadrilateral"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, Quadrilateral quadrilateral, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            if (quadrilateral.ComplexQuadrilateral != null) {
                ComplexQuadrilateralJsonConverter complexQuadrilateralJsonConverter = (ComplexQuadrilateralJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(quadrilateral.ComplexQuadrilateral.GetType()));
                complexQuadrilateralJsonConverter.WriteProperties(ref writer, quadrilateral.ComplexQuadrilateral, jsonSerializerOptions);
            }

            if (quadrilateral.SimpleQuadrilateral != null) {
                SimpleQuadrilateralJsonConverter simpleQuadrilateralJsonConverter = (SimpleQuadrilateralJsonConverter) jsonSerializerOptions.Converters.First(c => c.CanConvert(quadrilateral.SimpleQuadrilateral.GetType()));
                simpleQuadrilateralJsonConverter.WriteProperties(ref writer, quadrilateral.SimpleQuadrilateral, jsonSerializerOptions);
            }

            WriteProperties(ref writer, quadrilateral, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="Quadrilateral" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="quadrilateral"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, Quadrilateral quadrilateral, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteString("quadrilateralType", quadrilateral.QuadrilateralType);
        }
    }
}
