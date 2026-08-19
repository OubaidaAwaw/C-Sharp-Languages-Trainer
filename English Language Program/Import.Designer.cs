namespace English_Language_Program
{
    partial class Import
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtsubjectname = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtsubjectname);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.groupBox1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.groupBox1.Location = new System.Drawing.Point(50, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 385);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name Of Subject:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Turquoise;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.ForeColor = System.Drawing.Color.Orange;
            this.textBox1.Location = new System.Drawing.Point(270, 176);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(419, 36);
            this.textBox1.TabIndex = 13;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(220, 266);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 41);
            this.button3.TabIndex = 12;
            this.button3.Text = "Reset";
            this.toolTip1.SetToolTip(this.button3, "Reset Default And Remove All Text");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(368, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 41);
            this.button1.TabIndex = 11;
            this.button1.Text = "Import";
            this.toolTip1.SetToolTip(this.button1, "Import Subject");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(11, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 33);
            this.label2.TabIndex = 9;
            this.label2.Text = "Please Select Browse:";
            // 
            // txtsubjectname
            // 
            this.txtsubjectname.BackColor = System.Drawing.Color.Turquoise;
            this.txtsubjectname.Cursor = System.Windows.Forms.Cursors.No;
            this.txtsubjectname.ForeColor = System.Drawing.Color.Orange;
            this.txtsubjectname.Location = new System.Drawing.Point(330, 81);
            this.txtsubjectname.Name = "txtsubjectname";
            this.txtsubjectname.ReadOnly = true;
            this.txtsubjectname.Size = new System.Drawing.Size(240, 36);
            this.txtsubjectname.TabIndex = 7;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(576, 78);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(113, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Browse";
            this.toolTip1.SetToolTip(this.button2, "Browse File");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.FileName = "openFileDialog1";
            this.folderBrowserDialog1.Filter = "Text|*txt;";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 6F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Import";
            this.Text = "Import";
            this.Load += new System.EventHandler(this.Import_Load);
            this.Resize += new System.EventHandler(this.Import_Resize);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtsubjectname;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.OpenFileDialog folderBrowserDialog1;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}