// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace OpenAI.RealtimeConversation
{
    public readonly partial struct ConversationContentPartKind : IEquatable<ConversationContentPartKind>
    {
        private readonly string _value;

        public ConversationContentPartKind(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string InputTextValue = "input_text";
        private const string InputAudioValue = "input_audio";
        private const string OutputTextValue = "text";
        private const string OutputAudioValue = "audio";

        public static ConversationContentPartKind InputText { get; } = new ConversationContentPartKind(InputTextValue);
        public static ConversationContentPartKind InputAudio { get; } = new ConversationContentPartKind(InputAudioValue);
        public static bool operator ==(ConversationContentPartKind left, ConversationContentPartKind right) => left.Equals(right);
        public static bool operator !=(ConversationContentPartKind left, ConversationContentPartKind right) => !left.Equals(right);
        public static implicit operator ConversationContentPartKind(string value) => new ConversationContentPartKind(value);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is ConversationContentPartKind other && Equals(other);
        public bool Equals(ConversationContentPartKind other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value != null ? StringComparer.InvariantCultureIgnoreCase.GetHashCode(_value) : 0;
        public override string ToString() => _value;
    }
}
