using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StyleFileMinifierCompressorApp.Classes;
internal class Operations
{
    /// <summary>
    /// Location of CSS files
    /// </summary>
    public static string Folder { get; set; }
    /// <summary>
    /// List of CSS files
    /// </summary>
    public static List<string> Files { get; set; }

    public static bool Initialize(string folder)
    {
        return false;
    }

    public static (bool success, Exception exception) Execute(string fileName)
    {
        return (true, null);
    }
}
