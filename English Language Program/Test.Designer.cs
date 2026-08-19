namespace English_Language_Program
{
    partial class Test
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
            this.Enters = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsubjectname = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.comboBox4);
            this.container.Controls.Add(this.comboBox3);
            this.container.Controls.Add(this.comboBox2);
            this.container.Controls.Add(this.Enters);
            this.container.Controls.Add(this.button4);
            this.container.Controls.Add(this.button3);
            this.container.Controls.Add(this.button1);
            this.container.Controls.Add(this.label6);
            this.container.Controls.Add(this.textBox3);
            this.container.Controls.Add(this.label5);
            this.container.Controls.Add(this.txtsubjectname);
            this.container.Controls.Add(this.textBox2);
            this.container.Controls.Add(this.textBox1);
            this.container.Controls.Add(this.label3);
            this.container.Controls.Add(this.label4);
            this.container.Controls.Add(this.maskedTextBox1);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.comboBox1);
            this.container.Controls.Add(this.label1);
            this.container.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.container.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.container.Location = new System.Drawing.Point(50, 30);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(700, 600);
            this.container.TabIndex = 1;
            this.container.TabStop = false;
            this.container.Text = "Test Language";
            this.toolTip1.SetToolTip(this.container, "RTL OR LTR");
            // 
            // Enters
            // 
            this.Enters.Location = new System.Drawing.Point(21, 267);
            this.Enters.Multiline = true;
            this.Enters.Name = "Enters";
            this.Enters.ReadOnly = true;
            this.Enters.Size = new System.Drawing.Size(10, 10);
            this.Enters.TabIndex = 20;
            this.Enters.Text = "\r\n";
            this.Enters.Visible = false;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Orange;
            this.button4.Location = new System.Drawing.Point(356, 162);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 43);
            this.button4.TabIndex = 19;
            this.button4.TabStop = false;
            this.button4.Text = "Stop";
            this.toolTip1.SetToolTip(this.button4, "Stop Testing");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(206, 162);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 43);
            this.button3.TabIndex = 18;
            this.button3.TabStop = false;
            this.button3.Text = "Start";
            this.toolTip1.SetToolTip(this.button3, "Start Testing");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(555, 270);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 42);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.toolTip1.SetToolTip(this.button1, "Next Word");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label6.Location = new System.Drawing.Point(16, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 29);
            this.label6.TabIndex = 16;
            this.label6.Text = "Translate:";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.Turquoise;
            this.textBox3.ForeColor = System.Drawing.Color.Orange;
            this.textBox3.Location = new System.Drawing.Point(155, 273);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(287, 36);
            this.textBox3.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(62, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 29);
            this.label5.TabIndex = 14;
            this.label5.Text = "Word:";
            // 
            // txtsubjectname
            // 
            this.txtsubjectname.BackColor = System.Drawing.Color.Turquoise;
            this.txtsubjectname.ForeColor = System.Drawing.Color.Orange;
            this.txtsubjectname.Location = new System.Drawing.Point(159, 218);
            this.txtsubjectname.Name = "txtsubjectname";
            this.txtsubjectname.ReadOnly = true;
            this.txtsubjectname.Size = new System.Drawing.Size(526, 36);
            this.txtsubjectname.TabIndex = 0;
            this.txtsubjectname.TabStop = false;
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Red;
            this.textBox2.Location = new System.Drawing.Point(356, 362);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(329, 221);
            this.textBox2.TabIndex = 9;
            this.textBox2.TabStop = false;
            this.textBox2.WordWrap = false;
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Green;
            this.textBox1.Location = new System.Drawing.Point(15, 362);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(329, 221);
            this.textBox1.TabIndex = 8;
            this.textBox1.TabStop = false;
            this.textBox1.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(475, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "False";
            this.toolTip1.SetToolTip(this.label3, "False Words");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Green;
            this.label4.Location = new System.Drawing.Point(131, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "True";
            this.toolTip1.SetToolTip(this.label4, "True Words");
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maskedTextBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.Orange;
            this.maskedTextBox1.Location = new System.Drawing.Point(452, 99);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = '-';
            this.maskedTextBox1.Size = new System.Drawing.Size(179, 40);
            this.maskedTextBox1.TabIndex = 7;
            this.maskedTextBox1.TabStop = false;
            this.maskedTextBox1.Text = "0";
            this.maskedTextBox1.TextChanged += new System.EventHandler(this.maskedTextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(6, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(416, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter The Number Of Words Test:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Orange;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(408, 51);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(273, 37);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox1, "Select One");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(6, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(405, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select The Subject To Start Test:";
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
            this.comboBox2.Location = new System.Drawing.Point(448, 270);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(101, 41);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox2, "RTL OR LTR");
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
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
            this.comboBox3.Location = new System.Drawing.Point(356, 315);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(101, 41);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.TabStop = false;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox4
            // 
            this.comboBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox4.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.comboBox4.ForeColor = System.Drawing.Color.Orange;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "RTL",
            "LTR"});
            this.comboBox4.Location = new System.Drawing.Point(15, 315);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(101, 41);
            this.comboBox4.TabIndex = 23;
            this.comboBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox4, "RTL OR LTR");
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Test
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 660);
            this.Controls.Add(this.container);
            this.Font = new System.Drawing.Font("Tahoma", 6F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Test";
            this.Text = "Test";
            this.Load += new System.EventHandler(this.Test_Load);
            this.Resize += new System.EventHandler(this.Test_Resize);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox container;
        private System.Windows.Forms.TextBox Enters;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsubjectname;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}