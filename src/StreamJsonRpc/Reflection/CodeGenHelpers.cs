﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;
using System.Threading.Tasks;

namespace StreamJsonRpc.Reflection
{
    /// <summary>
    /// Helper methods for dynamically generated proxies to invoke.
    /// This type is only public because mono does not support IgnoresAccessChecksToAttribute. Do not call directly.
    /// </summary>
    [EditorBrowsable(EditorBrowsableState.Never)]
    [Obsolete("This class is only for invoking from dynamically generated code.")]
    public static class CodeGenHelpers
    {
#pragma warning disable VSTHRD200 // Use "Async" suffix in names of methods that return an awaitable type.
        /// <inheritdoc cref="ProxyGeneration.AsyncEnumerableProxy{T}"/>
        public static IAsyncEnumerable<T> CreateAsyncEnumerableProxy<T>(Task<IAsyncEnumerable<T>> enumerableTask, CancellationToken defaultCancellationToken) => new ProxyGeneration.AsyncEnumerableProxy<T>(enumerableTask, defaultCancellationToken);
#pragma warning restore VSTHRD200 // Use "Async" suffix in names of methods that return an awaitable type.
    }
}
