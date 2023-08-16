using System;
using AtlasEngine;
using AtlasEngine.ExternalTasks;

namespace OrderFulfilmentTaskWorker.Worker
{
    [ExternalTaskHandler("wms-execution")] 

    public class TriggerWMSHandler : IExternalTaskHandler<ExternalTaskPayload, ExternalTaskResult>
    {
        public Task<ExternalTaskResult> HandleAsync(ExternalTaskPayload input, ExternalTask task, CancellationToken cancellationToken = default)
        {
            Console.WriteLine(task.ProcessInstanceId);
            return Task.FromResult(new ExternalTaskResult
            {
                Result = $"WMS: success"
            });
        }
    }
}

