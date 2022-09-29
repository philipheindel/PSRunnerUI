using System;
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
    public partial class TextArg : UserControl
    {

        private string inputText;
        private string headerName;

        public TextArg()
        {
            InitializeComponent();
            this.inputText = "";
        }

        #region Getters and setters

        public string InputText 
        { 
            get { return inputText; } 
            set
            {
                this.inputText = value;
                this.textArgInput.Text = this.InputText;
            }
        }

        public string HeaderName
        {
            get { return headerName; }
            set 
            { 
                headerName = value;
                this.textArgName.Text = this.headerName;
            }
        }

        #endregion Getters and setters

        #region Event methods

        private void textArgInput_TextChanged(object sender, EventArgs e)
        {
            this.inputText = textArgInput.Text;
        }

        #endregion Event methods
    }
}
