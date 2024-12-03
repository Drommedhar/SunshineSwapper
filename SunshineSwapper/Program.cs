using System.Diagnostics;
using AudioSwitcher.AudioApi.CoreAudio;

namespace SunshineSwapper;

class Program
{
    /// <summary>
    /// </summary>
    /// <param name="args">/x %SUNSHINE_CLIENT_WIDTH% /y %SUNSHINE_CLIENT_HEIGHT% /r %SUNSHINE_CLIENT_FPS% /device Id of the device</param>
    static void Main(string[] args)
    {
        var dictArgs = new Dictionary<string, string>();
        for (int i = 0; i < args.Length; i += 2)
        {
            dictArgs.Add(args[i], args[i + 1]);
        }

        if (dictArgs.TryGetValue("/device", out var newPlaybackDeviceId))
        {
            var controller = new CoreAudioController();
            var devices = controller.GetPlaybackDevices();
            var newDevice = devices.FirstOrDefault(d => d.RealId.Equals(newPlaybackDeviceId));
            if (newDevice is null)
            {
                return;
            }

            newDevice.SetAsDefault();   
        }

        if (dictArgs.TryGetValue("/x", out var x) && dictArgs.TryGetValue("/y", out var y) &&
            dictArgs.TryGetValue("/r", out var fps))
        {
            var proc = Process.Start("QRes.exe", ["/x", x, "/y", y, "/r", fps]);
            proc.WaitForExit();
        }
    }
}