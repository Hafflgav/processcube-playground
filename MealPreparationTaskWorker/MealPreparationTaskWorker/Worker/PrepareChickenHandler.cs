using System;
using AtlasEngine;
using AtlasEngine.ExternalTasks;

namespace MealPreparationTaskWorker.Worker
{

    [ExternalTaskHandler("prepareChicken")]
    public class PrepareChickenHandler : IExternalTaskHandler<ExternalTaskPayload, ExternalTaskResult>
	{

        public Task<ExternalTaskResult> HandleAsync(ExternalTaskPayload input, ExternalTask task, CancellationToken cancellationToken = default)
        {
            return null; 
        }
    }
}

