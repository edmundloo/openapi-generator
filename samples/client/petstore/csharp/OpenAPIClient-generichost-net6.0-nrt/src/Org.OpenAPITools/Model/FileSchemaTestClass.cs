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
    /// FileSchemaTestClass
    /// </summary>
    public partial class FileSchemaTestClass : IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileSchemaTestClass" /> class.
        /// </summary>
        /// <param name="file">file</param>
        /// <param name="files">files</param>
        [JsonConstructor]
        public FileSchemaTestClass(Option<File> file = default, Option<List<File>> files = default)
        {
            File = file;
            Files = files;
            OnCreated();
        }

        partial void OnCreated();

        /// <summary>
        /// Gets or Sets File
        /// </summary>
        [JsonPropertyName("file")]
        public Option<File> File { get; set; }

        /// <summary>
        /// Gets or Sets Files
        /// </summary>
        [JsonPropertyName("files")]
        public Option<List<File>> Files { get; set; }

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
            sb.Append("class FileSchemaTestClass {\n");
            sb.Append("  File: ").Append(File).Append("\n");
            sb.Append("  Files: ").Append(Files).Append("\n");
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
            yield break;
        }
    }

    /// <summary>
    /// A Json converter for type <see cref="FileSchemaTestClass" />
    /// </summary>
    public class FileSchemaTestClassJsonConverter : JsonConverter<FileSchemaTestClass>
    {
        /// <summary>
        /// Deserializes json to <see cref="FileSchemaTestClass" />
        /// </summary>
        /// <param name="utf8JsonReader"></param>
        /// <param name="typeToConvert"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <returns></returns>
        /// <exception cref="JsonException"></exception>
        public override FileSchemaTestClass Read(ref Utf8JsonReader utf8JsonReader, Type typeToConvert, JsonSerializerOptions jsonSerializerOptions)
        {
            int currentDepth = utf8JsonReader.CurrentDepth;

            if (utf8JsonReader.TokenType != JsonTokenType.StartObject && utf8JsonReader.TokenType != JsonTokenType.StartArray)
                throw new JsonException();

            JsonTokenType startingTokenType = utf8JsonReader.TokenType;

            Option<File?> file = default;
            Option<List<File>?> files = default;

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
                        case "file":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                file = new Option<File?>(JsonSerializer.Deserialize<File>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        case "files":
                            if (utf8JsonReader.TokenType != JsonTokenType.Null)
                                files = new Option<List<File>?>(JsonSerializer.Deserialize<List<File>>(ref utf8JsonReader, jsonSerializerOptions)!);
                            break;
                        default:
                            break;
                    }
                }
            }

            if (file.Value == null)
                throw new ArgumentNullException(nameof(file), "Property is not nullable for class FileSchemaTestClass.");

            if (files.Value == null)
                throw new ArgumentNullException(nameof(files), "Property is not nullable for class FileSchemaTestClass.");

            Option<File> fileParsedValue = new Option<File>(file.Value);
            Option<List<File>> filesParsedValue = new Option<List<File>>(files.Value);

            return new FileSchemaTestClass(fileParsedValue, filesParsedValue);
        }

        /// <summary>
        /// Serializes a <see cref="FileSchemaTestClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fileSchemaTestClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public override void Write(Utf8JsonWriter writer, FileSchemaTestClass fileSchemaTestClass, JsonSerializerOptions jsonSerializerOptions)
        {
            writer.WriteStartObject();

            WriteProperties(ref writer, fileSchemaTestClass, jsonSerializerOptions);
            writer.WriteEndObject();
        }

        /// <summary>
        /// Serializes the properties of <see cref="FileSchemaTestClass" />
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="fileSchemaTestClass"></param>
        /// <param name="jsonSerializerOptions"></param>
        /// <exception cref="NotImplementedException"></exception>
        public void WriteProperties(ref Utf8JsonWriter writer, FileSchemaTestClass fileSchemaTestClass, JsonSerializerOptions jsonSerializerOptions)
        {
            if (fileSchemaTestClass.File.IsSet)
                writer.WritePropertyName("file");
                JsonSerializer.Serialize(writer, fileSchemaTestClass.File, jsonSerializerOptions);
            if (fileSchemaTestClass.Files.IsSet)
                writer.WritePropertyName("files");
                JsonSerializer.Serialize(writer, fileSchemaTestClass.Files, jsonSerializerOptions);
        }
    }
}
