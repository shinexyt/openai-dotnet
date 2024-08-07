// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.FineTuning
{
    internal partial class InternalFineTuningJob
    {
        internal IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }
        internal InternalFineTuningJob(string id, DateTimeOffset createdAt, InternalFineTuningJobError error, string fineTunedModel, DateTimeOffset? finishedAt, InternalFineTuningJobHyperparameters hyperparameters, string model, string organizationId, IEnumerable<string> resultFiles, InternalFineTuningJobStatus status, int? trainedTokens, string trainingFile, string validationFile, int seed)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(hyperparameters, nameof(hyperparameters));
            Argument.AssertNotNull(model, nameof(model));
            Argument.AssertNotNull(organizationId, nameof(organizationId));
            Argument.AssertNotNull(resultFiles, nameof(resultFiles));
            Argument.AssertNotNull(trainingFile, nameof(trainingFile));

            Id = id;
            CreatedAt = createdAt;
            Error = error;
            FineTunedModel = fineTunedModel;
            FinishedAt = finishedAt;
            Hyperparameters = hyperparameters;
            Model = model;
            OrganizationId = organizationId;
            ResultFiles = resultFiles.ToList();
            Status = status;
            TrainedTokens = trainedTokens;
            TrainingFile = trainingFile;
            ValidationFile = validationFile;
            Integrations = new ChangeTrackingList<InternalFineTuningIntegration>();
            Seed = seed;
        }

        internal InternalFineTuningJob(string id, DateTimeOffset createdAt, InternalFineTuningJobError error, string fineTunedModel, DateTimeOffset? finishedAt, InternalFineTuningJobHyperparameters hyperparameters, string model, InternalFineTuningJobObject @object, string organizationId, IReadOnlyList<string> resultFiles, InternalFineTuningJobStatus status, int? trainedTokens, string trainingFile, string validationFile, IReadOnlyList<InternalFineTuningIntegration> integrations, int seed, DateTimeOffset? estimatedFinish, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Id = id;
            CreatedAt = createdAt;
            Error = error;
            FineTunedModel = fineTunedModel;
            FinishedAt = finishedAt;
            Hyperparameters = hyperparameters;
            Model = model;
            Object = @object;
            OrganizationId = organizationId;
            ResultFiles = resultFiles;
            Status = status;
            TrainedTokens = trainedTokens;
            TrainingFile = trainingFile;
            ValidationFile = validationFile;
            Integrations = integrations;
            Seed = seed;
            EstimatedFinish = estimatedFinish;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }

        internal InternalFineTuningJob()
        {
        }

        public string Id { get; }
        public DateTimeOffset CreatedAt { get; }
        public InternalFineTuningJobError Error { get; }
        public string FineTunedModel { get; }
        public DateTimeOffset? FinishedAt { get; }
        public InternalFineTuningJobHyperparameters Hyperparameters { get; }
        public string Model { get; }
        public InternalFineTuningJobObject Object { get; } = InternalFineTuningJobObject.FineTuningJob;

        public string OrganizationId { get; }
        public IReadOnlyList<string> ResultFiles { get; }
        public InternalFineTuningJobStatus Status { get; }
        public int? TrainedTokens { get; }
        public string TrainingFile { get; }
        public string ValidationFile { get; }
        public IReadOnlyList<InternalFineTuningIntegration> Integrations { get; }
        public int Seed { get; }
        public DateTimeOffset? EstimatedFinish { get; }
    }
}
