namespace English_Language_Program
{
    partial class Words
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
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.trans = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.word = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.container.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // container
            // 
            this.container.Controls.Add(this.button4);
            this.container.Controls.Add(this.panel1);
            this.container.Controls.Add(this.button1);
            this.container.Controls.Add(this.listView1);
            this.container.Controls.Add(this.label1);
            this.container.Controls.Add(this.comboBox1);
            this.container.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.container.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.container.Location = new System.Drawing.Point(75, 25);
            this.container.Name = "container";
            this.container.Size = new System.Drawing.Size(700, 600);
            this.container.TabIndex = 0;
            this.container.TabStop = false;
            this.container.Text = "All Words";
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.Orange;
            this.button4.Location = new System.Drawing.Point(586, 103);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(99, 42);
            this.button4.TabIndex = 10;
            this.button4.TabStop = false;
            this.button4.Text = "Delete";
            this.toolTip1.SetToolTip(this.button4, "Delete  Word And Translate");
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Cornsilk;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(15, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 92);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.Orange;
            this.button3.Location = new System.Drawing.Point(455, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 38);
            this.button3.TabIndex = 10;
            this.button3.TabStop = false;
            this.button3.Text = "Cancel";
            this.toolTip1.SetToolTip(this.button3, "Cancel Edit");
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Orange;
            this.button2.Location = new System.Drawing.Point(455, 45);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 42);
            this.button2.TabIndex = 8;
            this.button2.TabStop = false;
            this.button2.Text = "Done";
            this.toolTip1.SetToolTip(this.button2, "Finish Edit And Save");
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label3.Location = new System.Drawing.Point(236, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Edit Translate:";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.Color.Orange;
            this.textBox2.Location = new System.Drawing.Point(3, 50);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(220, 36);
            this.textBox2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label2.Location = new System.Drawing.Point(3, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Edit Words:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.Color.Orange;
            this.textBox1.Location = new System.Drawing.Point(229, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(220, 36);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Orange;
            this.button1.Location = new System.Drawing.Point(586, 151);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 40);
            this.button1.TabIndex = 9;
            this.button1.TabStop = false;
            this.button1.Text = "Edit";
            this.toolTip1.SetToolTip(this.button1, "Edit Word And Translate");
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.trans,
            this.word});
            this.listView1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(15, 199);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(670, 379);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // trans
            // 
            this.trans.DisplayIndex = 1;
            this.trans.Text = "Translate";
            this.trans.Width = 380;
            // 
            // word
            // 
            this.word.DisplayIndex = 0;
            this.word.Text = "Words";
            this.word.Width = 400;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(13, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select The Subject To Add:";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.YellowGreen;
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.Color.Orange;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(343, 60);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(342, 37);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.comboBox1, "Select One");
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Words
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(850, 660);
            this.Controls.Add(this.container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Words";
            this.Text = "Words";
            this.Load += new System.EventHandler(this.Words_Load);
            this.Resize += new System.EventHandler(this.Words_Resize);
            this.container.ResumeLayout(false);
            this.container.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox container;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader trans;
        private System.Windows.Forms.ColumnHeader word;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}