// ------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// Licensed under the MIT License (MIT). See License.txt in the repo root for license information.
// ------------------------------------------------------------

namespace Microsoft.ServiceFabric.Actors.Diagnostics
{
    using System;

    internal interface IDiagnosticsManager : IDisposable
    {
        DiagnosticsEventManager DiagnosticsEventManager { get; }
    }
}
