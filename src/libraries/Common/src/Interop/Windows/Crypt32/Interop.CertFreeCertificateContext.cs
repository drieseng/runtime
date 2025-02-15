// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        // Note: This api always return TRUE, regardless of success.
        [GeneratedDllImport(Libraries.Crypt32, SetLastError = true)]
        internal static partial bool CertFreeCertificateContext(IntPtr pCertContext);
    }
}
