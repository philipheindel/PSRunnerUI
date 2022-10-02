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
    public partial class TextParam : UserControl
    {

        private string inputText;
        private string headerName;

        public TextParam()
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
                this.textParamInput.Text = this.InputText;
            }
        }

        public string HeaderName
        {
            get { return headerName; }
            set 
            { 
                headerName = value;
                this.textParamName.Text = this.headerName;
            }
        }

        #endregion Getters and setters

        #region Event methods

        private void textArgInput_TextChanged(object sender, EventArgs e)
        {
            this.inputText = textParamInput.Text;
        }

        #endregion Event methods
    }
}
