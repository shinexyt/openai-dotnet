// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Moderations
{
    internal partial class InternalModerationCategories
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalModerationCategories(bool hate, bool hateThreatening, bool harassment, bool harassmentThreatening, bool illicit, bool illicitViolent, bool selfHarm, bool selfHarmIntent, bool selfHarmInstructions, bool sexual, bool sexualMinors, bool violence, bool violenceGraphic)
        {
            Hate = hate;
            HateThreatening = hateThreatening;
            Harassment = harassment;
            HarassmentThreatening = harassmentThreatening;
            Illicit = illicit;
            IllicitViolent = illicitViolent;
            SelfHarm = selfHarm;
            SelfHarmIntent = selfHarmIntent;
            SelfHarmInstructions = selfHarmInstructions;
            Sexual = sexual;
            SexualMinors = sexualMinors;
            Violence = violence;
            ViolenceGraphic = violenceGraphic;
        }

        internal InternalModerationCategories(bool hate, bool hateThreatening, bool harassment, bool harassmentThreatening, bool illicit, bool illicitViolent, bool selfHarm, bool selfHarmIntent, bool selfHarmInstructions, bool sexual, bool sexualMinors, bool violence, bool violenceGraphic, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Hate = hate;
            HateThreatening = hateThreatening;
            Harassment = harassment;
            HarassmentThreatening = harassmentThreatening;
            Illicit = illicit;
            IllicitViolent = illicitViolent;
            SelfHarm = selfHarm;
            SelfHarmIntent = selfHarmIntent;
            SelfHarmInstructions = selfHarmInstructions;
            Sexual = sexual;
            SexualMinors = sexualMinors;
            Violence = violence;
            ViolenceGraphic = violenceGraphic;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalModerationCategories()
        {
        }

        public bool Hate { get; }
        public bool HateThreatening { get; }
        public bool Harassment { get; }
        public bool HarassmentThreatening { get; }
        public bool Illicit { get; }
        public bool IllicitViolent { get; }
        public bool SelfHarm { get; }
        public bool SelfHarmIntent { get; }
        public bool SelfHarmInstructions { get; }
        public bool Sexual { get; }
        public bool SexualMinors { get; }
        public bool Violence { get; }
        public bool ViolenceGraphic { get; }
    }
}
