namespace English_Language_Program
{
    partial class translate
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
            this.container = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TexTT = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.TexTT);
            this.container.Controls.Add(this.button3);
            this.container.Controls.Add(this.button2);
            this.container.Controls.Add(this.label5);
            this.container.Controls.Add(this.comboBox3);
            this.container.Controls.Add(this.comboBox2);
            this.container.Controls.Add(this.textBox2);
            this.container.Controls.Add(this.textBox1);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.comboBox1);
            this.container.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.container.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.container.Location = new System.Drawing.Point(25, 25);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(800, 600);
            this.container.TabIndex = 1;
            this.container.TabStop = false;
            this.container.Text = "Translate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(516, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(222, 29);
            this.label2.TabIndex = 24;
            this.label2.Text = "Result Translate :";
            // 
            // TexTT
            // 
            this.TexTT.Location = new System.Drawing.Point(13, 81);
            this.TexTT.Multiline = true;
            this.TexTT.Name = "TexTT";
            this.TexTT.Size = new System.Drawing.Size(10, 10);
            this.TexTT.TabIndex = 23;
            this.TexTT.Text = "\r\n";
            this.TexTT.Visible = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(409, 535);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(182, 49);
            this.button3.TabIndex = 22;
            this.button3.TabStop = false;
            this.button3.Text = "Reset";
            this.toolTip1.SetToolTip(this.button3, "Set Default And Remove All Text");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(597, 535);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(189, 49);
            this.button2.TabIndex = 20;
            this.button2.TabStop = false;
            this.button2.Text = "Translate";
            this.toolTip1.SetToolTip(this.button2, "Translate All Words");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(113, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 29);
            this.label5.TabIndex = 19;
            this.label5.Text = "Enter Word :";
            // 
            // comboBox3
            // 
            this.comboBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox3.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.comboBox3.ForeColor = System.Drawing.Color.Orange;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "RTL",
            "LTR"});
            this.comboBox3.Location = new System.Drawing.Point(409, 111);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 41);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox3, "Switch");
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.comboBox2.ForeColor = System.Drawing.Color.Orange;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "RTL",
            "LTR"});
            this.comboBox2.Location = new System.Drawing.Point(6, 108);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 41);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox2, "Switch");
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Orange;
            this.textBox2.Location = new System.Drawing.Point(409, 155);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(385, 374);
            this.textBox2.TabIndex = 14;
            this.textBox2.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Orange;
            this.textBox1.Location = new System.Drawing.Point(6, 155);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(385, 374);
            this.textBox1.TabIndex = 13;
            this.textBox1.WordWrap = false;
            this.textBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox1_DragDrop);
            this.textBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox1_DragEnter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(29, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(399, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select The Subject To Translate:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Orange;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Orange;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(434, 59);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(352, 37);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox1, "Select One");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // translate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 660);
            this.Controls.Add(this.container);
            this.Font = new System.Drawing.Font("Tahoma", 6F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "translate";
            this.Text = "translate";
            this.Load += new System.EventHandler(this.translate_Load);
            this.Resize += new System.EventHandler(this.Translate_Resize);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TexTT;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label2;
    }
}