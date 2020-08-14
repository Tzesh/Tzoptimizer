using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
            ArrayList Process = new ArrayList();

            if (FullScreenOptimizations.CheckState == CheckState.Checked) {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"System\GameConfigStore"), "GameDVR_FSEBehavior", 2);
                Process.Add("FullScreenOptimizations has been disabled globally.");
            }

            if (NetworkThrottlingIndex.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "NetworkThrottlingIndex", 4294967295);
                Process.Add("NetworkThrottlingIndex has been minimized.");
            }

            if (SystemResponsiveness.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "SystemResponsiveness", 0);
                Process.Add("SystemResponsiveness has been set to 0.");
            }

            if (HighPriority.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "GPU Priority", 8);
                RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "Priority", 6);
                Process.Add("Games' priority has been changed to higher-priority.");
            }

            if (Cortana.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Windows Search"), "AllowCortana", 0);
                Process.Add("Cortana has been disabled.");
            }

            if (StartupDelay.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Serialize"), "StartupDelayInMSec", 0);
                Process.Add("StartupDelay has been removed.");
            }

            if (DisableBing.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Explorer"), "DisableSearchBoxSuggestions", 1);
                Process.Add("Bing has been removed from Startup Menu.");
            }

            if (ADS.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SilentInstalledAppsEnabled", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SystemPaneSuggestionsEnabled", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SoftLandingEnabled", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "RotatingLockScreenEnabled", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "RotatingLockScreenOverlayEnabled", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SubscribedContent-310093Enabled", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "ShowSyncProviderNotifications", 0);
                Process.Add("All the advertisements has been removed.");
            }

            if (SSD.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters"), "EnableSuperfetch", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters"), "EnablePrefetcher", 0);
                Process.Add("Prefetch and Superfetch has been optimized for SSD.");
            }

            if (HWAcc.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\GraphicsDrivers"), "HwSchMode", 2);
                Process.Add("Enabled Hardware Accelerated GPU Scheduling.");
            }

            if (GameDVR.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR"), "AppCaptureEnabled", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR"), "HistoricalCaptureEnabled", 0);
                Process.Add("GameDVR, AppCapture and HistoricalCapture has been disabled.");
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\GameBar"), "AllowAutoGameMode", 1);
                Process.Add("Game Mode has been enabled it works properly after 2004.");
            }

            if (Enhancepointerprecision.CheckState == CheckState.Checked)
            {
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse"), "MouseSpeed", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse"), "MouseThreshold1", 0);
                RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse"), "MouseThreshold2", 0);
                Process.Add("Enchance Pointer Precision has been disabled.");
            }

            if (Process.Count == 0)
            {
                MessageBox.Show("Please select the processes that you want to do.", "Tzoptimizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Information.Text = "Please select the processes that you want to do.";
            }
            else
            {
                int progress = 100 / Process.Count;
                progressBar1.Maximum = 100;
                foreach (var Temp in Process)
                {
                    Information.Text = (string)Temp;
                    progressBar1.Value = progress;
                }

                progressBar1.Value = 100;

                if (MessageBox.Show("Selected processes have been done. You may need to restart your computer to apply all the changes. Do you want to exit?", "Tzoptimizer",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }

        private void Form1_Closing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Closing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Tzoptimizer", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            if (SelectAll.CheckState == CheckState.Checked)
            {
                FullScreenOptimizations.CheckState = CheckState.Checked;
                NetworkThrottlingIndex.CheckState = CheckState.Checked;
                SystemResponsiveness.CheckState = CheckState.Checked;
                HighPriority.CheckState = CheckState.Checked;
                Cortana.CheckState = CheckState.Checked;
                StartupDelay.CheckState = CheckState.Checked;
                DisableBing.CheckState = CheckState.Checked;
                ADS.CheckState = CheckState.Checked;
                SSD.CheckState = CheckState.Checked;
                HWAcc.CheckState = CheckState.Checked;
                GameDVR.CheckState = CheckState.Checked;
                Enhancepointerprecision.CheckState = CheckState.Checked;
            }
            else
            {
                FullScreenOptimizations.CheckState = CheckState.Unchecked;
                NetworkThrottlingIndex.CheckState = CheckState.Unchecked;
                SystemResponsiveness.CheckState = CheckState.Unchecked;
                HighPriority.CheckState = CheckState.Unchecked;
                Cortana.CheckState = CheckState.Unchecked;
                StartupDelay.CheckState = CheckState.Unchecked;
                DisableBing.CheckState = CheckState.Unchecked;
                ADS.CheckState = CheckState.Unchecked;
                SSD.CheckState = CheckState.Unchecked;
                HWAcc.CheckState = CheckState.Unchecked;
                GameDVR.CheckState = CheckState.Unchecked;
                Enhancepointerprecision.CheckState = CheckState.Unchecked;
            }
        }
    }
}
