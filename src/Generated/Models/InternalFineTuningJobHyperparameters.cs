// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningJobHyperparameters
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalFineTuningJobHyperparameters(BinaryData nEpochs)
        {
            Argument.AssertNotNull(nEpochs, nameof(nEpochs));

            NEpochs = nEpochs;
        }

        internal InternalFineTuningJobHyperparameters(BinaryData nEpochs, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            NEpochs = nEpochs;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalFineTuningJobHyperparameters()
        {
        }

        public BinaryData NEpochs { get; }
    }
}
