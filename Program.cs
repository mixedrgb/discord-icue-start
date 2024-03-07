using System.Diagnostics;

namespace discord_icue_start;

public class Program
{
    static void Main(string[] args)
    {
        string userEnv = Environment.UserName;

        string appPath = @"C:\Users\" + userEnv + @"\AppData\Local\Discord\Update.exe";
        string appCmd = "--processStart Discord.exe";
        var processInfo = new ProcessStartInfo();
        processInfo.UseShellExecute = false;
        processInfo.Arguments = appCmd;
        processInfo.CreateNoWindow = false;
        processInfo.FileName = appPath;
        Process p = Process.Start(processInfo);
    }
}
