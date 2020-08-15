namespace Windows_Optimizer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectAll = new System.Windows.Forms.CheckBox();
            this.Tzoptimermation = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProcessesBox = new System.Windows.Forms.CheckedListBox();
            this.Recommended = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.infoBox = new System.Windows.Forms.ComboBox();
            this.info = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Name = "label4";
            // 
            // progressBar1
            // 
            resources.ApplyResources(this.progressBar1, "progressBar1");
            this.progressBar1.Name = "progressBar1";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // SelectAll
            // 
            resources.ApplyResources(this.SelectAll, "SelectAll");
            this.SelectAll.Name = "SelectAll";
            this.SelectAll.UseVisualStyleBackColor = true;
            this.SelectAll.CheckedChanged += new System.EventHandler(this.SelectAll_CheckedChanged);
            // 
            // Tzoptimermation
            // 
            resources.ApplyResources(this.Tzoptimermation, "Tzoptimermation");
            this.Tzoptimermation.Name = "Tzoptimermation";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
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
            resources.GetString("ProcessesBox.Items12")});
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
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // infoBox
            // 
            this.infoBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.infoBox.FormattingEnabled = true;
            this.infoBox.Items.AddRange(new object[] {
            resources.GetString("infoBox.Items"),
            resources.GetString("infoBox.Items1"),
            resources.GetString("infoBox.Items2"),
            resources.GetString("infoBox.Items3"),
            resources.GetString("infoBox.Items4"),
            resources.GetString("infoBox.Items5"),
            resources.GetString("infoBox.Items6"),
            resources.GetString("infoBox.Items7"),
            resources.GetString("infoBox.Items8"),
            resources.GetString("infoBox.Items9"),
            resources.GetString("infoBox.Items10"),
            resources.GetString("infoBox.Items11"),
            resources.GetString("infoBox.Items12")});
            resources.ApplyResources(this.infoBox, "infoBox");
            this.infoBox.Name = "infoBox";
            this.infoBox.SelectedIndexChanged += new System.EventHandler(this.infoBox_SelectedIndexChanged);
            // 
            // info
            // 
            resources.ApplyResources(this.info, "info");
            this.info.Name = "info";
            // 
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // Information
            // 
            resources.ApplyResources(this.Information, "Information");
            this.Information.Name = "Information";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tzoptimizer.Properties.Resources.black;
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.info);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Recommended);
            this.Controls.Add(this.ProcessesBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tzoptimermation);
            this.Controls.Add(this.SelectAll);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_Closing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_Closing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox SelectAll;
        private System.Windows.Forms.Label Tzoptimermation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckedListBox ProcessesBox;
        private System.Windows.Forms.ComboBox Recommended;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox infoBox;
        private System.Windows.Forms.RichTextBox info;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox Information;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

