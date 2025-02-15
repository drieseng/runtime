// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class Crypt32
    {
        [GeneratedDllImport(Libraries.Crypt32, SetLastError = true)]
        internal static unsafe partial bool CryptQueryObject(
            CertQueryObjectType dwObjectType,
            void* pvObject,
            ExpectedContentTypeFlags dwExpectedContentTypeFlags,
            ExpectedFormatTypeFlags dwExpectedFormatTypeFlags,
            int dwFlags, // reserved - always pass 0
            IntPtr pdwMsgAndCertEncodingType,
            out ContentType pdwContentType,
            IntPtr pdwFormatType,
            IntPtr phCertStore,
            IntPtr phMsg,
            out IntPtr ppvContext
            );
    }
}
