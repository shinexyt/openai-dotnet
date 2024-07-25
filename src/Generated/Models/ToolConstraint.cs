// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    public partial class ToolConstraint
    {
        internal ToolConstraint(string objectType, InternalAssistantsNamedToolChoiceFunction function, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            _objectType = objectType;
            Function = function;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal ToolConstraint()
        {
        }
    }
}
