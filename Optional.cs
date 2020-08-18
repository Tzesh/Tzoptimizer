using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Windows_Optimizer;

namespace Tzoptimizer
{
    public partial class Optional : Form
    {
        private MainWindow mainForm = null;
        public ArrayList ProcessesIndexes = new ArrayList();
        public Optional()
        {
            InitializeComponent();
        }

        public Optional(Form callingForm, ArrayList ProcessIndexes)
        {
            mainForm = callingForm as MainWindow;
            this.ProcessesIndexes = ProcessIndexes;
            InitializeComponent();
            setProcesses();
        }

        private void setProcesses()
        {
            if (ProcessesIndexes.Count != 0)
            {
                foreach (int temp in ProcessesIndexes)
                {
                    OptionalProcesses.SetItemChecked(temp, true);
                }
            }
        }

        private void OptionalProcesses_SelectedIndexChanged(object sender, EventArgs e)
        {
            getProcesses();
        }

        public void getProcesses()
        {
            for (int i = 0; i < OptionalProcesses.Items.Count; i++)
            {
                if (OptionalProcesses.GetItemChecked(i) == true)
                    if (!ProcessesIndexes.Contains(i))
                    {
                        ProcessesIndexes.Add(i);
                    }
                if (OptionalProcesses.GetItemChecked(i) == false)
                {
                    if (ProcessesIndexes.Contains(i)) {
                        ProcessesIndexes.Remove(i);
                    }
                }
            }
            mainForm.setOptional(ProcessesIndexes);
        }

        private void processSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (processSelect.SelectedIndex)
            {
                case 0:
                    processInformation.Text = "You can disable Windows Update for example in these situations:" +
                        "\n- To stop windows rebooting your computer automatically." +
                        "\n- To avoid any forced upgrades." +
                        "\n- And etc.";
                    break;
                case 1:
                    processInformation.Text = "You can disable Driver Updates in order to avoid any broken/not working well driver updates.";
                    break;
                case 2:
                    processInformation.Text = "You can disable Windows Defender if you want to.";
                    break;
                case 3:
                    processInformation.Text = "You can see every hidden file and every single file extension if you want to.";
                    break;
                case 4:
                    processInformation.Text = "You can set explorer to open to my computer.";
                    break;
                case 5:
                    processInformation.Text = "Sometimes P2P Delivery Optimization process may be really unnecessary and resource-leaking problem. You can just disable it.";
                    break;
                case 6:
                    processInformation.Text = "You can allow Windows Update to update your other products like Office.";
                    break;
            }
        }

        private void Closing(object sender, FormClosingEventArgs e)
        {
            getProcesses();
            mainForm.closeOptional();
        }
    }
}
