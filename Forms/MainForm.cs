using ScriptRunnerUI.Forms;
using ScriptRunnerUI.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptRunnerUI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox.Instance.ShowDialog();
            //textArg1.HeaderName = this.textArg1.InputText;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TabPage newScriptTab = new TabPage("New script");
            ScriptPanel newScriptPanel = new ScriptPanel();
            newScriptPanel.Dock = DockStyle.Fill;
            //TextArg ta1 = new TextArg();
            //ta1.Dock = DockStyle.Top;
            //ta1.HeaderName = "Domain";
            //newScriptPanel.ArgumentsPanel.Controls.Add(ta1);
            //TextArg ta2 = new TextArg();
            //ta2.Dock = DockStyle.Top;
            //ta2.HeaderName = "Username";
            //newScriptPanel.ArgumentsPanel.Controls.Add(ta2);

            newScriptTab.Controls.Add(newScriptPanel);
            mainTabControl.TabPages.Add(newScriptTab);
            newScriptTab.SuspendLayout();

        }
    }
}
