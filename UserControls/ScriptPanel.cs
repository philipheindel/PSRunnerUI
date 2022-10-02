using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScriptRunnerUI.UserControls
{
    public partial class ScriptPanel : UserControl
    {
        private SplitterPanel parametersPanel;
        public ScriptPanel()
        {
            InitializeComponent();
            //argumentsPanel = this.controlSplitContainer.Panel2;
        }

        public SplitterPanel ParametersPanel { get { return parametersPanel; } }
    }
}
