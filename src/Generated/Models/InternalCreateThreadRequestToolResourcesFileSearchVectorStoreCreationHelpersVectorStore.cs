// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalCreateThreadRequestToolResourcesFileSearchVectorStoreCreationHelpersVectorStore
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        public InternalCreateThreadRequestToolResourcesFileSearchVectorStoreCreationHelpersVectorStore()
        {
            FileIds = new ChangeTrackingList<string>();
            Metadata = new ChangeTrackingDictionary<string, string>();
        }

        internal InternalCreateThreadRequestToolResourcesFileSearchVectorStoreCreationHelpersVectorStore(IList<string> fileIds, IDictionary<string, string> metadata, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileIds = fileIds;
            Metadata = metadata;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public IList<string> FileIds { get; }
        public IDictionary<string, string> Metadata { get; }
    }
}
