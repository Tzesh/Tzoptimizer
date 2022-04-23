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
            this.chk_SelectAll = new System.Windows.Forms.CheckBox();
            this.Tzoptimermation = new System.Windows.Forms.Label();
            this.GithubLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.rtb_System = new System.Windows.Forms.RichTextBox();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.btn_Optimize = new System.Windows.Forms.Button();
            this.lbl_Main = new System.Windows.Forms.Label();
            this.lbl_System = new System.Windows.Forms.Label();
            this.flp_Tweaks = new System.Windows.Forms.FlowLayoutPanel();
            this.lbl_HowTo = new System.Windows.Forms.Label();
            this.lbl_Reminder = new System.Windows.Forms.Label();
            this.lbl_Reminder1 = new System.Windows.Forms.Label();
            this.lbl_Reminder2 = new System.Windows.Forms.Label();
            this.lbl_Reminder3 = new System.Windows.Forms.Label();
            this.lbl_Reminder4 = new System.Windows.Forms.Label();
            this.lbl_Reminder5 = new System.Windows.Forms.Label();
            this.lbl_Revert = new System.Windows.Forms.Label();
            this.lbl_RevertHeader = new System.Windows.Forms.Label();
            this.btn_Revert = new System.Windows.Forms.Button();
            this.lbl_Progress = new System.Windows.Forms.Label();
            this.rtb_Progress = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // VersionLabel
            // 
            resources.ApplyResources(this.VersionLabel, "VersionLabel");
            this.VersionLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.VersionLabel.Name = "VersionLabel";
            // 
            // chk_SelectAll
            // 
            resources.ApplyResources(this.chk_SelectAll, "chk_SelectAll");
            this.chk_SelectAll.Name = "chk_SelectAll";
            this.chk_SelectAll.UseVisualStyleBackColor = true;
            this.chk_SelectAll.CheckedChanged += new System.EventHandler(this.SelectAllCheckBox_CheckedChanged);
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
            // label9
            // 
            resources.ApplyResources(this.label9, "label9");
            this.label9.Name = "label9";
            // 
            // rtb_System
            // 
            this.rtb_System.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtb_System, "rtb_System");
            this.rtb_System.Name = "rtb_System";
            this.rtb_System.ReadOnly = true;
            // 
            // Logo
            // 
            this.Logo.Image = global::Tzoptimizer.Properties.Resources.black;
            resources.ApplyResources(this.Logo, "Logo");
            this.Logo.Name = "Logo";
            this.Logo.TabStop = false;
            this.Logo.Click += new System.EventHandler(this.Logo_Click);
            // 
            // btn_Optimize
            // 
            resources.ApplyResources(this.btn_Optimize, "btn_Optimize");
            this.btn_Optimize.Name = "btn_Optimize";
            this.btn_Optimize.UseVisualStyleBackColor = true;
            this.btn_Optimize.Click += new System.EventHandler(this.btn_Optimize_Click);
            // 
            // lbl_Main
            // 
            resources.ApplyResources(this.lbl_Main, "lbl_Main");
            this.lbl_Main.Name = "lbl_Main";
            // 
            // lbl_System
            // 
            resources.ApplyResources(this.lbl_System, "lbl_System");
            this.lbl_System.Name = "lbl_System";
            // 
            // flp_Tweaks
            // 
            resources.ApplyResources(this.flp_Tweaks, "flp_Tweaks");
            this.flp_Tweaks.Name = "flp_Tweaks";
            // 
            // lbl_HowTo
            // 
            resources.ApplyResources(this.lbl_HowTo, "lbl_HowTo");
            this.lbl_HowTo.Name = "lbl_HowTo";
            // 
            // lbl_Reminder
            // 
            resources.ApplyResources(this.lbl_Reminder, "lbl_Reminder");
            this.lbl_Reminder.Name = "lbl_Reminder";
            // 
            // lbl_Reminder1
            // 
            resources.ApplyResources(this.lbl_Reminder1, "lbl_Reminder1");
            this.lbl_Reminder1.Name = "lbl_Reminder1";
            // 
            // lbl_Reminder2
            // 
            resources.ApplyResources(this.lbl_Reminder2, "lbl_Reminder2");
            this.lbl_Reminder2.Name = "lbl_Reminder2";
            // 
            // lbl_Reminder3
            // 
            resources.ApplyResources(this.lbl_Reminder3, "lbl_Reminder3");
            this.lbl_Reminder3.Name = "lbl_Reminder3";
            // 
            // lbl_Reminder4
            // 
            resources.ApplyResources(this.lbl_Reminder4, "lbl_Reminder4");
            this.lbl_Reminder4.Name = "lbl_Reminder4";
            // 
            // lbl_Reminder5
            // 
            resources.ApplyResources(this.lbl_Reminder5, "lbl_Reminder5");
            this.lbl_Reminder5.Name = "lbl_Reminder5";
            // 
            // lbl_Revert
            // 
            resources.ApplyResources(this.lbl_Revert, "lbl_Revert");
            this.lbl_Revert.Name = "lbl_Revert";
            // 
            // lbl_RevertHeader
            // 
            resources.ApplyResources(this.lbl_RevertHeader, "lbl_RevertHeader");
            this.lbl_RevertHeader.Name = "lbl_RevertHeader";
            // 
            // btn_Revert
            // 
            resources.ApplyResources(this.btn_Revert, "btn_Revert");
            this.btn_Revert.Name = "btn_Revert";
            this.btn_Revert.UseVisualStyleBackColor = true;
            this.btn_Revert.Click += new System.EventHandler(this.btn_Revert_Click);
            // 
            // lbl_Progress
            // 
            resources.ApplyResources(this.lbl_Progress, "lbl_Progress");
            this.lbl_Progress.Name = "lbl_Progress";
            // 
            // rtb_Progress
            // 
            this.rtb_Progress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.rtb_Progress, "rtb_Progress");
            this.rtb_Progress.Name = "rtb_Progress";
            this.rtb_Progress.ReadOnly = true;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.btn_Revert);
            this.Controls.Add(this.lbl_RevertHeader);
            this.Controls.Add(this.lbl_Revert);
            this.Controls.Add(this.lbl_Reminder5);
            this.Controls.Add(this.lbl_Reminder4);
            this.Controls.Add(this.lbl_Reminder3);
            this.Controls.Add(this.lbl_Reminder2);
            this.Controls.Add(this.lbl_Reminder1);
            this.Controls.Add(this.lbl_Reminder);
            this.Controls.Add(this.lbl_HowTo);
            this.Controls.Add(this.flp_Tweaks);
            this.Controls.Add(this.lbl_System);
            this.Controls.Add(this.lbl_Main);
            this.Controls.Add(this.btn_Optimize);
            this.Controls.Add(this.rtb_System);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.rtb_Progress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.GithubLabel);
            this.Controls.Add(this.Tzoptimermation);
            this.Controls.Add(this.chk_SelectAll);
            this.Controls.Add(this.lbl_Progress);
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
        private System.Windows.Forms.CheckBox chk_SelectAll;
        private System.Windows.Forms.Label Tzoptimermation;
        private System.Windows.Forms.Label GithubLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.RichTextBox rtb_System;
        private System.Windows.Forms.Button btn_Optimize;
        private System.Windows.Forms.Label lbl_Main;
        private System.Windows.Forms.Label lbl_System;
        private System.Windows.Forms.FlowLayoutPanel flp_Tweaks;
        private System.Windows.Forms.Label lbl_HowTo;
        private System.Windows.Forms.Label lbl_Reminder;
        private System.Windows.Forms.Label lbl_Reminder1;
        private System.Windows.Forms.Label lbl_Reminder2;
        private System.Windows.Forms.Label lbl_Reminder3;
        private System.Windows.Forms.Label lbl_Reminder4;
        private System.Windows.Forms.Label lbl_Reminder5;
        private System.Windows.Forms.Label lbl_Revert;
        private System.Windows.Forms.Label lbl_RevertHeader;
        private System.Windows.Forms.Button btn_Revert;
        private System.Windows.Forms.Label lbl_Progress;
        private System.Windows.Forms.RichTextBox rtb_Progress;
    }
}

