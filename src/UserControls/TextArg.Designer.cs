namespace ScriptRunnerUI.src.UserControls
{
    partial class TextArg
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textArgName = new System.Windows.Forms.GroupBox();
            this.textArgInput = new System.Windows.Forms.TextBox();
            this.textArgName.SuspendLayout();
            this.SuspendLayout();
            // 
            // textArgName
            // 
            this.textArgName.Controls.Add(this.textArgInput);
            this.textArgName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArgName.Location = new System.Drawing.Point(0, 0);
            this.textArgName.Name = "textArgName";
            this.textArgName.Size = new System.Drawing.Size(200, 40);
            this.textArgName.TabIndex = 0;
            this.textArgName.TabStop = false;
            this.textArgName.Text = "textArgName";
            // 
            // textArgInput
            // 
            this.textArgInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textArgInput.Location = new System.Drawing.Point(3, 16);
            this.textArgInput.Name = "textArgInput";
            this.textArgInput.Size = new System.Drawing.Size(194, 20);
            this.textArgInput.TabIndex = 0;
            this.textArgInput.TextChanged += new System.EventHandler(this.textArgInput_TextChanged);
            // 
            // TextArg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textArgName);
            this.Name = "TextArg";
            this.Size = new System.Drawing.Size(200, 40);
            this.textArgName.ResumeLayout(false);
            this.textArgName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textArgName;
        private System.Windows.Forms.TextBox textArgInput;
    }
}
