using System.Diagnostics;
using JavaScriptMinifierCompressorApp.Classes;

namespace JavaScriptMinifierCompressorApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        string[] args = Environment.GetCommandLineArgs();

        if (args.Length == 2)
        {
            var folder = args[1];

            if (Operations.Initialize(folder))
            {
                FilesListBox.DataSource = Operations.Files;
            }
            else
            {
                ExecuteButton.Enabled = false;
            }
        }
        else
        {
            ExecuteButton.Enabled = false;
        }

    }

    private void ExecuteButton_Click(object sender, EventArgs e)
    {
        
        var (_, exception) = Operations.Execute(FilesListBox.Text);

        if (exception is not null)
        {
            MessageBox.Show(
                $"""
                      Error:
                      {exception.Message}
                      """);
        }
    }
}
