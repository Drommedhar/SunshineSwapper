# SunshineSwapper

Pretty simple tool that also uses QRes.exe to change the desktop resolution and also the default Audio device.
Can be used with Sunshine Game Streaming to automate what device and what resolution should be set if a streaming session is started and ended.

Commandline Arguments:
/x Width
/y Height
/r FPS
/device RealId/DeviceId for the Audio Playback device

A sample command would look like this:
"cmd \/C D:\\SunshineSwapper\\SunshineSwapper.exe \/x %SUNSHINE_CLIENT_WIDTH% \/y %SUNSHINE_CLIENT_HEIGHT% \/r %SUNSHINE_CLIENT_FPS% /device {0.0.0.00000000}.{548a121a-c782-4e09-b344-1789ec5c8e89}"