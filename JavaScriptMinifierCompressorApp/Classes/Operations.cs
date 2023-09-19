using System.Diagnostics;

namespace JavaScriptMinifierCompressorApp.Classes;
internal class Operations
{
    /// <summary>
    /// Location of JavaScript files
    /// </summary>
    public static string Folder { get; set; }
    /// <summary>
    /// List of JavaScript files
    /// </summary>
    public static List<string> Files { get; set; }

    public static bool Initialize(string folder)
    {
        Folder = folder;

        // unsure why a " is at end of this string
        if (folder.Last() == '"')
        {
            Folder = folder[..^1];
        }
        
        if (Directory.Exists(Folder))
        {
            
            Folder = Path.Combine(Folder, "wwwroot\\js");
            if (Directory.Exists(Folder))
            {
                Files = Directory.GetFiles(Folder, "*.js")
                    .Where(f => !f.Contains(".min"))
                    .Select(Path.GetFileName)
                    .ToList()!;
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            return false;
        }
    }

    /// <summary>
    /// Create .min and .map files
    /// </summary>
    /// <param name="fileName">Valid JavaScript file</param>
    public static (bool success, Exception exception) Execute(string fileName)
    {
        var mappedName = Path.ChangeExtension(fileName, ".min.js");
        var command = $" uglifyjs {fileName} -o {Folder}\\{mappedName} -c -m --source-map";
        Environment.CurrentDirectory = Folder;

        var start = new ProcessStartInfo
        {
            FileName = "powershell.exe",
            UseShellExecute = false,
            RedirectStandardOutput = true,
            Arguments = command,
            CreateNoWindow = true
        };

        try
        {
            using var process = Process.Start(start);
            return (true, null);
        }
        catch (Exception ex)
        {
            return (false, ex);
        }
    }
}
