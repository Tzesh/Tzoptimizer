using System;
using System.Collections;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
using System.IO;
using System.Net;
using Tzoptimizer.Utils;
using System.Collections.Generic;
using System.Globalization;

namespace Tzoptimizer
{
    public partial class MainWindow : Form
    {
        List<RegistryClass> Registries = new List<RegistryClass>(); // to store and get tweaks
        List<RegistryClass> Defaults = new List<RegistryClass>(); // to store and get default values of tweaks
        bool IsTranslationNeeded = false; // to check whether translation is needed

        /// <summary>
        /// Constructor of MainWindow
        /// </summary>
        public MainWindow()
        {
            InitializeComponent(); // UI components
            GatherSystemInformation(); // display system information and recommend settings based on system drive
            if (AskIfTranslationNeeded()) TranslateTo(); // ask user if translation is needed
            FillTweaks("https://raw.githubusercontent.com/Tzesh/Tzoptimizer/master/Tweaks.reg"); // to get decent tweaks from github page
            FillTweaks("https://raw.githubusercontent.com/Tzesh/Tzoptimizer/master/Defaults.reg"); // to get default values of tweaks from github page
            AppearInformation(); // inform user about the program
        }

        /// <summary>
        /// Asking to user if wants to translate the program
        /// </summary>
        /// <returns>Boolean value represents whether the user wants to translate language of the program</returns>
        private bool AskIfTranslationNeeded()
        {
            // getting the current langauge
            string language = GetCurrentLanguage();
            if (language.StartsWith("en-"))
            {
                MessageBox.Show("Translation to another language isn't necessary since OS language is 'English'", "Tzoptimizer - Translation Service", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            DialogResult result = MessageBox.Show("You are using another language different than English. Do you want to translate Tzoptimizer to that language?", "Tzoptimizer - Translation Service", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            return result == DialogResult.Yes;
        }

        /// <summary>
        /// Gets the language of current culture of windows system
        /// </summary>
        /// <returns>String value which represents the culture of the system</returns>
        private string GetCurrentLanguage()
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            return ci.Name;
        }

        /// <summary>
        /// Translates necessary fields to system language
        /// </summary>
        private void TranslateTo()
        {
            IsTranslationNeeded = true;
            this.lbl_HowTo.Text = Translate(lbl_HowTo.Text);
            this.lbl_Main.Text = Translate(lbl_Main.Text);
            this.lbl_Reminder.Text = Translate(lbl_Reminder.Text);
            this.lbl_Reminder1.Text = Translate(lbl_Reminder1.Text);
            this.lbl_Reminder2.Text = Translate(lbl_Reminder2.Text);
            this.lbl_Reminder3.Text = Translate(lbl_Reminder3.Text);
            this.lbl_Reminder4.Text = Translate(lbl_Reminder4.Text);
            this.lbl_Reminder5.Text = Translate(lbl_Reminder5.Text);
            this.lbl_RevertHeader.Text = Translate(lbl_RevertHeader.Text);
            this.lbl_Revert.Text = Translate(lbl_Revert.Text);
            this.lbl_Progress.Text = Translate(lbl_Progress.Text);
            this.lbl_System.Text = Translate(lbl_System.Text);
            this.btn_Optimize.Text = Translate(btn_Optimize.Text);
            this.btn_Revert.Text = Translate(btn_Revert.Text);
            this.chk_SelectAll.Text = Translate(chk_SelectAll.Text);
        }

        /// <summary>
        /// Translates given string to system language
        /// </summary>
        /// <param name="text"></param>
        /// <param name="lang"></param>
        /// <returns></returns>
        private string Translate(string text)
        {
            string lang = GetCurrentLanguage().Split('-')[0];
            TextInfo cultInfo = new CultureInfo(GetCurrentLanguage(), false).TextInfo;
            string result = "";
            string[] sentences = text.Split('.');
            for (int i = 0; i < sentences.Length; i++)
            {
                if (string.IsNullOrEmpty(sentences[i])) continue;
                result += " " + Translator.TranslateViaGoogle(sentences[i], lang);
            }
            return result;
        }

        /// <summary>
        /// Function that gets all the decent tweaks from github page then saves, and displays it in this page
        /// </summary>
        public void FillTweaks(string url)
        {
            bool isTweaks = url.Contains("Tweaks.reg");
            WebClient client = new WebClient();
            Stream stream = client.OpenRead(url);
            StreamReader reader = new StreamReader(stream);
            String content = reader.ReadToEnd();
            String[] lines = content.Split('\n');
            RegistryClass reg = new RegistryClass();
            GroupBox gbx_Tweak = new GroupBox();
            for (int i = 0; i < lines.Length; i++)
            {
                string line = lines[i].Replace("\r", "");
                if (line.StartsWith("//") || line.Length < 1) continue;
                else if (isTweaks && line.StartsWith(";-"))
                {
                    string header = line.Replace(";-", "");
                    gbx_Tweak = new GroupBox();
                    gbx_Tweak.Text = IsTranslationNeeded ? Translate(header) : header;
                    gbx_Tweak.Width = 720;
                    gbx_Tweak.Height = 56;
                    flp_Tweaks.Controls.Add(gbx_Tweak);
                }
                else if (line.StartsWith(";") && line[1] != ';' && line[1] != ':' && line[1] != '!')
                {
                    reg = new RegistryClass();
                    string title = line.Replace(";", "");
                    reg.Title = IsTranslationNeeded ? Translate(title) : title;
                }
                else if (line.StartsWith(";:"))
                {
                    string description = line.Replace(";:", "");
                    reg.Description = IsTranslationNeeded ? Translate(description) : description;
                }
                else if (line.StartsWith(";!"))
                {
                    string category = line.Replace(";!", "");
                    reg.Category = IsTranslationNeeded ? Translate(category) : category;
                }
                else if (line.StartsWith("["))
                {
                    line = line.Replace("[", "").Replace("]", "");
                    reg.Root = line.Split('\\')[0];
                    reg.Path = line.Replace(reg.Root + "\\", "");
                }
                else if (line.StartsWith("\""))
                {
                    line = line.Replace("\"", "");
                    string[] keyAndValue = line.Split('=');
                    reg.KeyValuePairs.Add(keyAndValue[0], keyAndValue[1]);
                }
                else if (line.Equals(";;"))
                {
                    if (!isTweaks)
                    {
                        Defaults.Add(reg);
                        continue;
                    }
                    CheckBox chk_Registry = new CheckBox
                    {
                        Tag = Registries.Count,
                        Text = reg.Title
                    };
                    Registries.Add(reg);
                    ToolTip toolTip = new ToolTip();
                    toolTip.SetToolTip(chk_Registry, reg.Description);
                    int margin = gbx_Tweak.Controls.Count + 1;
                    chk_Registry.Location = new System.Drawing.Point(10, margin * 24);
                    chk_Registry.Width = 600;
                    gbx_Tweak.Controls.Add(chk_Registry);
                    gbx_Tweak.Height += 24;
                }
            }
        }

        /// <summary>
        /// Selected tweaks will be done when optimize button has clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Optimize_Click(object sender, EventArgs e)
        {
            ApplyRegistries(true);
        }
        /// <summary>
        /// Selected tweaks will be reverted to their default values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Revert_Click(object sender, EventArgs e)
        {
            ApplyRegistries(false);
        }

        /// <summary>
        /// Function that used in both optimize and revert buttons
        /// </summary>
        /// <param name="registries"></param>
        private void ApplyRegistries(bool tweak)
        {
            List<int> tweaks = GetTweakIndexes();
            if (!IsAppropriate(tweaks)) return;
            foreach (int index in tweaks)
            {
                RegistryClass reg = tweak ? Registries[index] : Defaults[index];
                RegistryManager.ApplyRegistry(reg);
                string message = tweak ? reg.Title + " tweak has been done." : reg.Title + " tweak has been reverted.";
                message = IsTranslationNeeded ? Translate(message) : message;
                rtb_Progress.Text += message + "\n";
            }
            string information = "You have to restart your computer whenever you want to apply all the tweaks.";
            information = IsTranslationNeeded ? Translate(information) : information;
            MessageBox.Show(information, "Tzoptimizer - Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Check whether given list is appropriate if it's not then return a message
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        private bool IsAppropriate(List<int> list)
        {
            if (list.Count == 0)
            {
                string message = "Please select at least one tweak to apply.";
                if (IsTranslationNeeded) message = Translate(message);
                MessageBox.Show(message, "Tzoptimizer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// All tweaks done accordingt to their indexes this function simply returns selected tweaks and their indexes
        /// </summary>
        /// <returns></returns>
        private List<int> GetTweakIndexes()
        {
            List<int> indexes = new List<int>();
            foreach (GroupBox gbx in flp_Tweaks.Controls)
            {
                foreach (CheckBox chk in gbx.Controls)
                {
                    if (chk.Checked)
                    {
                        indexes.Add((int)chk.Tag);
                    }
                }
            }
            return indexes;
        }

        /// <summary>
        /// If user wants to close application this method will be invoked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closing(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// If user approves to close the application application will be closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainWindow_Closed(object sender, FormClosingEventArgs e)
        {
            string message = "Are you sure you want to close?";
            if (IsTranslationNeeded) message = Translate(message);
            if (MessageBox.Show(message, "Tzoptimizer", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Function that gets every single system information and displays it
        /// </summary>
        private void GatherSystemInformation()
        {
            rtb_System.AppendText("Operating System: ");
            rtb_System.AppendText(System.Runtime.InteropServices.RuntimeInformation.OSDescription);
            rtb_System.AppendText(Environment.Is64BitOperatingSystem ? " 64-bit" : " 32-bit");
            rtb_System.AppendText("\nCPU: ");
            GetComponent("Win32_Processor", "Name");
            rtb_System.AppendText("RAM: ");
            GetRAM();
            rtb_System.AppendText("GPU(s): ");
            GetComponent("Win32_VideoController", "Name");
            rtb_System.AppendText("Disk(s) information: ");
            DiskChecker();

        }

        /// <summary>
        /// Get hardware (GPU/CPU) component information
        /// </summary>
        /// <param name="hwclass">hardware class</param>
        /// <param name="syntax">dataset/header/syntax</param>
        public void GetComponent(string hwclass, string syntax)
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM " + hwclass);
            foreach (ManagementObject mj in mos.Get())
            {
                rtb_System.AppendText(Convert.ToString(mj[syntax]) + "\n");
            }
        }

        /// <summary>
        /// Method used for get RAM amount and display it
        /// </summary>
        private void GetRAM()
        {
            ManagementClass mc = new ManagementClass("Win32_ComputerSystem");
            ManagementObjectCollection moc = mc.GetInstances();
            foreach (ManagementObject item in moc)
            {
                rtb_System.AppendText(Convert.ToString(Math.Round(Convert.ToDouble(item.Properties["TotalPhysicalMemory"].Value) / (1048576 * 1024), 0)) + " GB\n");
            }
        }

        /// <summary>
        /// Function that used for check disks and their information
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
                rtb_System.AppendText("\nDrive " + d.Name);
                rtb_System.AppendText("\nDrive type: " + d.DriveType + " " + drives[i]);
                if (d.IsReady == true)
                {
                    rtb_System.AppendText("\nVolume label: " + d.VolumeLabel);
                    rtb_System.AppendText("\nFile system: " + d.DriveFormat);
                    rtb_System.AppendText("\nAvailable space to current user: " + (d.AvailableFreeSpace / (1048576 * 1024), 0) + " GB");
                    rtb_System.AppendText("\nTotal available space: " + (d.TotalFreeSpace / (1048576 * 1024), 0) + " GB");

                    rtb_System.AppendText("\nTotal size of drive: " + (d.TotalSize / (1048576 * 1024), 0) + " GB");
                }
                i++;
            }
        }

        /// <summary>
        /// The opening pop-up window message
        /// </summary>
        private void AppearInformation()
        {
            string message = "You can always look source code of Tzoptimizer, but don't you forget, all the operations you done in here is at your own risk. If you want to open Tzoptimizer's github page just click on it's logo located in the right-bottom. Use at your own risk";
            if (IsTranslationNeeded) message = Translate(message);
            MessageBox.Show(message, "Tzoptimizer",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /// <summary>
        /// URL link of GitHub repository will be opened when user clicks on the image
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Logo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Tzesh/Tzoptimizer");
        }

        /// <summary>
        /// Basic implementation of select all/unselect all functionality
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            foreach (GroupBox gbx in flp_Tweaks.Controls)
            {
                foreach (CheckBox chk in gbx.Controls)
                {
                    chk.Checked = (sender as CheckBox).Checked;
                }
            }
        }
    }
}
