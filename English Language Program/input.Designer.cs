namespace English_Language_Program
{
    partial class input
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
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.container.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.comboBox3);
            this.container.Controls.Add(this.comboBox2);
            this.container.Controls.Add(this.button2);
            this.container.Controls.Add(this.button1);
            this.container.Controls.Add(this.textBox2);
            this.container.Controls.Add(this.textBox1);
            this.container.Controls.Add(this.label3);
            this.container.Controls.Add(this.label2);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.comboBox1);
            this.container.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.container.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.container.Location = new System.Drawing.Point(100, 31);
            this.container.Margin = new System.Windows.Forms.Padding(4);
            this.container.Name = "container";
            this.container.Padding = new System.Windows.Forms.Padding(4);
            this.container.Size = new System.Drawing.Size(933, 738);
            this.container.TabIndex = 0;
            this.container.TabStop = false;
            this.container.Text = "Enter More Words";
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
            this.comboBox3.Location = new System.Drawing.Point(473, 176);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(95, 48);
            this.comboBox3.TabIndex = 9;
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
            this.comboBox2.Location = new System.Drawing.Point(19, 176);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(95, 48);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox2, "Switch");
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(295, 663);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 52);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.Text = "Reset";
            this.toolTip1.SetToolTip(this.button2, "Remove All Text");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(475, 663);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(439, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add And Save";
            this.toolTip1.SetToolTip(this.button1, "Add All Text");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2
            // 
            this.textBox2.AllowDrop = true;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.Orange;
            this.textBox2.Location = new System.Drawing.Point(475, 234);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox2.Size = new System.Drawing.Size(438, 422);
            this.textBox2.TabIndex = 1;
            this.textBox2.WordWrap = false;
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            this.textBox2.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBox2_DragDrop);
            this.textBox2.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBox2_DragEnter);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.Orange;
            this.textBox1.Location = new System.Drawing.Point(20, 234);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(438, 422);
            this.textBox1.TabIndex = 0;
            this.textBox1.WordWrap = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(584, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(255, 36);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Translate:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 191);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Enter Word:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(419, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select The Subject To Add:";
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Orange;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(467, 89);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(445, 44);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox1, "Select One");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.BackColor = System.Drawing.Color.DimGray;
            this.toolTip1.ForeColor = System.Drawing.Color.Orange;
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 812);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "input";
            this.Text = "input";
            this.Load += new System.EventHandler(this.input_Load);
            this.Resize += new System.EventHandler(this.input_Resize);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox container;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}