using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Windows_Optimizer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FullScreenOptimizations.CheckState == CheckState.Checked) {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"System\GameConfigStore"), "GameDVR_FSEBehavior", 2);
            }
            if (NetworkThrottlingIndex.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "NetworkThrottlingIndex", 4294967295);
            }
            if (SystemResponsiveness.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "SystemResponsiveness", 0);
            }
            if (HighPriority.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "GPU Priority", 8);
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "Priority", 6);
            }
            if (Cortana.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Windows Search"), "AllowCortana", 0);
            }
            if (StartupDelay.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Serialize"), "StartupDelayInMSec", 0);
            }

            MessageBox.Show("Selected processes are done.", "Windoptimizer", MessageBoxButtons.OK);
        }

        private void FullScreenOptimizations_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
