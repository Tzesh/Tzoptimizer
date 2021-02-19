namespace Tzoptimizer
{
    partial class Optional
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Optional));
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.OptionalProcesses = new System.Windows.Forms.CheckedListBox();
            this.processSelect = new System.Windows.Forms.ComboBox();
            this.processInformation = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(559, 45);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // OptionalProcesses
            // 
            this.OptionalProcesses.FormattingEnabled = true;
            this.OptionalProcesses.Items.AddRange(new object[] {
            "Disable Windows Update",
            "Disable Driver Updates",
            "Disable Windows Defender",
            "Show Hidden Files And File Extensions",
            "Set Explorer Open To My Computer",
            "Disable P2P Update Delivery Optimization",
            "Allow Windows Updates For Other Products",
            "Enable Verbose Boot"});
            this.OptionalProcesses.Location = new System.Drawing.Point(13, 65);
            this.OptionalProcesses.Name = "OptionalProcesses";
            this.OptionalProcesses.Size = new System.Drawing.Size(280, 289);
            this.OptionalProcesses.TabIndex = 1;
            this.OptionalProcesses.SelectedIndexChanged += new System.EventHandler(this.OptionalProcesses_SelectedIndexChanged);
            // 
            // processSelect
            // 
            this.processSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.processSelect.FormattingEnabled = true;
            this.processSelect.Items.AddRange(new object[] {
            "Disable Windows Update",
            "Disable Driver Updates",
            "Disable Windows Defender",
            "Show Hidden Files And File Extensions",
            "Set Explorer Open To My Computer",
            "Disable P2P Update Delivery Optimization",
            "Allow Windows Updates For Other Products",
            "Enable Verbose Boot"});
            this.processSelect.Location = new System.Drawing.Point(299, 64);
            this.processSelect.Name = "processSelect";
            this.processSelect.Size = new System.Drawing.Size(272, 21);
            this.processSelect.TabIndex = 2;
            this.processSelect.SelectedIndexChanged += new System.EventHandler(this.processSelect_SelectedIndexChanged);
            // 
            // processInformation
            // 
            this.processInformation.Location = new System.Drawing.Point(300, 92);
            this.processInformation.Name = "processInformation";
            this.processInformation.ReadOnly = true;
            this.processInformation.Size = new System.Drawing.Size(272, 262);
            this.processInformation.TabIndex = 3;
            this.processInformation.Text = "You can select whether process that you want to do or not. The rest is just about" +
    " the same just close this window and click \'Optimize\'.";
            // 
            // Optional
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.processInformation);
            this.Controls.Add(this.processSelect);
            this.Controls.Add(this.OptionalProcesses);
            this.Controls.Add(this.richTextBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(600, 400);
            this.MinimumSize = new System.Drawing.Size(600, 400);
            this.Name = "Optional";
            this.Text = "Tzoptimizer - Windows 10 Optimizer - Optional Processes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Closing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox processSelect;
        private System.Windows.Forms.RichTextBox processInformation;
        private System.Windows.Forms.CheckedListBox OptionalProcesses;
    }
}