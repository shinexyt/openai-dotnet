// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningJobEvent
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalFineTuningJobEvent(string id, DateTimeOffset createdAt, InternalFineTuningJobEventLevel level, string message)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(message, nameof(message));

            Id = id;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
        }

        internal InternalFineTuningJobEvent(string id, DateTimeOffset createdAt, InternalFineTuningJobEventLevel level, string message, InternalFineTuningJobEventObject @object, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CreatedAt = createdAt;
            Level = level;
            Message = message;
            Object = @object;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalFineTuningJobEvent()
        {
        }

        public string Id { get; }
        public DateTimeOffset CreatedAt { get; }
        public InternalFineTuningJobEventLevel Level { get; }
        public string Message { get; }
        public InternalFineTuningJobEventObject Object { get; } = InternalFineTuningJobEventObject.FineTuningJobEvent;
    }
}
