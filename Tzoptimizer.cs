﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using Microsoft.TeamFoundation.Common;
using System.IO;

namespace Windows_Optimizer
{
    public partial class Tzoptimizer : Form
    {
        public Tzoptimizer()
        {
            InitializeComponent();
            gatherSystemInfo();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ArrayList Process = new ArrayList();
            for (int i = 0; i < ProcessesBox.Items.Count; i++)
            {
                if (ProcessesBox.GetItemChecked(i) == true) {
                switch (i)
                {
                    case 0:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"System\GameConfigStore"), "GameDVR_FSEBehavior", 2);
                        Process.Add("Full Screen Optimizations have been disabled system wide.");
                        break;
                    case 1:
                        RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "NetworkThrottlingIndex", 4294967295);
                        RegistryManager.DisableNablesAlgorithm(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces"));
                        Process.Add("Disabled Nagle's Algorithm and Network Throttling Index.");
                        break;
                    case 2:
                        RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "SystemResponsiveness", 0);
                        Process.Add("SystemResponsiveness has been set to 0.");
                        break;
                    case 3:
                        RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "GPU Priority", 8);
                        RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "Priority", 6);
                        Process.Add("Games' priority has been changed to higher-priority.");
                        break;
                    case 4:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Windows Search"), "AllowCortana", 0);
                        Process.Add("Cortana has been disabled.");
                        break;
                    case 5:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Serialize"), "StartupDelayInMSec", 0);
                        Process.Add("StartupDelay has been removed.");
                        break;
                    case 6:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\GraphicsDrivers"), "HwSchMode", 2);
                        Process.Add("Enabled Hardware Accelerated GPU Scheduling.");
                        break;
                    case 7:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR"), "AppCaptureEnabled", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\GameDVR"), "HistoricalCaptureEnabled", 0);
                        Process.Add("GameDVR, AppCapture and HistoricalCapture have been disabled.");
                        break;
                    case 8:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\GameBar"), "AllowAutoGameMode", 1);
                        Process.Add("Game Mode has been enabled it works properly after 2004.");
                        break;
                    case 9:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse"), "MouseSpeed", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse"), "MouseThreshold1", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse"), "MouseThreshold2", 0);
                        Process.Add("Enchanced Pointer Precision has been disabled.");
                        break;
                    case 10:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SilentInstalledAppsEnabled", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SystemPaneSuggestionsEnabled", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SoftLandingEnabled", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "RotatingLockScreenEnabled", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "RotatingLockScreenOverlayEnabled", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\ContentDeliveryManager"), "SubscribedContent-310093Enabled", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "ShowSyncProviderNotifications", 0);
                        Process.Add("All the advertisements have been removed.");
                        break;
                    case 11:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Explorer"), "DisableSearchBoxSuggestions", 1);
                        Process.Add("Bing has been removed from Startup Menu.");
                        break;
                    case 12:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters"), "EnableSuperfetch", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management\PrefetchParameters"), "EnablePrefetcher", 0);
                        Process.Add("Prefetch and Superfetch have been optimized for SSD.");
                        break;
                     default:
                        break;
                }
                }
            }
            if (Process.Count == 0)
            {
                MessageBox.Show("Please select the processes that you want to do.", "Tzoptimizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgressInfo.Text = "Please select the processes that you want to do.";
            }
            else
            {
                int progress = 100 / Process.Count;
                progressBar1.Maximum = 100;
                ProgressInfo.Clear();
                foreach (var Temp in Process)
                {
                    ProgressInfo.AppendText((string)Temp + "\n");
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
            for (int i = 0; i < ProcessesBox.Items.Count; i++)
            {
                if (SelectAll.Checked == true)
                {
                    ProcessesBox.SetItemChecked(i, true);
                }
                else
                {
                    ProcessesBox.SetItemChecked(i, false);
                }
            }
        }

        private void Recommended_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Recommended.SelectedIndex == 0)
            {
                for (int i = 0; i < ProcessesBox.Items.Count; i++)
                {
                        ProcessesBox.SetItemChecked(i, true);
                }
                ProcessesBox.SetItemChecked(12, false);
            }
            if (Recommended.SelectedIndex == 1) {
                for (int i = 0; i < ProcessesBox.Items.Count; i++)
                {
                        ProcessesBox.SetItemChecked(i, true);
                }
            }
        }

        private void infoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (infoBox.SelectedIndex)
            {
                case 0:
                    ProcessInfo.Text = "Full Screen Optimizations, is a bunch of optimizations that have been added Windows 10 by Microsoft. But as you can guess, it's not helpful at all just the opposite...";
                    break;
                case 1:
                    ProcessInfo.Text = "Nagle’s Algorithm combines several small packets into a single, larger packet for more efficient transmissions. This is designed to improve throughput efficiency of data transmission. Disabling “nagling” can help reduce latency/ping in some games. Nagle’s algorithm is enabled in Windows by default.\n" +
                        "Windows implements a network throttling mechanism, the idea behind such throttling is that processing of network packets can be a resource-intensive task. It is beneficial to turn off such throttling for achieving maximum throughput...";
                    break;
                case 2:
                    ProcessInfo.Text = "Multimedia streaming and some games that uses “Multimedia Class Scheduler” service (MMCSS) can only utilize up to 80% of the CPU. The “Multimedia Class Scheduler” service (MMCSS) ensures prioritized access to CPU resources, without denying CPU resources to lower-priority background applications.\n" +
                        "Update another tweak In Windows 8/8.1, just like with Windows 7, multimedia applications use the 'Multimedia Class Scheduler' service (MMCSS) to ensure priritized access to CPU resources, without denying CPU resources to lower-priority background applications. However, this also reserves 20% of CPU by default for background processes, your multimedia streaming and some games can only utilize up to 80% of the CPU. This setting, in combination with the above 'NetworkThrottlingIndex' can help some games and video streaming. We recommend reducing the reserved CPU for background processes from the default of 20%.";
                    break;
                case 3:
                    ProcessInfo.Text = "You can also change the priority of games to higher.";
                    break;
                case 4:
                    ProcessInfo.Text = "If you are not using Cortana or it's not supported in your country you can just disable it.";
                    break;
                case 5:
                    ProcessInfo.Text = "Windows always delays startup a little bit in order to make sure everything is working all right. Actually, you don't need this delay at all.";
                    break;
                case 6:
                    ProcessInfo.Text = "Recently, in Windows 10 2004, Microsoft added a feature which is called 'Hardware Accelerated GPU Scheduling' and it looks like works very well exclusively in 0.1% and 1% FPS. Basicly, it's increases your minimum-fps value.";
                    break;
                case 7:
                    ProcessInfo.Text = "GameDVR is the most common thing that every first human got trouble with it in Windows 10's early times. If you are using it, just please use Nvidia Geforce Experience or OBS to record your gameplay. It ruins your performance, not worth it.";
                    break;
                case 8:
                    ProcessInfo.Text = "If you are using Windows 10 2004 or higher version, I strongly recommend you to enable Game Mode. Including 2004 looks like Microsoft finally managed to increase our game performance by game mode.";
                    break;
                case 9:
                    ProcessInfo.Text = "Unless you are using and too old and not working well mouse you should disable Enchanced Pointer Precision. Just give a shot. It will totally worth it.";
                    break;
                case 10:
                    ProcessInfo.Text = "Windows 10 comes with lots of advertisements. This basic option just deletes all the advertisements at once. Strongly recommended.";
                    break;
                case 11:
                    ProcessInfo.Text = "Did you notice something boring while you are just looking for a file on your computer in search box? Yes, Bing Search! Who needs Bing even for searching in internet while Google exists?";
                    break;
                case 12:
                    ProcessInfo.Text = "Every time you run an application in your PC, a Prefetch file that contains information about the files loaded by the application is created by the Windows operating system. The information in the Prefetch file is used for optimizing the loading time of the application the next time that you run it. SuperFetch attempts to predict which applications you will launch next and preloads all of the necessary data into memory. Its prediction algorithm is superior and can predict which next 3 applications you will launch by what time in a day. In short, SuperFetch and Prefetch are Windows Storage Management technologies that provide fast access to data on traditional hard drives.On Solid State Drives, they result in unnecessary write operations.";
                    break;
            }
        }

        private void gatherSystemInfo()
        {
            SystemInfo.AppendText("Operating System: ");
            SystemInfo.AppendText(System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            SystemInfo.AppendText(Environment.Is64BitOperatingSystem ? " 64-bit" : " 32-bit");
            SystemInfo.AppendText("\nCPU: ");
            getComponent("Win32_Processor", "Name");
            SystemInfo.AppendText("RAM: ");
            getRAMsize();
            SystemInfo.AppendText("GPU(s): ");
            getComponent("Win32_VideoController", "Name");
            SystemInfo.AppendText("Disk(s) information: ");
            DiskChecker();

        }

        public void getComponent(string hwclass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                SystemInfo.AppendText(Convert.ToString(mj[syntax]) + "\n");
            }
        }

        private void getRAMsize()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject item in moc)
            {
                SystemInfo.AppendText(Convert.ToString(Math.Round(Convert.ToDouble(item.Properties["TotalPhysicalMemory"].Value) / (1048576 * 1024), 0)) + " GB\n");
            }
        }

        private void DiskChecker()
        {
            ManagementScope scope = new ManagementScope(@"\\.\root\microsoft\windows\storage");
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM MSFT_PhysicalDisk");
            scope.Connect();
            searcher.Scope = scope;
            ArrayList drives = new ArrayList();

            foreach (ManagementObject queryObj in searcher.Get())
            {
                switch (Convert.ToInt16(queryObj["MediaType"]))
                {
                    case 1:
                        drives.Add("Unspecified");
                        break;

                    case 3:
                        drives.Add("HDD");
                        break;

                    case 4:
                        drives.Add("SSD");
                        break;

                    case 5:
                        drives.Add("SCM");
                        break;

                    default:
                        drives.Add("Unspecified");
                        break;
                }
            }
            searcher.Dispose();

            DriveInfo[] allDrives = DriveInfo.GetDrives();

            foreach (DriveInfo d in allDrives)
            {
                int i = 0;
                SystemInfo.AppendText("\nDrive " + d.Name);
                SystemInfo.AppendText("\nDrive type: " + d.DriveType + " " + drives[i]);
                if (d.IsReady == true)
                {
                    SystemInfo.AppendText("\nVolume label: " + d.VolumeLabel);
                    SystemInfo.AppendText("\nFile system: " + d.DriveFormat);
                    SystemInfo.AppendText("\nAvailable space to current user: " + (d.AvailableFreeSpace / (1048576 * 1024), 0) + " GB");
                    SystemInfo.AppendText("\nTotal available space: " + (d.TotalFreeSpace / (1048576 * 1024), 0) + " GB");

                    SystemInfo.AppendText("\nTotal size of drive: " + (d.TotalSize / (1048576 * 1024), 0) + " GB");
                }
                i++;
            }

            if (drives[0].Equals("SSD"))
            {
                ProgressInfo.AppendText("\nLooks like your system is based on a SSD. We strongly recommend you to use recommended settings for SSD based systems.");
                ProgressInfo.AppendText("\nRecommended settings for SSD based systems selected.");
                Recommended.SelectedIndex = 1;
            } else
            {
                ProgressInfo.AppendText("\nLooks like your system is based on non-SSD. We strongly recommend you to use recommended settings for non-SSD based systems.");
                ProgressInfo.AppendText("\nRecommended settings for non-SSD based systems selected.");
                Recommended.SelectedIndex = 0;
            }
          }

        }
}
