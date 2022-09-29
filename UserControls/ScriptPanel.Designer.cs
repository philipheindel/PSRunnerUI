namespace ScriptRunnerUI.src.UserControls
{
    partial class ScriptPanel
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.controlSplitContainer = new System.Windows.Forms.SplitContainer();
            this.controlButtonTableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.runButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.scriptOutput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.controlSplitContainer)).BeginInit();
            this.controlSplitContainer.Panel1.SuspendLayout();
            this.controlSplitContainer.SuspendLayout();
            this.controlButtonTableLayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.controlSplitContainer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.scriptOutput);
            this.splitContainer1.Size = new System.Drawing.Size(946, 605);
            this.splitContainer1.SplitterDistance = 314;
            this.splitContainer1.TabIndex = 1;
            // 
            // controlSplitContainer
            // 
            this.controlSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.controlSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.controlSplitContainer.Name = "controlSplitContainer";
            this.controlSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // controlSplitContainer.Panel1
            // 
            this.controlSplitContainer.Panel1.Controls.Add(this.controlButtonTableLayout);
            // 
            // controlSplitContainer.Panel2
            // 
            this.controlSplitContainer.Panel2.AutoScroll = true;
            this.controlSplitContainer.Size = new System.Drawing.Size(314, 605);
            this.controlSplitContainer.SplitterDistance = 30;
            this.controlSplitContainer.TabIndex = 0;
            // 
            // controlButtonTableLayout
            // 
            this.controlButtonTableLayout.ColumnCount = 2;
            this.controlButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlButtonTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlButtonTableLayout.Controls.Add(this.runButton, 0, 0);
            this.controlButtonTableLayout.Controls.Add(this.stopButton, 1, 0);
            this.controlButtonTableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlButtonTableLayout.Location = new System.Drawing.Point(0, 0);
            this.controlButtonTableLayout.Name = "controlButtonTableLayout";
            this.controlButtonTableLayout.RowCount = 1;
            this.controlButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlButtonTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.controlButtonTableLayout.Size = new System.Drawing.Size(314, 30);
            this.controlButtonTableLayout.TabIndex = 0;
            // 
            // runButton
            // 
            this.runButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.runButton.Location = new System.Drawing.Point(3, 3);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(151, 24);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.stopButton.Location = new System.Drawing.Point(160, 3);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(151, 24);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // scriptOutput
            // 
            this.scriptOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scriptOutput.Location = new System.Drawing.Point(0, 0);
            this.scriptOutput.Multiline = true;
            this.scriptOutput.Name = "scriptOutput";
            this.scriptOutput.Size = new System.Drawing.Size(628, 605);
            this.scriptOutput.TabIndex = 0;
            // 
            // ScriptPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Name = "ScriptPanel";
            this.Size = new System.Drawing.Size(946, 605);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.controlSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.controlSplitContainer)).EndInit();
            this.controlSplitContainer.ResumeLayout(false);
            this.controlButtonTableLayout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer controlSplitContainer;
        private System.Windows.Forms.TableLayoutPanel controlButtonTableLayout;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.TextBox scriptOutput;
    }
}
