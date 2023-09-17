namespace JavaScriptMinifierCompressorApp;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        FilesListBox = new ListBox();
        ExecuteButton = new Button();
        SuspendLayout();
        // 
        // FilesListBox
        // 
        FilesListBox.FormattingEnabled = true;
        FilesListBox.ItemHeight = 20;
        FilesListBox.Location = new Point(12, 12);
        FilesListBox.Name = "FilesListBox";
        FilesListBox.Size = new Size(296, 264);
        FilesListBox.TabIndex = 0;
        // 
        // ExecuteButton
        // 
        ExecuteButton.Location = new Point(12, 295);
        ExecuteButton.Name = "ExecuteButton";
        ExecuteButton.Size = new Size(296, 29);
        ExecuteButton.TabIndex = 1;
        ExecuteButton.Text = "Execute";
        ExecuteButton.UseVisualStyleBackColor = true;
        ExecuteButton.Click += ExecuteButton_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(324, 351);
        Controls.Add(ExecuteButton);
        Controls.Add(FilesListBox);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        Name = "Form1";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "JavaScript Minifier Compressor";
        ResumeLayout(false);
    }

    #endregion

    private ListBox FilesListBox;
    private Button ExecuteButton;
}
