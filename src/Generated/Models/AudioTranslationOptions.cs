// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Audio
{
    public partial class AudioTranslationOptions
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }

        internal AudioTranslationOptions(BinaryData file, InternalCreateTranslationRequestModel model, string prompt, AudioTranslationFormat? responseFormat, float? temperature, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            File = file;
            Model = model;
            Prompt = prompt;
            ResponseFormat = responseFormat;
            Temperature = temperature;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
        public string Prompt { get; init; }
        public AudioTranslationFormat? ResponseFormat { get; init; }
        public float? Temperature { get; init; }
    }
}
