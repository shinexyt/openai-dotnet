// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageObjectAttachment
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalMessageObjectAttachment()
        {
            Tools = new ChangeTrackingList<BinaryData>();
        }

        internal InternalMessageObjectAttachment(string fileId, IReadOnlyList<BinaryData> tools, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            FileId = fileId;
            Tools = tools;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        public string FileId { get; }
        public IReadOnlyList<BinaryData> Tools { get; }
    }
}
