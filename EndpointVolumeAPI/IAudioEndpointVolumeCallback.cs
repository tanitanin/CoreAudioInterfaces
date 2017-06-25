﻿using System;
using System.Runtime.InteropServices;

namespace CoreAudio.EndpointVolumeAPI
{
    [Guid("657804FA-D6AD-4496-8A60-352752AF4F89"),
     InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    interface IAudioEndpointVolumeCallback
    {
        void OnNotify(IntPtr notifyData);
    }
}
