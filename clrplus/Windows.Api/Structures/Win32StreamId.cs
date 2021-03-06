﻿//-----------------------------------------------------------------------
// <copyright company="CoApp Project">
//     Copyright (c) 2010-2013 Garrett Serack and CoApp Contributors. 
//     Contributors can be discovered using the 'git log' command.
//     All rights reserved.
// </copyright>
// <license>
//     The software is licensed under the Apache 2.0 License (the "License")
//     You may not use the software except in compliance with the License. 
// </license>
//-----------------------------------------------------------------------

namespace ClrPlus.Windows.Api.Structures {
    using System.Runtime.InteropServices;

    [StructLayout(LayoutKind.Sequential)]
    public struct Win32StreamId {
        public readonly int StreamId;
        public readonly int StreamAttributes;
        public long Size;
        public readonly int StreamNameSize;
    }
}