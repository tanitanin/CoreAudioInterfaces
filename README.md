# CoreAudioInterfaces

Windows Core Audio APIs Wrapper

https://msdn.microsoft.com/en-us/library/windows/desktop/dd370784.aspx

https://msdn.microsoft.com/ja-jp/library/windows/desktop/dd370805.aspx

- Mulltimedia Device (MMDevice) API. Clients use this API to enumerate the audio endpoint devices in the system.
- Windows Audio Session API (WASAPI). Clients use this API to create and manage audio streams to and from audio endpoint devices.
- DeviceTopology API. Clients use this API to directly access the topological features (for example, volume controls and multiplexers) that lie along the data paths inside hardware devices in audio adapters.
- EndpointVolume API. Clients use this API to directly access the volume controls on audio endpoint devices. This API is primarily used by applications that manage exclusive-mode audio streams.
