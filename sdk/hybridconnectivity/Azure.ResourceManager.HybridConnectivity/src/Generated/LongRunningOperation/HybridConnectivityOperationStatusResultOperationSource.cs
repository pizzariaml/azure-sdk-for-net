// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.ResourceManager.HybridConnectivity.Models;

namespace Azure.ResourceManager.HybridConnectivity
{
    internal class HybridConnectivityOperationStatusResultOperationSource : IOperationSource<HybridConnectivityOperationStatusResult>
    {
        HybridConnectivityOperationStatusResult IOperationSource<HybridConnectivityOperationStatusResult>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return HybridConnectivityOperationStatusResult.DeserializeHybridConnectivityOperationStatusResult(document.RootElement);
        }

        async ValueTask<HybridConnectivityOperationStatusResult> IOperationSource<HybridConnectivityOperationStatusResult>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return HybridConnectivityOperationStatusResult.DeserializeHybridConnectivityOperationStatusResult(document.RootElement);
        }
    }
}
