using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace English_Language_Program
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }
        private void Test_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox2.SelectedIndex = comboBox3.SelectedIndex = comboBox4.SelectedIndex = 1;
                this.BackColor = comboBox1.BackColor = container.BackColor =
                    textBox3.BackColor = maskedTextBox1.BackColor = txtsubjectname.BackColor = textBox1.BackColor =
                    textBox2.BackColor = Color.FromArgb(255, 44, 44, 44);
                container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
                comboBox1.Items.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                if (comboBox1.Items.Count != 0)
                    comboBox1.SelectedIndex = 0;
                this.BackColor = container.BackColor = comboBox4.BackColor = comboBox3.BackColor = comboBox2.BackColor = Color.FromArgb(255, 44, 44, 44);
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        List<string> Word = new List<string>();
        List<string> Trans = new List<string>();
        List<int> Rand = new List<int>();
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (maskedTextBox1.Text == "" && comboBox1.Items.Count == 0 && comboBox1.SelectedIndex == -1)
                {
                    MessageBox.Show("Please Select Subject And Fill The Empty Failds!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
                else
                {
                    if (File.ReadAllText(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt")) == "")
                    {
                        MessageBox.Show("Please Add Words To Subject", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                    else
                    {
                        List<string> AllLines = new List<string>();
                        AllLines.AddRange(File.ReadAllLines(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt")));
                        if (maskedTextBox1.Text.Trim() == "")
                        {
                            MessageBox.Show("Please Enter An Other Number!", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            maskedTextBox1.SelectAll();
                            maskedTextBox1.Focus();
                        }
                        else
                          if (int.Parse(maskedTextBox1.Text.Trim()) >= AllLines.Count || int.Parse(maskedTextBox1.Text.Trim()) == 0)
                        {
                            MessageBox.Show("Please Enter An Other Number!", "Informtion", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                            maskedTextBox1.SelectAll();
                            maskedTextBox1.Focus();
                        }
                        else
                        {
                            Word.Clear();
                            Trans.Clear();
                            Rand.Clear();
                            textBox1.Clear();
                            textBox2.Clear();
                            button1.Enabled = button4.Enabled = true;
                            comboBox1.Enabled = false;
                            maskedTextBox1.Enabled = false;
                            button3.Enabled = false;
                            foreach (string item in AllLines)
                            {
                                Word.Add(item.Split(';')[0].ToString());
                                Trans.Add(item.Split(';')[1].ToString());
                            }
                            Random rnd = new Random();
                            int num;
                            for (int i = 0; i < int.Parse(maskedTextBox1.Text.Trim()); i++)
                            {
                                num = rnd.Next(0, AllLines.Count - 1);
                                if (Rand.Contains(num))
                                {
                                    i--;
                                    continue;
                                }
                                else
                                {
                                    Rand.Add(num);
                                }
                            }
                            j = 5;
                            button1.PerformClick();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        int j = 0;
        int Qnum = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(maskedTextBox1.Text) - 1 == Qnum)
                {
                    if (textBox3.Text == Trans[Rand[Qnum]])
                        textBox1.Text += txtsubjectname.Text + Enters.Text;
                    else
                        textBox2.Text += Word[Rand[Qnum]] + Enters.Text;
                    MessageBox.Show("The Test Is Finish!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    Word.Clear();
                    Qnum = 0;
                    Trans.Clear();
                    Rand.Clear();
                    txtsubjectname.Clear();
                    textBox3.Clear();
                    button1.Enabled = button4.Enabled = false;
                    comboBox1.Enabled = true;
                    maskedTextBox1.Enabled = true;
                    button3.Enabled = true;
                }
                else
                {
                    if (j != 0)
                    {
                        j = 0;
                        txtsubjectname.Text = Word[Rand[Qnum]];
                        return;
                    }
                    else
                    {
                        if (textBox3.Text == Trans[Rand[Qnum]])
                        {
                            textBox1.Text += txtsubjectname.Text + Enters.Text;
                            Qnum++;
                            txtsubjectname.Text = Word[Rand[Qnum]];
                            textBox3.Clear();
                        }
                        else
                        {
                            textBox2.Text += Word[Rand[Qnum]] + Enters.Text;
                            Qnum++;
                            txtsubjectname.Text = Word[Rand[Qnum]];
                            textBox3.Clear();
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Word.Clear();
            Trans.Clear();
            Rand.Clear();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Word.Clear();
            Trans.Clear();
            Rand.Clear();
            txtsubjectname.Clear();
            button1.Enabled = button4.Enabled = false;
            comboBox1.Enabled = true;
            maskedTextBox1.Enabled = true;
            button3.Enabled = true;
            Qnum = 0;
        }
        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int.Parse(maskedTextBox1.Text.Trim());
            }
            catch
            {
                maskedTextBox1.Text = "0";
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedIndex != -1)
                    if (comboBox2.SelectedIndex == 0)
                        textBox3.RightToLeft = RightToLeft.Yes;
                    else if (comboBox2.SelectedIndex == 1)
                        textBox3.RightToLeft = RightToLeft.No;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox3.SelectedIndex != -1)
                    if (comboBox3.SelectedIndex == 0)
                        textBox2.RightToLeft = RightToLeft.Yes;
                    else if (comboBox3.SelectedIndex == 1)
                        textBox2.RightToLeft = RightToLeft.No;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox4.SelectedIndex != -1)
                    if (comboBox4.SelectedIndex == 0)
                        textBox1.RightToLeft = RightToLeft.Yes;
                    else if (comboBox4.SelectedIndex == 1)
                        textBox1.RightToLeft = RightToLeft.No;
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Test_Resize(object sender, EventArgs e)
        {
            container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
        }
    }
}