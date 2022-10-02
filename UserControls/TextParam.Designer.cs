namespace ScriptRunnerUI.UserControls
{
    partial class TextParam
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
            this.textParamName = new System.Windows.Forms.GroupBox();
            this.textParamPersistCheckbox = new System.Windows.Forms.CheckBox();
            this.textParamInput = new System.Windows.Forms.TextBox();
            this.textParamName.SuspendLayout();
            this.SuspendLayout();
            // 
            // textParamName
            // 
            this.textParamName.Controls.Add(this.textParamPersistCheckbox);
            this.textParamName.Controls.Add(this.textParamInput);
            this.textParamName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textParamName.Location = new System.Drawing.Point(4, 0);
            this.textParamName.Name = "textParamName";
            this.textParamName.Size = new System.Drawing.Size(192, 59);
            this.textParamName.TabIndex = 0;
            this.textParamName.TabStop = false;
            this.textParamName.Text = "textParamName";
            // 
            // textParamPersistCheckbox
            // 
            this.textParamPersistCheckbox.AutoSize = true;
            this.textParamPersistCheckbox.Location = new System.Drawing.Point(3, 39);
            this.textParamPersistCheckbox.Name = "textParamPersistCheckbox";
            this.textParamPersistCheckbox.Size = new System.Drawing.Size(83, 17);
            this.textParamPersistCheckbox.TabIndex = 1;
            this.textParamPersistCheckbox.Text = "Persist input";
            this.textParamPersistCheckbox.UseVisualStyleBackColor = true;
            // 
            // textParamInput
            // 
            this.textParamInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textParamInput.Location = new System.Drawing.Point(3, 16);
            this.textParamInput.Name = "textParamInput";
            this.textParamInput.Size = new System.Drawing.Size(186, 20);
            this.textParamInput.TabIndex = 0;
            this.textParamInput.TextChanged += new System.EventHandler(this.textArgInput_TextChanged);
            // 
            // TextParam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textParamName);
            this.Name = "TextParam";
            this.Padding = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Size = new System.Drawing.Size(200, 59);
            this.textParamName.ResumeLayout(false);
            this.textParamName.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox textParamName;
        private System.Windows.Forms.TextBox textParamInput;
        private System.Windows.Forms.CheckBox textParamPersistCheckbox;
    }
}
