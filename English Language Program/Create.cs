using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace English_Language_Program
{
    public partial class Create : Form
    {
        public Create()
        {
            InitializeComponent();
        }
        private void Create_Load(object sender, EventArgs e)
        {
            try
            {
                button1.Text = "Add";
                comboBox1.Items.Clear();
                StreamReader strr = new StreamReader(Path.Combine("Subjects", "Subjects.txt"));
                string lin = strr.ReadToEnd();
                strr.Close();
                if (lin != null && lin != "")
                    comboBox1.Items.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                groupBox1.Location = new Point((this.Width - groupBox1.Width) / 2, (this.Height - groupBox1.Height) / 2);
                txtsubjectname.BackColor =
                this.BackColor =
                comboBox1.BackColor = Color.FromArgb(255, 44, 44, 44);
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (button1.Text == "Add")
                {
                    if (txtsubjectname.Text != null && txtsubjectname.Text != "")
                    {
                        List<string> AllSw = new List<string>();
                        AllSw.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                        if (!AllSw.Contains(txtsubjectname.Text))
                            using (StreamWriter strw = new StreamWriter(Path.Combine("Subjects", "Subjects.txt"), true))
                            {
                                strw.WriteLine(txtsubjectname.Text);
                            }
                        else
                        {
                            MessageBox.Show("The Subject Is Added In Other Oporator!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            txtsubjectname.SelectAll();
                            txtsubjectname.Focus();
                            return;
                        }
                        Directory.CreateDirectory(txtsubjectname.Text);
                        File.CreateText(Path.Combine(txtsubjectname.Text, txtsubjectname.Text + ".txt")).Close();
                        txtsubjectname.Text = "";
                        comboBox1.Items.Clear();
                        comboBox1.Items.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Name Subject!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                else if (button1.Text == "Edit")
                {
                    List<string> AllSw = new List<string>();
                    AllSw.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                    if (!AllSw.Contains(txtsubjectname.Text))
                    {
                        string news = txtsubjectname.Text;
                        txtsubjectname.Text = "";
                        StreamReader strr = new StreamReader(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt"));
                        string jak = strr.ReadToEnd();
                        strr.Close();
                        Directory.Delete(comboBox1.SelectedItem.ToString(), true);
                        Directory.CreateDirectory(news);
                        using (StreamWriter strw = new StreamWriter(Path.Combine(news, news + ".txt")))
                            strw.WriteLine(jak);
                        List<string> lstr = new List<string>();
                        lstr.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                        lstr.RemoveAt(lstr.IndexOf(comboBox1.SelectedItem.ToString()));
                        lstr.Add(news);
                        File.WriteAllLines(Path.Combine("Subjects", "Subjects.txt"), lstr.ToArray());
                        comboBox1.Items.Add(news);
                        comboBox1.Items.Remove(comboBox1.SelectedItem.ToString());
                        button4.Enabled = true;
                        button1.Text = "Add";
                        button5.Visible = false;
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
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItems.Count == 1)
                {
                    if (MessageBox.Show("You Are To Closed To Delete The Subject Is Selected!!", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.OK)
                    {
                        string SelectedDelete = comboBox1.SelectedItem.ToString();
                        List<string> AllSubjects = new List<string>();
                        AllSubjects.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                        if (AllSubjects.Contains(SelectedDelete))
                        {
                            Directory.Delete(SelectedDelete, true);
                            AllSubjects.Remove(SelectedDelete);
                            comboBox1.Items.Remove(SelectedDelete);
                            File.WriteAllLines(Path.Combine("Subjects", "Subjects.txt"), AllSubjects.ToArray());
                            AllSubjects.Clear();
                            SelectedDelete = "";
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please Select An Item From The List!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                txtsubjectname.Text = "";
                if (comboBox1.Items.Count >= 1)
                    comboBox1.SelectedIndex = 0;
                txtsubjectname.Focus();
                txtsubjectname.SelectAll();
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Create_Resize(object sender, EventArgs e)
        {
            groupBox1.Location = new Point((this.Width - groupBox1.Width) / 2, (this.Height - groupBox1.Height) / 2);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItems.Count == 1)
                {
                    txtsubjectname.Text = comboBox1.SelectedItem.ToString();
                    button1.Text = "Edit";
                    button4.Enabled = false;
                    button5.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please Select An Item From The List!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            button4.Enabled = true;
            txtsubjectname.Text = "";
        }
    }
}