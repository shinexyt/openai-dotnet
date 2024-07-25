// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class ThreadModificationOptions
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; }
        public ThreadModificationOptions()
        {
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal ThreadModificationOptions(ToolResources toolResources, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ToolResources = toolResources;
            Metadata = metadata;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
        public IDictionary<string, string> Metadata { get; }
    }
}
