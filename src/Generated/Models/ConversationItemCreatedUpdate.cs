// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.RealtimeConversation
{
    public partial class ConversationItemCreatedUpdate : ConversationUpdate
    {
        internal ConversationItemCreatedUpdate(string eventId, string previousItemId, InternalRealtimeResponseItem internalItem) : base(eventId)
        {
            Argument.AssertNotNull(eventId, nameof(eventId));
            Argument.AssertNotNull(previousItemId, nameof(previousItemId));
            Argument.AssertNotNull(internalItem, nameof(internalItem));

            Kind = ConversationUpdateKind.ItemCreated;
            PreviousItemId = previousItemId;
            _internalItem = internalItem;
        }

        internal ConversationItemCreatedUpdate(ConversationUpdateKind kind, string eventId, IDictionary<string, BinaryData> serializedAdditionalRawData, string previousItemId, InternalRealtimeResponseItem internalItem) : base(kind, eventId, serializedAdditionalRawData)
        {
            PreviousItemId = previousItemId;
            _internalItem = internalItem;
        }

        internal ConversationItemCreatedUpdate()
        {
        }

        public string PreviousItemId { get; }
    }
}
