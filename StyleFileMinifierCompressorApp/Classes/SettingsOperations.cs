using System.Text.Json;
using StyleFileMinifierCompressorApp.Models;

namespace StyleFileMinifierCompressorApp.Classes;

public class SettingsOperations
{
    public static string FileName { get; set; } = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json");
    public static void Save(string folderName)
    {
        AppSettings appSettings = new()
        {
            InitialFolder = folderName
        };

        File.WriteAllText(FileName, JsonSerializer.Serialize(appSettings,
            new JsonSerializerOptions { WriteIndented = true }));
    }

    /// <summary>
    /// Create appsettings.json first time or if simply missing
    /// </summary>
    public static void CreateAppsettingsIfMissing()
    {
        if (!File.Exists(FileName))
        {
            AppSettings appSettings = new()
            {
                InitialFolder = "C:\\"
            };

            File.WriteAllText(FileName, JsonSerializer.Serialize(appSettings,
                new JsonSerializerOptions { WriteIndented = true }));
        }
    }
    /// <summary>
    /// Get last used folder
    /// </summary>
    /// <returns>last folder if exists, else C:\</returns>
    public static string GetFolder()
    {
        AppSettings settings = JsonSerializer.Deserialize<AppSettings>(File.ReadAllText(FileName));

        return Directory.Exists(settings.InitialFolder) ? settings.InitialFolder : "C:\\";
    }
}