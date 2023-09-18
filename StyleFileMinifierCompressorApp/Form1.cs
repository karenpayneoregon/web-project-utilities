using StyleFileMinifierCompressorApp.Classes;

namespace StyleFileMinifierCompressorApp;

public partial class Form1 : Form
{
    public string Folder { get; set; }
    public Form1()
    {
        InitializeComponent();

        SettingsOperations.CreateAppsettingsIfMissing();
        var folder = SettingsOperations.GetFolder();
        Folder = string.IsNullOrWhiteSpace(folder) ? "C:\\" : folder;

        openFileDialog1.InitialDirectory = Folder;

    }

    private void ExecuteButton_Click(object sender, EventArgs e)
    {
        openFileDialog1.FileName = "";
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            var fileName = openFileDialog1.FileName;

            // assumes lower-cased file names and extensions
            if (!fileName.Contains(".min") || fileName.EndsWith(".map"))
            {
                try
                {
                    
                    SheetsOperations.Minimize(fileName);
                    SheetsOperations.CreateMap(fileName);

                    SettingsOperations.Save(Path.GetDirectoryName(fileName));

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show(@".min.css not permitted");
            }
        }
    }
}
