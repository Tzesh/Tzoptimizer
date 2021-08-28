using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using System.IO;

namespace Tzoptimizer
{
    public partial class MainWindow : Form
    {
        ArrayList optionalProcesses = new ArrayList(); // to store and get optional processes
        
        /// <summary>
        /// constructor of MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent(); // UI components
            GatherSystemInformation(); // display system information and recommend settings based on system drive
            AppearInformation(); // inform user about the program
        }

        /// <summary>
        /// selected processes will be done when optimize button has clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptimizeButton_Click(object sender, EventArgs e)
        {
            ArrayList Process = new ArrayList();

            // Tzoptimizer's processes based on indices so order is important thing in the application
            for (int i = 0; i < ProcessesBox.Items.Count; i++)
            {
                if (ProcessesBox.GetItemChecked(i) == true)
                {
                    switch (i)
                    {
                        case 0:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"System\GameConfigStore"), "GameDVR_FSEBehavior", 2);
                            Process.Add("Fullscreen optimizations have been disabled globally.");
                            break;

                        case 1:
                            RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "NetworkThrottlingIndex", 4294967295);
                            RegistryManager.DisableNablesAlgorithm(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SYSTEM\CurrentControlSet\Services\Tcpip\Parameters\Interfaces"));
                            Process.Add("Nagle's Algorithm has been disabled and Network Throttling Index has been minimized.");
                            break;

                        case 2:
                            RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile"), "SystemResponsiveness", 0);
                            Process.Add("System Responsiveness has been optimized.");
                            break;

                        case 3:
                            RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "GPU Priority", 8);
                            RegistryManager.SetRegistry(RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64).CreateSubKey(@"SOFTWARE\Microsoft\Windows NT\CurrentVersion\Multimedia\SystemProfile\Tasks\Games"), "Priority", 6);
                            Process.Add("Games' priority has been changed to higher priority.");
                            break;

                        case 4:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\Windows Search"), "AllowCortana", 0);
                            Process.Add("Cortana has been disabled.");
                            break;

                        case 5:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Serialize"), "StartupDelayInMSec", 0);
                            Process.Add("Startup Delay has been removed.");
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
                            Process.Add("Prefetch and Superfetch have been disabled for more optimized SSD.");
                            break;

                        case 13:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\ToggleKeys"), "Flags", 58);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Accessibility\ToggleKeys"), "Flags", 506);
                            Process.Add("Toggle Keys and Sticky Keys have been disabled.");
                            break;

                        case 14:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Office\16.0\Common"), "sendcustomerdata", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Office\16.0\Common\Feedback"), "enabled", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Office\16.0\Common\Feedback"), "includescreenshot", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Office\Common\ClientTelemetry"), "DisableTelemetry", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Office\16.0\Common"), "qmenable", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Office\16.0\Common"), "updatereliabilitydata", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Office\16.0\OSM"), "Enablelogging", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Policies\Microsoft\Office\16.0\OSM"), "EnableUpload", 0);
                            Process.Add("Office Telemetry (Data Collection For Office) has been disabled.");
                            break;

                        case 15:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Control Panel\Mouse"), "MouseHoverTime", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "Start_ShowRun", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"), "NoLowDiskSpaceChecks", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"), "LinkResolveIgnoreLinkInfo", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"), "NoResolveSearch", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"), "NoResolveTrack", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\Explorer"), "NoInternetOpenWith", 1);
                            Process.Add("Timeouts have been decreased as much as it could be.");
                            break;

                        case 16:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\ImmersiveShell"), "SignInMode", 2);
                            Process.Add("Tablet Mode has been disabled.");
                            break;

                        case 17:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\System"), "PublishUserActivities", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\System"), "EnableActivityFeed", 0);
                            Process.Add("Timeline has been disabled.");
                            break;

                        case 18:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications"), "GlobalUserDisabled", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\BackgroundAccessApplications"), "Migrated", 4);
                            Process.Add("Background applications of Windows 10 have been disabled.");
                            break;

                        case 19:
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "ClearPageFileAtShutdown", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "FeatureSettings", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "FeatureSettingsOverrideMask", 3);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "FeatureSettingsOverride", 3);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "LargeSystemCache", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "NonPagedPoolQuota", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "NonPagedPoolSize", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "SessionViewSize", 192);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "SystemPages", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "SecondLevelDataCache", 3072);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "SessionPoolSize", 192);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "DisablePagingExecutive", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "PagedPoolSize", 192);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "PagedPoolQuota", 0);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "PhysicalAddressExtension", 1);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "IoPageLockLimit", 100000);
                            RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SYSTEM\CurrentControlSet\Control\Session Manager\Memory Management"), "PoolUsageMaximum", 60);
                            Process.Add("Memory usage has been optimized.");
                            break;

                        default:
                            break;
                    }
                }
            }

            foreach (int temp in optionalProcesses)
            {
                switch (temp)
                {
                    case 0:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate\AU"), "AUOptions", 2);
                        Process.Add("Optional Processes: Windows Update has been disabled.");
                        break;

                    case 1:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows\WindowsUpdate"), "ExcludeWUDriversInQualityUpdate", 1);
                        Process.Add("Optional Processes: Driver Updates have been disabled.");
                        break;

                    case 2:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender"), "DisableAntiSpyware", 1);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"), "DisableBehaviorMonitoring", 1);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"), "DisableOnAccessProtection", 1);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Policies\Microsoft\Windows Defender\Real-Time Protection"), "DisableScanOnRealtimeEnable", 1);
                        Process.Add("Optional Processes: Windows Defender has been disabled.");
                        break;

                    case 3:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "HideFileExt", 0);
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "Hidden", 1);
                        Process.Add("Optional Processes: Hidden files and file extensions are gonna be visible from this moment.");
                        break;

                    case 4:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Explorer\Advanced"), "LaunchTo", 1);
                        Process.Add("Optional Processes: Explorer will open to my computer.");
                        break;

                    case 5:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\DeliveryOptimization\Config"), "DODownloadMode", 0);
                        Process.Add("Optional Processes: Delivery Optimization (P2P Update) has been disabled.");
                        break;

                    case 6:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\WindowsUpdate\Services\7971f918-a847-4430-9279-4a52d1efe18d"), "RegisteredWithAU", 1);
                        Process.Add("Optional Processes: Other products will be updated by Windows Update.");
                        break;

                    case 7:
                        RegistryManager.SetRegistry(Microsoft.Win32.Registry.LocalMachine.CreateSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Policies\System"), "VerboseStatus", 1);
                        Process.Add("Optional Processes: Verbose Boot has been enabled.");
                        break;

                    default:
                        break;
                }
            }

            if (Process.Count == 0 && optionalProcesses.Count == 0)
            {
                MessageBox.Show("Please select the processes that you want to do.", "Tzoptimizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ProgressInfo.Text = "Please select the processes that you want to do.";
            }

            else
            {
                int progress = 100 / Process.Count;
                ProgressBar.Maximum = 100;
                ProgressInfo.Clear();
                foreach (var Temp in Process)
                {
                    ProgressInfo.AppendText((string)Temp + "\n");
                    ProgressBar.Value = progress;
                }
                ProgressInfo.AppendText("All selected processes have been applied.");
                ProgressBar.Value = 100;

                MessageBox.Show("Selected processes have been done. You may need to restart your computer to apply all the changes.", "Tzoptimizer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// if user wants to close application this method will be invoked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// if user approves to close the application application will be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closed(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close?", "Tzoptimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// functionality of select all tick
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAll_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < ProcessesBox.Items.Count; i++)
            {
                if (SelectAllCheckBox.Checked == true)
                {
                    ProcessesBox.SetItemChecked(i, true);
                }
                else
                {
                    ProcessesBox.SetItemChecked(i, false);
                }
            }
        }

        /// <summary>
        /// a function that helps user to set recommended settings
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            if (Recommended.SelectedIndex == 1)
            {
                for (int i = 0; i < ProcessesBox.Items.Count; i++)
                {
                    ProcessesBox.SetItemChecked(i, true);
                }
            }
        }

        /// <summary>
        /// function that gets every single system information and displays it
        /// </summary>
        private void GatherSystemInformation()
        {
            SystemInfo.AppendText("Operating System: ");
            SystemInfo.AppendText(System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            SystemInfo.AppendText(Environment.Is64BitOperatingSystem ? " 64-bit" : " 32-bit");
            SystemInfo.AppendText("\nCPU: ");
            GetComponent("Win32_Processor", "Name");
            SystemInfo.AppendText("RAM: ");
            GetRAM();
            SystemInfo.AppendText("GPU(s): ");
            GetComponent("Win32_VideoController", "Name");
            SystemInfo.AppendText("Disk(s) information: ");
            DiskChecker();

        }

        /// <summary>
        /// to get hardware (GPU/CPU) component information
        /// </summary>
        /// <param name="hwclass">hardware class</param>
        /// <param name="syntax">dataset/header/syntax</param>
        public void GetComponent(string hwclass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                SystemInfo.AppendText(Convert.ToString(mj[syntax]) + "\n");
            }
        }

        /// <summary>
        /// method used for get RAM amount and display it
        /// </summary>
        private void GetRAM()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject item in moc)
            {
                SystemInfo.AppendText(Convert.ToString(Math.Round(Convert.ToDouble(item.Properties["TotalPhysicalMemory"].Value) / (1048576 * 1024), 0)) + " GB\n");
            }
        }

        /// <summary>
        /// function that used for check disks and their information
        /// </summary>
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
            }

            else
            {
                ProgressInfo.AppendText("\nLooks like your system is based on non-SSD. We strongly recommend you to use recommended settings for non-SSD based systems.");
                ProgressInfo.AppendText("\nRecommended settings for non-SSD based systems selected.");
                Recommended.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// the opening pop-up window message
        /// </summary>
        private void AppearInformation()
        {
            MessageBox.Show("You can always look source code of Tzoptimizer, but don't you forget, all the operations you done in here is at your own risk. If you want to open Tzoptimizer's github page just click on it's logo located in the right-bottom. Use at your own risk", "Tzoptimizer",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// function to open optional window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OptionalButton_Click(object sender, EventArgs e)
        {
            Form optionalForm = new OptionalWindow(this, optionalProcesses);
            optionalForm.Show();
            optionalForm.Owner = this;
        }

        /// <summary>
        /// a basic function to get optional processes
        /// </summary>
        /// <param name="arrayList"></param>
        public void SetOptional(ArrayList arrayList)
        {
            this.optionalProcesses = arrayList;
        }

        /// <summary>
        /// function that used for closing optional window
        /// </summary>
        public void CloseOptionalWindow()
        {
            Form optionalForm = new OptionalWindow(this, optionalProcesses);
            optionalForm.Owner = this;
            optionalForm.Close();
        }

        /// <summary>
        /// basic easter egg to open github page of the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Tzesh/Tzoptimizer");
        }
    }
}
