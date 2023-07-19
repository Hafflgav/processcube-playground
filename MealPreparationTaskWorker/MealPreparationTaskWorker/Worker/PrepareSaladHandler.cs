using System;
using AtlasEngine;
using AtlasEngine.ExternalTasks;

namespace MealPreparationTaskWorker.Worker
{
    [ExternalTaskHandler("prepareSalad")]
    public class PrepareSaladHandler : IExternalTaskHandler<ExternalTaskPayload, ExternalTaskResult>
    {

        public Task<ExternalTaskResult> HandleAsync(ExternalTaskPayload input, ExternalTask task, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(new ExternalTaskResult
            {
                Result = $"Meal: {input.Var}"
            });
        }
    }
}

