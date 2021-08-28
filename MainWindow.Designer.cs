namespace Tzoptimizer
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.VersionLabel = new System.Windows.Forms.Label();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.ProgressLabel = new System.Windows.Forms.Label();
            this.SelectAllCheckBox = new System.Windows.Forms.CheckBox();
            this.Tzoptimermation = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.ProcessesBox = new System.Windows.Forms.CheckedListBox();
            this.Recommended = new System.Windows.Forms.ComboBox();
            this.RecommendedSettingsLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.ProgressInfo = new System.Windows.Forms.RichTextBox();
            this.SystemInfo = new System.Windows.Forms.RichTextBox();
            this.OptionalButton = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.OptimizeButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SystemInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            this.VersionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VersionLabel.Name = "VersionLabel";
            // 
            // ProgressBar
            // 
            resources.ApplyResources(this.ProgressBar, "ProgressBar");
            this.ProgressBar.Name = "ProgressBar";
            // 
            // ProgressLabel
            // 
            resources.ApplyResources(this.ProgressLabel, "ProgressLabel");
            this.ProgressLabel.Name = "ProgressLabel";
            // 
            // SelectAllCheckBox
            // 
            resources.ApplyResources(this.SelectAllCheckBox, "SelectAllCheckBox");
            this.SelectAllCheckBox.Name = "SelectAllCheckBox";
            this.SelectAllCheckBox.UseVisualStyleBackColor = true;
            this.SelectAllCheckBox.CheckedChanged += new System.EventHandler(this.SelectAll_CheckedChanged);
            // 
            // Tzoptimermation
            // 
            resources.ApplyResources(this.Tzoptimermation, "Tzoptimermation");
            this.Tzoptimermation.Name = "Tzoptimermation";
            // 
            // GithubLabel
            // 
            resources.ApplyResources(this.GithubLabel, "GithubLabel");
            this.GithubLabel.Name = "GithubLabel";
            // 
            // ProcessesBox
            // 
            this.ProcessesBox.FormattingEnabled = true;
            this.ProcessesBox.Items.AddRange(new object[] {
            resources.GetString("ProcessesBox.Items"),
            resources.GetString("ProcessesBox.Items1"),
            resources.GetString("ProcessesBox.Items2"),
            resources.GetString("ProcessesBox.Items3"),
            resources.GetString("ProcessesBox.Items4"),
            resources.GetString("ProcessesBox.Items5"),
            resources.GetString("ProcessesBox.Items6"),
            resources.GetString("ProcessesBox.Items7"),
            resources.GetString("ProcessesBox.Items8"),
            resources.GetString("ProcessesBox.Items9"),
            resources.GetString("ProcessesBox.Items10"),
            resources.GetString("ProcessesBox.Items11"),
            resources.GetString("ProcessesBox.Items12"),
            resources.GetString("ProcessesBox.Items13"),
            resources.GetString("ProcessesBox.Items14"),
            resources.GetString("ProcessesBox.Items15"),
            resources.GetString("ProcessesBox.Items16"),
            resources.GetString("ProcessesBox.Items17"),
            resources.GetString("ProcessesBox.Items18"),
            resources.GetString("ProcessesBox.Items19")});
            resources.ApplyResources(this.ProcessesBox, "ProcessesBox");
            this.ProcessesBox.Name = "ProcessesBox";
            // 
            // Recommended
            // 
            this.Recommended.BackColor = System.Drawing.SystemColors.Window;
            this.Recommended.Cursor = System.Windows.Forms.Cursors.Default;
            this.Recommended.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Recommended.FormattingEnabled = true;
            this.Recommended.Items.AddRange(new object[] {
            resources.GetString("Recommended.Items"),
            resources.GetString("Recommended.Items1")});
            resources.ApplyResources(this.Recommended, "Recommended");
            this.Recommended.Name = "Recommended";
            this.Recommended.SelectedIndexChanged += new System.EventHandler(this.Recommended_SelectedIndexChanged);
            // 
            // RecommendedSettingsLabel
            // 
            resources.ApplyResources(this.RecommendedSettingsLabel, "RecommendedSettingsLabel");
            this.RecommendedSettingsLabel.Name = "RecommendedSettingsLabel";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // ProgressInfo
            // 
            this.ProgressInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.ProgressInfo, "ProgressInfo");
            this.ProgressInfo.Name = "ProgressInfo";
            this.ProgressInfo.ReadOnly = true;
            // 
            // SystemInfo
            // 
            this.SystemInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.SystemInfo, "SystemInfo");
            this.SystemInfo.Name = "SystemInfo";
            this.SystemInfo.ReadOnly = true;
            // 
            // OptionalButton
            // 
            resources.ApplyResources(this.OptionalButton, "OptionalButton");
            this.OptionalButton.Name = "OptionalButton";
            this.OptionalButton.UseVisualStyleBackColor = true;
            this.OptionalButton.Click += new System.EventHandler(this.OptionalButton_Click);
            // 
            // Logo
            // 
            this.Logo.Image = global::Tzoptimizer.Properties.Resources.black;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // OptimizeButton
            // 
            resources.ApplyResources(this.OptimizeButton, "OptimizeButton");
            this.OptimizeButton.Name = "OptimizeButton";
            this.OptimizeButton.UseVisualStyleBackColor = true;
            this.OptimizeButton.Click += new System.EventHandler(this.OptimizeButton_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // SystemInfoLabel
            // 
            resources.ApplyResources(this.SystemInfoLabel, "SystemInfoLabel");
            this.SystemInfoLabel.Name = "SystemInfoLabel";
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.SystemInfoLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OptimizeButton);
            this.Controls.Add(this.OptionalButton);
            this.Controls.Add(this.SystemInfo);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.ProgressInfo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.RecommendedSettingsLabel);
            this.Controls.Add(this.Recommended);
            this.Controls.Add(this.ProcessesBox);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.Tzoptimermation);
            this.Controls.Add(this.SelectAllCheckBox);
            this.Controls.Add(this.ProgressLabel);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.VersionLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_Closed);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainWindow_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label VersionLabel;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.Windows.Forms.Label ProgressLabel;
        private System.Windows.Forms.CheckBox SelectAllCheckBox;
        private System.Windows.Forms.Label Tzoptimermation;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.CheckedListBox ProcessesBox;
        private System.Windows.Forms.ComboBox Recommended;
        private System.Windows.Forms.Label RecommendedSettingsLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox ProgressInfo;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.RichTextBox SystemInfo;
        private System.Windows.Forms.Button OptionalButton;
        private System.Windows.Forms.Button OptimizeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label SystemInfoLabel;
    }
}

