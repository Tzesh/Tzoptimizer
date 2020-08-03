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
            this.FullScreenOptimizations = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NetworkThrottlingIndex = new System.Windows.Forms.CheckBox();
            this.SystemResponsiveness = new System.Windows.Forms.CheckBox();
            this.HighPriority = new System.Windows.Forms.CheckBox();
            this.Cortana = new System.Windows.Forms.CheckBox();
            this.StartupDelay = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FullScreenOptimizations
            // 
            resources.ApplyResources(this.FullScreenOptimizations, "FullScreenOptimizations");
            this.FullScreenOptimizations.Name = "FullScreenOptimizations";
            this.FullScreenOptimizations.UseVisualStyleBackColor = true;
            this.FullScreenOptimizations.CheckedChanged += new System.EventHandler(this.FullScreenOptimizations_CheckedChanged);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
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
            // NetworkThrottlingIndex
            // 
            resources.ApplyResources(this.NetworkThrottlingIndex, "NetworkThrottlingIndex");
            this.NetworkThrottlingIndex.Name = "NetworkThrottlingIndex";
            this.NetworkThrottlingIndex.UseVisualStyleBackColor = true;
            // 
            // SystemResponsiveness
            // 
            resources.ApplyResources(this.SystemResponsiveness, "SystemResponsiveness");
            this.SystemResponsiveness.Name = "SystemResponsiveness";
            this.SystemResponsiveness.UseVisualStyleBackColor = true;
            // 
            // HighPriority
            // 
            resources.ApplyResources(this.HighPriority, "HighPriority");
            this.HighPriority.Name = "HighPriority";
            this.HighPriority.UseVisualStyleBackColor = true;
            this.HighPriority.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // Cortana
            // 
            resources.ApplyResources(this.Cortana, "Cortana");
            this.Cortana.Name = "Cortana";
            this.Cortana.UseVisualStyleBackColor = true;
            // 
            // StartupDelay
            // 
            resources.ApplyResources(this.StartupDelay, "StartupDelay");
            this.StartupDelay.Name = "StartupDelay";
            this.StartupDelay.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            resources.ApplyResources(this.label7, "label7");
            this.label7.Name = "label7";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.StartupDelay);
            this.Controls.Add(this.Cortana);
            this.Controls.Add(this.HighPriority);
            this.Controls.Add(this.SystemResponsiveness);
            this.Controls.Add(this.NetworkThrottlingIndex);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FullScreenOptimizations);
            this.Controls.Add(this.button1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox FullScreenOptimizations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox NetworkThrottlingIndex;
        private System.Windows.Forms.CheckBox SystemResponsiveness;
        private System.Windows.Forms.CheckBox HighPriority;
        private System.Windows.Forms.CheckBox Cortana;
        private System.Windows.Forms.CheckBox StartupDelay;
        private System.Windows.Forms.Label label7;
    }
}

