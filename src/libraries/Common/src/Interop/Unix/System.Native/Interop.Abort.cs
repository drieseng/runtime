// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal unsafe partial class Sys
    {
        [DoesNotReturn]
        [GeneratedDllImport(Interop.Libraries.SystemNative, EntryPoint = "SystemNative_Abort")]
        internal static partial void Abort();
    }
}
