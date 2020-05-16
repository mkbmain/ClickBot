namespace ClickBot
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LeftCheckBox = new System.Windows.Forms.CheckBox();
            this.RightCheckBox = new System.Windows.Forms.CheckBox();
            this.RunKeyLabel = new System.Windows.Forms.Label();
            this.SetRunKey = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(145, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "1.2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SetRunKey);
            this.groupBox1.Controls.Add(this.RunKeyLabel);
            this.groupBox1.Controls.Add(this.RightCheckBox);
            this.groupBox1.Controls.Add(this.LeftCheckBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 132);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            // 
            // LeftCheckBox
            // 
            this.LeftCheckBox.Location = new System.Drawing.Point(18, 66);
            this.LeftCheckBox.Name = "LeftCheckBox";
            this.LeftCheckBox.Size = new System.Drawing.Size(84, 24);
            this.LeftCheckBox.TabIndex = 2;
            this.LeftCheckBox.Text = "Left";
            this.LeftCheckBox.UseVisualStyleBackColor = true;
            this.LeftCheckBox.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // RightCheckBox
            // 
            this.RightCheckBox.Checked = true;
            this.RightCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.RightCheckBox.Location = new System.Drawing.Point(108, 66);
            this.RightCheckBox.Name = "RightCheckBox";
            this.RightCheckBox.Size = new System.Drawing.Size(104, 24);
            this.RightCheckBox.TabIndex = 3;
            this.RightCheckBox.Text = "Right";
            this.RightCheckBox.UseVisualStyleBackColor = true;
            this.RightCheckBox.CheckedChanged += new System.EventHandler(this.RightCheckBox_CheckedChanged);
            // 
            // RunKeyLabel
            // 
            this.RunKeyLabel.Location = new System.Drawing.Point(49, 102);
            this.RunKeyLabel.Name = "RunKeyLabel";
            this.RunKeyLabel.Size = new System.Drawing.Size(145, 26);
            this.RunKeyLabel.TabIndex = 4;
            this.RunKeyLabel.Text = "label2";
            // 
            // SetRunKey
            // 
            this.SetRunKey.Location = new System.Drawing.Point(4, 98);
            this.SetRunKey.Name = "SetRunKey";
            this.SetRunKey.Size = new System.Drawing.Size(31, 30);
            this.SetRunKey.TabIndex = 5;
            this.SetRunKey.Text = "..";
            this.SetRunKey.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SetRunKey.UseVisualStyleBackColor = true;
            this.SetRunKey.Click += new System.EventHandler(this.SetRunKey_Click);
            this.SetRunKey.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SetRunKey_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(220, 147);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Harvey auto clicker";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox LeftCheckBox;
        private System.Windows.Forms.CheckBox RightCheckBox;
        private System.Windows.Forms.Label RunKeyLabel;
        private System.Windows.Forms.Button SetRunKey;
    }
}