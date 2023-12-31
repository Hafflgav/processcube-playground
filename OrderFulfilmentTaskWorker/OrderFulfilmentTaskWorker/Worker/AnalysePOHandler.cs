﻿using System;
using AtlasEngine;
using AtlasEngine.ExternalTasks;
using AtlasEngine.ExternalTasks.Requests;

namespace OrderFulfilmentTaskWorker.Worker
{
    [ExternalTaskHandler("analysePO")]
    public class AnalysePOHandler : IExternalTaskHandler<ExternalTaskPayload, ExternalTaskResult>
    {

        public Task<ExternalTaskResult> HandleAsync(ExternalTaskPayload input, ExternalTask task, CancellationToken cancellationToken = default)
        {
            return Task.FromResult(new ExternalTaskResult
            {
                Result = $"PO_check: success"
            });
        }
    }
}
