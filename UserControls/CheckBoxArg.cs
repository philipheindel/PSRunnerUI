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

namespace ScriptRunnerUI.src.UserControls
{
    public partial class CheckBoxArg : UserControl
    {

        private Hashtable checkBoxes;

        public CheckBoxArg()
        {
            InitializeComponent();
            this.checkBoxes = new Hashtable();
        }
    }
}
