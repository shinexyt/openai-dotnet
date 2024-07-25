// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class RunModificationOptions
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        public RunModificationOptions()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal RunModificationOptions(IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Metadata = metadata;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public IDictionary<string, string> Metadata { get; }
    }
}
