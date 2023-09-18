using System.Diagnostics;

namespace StyleFileMinifierCompressorApp.Classes;
internal class SheetsOperations
{
    public static void Minimize(string fileName)
    {

        var command = $"css-minify --file {Path.GetFileName(fileName)} -o .";
        Environment.CurrentDirectory = Path.GetDirectoryName(fileName)!;

        var start = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            Arguments = command,
            CreateNoWindow = true
        };

        using var process = Process.Start(start);

    }
    public static void CreateMap(string fileName)
    {

        var command = $"UglifyCSS {Path.GetFileName(fileName)} >debugger.css.map";
        Environment.CurrentDirectory = Path.GetDirectoryName(fileName)!;

        var start = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            Arguments = command,
            CreateNoWindow = true
        };
        using var process = Process.Start(start);
    }
}
