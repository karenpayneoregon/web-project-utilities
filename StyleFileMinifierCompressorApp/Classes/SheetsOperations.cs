using System.Diagnostics;

namespace StyleFileMinifierCompressorApp.Classes;
internal class SheetsOperations
{
    /// <summary>
    /// Minimize file to same folder as the original file
    /// </summary>
    /// <param name="fileName">valid .css file</param>
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
    /// <summary>
    /// Create map file for fileName in the same folder as the original file
    /// </summary>
    /// <param name="fileName">valid .css file</param>
    public static void CreateMap(string fileName)
    {
        var command = $"UglifyCSS {Path.GetFileName(fileName)} >{Path.GetFileName(fileName)}.map";
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
