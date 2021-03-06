﻿//  Copyright (c) 2014 Andrey Akinshin
//  Project URL: https://github.com/AndreyAkinshin/InteropDotNet
//  Distributed under the MIT License: http://opensource.org/licenses/MIT
using System;
using System.Runtime.InteropServices;

namespace InteropDotNet
{
    static class SystemManager
    {
        public static string GetPlatformName()
        {
            return IntPtr.Size == sizeof(int) ? "x86" : "x64";
        }

        public static OperatingSystem GetOperatingSystem()
        {
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) {
                return OperatingSystem.Windows;
            }
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) {
                return OperatingSystem.Unix;
            }
            if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX)) {
                return OperatingSystem.MacOSX;
            }
            return OperatingSystem.Unknown;
        }
    }

    enum OperatingSystem
    {
        Windows,
        Unix,
        MacOSX,
        Unknown
    }
}