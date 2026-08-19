using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace English_Language_Program
{
    public partial class Import : Form
    {
        public Import()
        {
            InitializeComponent();
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            button2.Focus();
            txtsubjectname.Text = textBox1.Text = "";
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            try
            { 
            if (MessageBox.Show("Are You Sure You Want To Import!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
            {
                List<string> AllSw = new List<string>();
                AllSw.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                if (!AllSw.Contains(txtsubjectname.Text))
                {
                    using (StreamWriter strr = new StreamWriter(Path.Combine("Subjects", "Subjects.txt"), true))
                    {
                        strr.WriteLine(textBox1.Text);
                        Directory.CreateDirectory(textBox1.Text);
                        File.CreateText(Path.Combine(textBox1.Text, textBox1.Text + ".txt")).Close();
                        string[] All = File.ReadAllLines(txtsubjectname.Text);
                        File.WriteAllLines(Path.Combine(textBox1.Text, textBox1.Text + ".txt"), All);
                    }
                }
                else
                {
                    MessageBox.Show("Please Enter Name Subject!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    txtsubjectname.SelectAll();
                    txtsubjectname.Focus();
                }
            }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            { 
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                txtsubjectname.Text = folderBrowserDialog1.FileName.ToString();
                textBox1.Text = Path.GetFileNameWithoutExtension(folderBrowserDialog1.FileName.ToString()).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Import_Load(object sender, EventArgs e)
        {
            this.BackColor =
               groupBox1.BackColor =
               textBox1.BackColor =
               txtsubjectname.BackColor =
               Color.FromArgb(255, 44, 44, 44);
            groupBox1.Location = new Point((this.Width - groupBox1.Width) / 2, (this.Height - groupBox1.Height) / 2);
        }
        private void Import_Resize(object sender, EventArgs e)
        {
            groupBox1.Location = new Point((this.Width - groupBox1.Width) / 2, (this.Height - groupBox1.Height) / 2);
        }
    }
}