// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationContentPartStartedUpdate : ConversationUpdate
    {
        internal ConversationContentPartStartedUpdate(string eventId, string responseId, string itemId, int outputIndex, int contentIndex, ConversationContentPart internalContentPart) : base(eventId)
        {
            Argument.AssertNotNull(responseId, nameof(responseId));
            Argument.AssertNotNull(itemId, nameof(itemId));
            Argument.AssertNotNull(internalContentPart, nameof(internalContentPart));

            Kind = ConversationUpdateKind.ContentPartStarted;
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
            _internalContentPart = internalContentPart;
        }

        internal ConversationContentPartStartedUpdate(ConversationUpdateKind kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData, string responseId, string itemId, int outputIndex, int contentIndex, ConversationContentPart internalContentPart) : base(kind, eventId, serializedAdditionalRawData)
        {
            ResponseId = responseId;
            ItemId = itemId;
            OutputIndex = outputIndex;
            ContentIndex = contentIndex;
            _internalContentPart = internalContentPart;
        }

        internal ConversationContentPartStartedUpdate()
        {
        }

        public string ResponseId { get; }
        public string ItemId { get; }
        public int OutputIndex { get; }
        public int ContentIndex { get; }
    }
}
