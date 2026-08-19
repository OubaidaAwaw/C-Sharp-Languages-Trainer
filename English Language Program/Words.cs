using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
namespace English_Language_Program
{
    public partial class Words : Form
    {
        public Words()
        {
            InitializeComponent();
        }
        private void Words_Load(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.AddRange(File.ReadAllLines(Path.Combine("Subjects", "Subjects.txt")));
                if (comboBox1.Items.Count != 0)
                    comboBox1.SelectedIndex = 0;
                container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
                this.BackColor = textBox1.BackColor = textBox2.BackColor = listView1.BackColor = panel1.BackColor = comboBox1.BackColor = label1.BackColor = Color.FromArgb(255, 44, 44, 44);
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void Words_Resize(object sender, EventArgs e)
        {
            container.Location = new Point((this.Width - container.Width) / 2, (this.Height - container.Height) / 2);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                List<string> AllLines = new List<string>();
                AllLines.AddRange(File.ReadAllLines(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt")));
                AllLines[AllLines.IndexOf(listView1.SelectedItems[0].SubItems[1].Text + ";" + listView1.SelectedItems[0].SubItems[0].Text)] = textBox2.Text + ";" + textBox1.Text;
                listView1.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                listView1.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                File.WriteAllLines(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt"), AllLines.ToArray());
                panel1.Visible = false;
                textBox1.Text = textBox2.Text = "";
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
                if (listView1.SelectedItems.Count != 0)
                {
                    textBox1.Text = listView1.SelectedItems[0].SubItems[0].Text;
                    textBox2.Text = listView1.SelectedItems[0].SubItems[1].Text;
                    panel1.Visible = true;
                }
                else
                {
                    MessageBox.Show("Please Select Words From The List!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void AddToListView(string A, string B)
        {
            try
            {
                string[] Line = new string[] { A, B };
                ListViewItem ALL = new ListViewItem(Line);
                listView1.Items.Add(ALL);
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex != -1)
                {
                    listView1.Items.Clear();
                    panel1.Visible = false;
                    textBox1.Text = textBox2.Text = "";
                    string[] AllLines = File.ReadAllLines(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt"));
                    for (int i = 0; i < AllLines.Length; i++)
                    {
                        AddToListView(AllLines[i].Split(';')[1].ToString(), AllLines[i].Split(';')[0].ToString());
                    }
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            textBox1.Text = textBox2.Text = "";
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (listView1.SelectedItems.Count != 0)
                {
                    List<string> AllLines = new List<string>();
                    AllLines.AddRange(File.ReadAllLines(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt")));
                    if (AllLines.Contains(listView1.SelectedItems[0].SubItems[1].Text + ";" + listView1.SelectedItems[0].SubItems[0].Text))
                        AllLines.Remove(listView1.SelectedItems[0].SubItems[1].Text + ";" + listView1.SelectedItems[0].SubItems[0].Text);
                    File.WriteAllLines(Path.Combine(comboBox1.SelectedItem.ToString(), comboBox1.SelectedItem.ToString() + ".txt"), AllLines.ToArray());
                    string[] jak = new string[] { listView1.SelectedItems[0].SubItems[1].Text,
                listView1.SelectedItems[0].SubItems[0].Text };
                    ListViewItem lvi = new ListViewItem(jak);
                    listView1.Items.Remove(lvi);
                    comboBox1_SelectedIndexChanged(sender, e);
                }
                else
                {
                    MessageBox.Show("Please Select Words From The List!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                }
            }
            catch
            {
                MessageBox.Show("Error Coding", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }
        }
    }
}